﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ReservaModel
    {

        public int ID { get; set; }
        public int SalaID { get; set; }
        public SalaModel Sala { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Usuario { get; set; }
    }
}
