using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.IServices
{
    public interface IUsuariosService
    {
        public Task<Usuario> GetUserById(int Id);
    }
}
