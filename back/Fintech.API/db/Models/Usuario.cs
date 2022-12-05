using System;
using System.Collections.Generic;

namespace db.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public float BalancePesos { get; set; }

    public float BalanceDolar { get; set; }

    public DateTime DateJoined { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual ICollection<Movimiento> Movimientos { get; } = new List<Movimiento>();
}
