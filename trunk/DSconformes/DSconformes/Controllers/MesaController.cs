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

        public ActionResult Index(int codigoZona, string nombre, int capacidad )
        {


            Zona zona = new Zona { id_zona = codigoZona, nombre = nombre,  capacidad = capacidad };
            return View();
        }

        public ActionResult Detalle()
        {
            return View();

        }


    }
}
