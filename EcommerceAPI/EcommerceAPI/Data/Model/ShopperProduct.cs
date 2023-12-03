namespace EcommerceAPI.Data.Model
{
    public class ShopperProduct
    {
        public int Id { get; set; }
        public int ShopperId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public Shopper? Shopper { get; set; }
    }
}
