using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSconformes.Presentacion
{
    [TestClass]
    public class ReservacionTest
    {
        [TestMethod]
        public void Registrarreserva()
        {
            ws_reserva.ReservaClient rc = new ws_reserva.ReservaClient();
            ws_reserva.Zonas zona=new ws_reserva.Zonas();
            zona.id_zona=1;
            ws_reserva.Mesas mesa=new ws_reserva.Mesas();
            mesa.id_mesa=2;

            Assert.AreEqual(rc.Registrar("Samuel Flores", "46683055", zona, mesa, new TimeSpan(7, 10, 00), 1, 5, DateTime.Now).nombre, "Samuel Flores");


        }

        [TestMethod]
        public void ListarReservas() {
            ws_reserva.ReservaClient rc = new ws_reserva.ReservaClient();

            Assert.AreEqual(rc.Listar().Count(), 13);

        }

        [TestMethod]
        public void ObternerReserva() {
            ws_reserva.ReservaClient rc = new ws_reserva.ReservaClient();

            Assert.AreEqual(rc.Obtener(3).nombre, "Nicolas Cage");

        }


        
    }
}
