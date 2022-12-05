using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstractions.IServices
{
    public interface ISeguridadService
    {

        public Task<Usuario> GetLoginByCredentials(Usuario usuario);
        public Task RegisterUser(Usuario usuario);
    }
}
