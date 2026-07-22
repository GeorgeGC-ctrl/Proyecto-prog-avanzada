using Microsoft.EntityFrameworkCore.Storage;
using SistemaInventario.AccesoDatos.Repositorios;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindDbContext _context;
        private IDbContextTransaction _transaction;
        public UnitOfWork(NorthwindDbContext context)
        {
            this._context = context;
        }
        public IRepository<Categories> Categorias =>  new GenericRepository<Categories>(_context);
        public IRepository<Suppliers> Suplidores => new GenericRepository<Suppliers>(_context);
        public IRepository<Products> Productos => new GenericRepository<Products>(_context);
     
        public async Task BeginTransaction()
        {
            await _context.Database.BeginTransactionAsync();
        }
        public async Task CommitTransaction()
        {
            if (_transaction == null) return;

            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();

            _transaction = null;
        }
        public async Task RollbackTransaction()
        {
            if (_transaction == null) return;

            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
            
            _transaction = null;
        }
        public void Dispose()
        {
            _context.Dispose();
            _transaction.Dispose();

            GC.SuppressFinalize(this);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
