﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Categoria" en el código, en svc y en el archivo de configuración a la vez.
    public class Categoria : ICategoria
    {
        private CategoriaDAO dao = new CategoriaDAO();
        public List<Categorias> Listar()
        {
            return dao.Listar();
        }
        public Dominio.Categorias Insertar(Dominio.Categorias pbeCat)
        {
            return dao.Insertar(pbeCat);
        }

        public Categorias ObtenerUltimo()
        {
            return dao.ObtenerUltimo();
        }

    }
}
