using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.AccesoDatos;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Ordenes;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;
using static Northwind.LogicaNegocios.Categorias.CreateCategoryValidator;

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
            services.AddTransient<IOrderService, OrderService>();
            services.AddValidatorsFromAssemblyContaining<CreateCategoryValidator>();
            services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();
            services.AddValidatorsFromAssemblyContaining<SuppliersValidator>();
            services.AddValidatorsFromAssemblyContaining<OrderValidator>();
            services.AddValidatorsFromAssemblyContaining<DeleteCategoryValidator>();


            return services;
        }

    }
}
