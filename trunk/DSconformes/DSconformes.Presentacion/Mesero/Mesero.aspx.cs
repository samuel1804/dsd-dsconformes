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
            if (!IsPostBack) {
                CargarCodigo();
                CargarZonas();
                CargarMesas();
            }

        }

        private void CargarZonas()
        {
            ws_zona.ZonaClient zona = new ws_zona.ZonaClient();
            ddlZona.DataSource = zona.ListarZonas();
            ddlZona.DataTextField = "nombre";
            ddlZona.DataValueField = "id_zona";
            ddlZona.DataBind();
        }
        private void CargarMesas()
        {
            ws_mesa.MesaClient mc = new ws_mesa.MesaClient();
            ddlMesa.DataSource = mc.ListarMesasporZona(int.Parse(ddlZona.SelectedValue.ToString()));
            ddlMesa.DataTextField = "id_mesa";
            ddlMesa.DataValueField = "id_mesa";
            ddlMesa.DataBind();

        }

        private void CargarCodigo()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Mesero.svc/Meseros") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string meserojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Meseros meseroobtenido = js.Deserialize<Meseros>(meserojson);
            id_mesero.Text = meseroobtenido.id_mesero.ToString();
        }
        private void Limpiar()
        {
            id_mesero.Text = "";


        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                    
                    CargarCodigo();
                    string postdata = "{\"id_mesero\":" + Int32.Parse(id_mesero.Text) + ",\"DNI\":\"" + TextDNI.Text + ",\"nombre\":\"" + TextNombres.Text + "\",\"id_zona\":" + ddlZona.SelectedValue + "\",\"id_mesa\":" + ddlMesa.SelectedValue + ",\"sexo\":" + TxtSexo.Text + ",\"edad\":" + Int32.Parse(TxtEdad.Text) + ",\"h_entrada\":\"" + TxtEntrada.Text + ",\"h_salida\":\"" + TxtSalida.Text + "\"}";

                    byte[] data = Encoding.UTF8.GetBytes(postdata);

                    HttpWebRequest req = WebRequest.Create("http://localhost:12455/Mesero.svc/Meseros") as HttpWebRequest;
                    req.Method = "POST";
                    req.ContentLength = data.Length;
                    req.ContentType = "application/json";
                    var reqStream = req.GetRequestStream();
                    reqStream.Write(data, 0, data.Length);
                    var res = req.GetResponse() as HttpWebResponse;
                    StreamReader reader = new StreamReader(res.GetResponseStream());
                    string platojson = reader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Mesero meseromodif = js.Deserialize<Mesero>(platojson);


                    lblMensaje.Text = "El mesero ha sido registrado correctamente";
                    Limpiar();
                    CargarCodigo();

 
            }

            catch (Exception ex) {

                lblMensaje.Text = "Error: " + ex.Message;
            
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMesas();
        }
    }
}