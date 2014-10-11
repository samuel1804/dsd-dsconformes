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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICategoria" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICategoria
    {
        /*[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Categorias", ResponseFormat = WebMessageFormat.Json)]
        Categorias ObtenerUltimo();*/
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Categorias", ResponseFormat = WebMessageFormat.Json)]
        List<Categorias> Listar();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CategoriasUltimo", ResponseFormat = WebMessageFormat.Json)]
        Categorias ObtenerUltimo();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Categorias", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Categorias Insertar(Categorias pbeCat);

        

    }
}
