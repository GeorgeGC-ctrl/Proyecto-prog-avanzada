using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.LogicaNegocios;
using Northwind.UI;
using SistemaInventario.Presentacion;

namespace dashboard
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);   
            services.AddBusinessLogic(configuration);

            services.AddTransient<Form1>();
            services.AddTransient<UserControlCategories>();
            services.AddTransient<UserControlProducts>();
            services.AddTransient<UserControlSuplidores>();
            services.AddTransient<ucAgregarSuplidor>();
            services.AddTransient<UserControlGestionOrdenes>();
            services.AddTransient<ucAgregarOrden>();
            services.AddTransient<FormOrder>();


            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
    }
}