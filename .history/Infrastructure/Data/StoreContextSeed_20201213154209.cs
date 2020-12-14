using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loogerFactory)
        {
        try{
            if (!context.ProductBrands.Any()){
                var barn
            }
        }catch (Exception ex){

        }
        }
    }
}