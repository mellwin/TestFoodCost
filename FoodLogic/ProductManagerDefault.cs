namespace TestFoodCost.Application
{
    public class ProductManagerDefault : IFillProduct
    {
        public Product FillProduct()
        {
            var productName = ProductFiller.GetProductName();
            var productVolume = ProductFiller.GetProductVolume();
            var productCost = ProductFiller.GetProductCost();

            return new Product(productName, productVolume, productCost);
        }
        public override string ToString()
        {
            return "Режим работы стандартный. Порядок работы: Имя, Количество, Стоимость.";
        }
    }
}