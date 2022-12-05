using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.DTOs;

namespace Abstractions.IServices
{
    public interface IMovimientosService
    {
        public Task<List<Movimiento>> Get();
        public Task AddMovimiento(AddMovimientoDTO movimientoDTO);

    }
}
