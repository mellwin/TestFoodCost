using System;
using TestFoodCost.Exceptions;

namespace TestFoodCost
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductVolume { get; set; }
        public double ProductCost { get; set; }

        public Product FillProduct()
        {
            Product newProduct = new Product();

            Console.WriteLine("Введите наименование продукта");
            newProduct.ProductName = Console.ReadLine();
            if (newProduct.ProductName == "") throw new ValueNotAvailable("Не введено наименование продукта");

            Console.WriteLine("Введите количество продукта");
            newProduct.ProductVolume = Convert.ToDouble(Console.ReadLine());
            if (newProduct.ProductVolume < 0) throw new ValueNotAvailable("Количество продукта");

            Console.WriteLine("Введите стоимость продукта");
            newProduct.ProductCost = Convert.ToDouble(Console.ReadLine());
            if (newProduct.ProductCost < 0) throw new ValueNotAvailable("Стоимость продукта");

            return newProduct;
        }
    }

}