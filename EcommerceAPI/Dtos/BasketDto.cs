using Dtos;
using System.Collections.Generic;

namespace EcommerceAPI.Dtos
{
    public class BasketDto
    {
        public int UserId { get; set; }
        public List<ItemDto> ProductIds { get; set; } = new List<ItemDto>();
    }
}
