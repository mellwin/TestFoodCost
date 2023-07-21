using System;
using TestFoodCost.Exceptions;

namespace TestFoodCost
{
    public class ProductFiller
    {
        public static string GetProductName()
        {
            Console.WriteLine("Введите наименование продукта");
            var productName = Console.ReadLine();
            if (string.IsNullOrEmpty(productName)) throw new ValueNotAvailable("Не введено наименование продукта");

            return productName;
        }

        public static double GetProductVolume()
        {
            Console.WriteLine("Введите количество продукта");
            var productVolume = Convert.ToDouble(Console.ReadLine());
            if (productVolume < 0) throw new ValueNotAvailable("Количество продукта");

            return productVolume;
        }

        public static double GetProductCost()
        {
            Console.WriteLine("Введите стоимость продукта");
            var productCost = Convert.ToDouble(Console.ReadLine());
            if (productCost < 0) throw new ValueNotAvailable("Стоимость продукта");

            return productCost;
        }
    }
}