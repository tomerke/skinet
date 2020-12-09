using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}