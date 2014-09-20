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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Mesa" en el código, en svc y en el archivo de configuración a la vez.
    public class Mesa : IMesa
    {

        MesaDAO md = new MesaDAO();
        public List<Mesas> ListarMesasporZona(int id_zona)
        {
           return md.ListarTodos().Where(t=>t.zona.id_zona==id_zona).ToList();

        }
    }
}
