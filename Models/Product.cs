namespace TestFoodCost
{
    public class Product
    {
        public string Name { get; private set; }
        public double Volume { get; private set; }
        public double Cost { get; private set; }

        public Product(string productName, double productVolume, double productCost)
        {
            Name = productName;
            Volume = productVolume;
            Cost = productCost;
        }
    }
}