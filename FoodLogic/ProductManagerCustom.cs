namespace TestFoodCost.Application
{
    public class ProductManagerCustom : IFillProduct
    {
        public Product FillProduct()
        {
            var productName = ProductFiller.GetProductName();
            var productCost = ProductFiller.GetProductCost();
            var productVolume = ProductFiller.GetProductVolume();

            return new Product(productName, productVolume, productCost);
        }

        public override string ToString()
        {
            return "Режим работы кастомный. Порядок работы: Имя, Стоимость, Количество.";
        }
    }
}
