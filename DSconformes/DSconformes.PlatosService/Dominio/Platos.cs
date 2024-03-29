﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Platos
    {
        [DataMember]
        public int id_plato { get; set; }

        [DataMember]
        public int id_categoria { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public Categorias categoria { get; set; }
        [DataMember]
        public decimal costo { get; set; }
        [DataMember]
        public string descripcion { get; set; }


        [DataMember]
        public string cod_categoria { get; set; }
        [DataMember]
        public string cod_plato { get; set; }
    }
}