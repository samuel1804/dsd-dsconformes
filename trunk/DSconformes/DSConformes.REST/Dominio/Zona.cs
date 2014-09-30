﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSConformes.REST.Dominio
{
    [DataContract]
    public class Zona
    {
        [DataMember]
        public int id_zona { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public int minimo { get; set; }
        [DataMember]
        public int capacidad { get; set; }
        [DataMember]
        public bool habilitado { get; set; }

    }
}