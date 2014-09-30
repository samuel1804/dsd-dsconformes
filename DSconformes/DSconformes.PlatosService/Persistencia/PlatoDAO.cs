﻿using System;
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

            string sql = "INSERT INTO t_plato(id_plato,nombre,categoria,costo,descripcion) VALUES(@id_plato,@nombre,@categoria,@costo,@descripcion)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id_plato", pbePlato.id_plato));
                    com.Parameters.Add(new SqlParameter("@nombre", pbePlato.nombre));
                    com.Parameters.Add(new SqlParameter("@categoria", pbePlato.categoria));
                    com.Parameters.Add(new SqlParameter("@costo", pbePlato.costo));
                    com.Parameters.Add(new SqlParameter("@descripcion", pbePlato.descripcion));

                    com.ExecuteNonQuery();
                }
            }

            return pbePlato;
        }
    }
}