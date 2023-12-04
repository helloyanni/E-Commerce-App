namespace EcommerceAPI.Data.Model
{
    public class ShopperProduct
    {
        public int Id { get; set; }
        public int ShopperId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Quantity { get; set; } = 1;
        public Product? Product { get; set; }
        public Shopper? Shopper { get; set; }
    }
}
