using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.ws_zona;
namespace DSconformes.Models
{
    public class ZonaModels
    {
         private Zona zona=new Zona();
        public List<Zonas> ListarZonas(){
        return zona.ListarZonas().ToList();
        }
       

    }
}