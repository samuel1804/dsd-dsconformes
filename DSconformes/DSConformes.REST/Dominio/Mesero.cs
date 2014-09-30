using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSConformes.REST.Dominio
{
    [DataContract]
    public class Mesero
    {
        [DataMember]
        public int id_mesero { get; set; }
        [DataMember]
        public int dni { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public Mesa mesa { get; set; }
        [DataMember]
        public char sexo { get; set; }
        [DataMember]
        public int edad { get; set; }
        [DataMember]
        public TimeSpan h_entrada { get; set; }
        [DataMember]
        public TimeSpan h_salida { get; set; }
    }

}