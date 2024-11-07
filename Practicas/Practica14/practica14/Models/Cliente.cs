using System;
using System.Collections.Generic;

namespace practica14.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
