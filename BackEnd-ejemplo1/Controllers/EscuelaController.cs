using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela View Back
        public ActionResult Index()
        {
            ViewBag.Nombre = "Eduardo Tomas";
            ViewBag.correo = "eduardo@gmail.com";
            ViewBag.Fecha = new DateTime(2001, 12, 10);
            return View();
        }

        //View Data

        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Danna Marlene";
            ViewData["correo"] = "danna@gmail.com";
            ViewData["FechaNaci"] = new DateTime(2002, 04, 03);
            return View();
        }

        public ActionResult Agregar(Trabajador emp)
        {
            
            return View(emp);

        }

        public ActionResult Agregar2(Trabajador emp)
        {
            var trab = new Trabajador()
            {
                Nombre = "Pedro",
                Apellidos = "Lopez",
                FechaNacimiento = new DateTime(2001, 1, 1),
                Sueldo= 250,
                EsFijo=true
            };
            ViewBag.Trabajador = trab;

            return View(emp);

        }

        public List<SelectListItem> ObtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text="Sí",
                    Value="1"
                },

                 new SelectListItem()
                {
                    Text="No",
                    Value="2"
                }
            };
        }
    }
}
