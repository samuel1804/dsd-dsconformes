using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMesero" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMesero
    {
        [OperationContract]
        void DoWork();
    }
}
