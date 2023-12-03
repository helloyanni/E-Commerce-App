using EcommerceAPI.Data.Model;
using EcommerceAPI.Dto;

namespace EcommerceAPI.Services.Abstract
{
    public interface IShopService
    {
        List<ProductDto> GetProducts();
        Task<ProductDto> GetProduct(int id);
        PurchaseDto PurchaseItem(BasketDto basket);
    }
}
