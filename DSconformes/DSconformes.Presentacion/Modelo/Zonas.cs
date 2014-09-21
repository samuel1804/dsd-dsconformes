using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSconformes.Presentacion
{
    
    public class Zonas
    {
    
        public int id_zona { get; set; }
    
        public string nombre { get; set; }
    
        public string descripcion { get; set; }
    
        public int minimo { get; set; }
    
        public int capacidad { get; set; }
    
        public bool habilitado { get; set; }

    }
}