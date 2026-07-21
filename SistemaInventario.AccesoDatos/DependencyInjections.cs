using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaInventario.AccesoDatos;

namespace Northwind.AccesoDatos
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<NorthwindDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Northwind"));

            });
            services.AddDbContext<NorthwindDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("NorthwindConnection")));


            return services;
        }

    }
}
