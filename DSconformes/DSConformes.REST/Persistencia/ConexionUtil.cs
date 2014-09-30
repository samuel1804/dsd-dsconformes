using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSConformes.REST.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {
                return "Data Source=(local);Initial Catalog=DSD_Restaurante;Integrated Security=SSPI;";
            }

        }
    }
}
