using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cancelacion
    {
        public int Id { get; set; }
        public string codigoSerial { get; set; }
        public int numeroContacto { get; set; }
        public string tipoContacto { get; set; }
        public string correoCliente { get; set; }
        public string tipologia { get; set; }
        public string fechaSeleccionCategoria { get; set; }
        public int lineaProductoSolicitud { get; set; }
        public string otroCanal { get; set; }
        public string ciudad { get; set; }
        public string enviaCorreo { get; set; }
        public string fechaNotificacionInmediata { get; set; }
    }
}

