using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IZona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IZona
    {
        [OperationContract]
        List<Zonas> ListarZonas();
    }
}
