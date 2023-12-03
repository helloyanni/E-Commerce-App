namespace EcommerceAPI.Data.Model
{
    public class Shopper
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ShopperProduct>? ShopperProducts { get; set; }
    }
}
