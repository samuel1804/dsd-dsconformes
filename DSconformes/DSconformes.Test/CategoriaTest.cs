using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
namespace DSconformes.Presentacion
{
     [TestClass]
    public class CategoriaTest
    {
       
        [TestMethod]
        public void Listar()
        {
            HttpWebRequest req2 = WebRequest.Create("http://localhost:12455/Categoria.svc/Categorias") as HttpWebRequest;
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string platojson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Categorias> platoobtenido = js.Deserialize<List<Categorias>>(platojson);
            Assert.AreEqual(4, platoobtenido.Count());

        }
    }
}
