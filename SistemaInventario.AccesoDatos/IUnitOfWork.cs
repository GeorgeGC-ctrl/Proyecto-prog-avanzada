using SistemaInventario.AccesoDatos.Repositorios;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Categorias> Categorias { get; }
        IRepository<Suplidores> Suplidores { get; }
        IRepository<Productos> Productos { get; }
        Task<int> SaveChangesAsync();

        Task BeginTransaction();
        Task CommitTransaction();
        Task RollbackTransaction();

    }
}
