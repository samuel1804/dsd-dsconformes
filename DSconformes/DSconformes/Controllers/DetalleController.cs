using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSconformes.Controllers
{
    public class DetalleController : Controller
    {
        //
        // GET: /Detalle/

        public ActionResult Index(int id_zona, string nombre, int capacidad, Boolean habilitado)
        {
            ViewData["id_zona"] = id_zona;
            ViewData["nombre"] = nombre;
            ViewData["capacidad"] = capacidad;
            ViewData["habilitado"] = habilitado;
            return View();
        }

    }
}
