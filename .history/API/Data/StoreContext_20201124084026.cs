using Microsoft.EntityFrameworkCore;
using API.Entit;
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