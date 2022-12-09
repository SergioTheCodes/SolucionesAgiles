using Domain.Entities;
using Infrastructure.Data.Interfaces;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CancelacionRepository : ICancelacionRepository
    {
        private readonly IDCancelacion _context;
        public Task<bool> UpdateCancelacion(Cancelacion cancelacion)
        {
            var updateCancelacion = _context.UpdateCancelacion(cancelacion);
            return updateCancelacion;
        }
    }
}
