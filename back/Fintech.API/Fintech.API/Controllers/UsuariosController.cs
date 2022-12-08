using Abstractions.IServices;
using db.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Fintech.API.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet("identity")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult identityEndpoint()
        {
            var usuario = GetUsuarioActual().Result;
            return Ok(usuario);
        }

        private async Task<Usuario> GetUsuarioActual()
        {

            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int? supuestoEntero = int.Parse(userId);
            //string userId = identidad.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _usuariosService.GetUserById(int.Parse(userId));
 
            return user;
        }
    }
}

