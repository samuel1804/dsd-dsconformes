using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
using System.Messaging;
namespace DSconformes.Persistencia
{
    public class Reserva_DetalleDAO
    {
        string rutacola= @".\private$\pedidodetalle";
        MessageQueue cola;
        Message mensaje;
         
        public void Registrar(Reserva_Detalles reserva_detalle) {

            try
            {
                
                if (!MessageQueue.Exists(rutacola))
                    MessageQueue.Create(rutacola);
                cola = new MessageQueue(rutacola);
                mensaje = new Message();
                mensaje.Label = reserva_detalle.reserva.id_reserva.ToString();
                mensaje.Body = new Reserva_Detalles() { id_reserva = reserva_detalle.id_reserva,
                    id_plato = reserva_detalle.id_plato, cantidad=reserva_detalle.cantidad, costo=reserva_detalle.costo, subtotal=reserva_detalle.subtotal };
                cola.Send(mensaje);

            }
            catch (Exception ex) { 
            
            }
        }


        public List<Reserva_Detalles> Listar(int id_reserva) {
            try
            {
                if (!MessageQueue.Exists(rutacola))
                    MessageQueue.Create(rutacola);
                cola = new MessageQueue(rutacola);
                int cantmsg = cola.GetAllMessages().Count();

                var Lista = new List<Reserva_Detalles>();

                for (int i = 0; i <= cantmsg; i++)
                {
                    cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Reserva_Detalles) });
                    mensaje = cola.Receive();
                    Reserva_Detalles reserva_detalle = (Reserva_Detalles)mensaje.Body;

                }

                return Lista;
            }
            catch (Exception ex) {
                return null;
            }
                
        }
    }
}