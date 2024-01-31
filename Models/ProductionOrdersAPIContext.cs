using API_Proje.Models;
using Microsoft.EntityFrameworkCore.InMemory;
namespace API_Proje.Models
{
    public class ProductionOrdersAPIContext : DbContext
    {
        public ProductionOrdersAPIContext(DbContextOptions<ProductionOrdersAPIContext> options) : base(options)
        {
        }

        public DbSet<ProductionOrder> ProductionOrders { get; set; }
    }
    internal class ProductionOrdersAPIContext
    {

    }
}
