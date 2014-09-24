using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;

namespace DSconformes.PlatosService
{
    [ServiceContract]
    public interface IMesero
    {
        [OperationContract]
        Meseros Registrar(int dni, string nombre, Mesas mesa, char sexo, int edad, TimeSpan h_entrada, TimeSpan h_salida);
        [OperationContract]
        Meseros Actualizar(int dni, string nombre, Mesas mesa, char sexo, int edad, TimeSpan h_entrada, TimeSpan h_salida);
        [OperationContract]
        Meseros Obtener(int id_mesa);
        [OperationContract]
        List<Meseros> Listar();
        [OperationContract]
        Meseros Eliminar(int dni);

    }
}
