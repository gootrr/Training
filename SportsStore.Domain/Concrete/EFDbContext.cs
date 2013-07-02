using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        // Define a property of each table you want to work with
        public DbSet<Product> Products { get; set; }
    }
}
