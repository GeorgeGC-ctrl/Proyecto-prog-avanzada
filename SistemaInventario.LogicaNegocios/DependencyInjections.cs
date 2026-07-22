using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.AccesoDatos;
using FluentValidation;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;

namespace Northwind.LogicaNegocios
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccess(configuration);
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISuppliersService, SuppliersService>();
            services.AddValidatorsFromAssemblyContaining<CreateCategoryValidator>();
            services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();
            services.AddValidatorsFromAssemblyContaining<SuppliersValidator>();


            return services;
        }

    }
}
