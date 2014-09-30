using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DSConformes.REST.Dominio;
using DSConformes.REST.Persistencia;

namespace DSconformes.Persistencia
{
    public class MeseroDAO
    {
        public Mesero Crear(Mesero meseroACrear)
        {
            Mesero meseroCreado = null;
            string sql = "INSERT INTO t_mesero VALUES (@cod, @nom)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", meseroACrear.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", meseroACrear.Nombre));
                    com.ExecuteNonQuery();

                }
            }
            meseroCreado = Obtener(meseroACrear.Codigo);
            return meseroCreado;

        }
        public Mesero Obtener(string codigo)
        {
            Mesero meseroEncontrado = null;
            string sql = "SELECT * FROM t_mesero WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            meseroEncontrado = new Mesero()
                            {
                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"]
                            };
                        }
                    }
                }
            }
            return meseroEncontrado;
        }
        public Mesero Modificar(Mesero meseroAModificar)
        {
            return null;
        }
        public void Eliminar(Mesero meseroAEliminar)
        {
        }
        public List<Mesero> LisarTodos()
        {
            return null;
        }
    }
}