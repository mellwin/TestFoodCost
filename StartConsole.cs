using System;
using TestFoodCost.Exceptions;

namespace TestFoodCost
{
    public class StartConsole
    {
        public void StartProgram()
        {
            Recipe recipe = new Recipe();
            Product product = new Product();
            var calculator = new Calculator();
            Try tryEx = new Try();

            Console.WriteLine("Расчет стоимости порции блюда \n");

            Console.WriteLine("Заполните рецепт продуктами \n");

            string funcFlag = "";

            while (funcFlag != "0")
            {
                Console.WriteLine("Введите 1 чтобы добавить продукт" +
                                "\nВведите 0 если закончили вводить продукты \n");
                funcFlag = Console.ReadLine();

                if (funcFlag == "1")
                {
                    tryEx.TryExecute(() =>
                    {
                        product = product.FillProduct();

                        recipe.RecipeProducts.Add(product);
                    });
                }
                if (funcFlag == "") break;
            }

            if (recipe.RecipeProducts.Count > 0)
            {
                recipe.FillRecipePrortions(recipe);

                Console.WriteLine($"Стоимость одной порции блюда: {calculator.GetPortionPrice(recipe)}");
            }
        }
    }
}
