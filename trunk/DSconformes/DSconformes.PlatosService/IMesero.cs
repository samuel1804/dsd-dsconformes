using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;
using System.ServiceModel.Web;

namespace DSconformes.PlatosService
{
    [ServiceContract]
    public interface IMesero
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate="Meseros", ResponseFormat=WebMessageFormat.Json)]
        Meseros CrearMesero(Meseros meseroACrear);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Meseros/{id_mesero}", ResponseFormat = WebMessageFormat.Json)]
        Meseros ObtenerMesero(int id_mesero);
        
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Meseros", ResponseFormat = WebMessageFormat.Json)]
        Meseros ModificarMesero(Meseros meseroAModificar);
        
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Meseros", ResponseFormat = WebMessageFormat.Json)]
        bool EliminarMesero(Meseros meseroAModificar);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Meseros", ResponseFormat = WebMessageFormat.Json)]
        List<Meseros> ListarMeseros();


    }
}
