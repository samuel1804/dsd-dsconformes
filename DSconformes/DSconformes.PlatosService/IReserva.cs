using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReserva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReserva
    {
        [OperationContract]
        Reservas Registrar(string nombre, string dni, Zonas zona, Mesas mesa, TimeSpan hora_inicio, int estado, int asistentes, DateTime fecha);
        [OperationContract]
        List<Reservas> Listar(string nombre,string dni);
        [OperationContract]
        Reservas Obtener(int id_reserva);
        [OperationContract]
        void Actualizar(int id_reserva,decimal Total);
    }
}
