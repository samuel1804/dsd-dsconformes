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

namespace DSconformes.Presentacion.Categoria
{
	public partial class frmCategorias : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            CargarCodigo();

		}
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
        }
        private void CargarCodigo()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Categoria.svc/CategoriasUltimo") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string catjson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Categorias catobtenido = js.Deserialize<Categorias>(catjson);
            txtCodigo.Text = (catobtenido.id_categoria + 1).ToString() ?? "0";
        }
        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoria.Text == "0")
                {
                    lblMensajeError.Text = "Ingrese algun tipo de categoría";
                }
                else
                {
                    CargarCodigo();
                    string postdata = "{\"id_categoria\":" + Int32.Parse(txtCodigo.Text) 
                                    + ",\"nombre\":\"" + txtCategoria.Text  + "\"}";
                    byte[] data = Encoding.UTF8.GetBytes(postdata);

                    HttpWebRequest req = WebRequest.Create("http://localhost:12455/Categoria.svc/Categorias") as HttpWebRequest;
                    req.Method = "POST";
                    req.ContentLength = data.Length;
                    req.ContentType = "application/json";
                    var reqStream = req.GetRequestStream();
                    reqStream.Write(data, 0, data.Length);
                    var res = req.GetResponse() as HttpWebResponse;
                    StreamReader reader = new StreamReader(res.GetResponseStream());
                    string catjson = reader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    frmCategorias catmodif = js.Deserialize<frmCategorias>(catjson);

                    lblMensaje.Text = "Categoria Registrada Correctamente";
                    Limpiar();
                    CargarCodigo();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }        
    }
}