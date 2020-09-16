using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiplomadoMVC_Crud_HTML_Helps_NoTipados.Models;

namespace DiplomadoMVC_Crud_HTML_Helps_NoTipados.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection coleccion)
        {
            MantenimientoProducto mantenimiento = new MantenimientoProducto();
            if (mantenimiento!=null)
            {
                Producto producto = mantenimiento.RecuperarUnRegistro(int.Parse(coleccion["Codigo"].ToString()));
                if (producto != null)
                {
                    return View("ModificacionDeProducto", producto);
                }
                else
                    return View("ProductoNoExiste");
            }
            else
                return View("ProductoNoExiste");
        }
        [HttpPost]
        public ActionResult ModificacionDeProducto(FormCollection coleccion)
        {
            MantenimientoProducto mantenimiento = new MantenimientoProducto();
            Producto productos = new Producto
            {
                Codigo = int.Parse(coleccion["Codigo"].ToString()),
                Descripcion = coleccion["Descripcion"].ToString(),
                Precio = float.Parse(coleccion["Precio"].ToString())
            };
            mantenimiento.Modificar(productos);
            return RedirectToAction("Index");
        }

        public ActionResult Grabar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Grabar(FormCollection coleccion)
        {

            MantenimientoProducto mantenimiento = new MantenimientoProducto();
            Producto productos = new Producto
            {

                //Codigo = int.Parse(coleccion["Codigo"].ToString()),
                Descripcion = coleccion["Descripcion"],
                Precio = float.Parse(coleccion["Precio"].ToString())
            };
            mantenimiento.Agregar(productos);
            return RedirectToAction("Index");
        }

        public ActionResult ModificacionDeProducto()
        {
           

            return View();
        }
        public ActionResult ProductoNoExiste()
        {

            return View();
        }
        public ActionResult ListarProductos()
        {

            return View();
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