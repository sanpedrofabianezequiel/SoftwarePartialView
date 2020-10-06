using SoftwarePartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwarePartialView.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var personas = new List<Persona>()
            {
                new Persona(){ Nombre="Marcela",Edad=18},
                new Persona(){ Nombre="Henry",Edad=40},
                new Persona(){ Nombre="Daniela",Edad=27}
            };
            ViewBag.MiListado = personas;
            return View();
        }

        public ActionResult About()
        {
            var personas = new List<Persona>()
            {
                new Persona(){ Nombre="Marcela",Edad=18},
                new Persona(){ Nombre="Henry",Edad=40},
                new Persona(){ Nombre="Daniela",Edad=27}
            };
            ViewBag.MiListado = personas;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}