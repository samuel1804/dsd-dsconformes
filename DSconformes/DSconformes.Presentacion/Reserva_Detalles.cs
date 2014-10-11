using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace DSconformes.Presentacion
{
    [DataContract]
    public class Reserva_Detalles
    {
       
        public int id_reserva_detalle { get; set; }
        
        //public Reservas reserva { get; set; }
       
        public Platos plato { get; set; }
       
        public int cantidad { get; set; }
       
        public decimal costo { get; set; }
        
        public decimal subtotal { get; set; }

        
        public int id_reserva { get; set; }
      
        public int id_plato { get; set; }
        
        public string PlatoNombre { get; set; }
    }
}