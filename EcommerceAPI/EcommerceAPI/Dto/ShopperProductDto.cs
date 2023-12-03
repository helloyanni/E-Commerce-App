namespace EcommerceAPI.Dto
{
    public class ShopperProductDto
    {
        public int ShopperId { get; set; }
        public int ProductId { get; set; }

        public ShopperProductDto(int shopperId, int productId)
        {
            ShopperId = shopperId;
            ProductId = productId;
        }
    }
}
