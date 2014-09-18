using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSconformes.Dominio
{
    [DataContract]
    public class Mesa
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public Zona Zona { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public int Capacidad { get; set; }

    }
}