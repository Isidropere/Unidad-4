using MVC_Validar_Estudiante_DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Validar_Estudiante_DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Estudiante estud = new Estudiante();
            return View(estud);
        }


        [HttpPost]
        public ActionResult Index(Estudiante estud)
        {
            if (ModelState.IsValid)
            {
                return View("Correcto");
            }
            else
                return View(estud);
        }


        public ActionResult Correcto()
        {
            return View();
        }


        //--------------------------------------------------------------//
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