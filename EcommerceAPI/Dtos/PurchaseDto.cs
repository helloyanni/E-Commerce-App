using System.Collections.Generic;

namespace EcommerceAPI.Dtos
{
    public class PurchaseDto
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
