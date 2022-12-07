using Abstractions.IServices;
using AutoMapper;
using db.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Refit;
using Views.DTOs;

namespace Fintech.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SeguridadController : ControllerBase
    {
        private readonly ISeguridadService _seguridadService;
        private readonly IMapper _mapper;
        private readonly IPasswordService _passwordService;

        public SeguridadController(ISeguridadService seguridadService, IMapper mapper,IPasswordService passwordService)
        {
            _seguridadService= seguridadService; 
            _mapper= mapper;
            _passwordService= passwordService;
        }

        [HttpPost("registrarse")]
        public async Task<IActionResult> Post(UsuarioRegisterDTO usuarioDTO)
        {
            try
            {
               await _seguridadService.RegisterUser(usuarioDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SeguridadDto LoginDTO)
        {
            //hash password
            LoginDTO.Password = _passwordService.Hash(LoginDTO.Password);
            //mando validación y pido token
            var resultado = await _seguridadService.LoginAsync(LoginDTO);
            if (string.IsNullOrEmpty(resultado))
            {
                return Unauthorized();
            }
            return Ok(resultado);
        }

    }
}
