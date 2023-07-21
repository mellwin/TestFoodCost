using System.Collections.Generic;

namespace TestFoodCost
{
    public class Recipe
    {
        public List<Product> Products { get; private set; } = new();
        public int Portions { get; private set; }

        public Recipe(List<Product> products, int portions)
        {
            Products = products;
            Portions = portions;
        }
    }
}