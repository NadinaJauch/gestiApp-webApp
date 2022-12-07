using System;
using System.Collections.Generic;

namespace db.Models;

public partial class Movimiento : BaseEntity
{
    public int Id { get; set; }

    public float Total { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime Hora { get; set; }

    public int IdUsuario { get; set; }

    public string? Destino { get; set; }

    public string? Emisor { get; set; }

    public string? MedioPago { get; set; }

    public string? TipoDetalle { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
