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

        [HttpPost]
        public async Task<IActionResult> Post(SeguridadDto securityDto)
        {
            var security = _mapper.Map<Usuario>(securityDto);

            security.Password = _passwordService.Hash(security.Password);
            await _seguridadService.RegisterUser(security);

            securityDto = _mapper.Map<SeguridadDto>(security);
            return Ok(securityDto);
        }

    }
}
