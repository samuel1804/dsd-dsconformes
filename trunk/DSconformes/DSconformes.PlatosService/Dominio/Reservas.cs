using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using DSconformes.PlatosService.Dominio;
namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Reservas
    {

        [DataMember]
        public int id_reserva { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string dni { get; set; }
        [DataMember]
        public Mesas zona { get; set; }
        [DataMember]
        public Mesas mesa { get; set; }
        [DataMember]
        public TimeSpan hora_inicio { get; set; }
        [DataMember]
        public int estado { get; set; }
        [DataMember]
        public int asistentes { get; set; }
        [DataMember]
        public decimal total_consumo { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
    }
}