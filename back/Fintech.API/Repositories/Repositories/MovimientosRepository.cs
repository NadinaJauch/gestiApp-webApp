using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.IRepositories;
using db.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories;

namespace Repositories
{
    public class MovimientosRepository : BaseRepository<Movimiento>, IMovimientosRepository<Movimiento>
    {
        public MovimientosRepository(GestionAhorrosContext db) : base(db) { }

        public async Task<List<Movimiento>> Get()
        {
            return await _entities.ToListAsync();
        }

        public async Task Post(Movimiento movimiento)
        {
            await _entities.AddAsync(movimiento);
        }

    }
}
