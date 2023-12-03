
using EcommerceAPI.Dto;

namespace EcommerceAPI.Classes
{
    public class Purchase
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public List<ProductDto>? Products { get; set; }

    }
}
