using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.DTOs
{
    public class AddMovimientoDTO
    {

        public float Total { get; set; }

        public string Tipo { get; set; } = null!;

        public DateTime Hora { get; set; }

        public int IdUsuario { get; set; }

        public string? Destino { get; set; }

        public string? Emisor { get; set; }

        public string? MedioPago { get; set; }

        public string? TipoDetalle { get; set; }
    }
}
