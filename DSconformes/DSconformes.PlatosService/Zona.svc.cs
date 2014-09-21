using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSconformes.Persistencia;
using DSconformes.PlatosService.Dominio;
namespace DSconformes.PlatosService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Zona" en el código, en svc y en el archivo de configuración a la vez.
    public class Zona : IZona
    {
      

        private ZonaDAO zonaDAO = null;
        private ZonaDAO ZonaDAO
        {
            get
            {
                if (zonaDAO == null)
                    zonaDAO = new ZonaDAO();
                return zonaDAO;
            }
        }

        public List<Zonas> ListarZonas()
        {
            return ZonaDAO.ListarTodos().ToList();
        }

    }
}
