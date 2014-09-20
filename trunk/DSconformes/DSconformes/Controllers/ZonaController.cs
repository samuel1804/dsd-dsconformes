using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSconformes.Models;
namespace DSconformes.Controllers
{
    public class ZonaController : Controller
    {
        //
        // GET: /Zona/
        private ZonaModels zm = new ZonaModels();
        public ActionResult Index()
        {



            return View(zm.ListarZonas());
        }

    }
}
