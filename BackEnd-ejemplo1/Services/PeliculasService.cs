using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace BackEnd_ejemplo1.Services
{
    public class PeliculasService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 150,
                Pais = "USA",
                Publicacion = new DateTime(2012, 12, 11)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2015, 12, 11)
            };
            return new List<Pelicula>{pelicula1, pelicula2 };
        }
    }
}