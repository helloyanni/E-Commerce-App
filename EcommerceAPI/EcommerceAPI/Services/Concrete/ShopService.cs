using AutoMapper;
using Dtos;
using EcommerceAPI.Data.Context;
using EcommerceAPI.Data.Model;
using EcommerceAPI.Dtos;
using EcommerceAPI.Services.Abstract;

namespace EcommerceAPI.Services.Concrete
{
    public class ShopService : IShopService
    {
        public DataContext _context { get; set; }
        private readonly IMapper _mapper;
        public ShopService(DataContext context, IMapper mapper)
        {
                _context = context;
                _mapper = mapper;
        }

        public List<ProductDto> GetProducts()
        {
            var results = _context.Products.ToList();
            var products = _mapper.Map<List<ProductDto>>(results);

            return products;
        }

        public async Task<ProductDto> GetProduct(int id)
        {
            var result = await _context.Products.FindAsync(id);
            var product = _mapper.Map<ProductDto>(result);
            return product;
        }

        public PurchaseDto Checkout(BasketDto basket)
        {
            var products = new List<ProductDto>();

            var productsList = _context.Products.ToList();

            foreach(ItemDto item in basket.ProductIds)
            {
                var result = _context.Products.First(x => x.Id == item.ItemId);

                result.Quantity = item.Quantity;
                result.Price = result.Quantity * result.Price;

                var product = _mapper.Map<ProductDto>(result);

                products.Add(product);
            }

            var price = products.Sum(x => x.Price);
       
            var name = _context.Shoppers.First(x => x.Id == basket.UserId).Name;

            foreach (var product in products)
            {
                var order = new ShopperProductDto(basket.UserId, product.Id, product.Quantity);

                var userOrder = _mapper.Map<ShopperProduct>(order);

                _context.ShopperProducts.Add(userOrder);
            }

            var outputResult = new PurchaseDto()
            {
                Name = name,
                Price = price,
                Products = products
            };

            _context.SaveChanges();

            return outputResult;
        }
        
    }
}
