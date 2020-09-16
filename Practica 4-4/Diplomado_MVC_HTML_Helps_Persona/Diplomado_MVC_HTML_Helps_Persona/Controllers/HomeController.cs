using Diplomado_MVC_HTML_Helps_Persona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_HTML_Helps_Persona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FormCollection coleccion)
        {
            MantenimientoPersona  mantenimiento = new MantenimientoPersona();

            Persona person = mantenimiento.Retornar(int.Parse(coleccion["Codigo"].ToString()));
            if (person != null)
            {
                return View("EditarPersona", person);
            }
            else
                return RedirectToAction("Index");
        }

            public ActionResult About()
        {
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