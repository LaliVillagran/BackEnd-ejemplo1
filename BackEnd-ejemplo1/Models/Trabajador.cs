using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public double Sueldo { get; set; }
        
        public bool EsFijo { get; set; }



    }
}