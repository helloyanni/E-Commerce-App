using AutoMapper;
using EcommerceAPI.Data.Model;
using EcommerceAPI.Dto;

namespace EcommerceAPI.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ShopperProductDto, ShopperProduct>();
        }
    }
}
