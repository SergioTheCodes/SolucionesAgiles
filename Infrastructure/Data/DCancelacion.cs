using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infrastructure.Data
{
    public class DCancelacion : IDCancelacion
    {
        protected readonly IConfiguration Configuration;

        public DCancelacion (IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        private void Connection(string cs)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(cs))
            {
                connection.Open();
            }
        }
        
        public  Task<bool> UpdateCancelacion(Cancelacion cancelacion)
        {
            string cs = Configuration.GetConnectionString("adesasolucionesagilesbd01").ToString();
            Connection(cs);
            NpgsqlCommand cmd = new NpgsqlCommand();
            return Task.FromResult(true);
            
        }
    }
}
