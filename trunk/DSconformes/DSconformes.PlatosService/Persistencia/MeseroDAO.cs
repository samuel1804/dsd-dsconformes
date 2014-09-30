using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
using System.Data.SqlClient;
using DSconformes.PlatosService;

namespace DSconformes.Persistencia
{
    public class MeseroDAO
    {
        public Meseros Crear(Meseros meseroACrear)
        {
            Meseros meseroCreado = null;
            string sql = "INSERT INTO t_mesero VALUES (@id, @dni, @nom, @mes, @sex, @eda, @hen, @hsa)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", meseroACrear.id_mesero));
                    com.Parameters.Add(new SqlParameter("@dni", meseroACrear.dni));
                    com.Parameters.Add(new SqlParameter("@nom", meseroACrear.nombre));
                    com.Parameters.Add(new SqlParameter("@mes", meseroACrear.mesa));
                    com.Parameters.Add(new SqlParameter("@sex", meseroACrear.sexo));
                    com.Parameters.Add(new SqlParameter("@eda", meseroACrear.edad));
                    com.Parameters.Add(new SqlParameter("@hen", meseroACrear.h_entrada));
                    com.Parameters.Add(new SqlParameter("@hsa", meseroACrear.h_salida));
                    com.ExecuteNonQuery();

                }
            }
            meseroCreado = Obtener(meseroACrear.id_mesero);
            return meseroCreado;

        }

        public Meseros Obtener(int id_mesero)
        {
            Meseros meseroEncontrado = null;
            string sql = "SELECT * FROM t_mesero WHERE id_mesero=@id";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id_mesero));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            meseroEncontrado = new Meseros()
                            {
                                id_mesero = (int)resultado["id_msero"],
                                dni = (int)resultado["dni"],
                                nombre = (string)resultado["nombre"],
                                mesa = (Mesas)resultado["mesa"],
                                sexo = (char)resultado["sexo"],
                                edad = (int)resultado["edad"],
                                h_entrada = (TimeSpan)resultado["h_entrada"],
                                h_salida = (TimeSpan)resultado["h_salida"]
                            };
                        }
                    }
                }
            }
            return meseroEncontrado;
        }

        public Meseros Modificar(Meseros meseroAModificar)
        {

            string sql = "UPDATE t_mesero set dni=@dni, nombre=@nom, edad=@eda, h_entrada=@hen, h_salida=@hsa where id_mesero=@id";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", meseroAModificar.dni));
                    com.Parameters.Add(new SqlParameter("@nom", meseroAModificar.nombre));
                    com.Parameters.Add(new SqlParameter("@eda", meseroAModificar.edad));
                    com.Parameters.Add(new SqlParameter("@hen", meseroAModificar.h_entrada));
                    com.Parameters.Add(new SqlParameter("@hsa", meseroAModificar.h_salida));
                    com.ExecuteNonQuery();
                }
            }
            return meseroAModificar;
        }

        public bool Eliminar(Meseros meseroAModificar)
        {
            string sql = "DELETE t_mesero WHERE id_mesero=@id";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", meseroAModificar.id_mesero));
                    com.ExecuteNonQuery();
                }
            }

            return true;
        }

        public List<Meseros> ListarTodos()
        {
            string sql = "SELECT * from t_mesero";
            Meseros mesero;
            List<Meseros> ListaMeseros = new List<Meseros>();
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            mesero = new Meseros()
                            {
                                id_mesero = (int)dr["id_mesero"],
                                dni = (int)dr["dni"],
                                nombre = (string)dr["nombre"],
                                mesa = (Mesas)dr["mesa"],
                                sexo = (char)dr["sexo"],
                                edad = (int)dr["edad"],
                                h_entrada = (TimeSpan)dr["h_entrada"],
                                h_salida = (TimeSpan)dr["h_salida"],
                            };
                            ListaMeseros.Add(mesero);
                        }
                    }
                }
            }

            return ListaMeseros;
        }
    }
}