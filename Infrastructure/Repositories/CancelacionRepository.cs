using Infrastructure.Data;
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
        private readonly Adesasolucionesagilesbd01Context _context;
        public Task<bool> UpdateCancelacion(Cancelacion cancelacion)
        {
            Cancelacion updateCancelacion = (from c in _context.Cancelacions 
                                             where c.Codigo == cancelacion.Codigo
                                             select c).FirstOrDefault();
            if (updateCancelacion != null)
            {
                updateCancelacion = cancelacion;
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
    }
}
