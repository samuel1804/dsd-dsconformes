using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSconformes;

namespace DSconformes.Presentacion
{
    public partial class Reservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) {
                CargarZonas();
                CargarMesas();
            }
        }


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

                rc.Registrar(txtNombre.Text, txtDNI.Text, int.Parse(ddlZona.SelectedValue.ToString()), int.Parse(ddlMesa.SelectedValue.ToString()),TimeSpan.Parse( TxtHora.Text), 1, int.Parse(txtCantidad.Text),DateTime.Parse( TxtFecha.Text));


            }
            catch(Exception ex)
            { 
            
            }
        }
    }
}