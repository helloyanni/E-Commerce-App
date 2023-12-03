namespace EcommerceAPI.Dto
{
    public class BasketDto
    {
        public int UserId { get; set; }
        public List<int> ProductIds { get; set; } = new List<int>();
    }
}
