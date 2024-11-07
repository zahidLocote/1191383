using System;
using System.Collections.Generic;

namespace practica14.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public int? ClienteId { get; set; }

    public string? Vendedor { get; set; }

    public string? MetodoPago { get; set; }

    public decimal? TotalVenta { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
}
