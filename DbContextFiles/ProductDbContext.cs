using FurntureWebAPP_ASP_NET_CORE_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.DbContextFiles
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
