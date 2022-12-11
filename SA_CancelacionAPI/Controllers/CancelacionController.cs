using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.Entities;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;

namespace SA_CancelacionAPI.Controllers
{
    public class CancelacionController : Controller
    {
        private readonly ICancelacionRepository _repository;
        [HttpPut]
        [ProducesResponseType(typeof(Cancelacion), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateCancelacion([FromBody] Cancelacion cancelacion)
        {
            Infrastructure.Data.Cancelacion cancelacionData = new Infrastructure.Data.Cancelacion();
            cancelacionData.Ciudad = cancelacion.ciudad;
            cancelacionData.Codigo = Convert.ToInt32(cancelacion.codigoSerial);
            cancelacionData.CorreoCliente = cancelacion.correoCliente;
            cancelacionData.EnviaCorreo = cancelacion.enviaCorreo;
            //cancelacionData.FechaNotificacionInmediata = cancelacion.fechaNotificacionInmediata.;
            //cancelacionData.FechaSeleccionCategoria = cancelacion.fechaSeleccionCategoria;
            cancelacionData.LineaProductoSolicitud = cancelacion.lineaProductoSolicitud;
            cancelacionData.NumeroContacto = cancelacion.numeroContacto;
            cancelacionData.OtroCanal = cancelacion.otroCanal;
            cancelacionData.TipoContacto = cancelacion.tipoContacto;
            cancelacionData.Tipologia = cancelacion.tipologia;
            return Ok(await _repository.UpdateCancelacion(cancelacionData));
        }
    }
}
