using System;
using System.Collections.Generic;

namespace practica14.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public float? Precio { get; set; }

    public int? Inventario { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
}
