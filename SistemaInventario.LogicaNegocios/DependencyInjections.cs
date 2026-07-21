using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.AccesoDatos;
using SistemaInventario.LogicaNegocios;
using FluentValidation; 

namespace Northwind.LogicaNegocios
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccess(configuration);
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddValidatorsFromAssemblyContaining<CreateCategoryValidator>();
             

            return services;
        }

    }
}
