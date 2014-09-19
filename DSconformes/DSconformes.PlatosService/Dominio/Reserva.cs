﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using DSconformes.Dominio;
namespace DSconformes.PlatosService.Dominio
{
    [DataContract]
    public class Reserva
    {

        [DataMember]
        public int id_reserva { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public Zona zona { get; set; }
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