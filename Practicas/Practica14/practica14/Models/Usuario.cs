﻿using System;
using System.Collections.Generic;

namespace practica14.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Clave { get; set; }
}
