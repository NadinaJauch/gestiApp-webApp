using Abstractions.IServices;
using Abstractions.IRepositories;
using db.Models;
using Views.DTOs;

namespace Services
{
    public class MovimientosService : IMovimientosService
    {
        private readonly IMovimientosRepository _movimientosRepository;
        public MovimientosService(IMovimientosRepository movimientosRepository)
        {
            _movimientosRepository = movimientosRepository;
        }

        public async Task<List<Movimiento>> Get()
        {
            return await _movimientosRepository.Get();
        }

        public async Task AddMovimiento(AddMovimientoDTO movimientoDTO)
        {
            Movimiento movimiento = new Movimiento();

            movimiento.Total = movimientoDTO.Total;
            movimiento.Tipo = movimientoDTO.Tipo;
            movimiento.Hora = movimientoDTO.Hora;
            movimiento.Destino = movimientoDTO.Destino;
            movimiento.Emisor = movimientoDTO.Emisor;
            movimiento.MedioPago = movimientoDTO.MedioPago;
            movimiento.TipoDetalle = movimientoDTO.TipoDetalle;

            await _movimientosRepository.Post(movimiento);

        }
    }
}