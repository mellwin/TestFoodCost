using System;
using System.Collections.Generic;
using TestFoodCost.Exceptions;

namespace TestFoodCost
{
    public class Recipe
    {
        public List<Product> RecipeProducts { get; set; } = new List<Product>();
        public int RecipePortions { get; set; }
        public Recipe FillRecipePrortions(Recipe recipe)
        {
            Console.WriteLine("Введите количество порций: ");
            recipe.RecipePortions = Convert.ToInt32(Console.ReadLine());
            if (recipe.RecipePortions < 0) throw new ValueNotAvailable("Количество порций");

            return recipe;
        }
    }
}