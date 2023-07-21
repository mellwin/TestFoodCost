using System.Collections.Generic;

namespace TestFoodCost.Application
{
    interface IFillRecipe
    {
        public int FillRecipePrortions();

        public Recipe GetRecipe(List<Product> products, int porions);
    }
}