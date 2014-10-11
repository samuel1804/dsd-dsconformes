using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSconformes;

namespace DSconformes.Presentacion.Reservas
{
    public partial class CrearPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarPedidos();
            }

        }


        private void CargarPedidos()
        {

            try
            {
                ws_reserva.ReservaClient reservaBL = new ws_reserva.ReservaClient();
                var pedidos = reservaBL.Listar(txtBuscarNombre.Text, txtBuscarDNI.Text);
                gvPedidos.DataSource = pedidos;
                gvPedidos.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                CargarPedidos();
            }
            catch(Exception ex){


        }
        }





    }
}