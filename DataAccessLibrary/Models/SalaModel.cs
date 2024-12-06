using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class SalaModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
