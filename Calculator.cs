namespace TestFoodCost
{
    public class Calculator
    {
        public double GetPortionPrice(Recipe recipe)
        {
            double total = 0;

            foreach (var ingredient in recipe.RecipeProducts)
            {
                total += ingredient.ProductCost / ingredient.ProductVolume;
            }

            return total / recipe.RecipePortions;
        }
    }
}