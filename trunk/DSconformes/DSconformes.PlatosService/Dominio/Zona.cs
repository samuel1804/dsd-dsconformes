using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Zona
    {
        [DataMember]
        public int id_zona { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int capacidad { get; set; }

    }
}