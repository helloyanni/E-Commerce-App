namespace EcommerceAPI.Dto
{
    public class PurchaseDto
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public List<ProductDto>? Products { get; set; }
    }
}
