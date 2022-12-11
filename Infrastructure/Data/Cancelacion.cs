using System;
using System.Collections.Generic;

namespace Infrastructure.Data;

public partial class Cancelacion
{
    public int Codigo { get; set; }

    public int? NumeroContacto { get; set; }

    public string? TipoContacto { get; set; }

    public string? CorreoCliente { get; set; }

    public DateOnly? FechaSeleccionCategoria { get; set; }

    public string? Tipologia { get; set; }

    public int? LineaProductoSolicitud { get; set; }

    public string? OtroCanal { get; set; }

    public string? Ciudad { get; set; }

    public string? EnviaCorreo { get; set; }

    public DateOnly? FechaNotificacionInmediata { get; set; }
}
