using Abstractions.IServices;
using db.Models;
using Microsoft.AspNetCore.Mvc;
using Views.DTOs;

namespace Fintech.API.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class MovimientosController : ControllerBase
    {
        private readonly IMovimientosService _movimientosService;

        public MovimientosController(IMovimientosService movimientosService)
        {
            _movimientosService = movimientosService;
        }

        [Route("GetMovimiento")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _movimientosService.Get();
                
                if (results == null || results.Count == 0)
                    return NotFound();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Route("AddMovimiento")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddMovimientoDTO movimiento)
        {
            _movimientosService.AddMovimiento(movimiento);
            return Ok();
        }

    }
}
