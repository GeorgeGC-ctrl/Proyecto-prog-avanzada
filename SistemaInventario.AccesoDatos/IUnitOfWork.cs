using SistemaInventario.AccesoDatos.Repositorios;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Categories> Categorias { get; }
        IRepository<Suppliers> Suplidores { get; }
        IRepository<Products> Productos { get; }
        Task<int> SaveChangesAsync();

        Task BeginTransaction();
        Task CommitTransaction();
        Task RollbackTransaction();

    }
}
