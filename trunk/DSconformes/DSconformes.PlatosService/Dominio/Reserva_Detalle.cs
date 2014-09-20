using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.PlatosService.Dominio;
using System.Runtime.Serialization;
namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Reserva_Detalle
    {
        [DataMember]
        public int id_reserva_detalle { get; set; }
        [DataMember]
        public Reserva reserva { get; set; }
        [DataMember]
        public Plato plato { get; set; }
        [DataMember]
        public int cantidad { get; set; }
        [DataMember]
        public decimal costo { get; set; }
        [DataMember]
        public decimal SubTotal { get; set; }
    }
}