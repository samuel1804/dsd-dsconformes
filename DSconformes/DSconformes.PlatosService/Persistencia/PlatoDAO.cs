using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
using System.Data.SqlClient;
namespace DSconformes.Persistencia
{
    public class PlatoDAO
    {
        public Platos Insertar(Platos pbePlato)
        {

            string sql = "INSERT INTO t_plato(id_plato,nombre,categoria,costo,descripcion) VALUES(@id_plato,@nombre,@id_categoria,@costo,@descripcion)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id_plato", pbePlato.id_plato));
                    com.Parameters.Add(new SqlParameter("@nombre", pbePlato.nombre));
                    com.Parameters.Add(new SqlParameter("@id_categoria", pbePlato.id_categoria));
                    com.Parameters.Add(new SqlParameter("@costo", pbePlato.costo));
                    com.Parameters.Add(new SqlParameter("@descripcion", pbePlato.descripcion));

                    com.ExecuteNonQuery();
                }
            }

            return pbePlato;
        }


        public Platos ObtenerUltimo()
        {

            string sql = "Select * from t_plato order by id_plato desc";
            Platos plato = new Platos(); 
           
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                   
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            plato = new Platos()
                            {
                                id_plato = (int)dr["id_plato"],
                            };
                          
                        }


                    }
                }
            }

            return plato;
        }

        public List<Platos> Listar(string cod_categoria)
        {

            string sql = "Select * from t_plato where categoria=@cod_categoria";
            Platos categoria = new Platos();
            List<Platos> Lista = new List<Platos>();

            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod_categoria", cod_categoria));
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categoria = new Platos()
                            {
                                id_plato = (int)dr["id_plato"],
                                nombre = (string)dr["nombre"],
                                id_categoria = (int)dr["categoria"],
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