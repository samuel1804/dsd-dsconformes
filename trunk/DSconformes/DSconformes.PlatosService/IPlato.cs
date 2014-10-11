using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DSconformes.PlatosService.Dominio;


namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPlato" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPlato
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Platos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Platos Insertar(Platos pbePlato);

        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Platos", ResponseFormat = WebMessageFormat.Json)]
        Platos ObtenerUltimo();


        [WebInvoke(Method = "GET", UriTemplate = "Platos/{cod_categoria}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Platos> Listar(string cod_categoria);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Plato/{cod_plato}", ResponseFormat = WebMessageFormat.Json)]
        Platos Obtener(string cod_plato);
    }
}
