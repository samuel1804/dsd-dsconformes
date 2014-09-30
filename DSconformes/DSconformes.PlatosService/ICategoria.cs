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
        [WebInvoke(Method = "GET", UriTemplate = "Categorias", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Categorias> Listar();
    }
}
