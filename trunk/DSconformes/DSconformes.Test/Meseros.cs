using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSconformes.Presentacion
{
    public class Meseros
    {
       
        public int id_mesero { get; set; }
       
        public string dni { get; set; }
      
        public string nombre { get; set; }
       
        public Mesas mesa { get; set; }
       
        public char sexo { get; set; }
      
        public int edad { get; set; }
       
        public TimeSpan? h_entrada { get; set; }
       
        public TimeSpan? h_salida { get; set; }
    }
}
