using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class DCancelacion : IDCancelacion
    {
        string connectionString = "";
        public  Task<bool> UpdateCancelacion(Cancelacion cancelacion)
        {
            
            
        }
    }
}
