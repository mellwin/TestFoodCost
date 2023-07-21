using System;

namespace TestFoodCost
{
    public class Calculator
    {
        public double GetPortionPrice(Recipe recipe)
        {
            double total = 0;

            foreach (var ingredient in recipe.Products)
            {
                total += ingredient.Cost / ingredient.Volume;
            }

            return Math.Round(total / recipe.Portions, 2);
        }
    }
}