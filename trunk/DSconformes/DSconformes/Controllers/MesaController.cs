using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSconformes.PlatosService;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.Controllers
{
    public class MesaController : Controller
    {
        //
        // GET: /Mesa/
        Zonas zonas = null;

        public ActionResult Index(int codigoZona, string nombre, int capacidad )
        {

          
           //ViewData["Zonas"] = new Zonas { id_zona = codigoZona, nombre = nombre,  capacidad = capacidad };
            ViewData["nombre"] = nombre;
            return View();
        }

        public ActionResult Detalle(int id_zona, string nombre, int capacidad, Boolean habilitado)
        {
            ViewData["id_zona"] = id_zona;
            ViewData["nombre"] = nombre;
            ViewData["capacidad"] = capacidad;
            ViewData["habilitado"] = habilitado;
            return View();
        }


    }
}
