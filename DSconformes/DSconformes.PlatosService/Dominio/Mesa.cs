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
        public int id_mesa { get; set; }
        [DataMember]
        public Zona zona { get; set; }
        [DataMember]
        public int estado { get; set; }
        [DataMember]
        public int asientos { get; set; }

    }
}