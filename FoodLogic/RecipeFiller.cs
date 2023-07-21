using System;
using TestFoodCost.Exceptions;

namespace TestFoodCost.Application
{
    public class RecipeFiller
    {
        public static int GetRecipePrortions()
        {
            Console.WriteLine("Введите количество порций: ");
            var recipePortions = Convert.ToInt32(Console.ReadLine());
            if (recipePortions < 0) throw new ValueNotAvailable("Количество порций");

            return recipePortions;
        }
    }
}
