using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.PlatosService.Dominio;
using DSconformes.Persistencia;

namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Plato" en el código, en svc y en el archivo de configuración a la vez.
    public class Plato : IPlato
    {

        private PlatoDAO dao = new PlatoDAO();
        public Dominio.Platos Insertar(Dominio.Platos pbePlato)
        {
            return dao.Insertar(pbePlato);
        }
        public Platos ObtenerUltimo()
        {
            return dao.ObtenerUltimo();
        }





        public List<Platos> Listar(string cod_categoria)
        {
            return dao.Listar(cod_categoria);
        }


        public Platos Obtener(string cod_plato)
        {
            return dao.Obtener(cod_plato);
        }
    }
}
