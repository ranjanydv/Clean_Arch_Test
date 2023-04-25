using Microsoft.Extensions.DependencyInjection;
using WebApp.Application.Services.Auth;

namespace WebApp.Application.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}