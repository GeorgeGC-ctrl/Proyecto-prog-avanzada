using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Common
{
    public static class DependencyInjections
    {
        public static  IServiceCollection AddCommom(this IServiceCollection services,IConfiguration configuration)
        {
            return services;
            // Aquí puedes agregar tus servicios y dependencias
            // Por ejemplo:
            // services.AddScoped<IMiServicio, MiServicio>();
        }
    }
}
