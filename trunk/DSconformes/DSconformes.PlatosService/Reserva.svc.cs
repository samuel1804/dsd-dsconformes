using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Reserva" en el código, en svc y en el archivo de configuración a la vez.
    public class Reserva : IReserva
    {
        private ReservaDAO rs = new ReservaDAO();
        public Reservas Registrar(string nombre, string dni, Zonas zona, Mesas mesa, TimeSpan hora_inicio, int estado, int asistentes, DateTime fecha)
        {
            Reservas reservas = new Reservas();
            reservas.nombre = nombre;
            reservas.dni = dni;
            reservas.zona = zona;
            reservas.mesa = mesa;
            reservas.hora_inicio = hora_inicio;
            reservas.estado = estado;
            reservas.asistentes = asistentes;
            reservas.fecha = fecha;

            return rs.Crear(reservas);

            
        }


        
    }
    }

