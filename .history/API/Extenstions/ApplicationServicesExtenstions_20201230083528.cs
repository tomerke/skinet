namespace API.Extenstions
{
    public static class ApplicationServicesExtenstions
    {
        public static  IServiceCollection AddApplicationService(this IServiceCollection services)
        {
 services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
        }
    }
}