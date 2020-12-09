using Microsoft.EntityFrameworkCore;
using API.EntityFrameworkCore;
namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products {get;set;}
    }
}