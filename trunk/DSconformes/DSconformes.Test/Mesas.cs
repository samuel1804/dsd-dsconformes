using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSconformes.Presentacion
{
   public class Mesas
    {
        
        public int id_mesa { get; set; }
        
        public Zonas zona { get; set; }
        
        public int estado { get; set; }
        
        public int asientos { get; set; }
    }
}
