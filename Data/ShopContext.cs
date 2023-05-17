using Microsoft.EntityFrameworkCore;

namespace ShopSystem.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
    }
}
