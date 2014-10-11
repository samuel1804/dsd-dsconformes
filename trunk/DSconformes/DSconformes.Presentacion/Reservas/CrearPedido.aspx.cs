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
                CargarDatos();
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
                upPedidos.Update();
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
            CargarDatos();
            mpePedido.Show();
        }
        private void CargarDetalle() { 
        ws_reserva_detalle.Reserva_DetalleClient wdc=new ws_reserva_detalle.Reserva_DetalleClient();
           
            var rd = wdc.ListarReserva(int.Parse(hfIdReserva.Value));
            gvPedidoDetalle.DataSource = rd;
      gvPedidoDetalle.DataBind();

            //CalcularTotal
            decimal Total=0;
      foreach (var r in rd) {
          Total += (r.costo * r.cantidad);
      }
      txtTotal.Text = Total.ToString();

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ws_reserva_detalle.Reserva_DetalleClient rdc = new ws_reserva_detalle.Reserva_DetalleClient();
                ws_reserva_detalle.Reserva_Detalles rd = new ws_reserva_detalle.Reserva_Detalles();
                rd.id_reserva = int.Parse(hfIdReserva.Value.ToString());
                rd.id_plato = int.Parse(ddlPlato.SelectedValue.ToString());
                rd.cantidad = int.Parse(txtCantidad.Text);
                rd.costo = decimal.Parse(txtCosto.Text);
                rd.subtotal = rd.costo * rd.cantidad;
                rdc.Insertar(rd);


                ws_reserva.ReservaClient rc = new ws_reserva.ReservaClient();
                rc.Actualizar(int.Parse(hfIdReserva.Value.ToString()), decimal.Parse(txtTotal.Text));
                

                CargarDetalle();
                mpePedido.Show();
            }
            catch (Exception ex) { 

            }
        }


        
        protected void gvPedidos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idr= (int)this.gvPedidos.DataKeys[e.RowIndex]["id_reserva"];

            hfIdReserva.Value = idr.ToString();
            CargarDetalle();
            

            mpePedido.Show();
        }
        private void CargarDatos() {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Plato/" + ddlPlato.SelectedValue) as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Platos platoobtenido = js.Deserialize<Platos>(platojson);


            txtCosto.Text = platoobtenido.costo.ToString();
            txtCantidad.Text = "1";
        }
        protected void ddlPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
            mpePedido.Show();
        }





    }
}