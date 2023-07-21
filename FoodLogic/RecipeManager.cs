using System.Collections.Generic;

namespace TestFoodCost.Application
{
    public class RecipeManager : IFillRecipe
    {
        public int FillRecipePrortions()
        {
            int portions = RecipeFiller.GetRecipePrortions();
            return portions;
        }

        public Recipe GetRecipe(List<Product> products, int porions)
        {
            return new Recipe(products, porions);
        }
    }
}