using System;

namespace EcommerceAPI.Dtos
{
    public class ShopperProductDto
    {
        public int ShopperId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Quantity { get; set; } = 1;

        public ShopperProductDto(int shopperId, int productId, int quantity)
        {
            ShopperId = shopperId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
