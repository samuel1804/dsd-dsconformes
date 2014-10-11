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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Reserva_Detalle" en el código, en svc y en el archivo de configuración a la vez.
    public class Reserva_Detalle : IReserva_Detalle
    {

        private Reserva_DetalleDAO dao = new Reserva_DetalleDAO();
        public void Registrar(Reserva_Detalles reserva_detalle)
        {
            dao.Registrar(reserva_detalle);
        }

        public Reserva_Detalles Insertar(Reserva_Detalles reserva_detalle)
        {
            return dao.Insertar(reserva_detalle);
        }

        public List<Reserva_Detalles> ListarReserva(int id_reserva)
        {
            return dao.ListarReserva(id_reserva);
        }


        public List<Reserva_Detalles> Listar(int id_reserva)
        {
            return dao.Listar(id_reserva);
        }
    }
}
