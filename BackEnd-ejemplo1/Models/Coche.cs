using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Coche
    {
        public string IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Propietario { get; set; }

        public Coche(string Idcoche, string Marca, string Modelo, string Propietario)//Este es un constructor
        {
            this.IdCoche = Idcoche;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Propietario = Propietario;
        }
    }
}