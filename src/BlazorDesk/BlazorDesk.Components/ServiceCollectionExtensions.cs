using Microsoft.Extensions.DependencyInjection;

namespace BlazorDesk.Components
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddComponents(this IServiceCollection services)
        {
            return services.AddScoped<NavBarLeftInjectableMenu>();
        }
    }
}
