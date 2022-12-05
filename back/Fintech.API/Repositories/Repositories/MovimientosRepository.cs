using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.IRepositories;
using db.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class MovimientosRepository : IMovimientosRepository
    {
        private readonly GestionAhorrosContext _db;

        public MovimientosRepository(GestionAhorrosContext db)
        {
            _db = db;
        }

        public async Task<List<Movimiento>> Get()
        {
            return await _db.Movimientos.ToListAsync();
        }

        public async Task Post(Movimiento movimiento)
        {
            await _db.Movimientos.AddAsync(movimiento);
            await _db.SaveChangesAsync();
        }
    }
}
