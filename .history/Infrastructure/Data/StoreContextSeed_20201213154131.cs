using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loogerFactory)
        {
        try{
            if (!context.ProductBrands.Any)
        }catch (Exception ex){

        }
        }
    }
}