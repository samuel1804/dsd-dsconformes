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
        public Categorias Insertar(Categorias pbeCat)
        {
            string sql = "INSERT INTO t_categoria(id_categoria,nombre) VALUES(@id_categoria,@nombre)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id_categoria", pbeCat.id_categoria));
                    com.Parameters.Add(new SqlParameter("@nombre", pbeCat.nombre));
                    com.ExecuteNonQuery();
                }
            }
            return pbeCat;
        }
        public Categorias ObtenerUltimo()
        {
            string sql = "Select * from t_categoria order by id_categoria desc";
            Categorias categoria = new Categorias();

            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            categoria = new Categorias()
                            {
                                id_categoria = (int)dr["id_categoria"],
                            };
                        }
                    }
                }
            }
            return categoria;
        }

    }
}