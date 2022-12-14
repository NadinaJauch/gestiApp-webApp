using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.DTOs;

namespace Abstractions.IServices
{
    public interface ISeguridadService
    {

        public Task<Usuario> GetLoginByCredentials(Usuario usuario);
        public Task RegisterUser(UsuarioRegisterDTO usuarioDTO);
        public Task<string> LoginAsync(SeguridadDto loginDTO);
    }
}
