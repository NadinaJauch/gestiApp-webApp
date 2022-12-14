using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.IRepositories
{
    public interface IUsuariosRepository : IRepository<Usuario>
    {
         Task<Usuario> ObtenerUsuarioPorId(int id);
    }
}
