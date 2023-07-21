using System;
using System.Collections.Generic;
using TestFoodCost.Application;
using TestFoodCost.Exceptions;

namespace TestFoodCost
{
    public class StartConsole
    {
        private IFillProduct _fillProduct;
        private IFillRecipe _fillRecipe;

        public StartConsole()
        {
            _fillProduct = new ProductManagerDefault();
            _fillRecipe = new RecipeManager();
            Console.WriteLine(_fillProduct);
        }

        public void StartProgram()
        {
            Calculator calculator = new Calculator();
            Try tryEx = new Try();
            List<Product> productList = new List<Product>();

            Console.WriteLine("Расчет стоимости порции блюда \n");

            Console.WriteLine("Заполните рецепт продуктами \n");

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите 1 чтобы добавить продукт \n" +
                                  "Введите 0 если закончили вводить продукты \n" +
                                  "Введите 2 для выбора режима заполнения продукта. \n");

                switch (Console.ReadLine())
                {
                    case "0":
                        {
                            flag = false;
                            break;
                        }
                    case "1":
                        {
                            tryEx.TryExecute(() =>
                            {
                                Product product = _fillProduct.FillProduct();

                                productList.Add(product);
                            });
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Выбор режима заполнения продукта. \n" +
                                              "Введите 0 чтобы использовать стандартный набор. \n " +
                                              "Введите 1 чтобы использовать другой режим. \n ");
                            switch (Console.ReadLine())
                            {
                                case "0":
                                    {
                                        _fillProduct = new ProductManagerDefault();
                                        break;
                                    }
                                case "1":
                                    {
                                        _fillProduct = new ProductManagerCustom();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            Console.WriteLine($"Описание выбранного режима: {_fillProduct}");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            if (productList.Count > 0)
            {
                int portions = _fillRecipe.FillRecipePrortions();

                var recipe = _fillRecipe.GetRecipe(productList, portions);

                Console.WriteLine($"Стоимость одной порции блюда: {calculator.GetPortionPrice(recipe)}");
            }
        }
    }
}
