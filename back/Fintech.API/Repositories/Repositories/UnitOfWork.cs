using Abstractions.IRepositories;
using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GestionAhorrosContext _db;
        private readonly IUsuariosRepository _usuarioRepository;
        private readonly IRepository<Movimiento> _movimientoRepository;
        private readonly ISeguridadRepository _seguridadRepository;

        public UnitOfWork(GestionAhorrosContext context)
        {
            _db = context;
        }

        public IUsuariosRepository UsuariosRepository => _usuarioRepository ?? new UsuariosRepository(_db);

        //public IRepository<Movimiento> CommentRepository => _movimientoRepository ?? new BaseRepository<Movimiento>(_db);

        public ISeguridadRepository SeguridadRepository => _seguridadRepository ?? new SeguridadRepository(_db);

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }


        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
