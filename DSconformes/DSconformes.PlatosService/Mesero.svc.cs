using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.PlatosService
{
    public class Mesero : IMesero
    {
        private MeseroDAO me =  new MeseroDAO();
        public  Meseros Registrar
        {
        }
    }
}
