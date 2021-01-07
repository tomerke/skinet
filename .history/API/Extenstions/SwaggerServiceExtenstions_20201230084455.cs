using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extenstions
{
    public static class SwaggerServiceExtenstions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc("v1", new OpenApiInfo { Title = "SkiNet API", Version = "v1" });
           });

           return services;
        }

        public static IApplicationBuilder Use

    }
}