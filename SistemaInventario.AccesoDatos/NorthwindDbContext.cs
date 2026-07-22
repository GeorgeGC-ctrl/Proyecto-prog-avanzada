using FluentAssertions.Common;
using LiveChartsCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using SistemaInventario.Entidades;
using System;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaInventario.AccesoDatos
{
    public class NorthwindDbContext: DbContext
    {

        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
        {
            
        }
        public  DbSet<Categories> Categorias { get; set; }
        public DbSet<Suppliers> Suplidores { get; set; }
        public DbSet<Products> Productos { get; set; }
        public DbSet<Orders> Ordenes { get; set; }
        public DbSet<OrderDetails> DetallesOrdenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Order Details tiene clave compuesta (OrderID + ProductID)
            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => new { od.OrderID, od.ProductID });
        }
    }
     
}       