using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using DSconformes.Dominio;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
namespace DSconformes.Presentacion
{
    /// <summary>
    /// Descripción resumida de Plato
    /// </summary>
    [TestClass]
    public class PlatosTest
    {
        [TestMethod]
        public void Insertar()
        {
            //Prueba de modificar
            string postdata = "{\"id_plato\":21,\"nombre\":\"Ceviche\",\"id_categoria\":2,\"costo\":20,\"descripcion\":\"Ceviche\"}";
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
            Assert.AreEqual(platomodif.descripcion, "Ceviche");

            
        }

        [TestMethod]
        public void ObtenerUltimo() {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Platos") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Platos platoobtenido = js.Deserialize<Platos>(platojson);
            Assert.AreEqual(22, platoobtenido.id_plato);

        }

        [TestMethod]
        public void Obtener()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Plato/2") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Platos platoobtenido = js.Deserialize<Platos>(platojson);
            Assert.AreEqual(2, platoobtenido.id_plato);

        }


        [TestMethod]
        public void Listar()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Plato.svc/Platos/3") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Platos> platoobtenido = js.Deserialize<List<Platos>>(platojson);
            Assert.AreEqual(1, platoobtenido.Count());

        }

    }
}
