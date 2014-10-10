using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
namespace DSconformes.Presentacion
{
    /// <summary>
    /// Descripción resumida de MeserosTest
    /// </summary>
    [TestClass]
    public class MeserosTest
    {
        

        [TestMethod]
        public void MeseroObtenerTest()
        {


            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Mesero.svc/Meseros") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string meserojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Meseros meseroobtenido = js.Deserialize<Meseros>(meserojson);
            Assert.AreEqual(meseroobtenido.id_mesero, 4);
            //id_mesero.Text = meseroobtenido.id_mesero.ToString();
        }
    }
}
