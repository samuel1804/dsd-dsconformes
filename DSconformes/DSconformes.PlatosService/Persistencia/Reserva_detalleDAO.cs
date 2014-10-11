using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
using System.Messaging;
using System.Data.SqlClient;
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
                mensaje.Label = reserva_detalle.id_reserva.ToString();
                mensaje.Body = new Reserva_Detalles() { id_reserva = reserva_detalle.id_reserva,
                    id_plato = reserva_detalle.id_plato, cantidad=reserva_detalle.cantidad, costo=reserva_detalle.costo, subtotal=reserva_detalle.subtotal };
                cola.Send(mensaje);

            }
            catch (Exception ex) { 
            
            }
        }


        public List<Reserva_Detalles> Listar(int id_reserva) {
            var Lista = new List<Reserva_Detalles>();
            try
            {
                if (!MessageQueue.Exists(rutacola))
                    MessageQueue.Create(rutacola);
                cola = new MessageQueue(rutacola);
                int cantmsg = cola.GetAllMessages().Count();

                

                for (int i = 0; i <= cantmsg; i++)
                {
                    cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Reserva_Detalles) });
                    mensaje = cola.Receive();
                    Reserva_Detalles reserva_detalle = (Reserva_Detalles)mensaje.Body;

                }

                return Lista;
            }
            catch (Exception ex) {
                return Lista;
            }
                
        }


        public Reserva_Detalles Insertar(Reserva_Detalles reservaACrear)
        {
            Meseros meseroCreado = null;
            string sql = "INSERT INTO t_reserva_detalle(id_reserva, id_plato, costo, cantidad, subtotal) VALUES (@id_reserva, @id_plato, @costo, @cantidad, @subtotal)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id_reserva", reservaACrear.id_reserva));
                    com.Parameters.Add(new SqlParameter("@id_plato", reservaACrear.id_plato));
                    com.Parameters.Add(new SqlParameter("@costo", reservaACrear.costo));
                    com.Parameters.Add(new SqlParameter("@cantidad", reservaACrear.cantidad));
                    com.Parameters.Add(new SqlParameter("@subtotal", reservaACrear.subtotal));
                    
                    com.ExecuteNonQuery();

                }
            }
           
            return reservaACrear;

        }


        public List<Reserva_Detalles> ListarReserva(int id_reserva)
        {

            string sql = "Select rd.id_reserva,rd.id_plato,rd.cantidad,rd.costo,rd.subtotal,p.nombre [PlatoNombre] from t_reserva_detalle rd inner join t_plato p on p.id_plato=rd.id_plato where rd.id_reserva=@id_reserva";
            Reserva_Detalles reservadetalle = new Reserva_Detalles();
            List<Reserva_Detalles> Lista = new List<Reserva_Detalles>();

            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id_reserva", id_reserva));
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            reservadetalle = new Reserva_Detalles()
                            {
                                id_reserva = (int)dr["id_reserva"],
                                id_plato = (int)dr["id_plato"],
                                
                                cantidad = (int)dr["cantidad"],
                                costo = (decimal)dr["costo"],
                                subtotal = (decimal)dr["subtotal"],
                                PlatoNombre = (string)dr["PlatoNombre"],
                            };
                            Lista.Add(reservadetalle);
                        }


                    }
                }
            }

            return Lista;
        }

    }
}