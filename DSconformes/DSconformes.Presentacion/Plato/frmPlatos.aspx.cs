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


namespace DSconformes.Presentacion.Plato
{
    public partial class frmPlatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCodigo();
            CargarCategorias();
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
        private void Limpiar(){
            txtCodigo.Text="";
            txtnombre.Text="";
            txtDescripcion.Text = "";
            ddlCategoria.SelectedIndex = 0;
            txtPrecio.Text = "";
        }
        private void CargarCodigo() {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Platos") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Platos platoobtenido = js.Deserialize<Platos>(platojson);
            txtCodigo.Text = (platoobtenido.id_plato+1).ToString() ?? "0";


        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Prueba de modificar
                CargarCodigo();
                string postdata = "{\"id_plato\":"+Int32.Parse(txtCodigo.Text)+",\"nombre\":\""+txtnombre.Text+"\",\"categoria\":"+ddlCategoria.SelectedValue+",\"costo\":"+decimal.Parse(txtPrecio.Text)+",\"descripcion\":\""+txtDescripcion.Text+"\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);

                HttpWebRequest req = WebRequest.Create("http://localhost:12455/Plato.svc/Platos") as HttpWebRequest;
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = req.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string platojson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                frmPlatos platomodif = js.Deserialize<frmPlatos>(platojson);


                lblMensaje.Text = "Plato Registrado Correctamente";
                Limpiar();
                CargarCodigo();
                //Assert.AreEqual(platomodif.descripcion, "Ceviche");

            }
            catch (Exception ex) {

                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}