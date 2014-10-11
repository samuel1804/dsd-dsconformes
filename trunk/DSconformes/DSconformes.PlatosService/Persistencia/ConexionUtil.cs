using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSconformes.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {

            return @"Data Source=WIL-PC\SQLEXPRESS;Initial Catalog=Restaurante1;Integrated Security=SSPI;";

        }

    }
}