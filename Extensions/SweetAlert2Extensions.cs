using Microsoft.Extensions.DependencyInjection;
using SweetAlert2.Blazor.Services;

namespace SweetAlert2.Blazor.Extensions;

public static class SweetAlert2Extensions
{
    public static IServiceCollection AddSweetAlert2(this IServiceCollection services)
    {
        services.AddScoped<ISweetAlert2Service, SweetAlert2Service>();
        return services;
    }
}
