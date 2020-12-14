using System;
using System.IO;
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
                var barndsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
            }
        }catch (Exception ex){

        }
        }
    }
}