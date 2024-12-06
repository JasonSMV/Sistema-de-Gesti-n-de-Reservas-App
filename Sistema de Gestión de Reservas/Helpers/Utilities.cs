using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Sistema_de_Gestión_de_Reservas.Helpers
{
    public class Utilities
    {
        public static string GetConnectionString(string name = "Default")
        {

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return connStr;
        }
    }
}