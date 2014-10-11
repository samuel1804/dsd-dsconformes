using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSconformes;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace DSconformes.Presentacion.Reservas
{
    public partial class CrearPedido : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarPedidos();
                CargarCategorias();
                CargarPlatos();
            }

        }


        private void CargarCategorias() {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Categoria.svc/Categorias") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Categorias> platoobtenido = js.Deserialize<List<Categorias>>(platojson);
            ddlCategoria.DataSource = platoobtenido;
            ddlCategoria.DataTextField = "nombre";
            ddlCategoria.DataValueField = "id_categoria";
            ddlCategoria.DataBind();
        }
        private void CargarPlatos() {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Platos/"+ddlCategoria.SelectedValue) as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Platos> platoobtenido = js.Deserialize<List<Platos>>(platojson);
            ddlPlato.DataSource = platoobtenido;
            ddlPlato.DataTextField = "nombre";
            ddlPlato.DataValueField = "id_plato";
            ddlPlato.DataBind();

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

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPlatos();
        }
        private void CargarDetalle() { 
        
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            

            CargarDetalle();
        }





    }
}