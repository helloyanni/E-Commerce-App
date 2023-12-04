using EcommerceAPI.Data.Model;
using EcommerceAPI.Dtos;

namespace EcommerceAPI.Services.Abstract
{
    public interface IShopService
    {
        List<ProductDto> GetProducts();
        Task<ProductDto> GetProduct(int id);
        PurchaseDto Checkout(BasketDto basket);
    }
}
