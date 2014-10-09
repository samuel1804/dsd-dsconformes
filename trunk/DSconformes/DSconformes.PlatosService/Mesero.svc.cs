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
    public class Mesero : IMesero
    {
        private MeseroDAO dao = new MeseroDAO();

        public Meseros CrearMesero(Meseros meseroACrear)
        {
            return dao.Crear(meseroACrear);
        }

        public Meseros ObtenerMesero(string id_mesero)
        {
            return dao.Obtener(id_mesero);
        }

        public Meseros ModificarMesero(Meseros meseroAModificar)
        {
            return dao.Modificar(meseroAModificar);
        }

        public bool EliminarMesero(Meseros meseroAModificar)
        {
            return dao.Eliminar(meseroAModificar);
        }

        public List<Meseros> ListarMeseros()
        {
            return dao.ListarTodos();
        }
    }
}
