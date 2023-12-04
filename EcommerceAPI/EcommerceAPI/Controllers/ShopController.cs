using EcommerceAPI.Dtos;
using EcommerceAPI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IShopService _shopService;
        public ShopController(IShopService shopService, ILogger<ShopController> logger)
        {
            _shopService = shopService;
            _logger = logger;
        }

        [HttpGet("products")]
        public List<ProductDto> GetProductsAsync()
        {
            return _shopService.GetProducts();
        }

        [HttpGet("products/{id}")]
        public async Task<ProductDto> GetProductById(int id)
        {
            return await _shopService.GetProduct(id);
        }

        [HttpPost]
        public PurchaseDto PurchaseItems(BasketDto basket)
        {
            return _shopService.Checkout(basket);
        }
    }
}
