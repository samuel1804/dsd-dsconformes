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
            
            if (!IsPostBack) {
                 CargarZonas();
                CargarMesas();
            }}

       


            private void CargarZonas(){
            ws_zona.ZonaClient zona = new ws_zona.ZonaClient();
            ddlZona.DataSource= zona.ListarZonas();
            ddlZona.DataTextField = "nombre";
            ddlZona.DataValueField = "id_zona";
            ddlZona.DataBind();
         }
           private void CargarMesas() {
           ws_mesa.MesaClient mc = new ws_mesa.MesaClient();
           ddlMesa.DataSource= mc.ListarMesasporZona(int.Parse( ddlZona.SelectedValue.ToString()));
           ddlMesa.DataTextField = "id_mesa";
           ddlMesa.DataValueField = "id_mesa";
           ddlMesa.DataBind();
        
        }

         protected void BtnGrabar_Click(object sender, EventArgs e)
         {
            try
            {
                ws_reserva.ReservaClient rc = new ws_reserva.ReservaClient();
                ws_reserva.Mesas mesa = new ws_reserva.Mesas();
                mesa.id_mesa = int.Parse(ddlMesa.SelectedValue.ToString());
                ws_reserva.Zonas zona = new ws_reserva.Zonas();
                zona.id_zona = int.Parse(ddlZona.SelectedValue.ToString());
                rc.Registrar(txtNombre.Text, txtDNI.Text, zona, mesa,new TimeSpan(int.Parse(TxtHora.Text),0,0), 1, int.Parse(txtCantidad.Text),DateTime.Parse( TxtFecha.Text));

                lblMensaje.Text = "Reserva Registrada Correctamente";

                Limpiar();
            }
            catch(Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void Limpiar()
        {
            TxtFecha.Text = "";
            txtCantidad.Text = "";
            txtDNI.Text = "";
            TxtHora.Text = "";
            txtNombre.Text = "";
            ddlZona.SelectedIndex = 0;
            ddlMesa.SelectedIndex = 0;

        }

        protected void ddlZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMesas();
        }
    }
}