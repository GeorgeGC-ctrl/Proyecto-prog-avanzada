using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Commom
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCommom(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

    }
}
