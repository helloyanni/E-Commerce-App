using EcommerceAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
        public DbSet<ShopperProduct> ShopperProducts { get; set; }
    }
}
