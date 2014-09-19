using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        public int id_categoria { get; set; }
        [DataMember]
        public string nombre { get; set; }
    }
}