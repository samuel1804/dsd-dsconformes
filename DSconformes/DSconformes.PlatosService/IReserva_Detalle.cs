using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReserva_Detalle" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReserva_Detalle
    {
        [OperationContract]
        void Registrar(Reserva_Detalles reserva_detalle);
    }
}
