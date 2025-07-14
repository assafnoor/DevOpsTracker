using Identity.Api.Common.Errors;
using Identity.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Identity.Api;

public static class DependencyInjectionRegister
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, IdentityProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}