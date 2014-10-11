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

            return @"Data Source=SAMUEL-PC\SQL2008_2;Initial Catalog=Restaurante;Integrated Security=SSPI;";

        }

    }
}