using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Dominio;
using System.Runtime.Serialization;
namespace DSconformes.PlatosService.Dominio
{
[DataContract]
    public class Mesero
    {
    [DataMember]
    public string dni { get; set; }
    [DataMember]   
    public string nombre { get; set; }
    [DataMember]    
    public Mesa mesa { get; set; }
    }
}