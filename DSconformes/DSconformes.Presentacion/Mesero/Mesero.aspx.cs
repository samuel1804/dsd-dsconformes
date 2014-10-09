using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;


namespace DSconformes.Presentacion.Mesero
{
    public partial class Mesero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCodigo();
            CargarMesas();

        }

        private void CargarCodigo()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Mesas.svc/Mesas") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string meserojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Mesas> meseroobtenido = js.Deserialize<List<Mesas>>(meserojson);
            ddlCategoria.DataSource = meseroobtenido;
            ddlCategoria.DataTextField = "nombre";
            ddlCategoria.DataValueField = "id_mesa";
            ddlCategoria.DataBind();
        }
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtnombre.Text = "";
            txtDescripcion.Text = "";
            ddlCategoria.SelectedIndex = 0;
            txtPrecio.Text = "";

        }
    }
}