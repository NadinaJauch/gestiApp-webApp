using Abstractions.IRepositories;
using db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UsuariosRepository : BaseRepository<Usuario>, IUsuariosRepository
    {
        public UsuariosRepository(GestionAhorrosContext context) : base(context) { }

        public async Task<Usuario> ObtenerUsuarioPorId(int id)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
