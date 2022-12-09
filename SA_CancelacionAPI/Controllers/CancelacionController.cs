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
            return Ok(await _repository.UpdateCancelacion(cancelacion));
        }
    }
}
