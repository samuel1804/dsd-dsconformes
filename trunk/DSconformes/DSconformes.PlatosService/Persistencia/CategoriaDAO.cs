using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
using System.Data.SqlClient;
namespace DSconformes.Persistencia
{
    public class CategoriaDAO 
    {
        public List<Categorias> Listar()
        {

            string sql = "Select * from t_categoria";
            Categorias categoria = new Categorias();
            List<Categorias> Lista = new List<Categorias>();

            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {

                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categoria = new Categorias()
                            {
                                id_categoria = (int)dr["id_categoria"],
                                nombre=(string)dr["nombre"],
                            };
                            Lista.Add(categoria);
                        }


                    }
                }
            }

            return Lista;
        }
    }
}