namespace API.Extenstions
{
    public static class ApplicationServicesExtenstions
    {
        public static  IServiceCollection AddApplicationService(this IServiceCollection services)
        {
             services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
            services.Configure<ApiBehaviorOptions>(options =>{
                    options.InvalidModelStateResponseFactory = actionContext =>
                    {
                        var errors = actionContext.ModelState
                        .Where(e => e.Value.Errors.Count > 0).SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage).ToArray();

                        var errorResponse = new ApiValidationErrorResponse
                        {
                                Errors = errors
                        };
                        return new BadRequestObjectResult(errorResponse);
                    };
            });
        }
    }
}