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
    public class SeguridadRepository : BaseRepository<Usuario>, ISeguridadRepository
    {
        public SeguridadRepository(GestionAhorrosContext db) : base(db) { }

        public async Task<Usuario> GetLoginByCredentials(Usuario login)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Mail == login.Mail);
        }

        public async Task<Usuario> getUserWithMail(string mail)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Mail == mail);
        }

    }
}
