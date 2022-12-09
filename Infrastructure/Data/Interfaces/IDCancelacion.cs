using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Data.Interfaces
{
    public interface IDCancelacion
    {
        Task<bool> UpdateCancelacion(Cancelacion updateCancelacion);
    }
}
