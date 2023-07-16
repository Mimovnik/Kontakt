using Kontakt.Api.Common.Errors;
using Kontakt.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Kontakt.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, KontaktProblemDetailsFactory>();

        return services;
    }
}