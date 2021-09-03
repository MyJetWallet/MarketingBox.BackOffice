namespace MarketingBox.Backoffice.Services.Brands
{
    public class BrandItem
    {
        public Brand Brand { get; set; }
    }

    public class Brand
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}