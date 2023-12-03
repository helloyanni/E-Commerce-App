using AutoMapper.Configuration.Conventions;

namespace EcommerceAPI.Classes
{
    public class Basket
    {
        public int UserId { get; set; }
        public List<int> ProductId { get; set; } = new List<int>();
    }
}
