namespace ModelValidation.Utilities;
public static class AddControllerConfigurationUtility
{
    public static IServiceCollection AddControllerUtility(this IServiceCollection services)
    {
        services
            .AddControllers()
            .ConfigureApiBehaviorOptions(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var result = new ValidationFailedResult(context.ModelState);
                    result.ContentTypes.Add(MediaTypeNames.Application.Json);
                    return result;
                };
            });
        return services;
    }
}