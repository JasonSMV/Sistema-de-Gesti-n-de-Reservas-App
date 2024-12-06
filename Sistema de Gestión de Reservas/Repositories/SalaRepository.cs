using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Gestión_de_Reservas.Repositories
{
    public class SalaRepository
    {
        public SalaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}