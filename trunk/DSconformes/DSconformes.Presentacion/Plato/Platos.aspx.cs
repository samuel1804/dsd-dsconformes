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
namespace DSconformes.Presentacion.Platos
{
    public partial class Platos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        private void CargarCodigo() { 
        
        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Prueba de modificar
                CargarCodigo();
                string postdata = "{\"id_plato\":22,\"nombre\":\""+txtnombre.Text+"\",\"categoria\":2,\"costo\":20,\"descripcion\":\""+txtDescripcion.Text+"\"}";
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
                Platos platomodif = js.Deserialize<Platos>(platojson);


                lblMensaje.Text = "Plato Registrado Correctamente";

                //Assert.AreEqual(platomodif.descripcion, "Ceviche");

            }
            catch (Exception ex) {

                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}