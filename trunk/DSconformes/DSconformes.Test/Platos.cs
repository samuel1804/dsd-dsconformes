using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSconformes.Presentacion
{
    public class Platos
    {

        public int id_plato { get; set; }

        public int id_categoria { get; set; }
        public string nombre { get; set; }

        public Categorias categoria { get; set; }

        public decimal costo { get; set; }

        public string descripcion { get; set; }

        public string cod_plato { get; set; }

    }
}