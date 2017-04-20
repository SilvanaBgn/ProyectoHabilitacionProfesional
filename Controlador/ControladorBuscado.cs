using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorBuscado
    {
        /// <summary>
        /// Crea una nuevo Buscado
        /// </summary>
        /// <param name="pBuscado">Buscado a crear</param>
        public void NuevoBuscado(Buscado pBuscado)
        {
            ModeloFachada.GetInstancia().CrearBuscado(pBuscado);
        }

        /// <summary>
        /// Elimina el buscado indicado del usuario
        /// </summary>
        /// <param name="pIdBuscado">Id del buscado que se quiere eliminar</param>
        public void EliminarBuscado(int pIdBuscado)
        {
            Buscado bus = ModeloFachada.GetInstancia().BuscarBuscado(pIdBuscado);
            ModeloFachada.GetInstancia().EliminarBuscado(bus);
        }

        /// <summary>
        /// Busca el Buscado indicado
        /// </summary>
        /// <param name="pIdRS">Id del Buscado a buscar</param>
        /// <returns>Devuelve el Buscado encontrado</returns>
        public Buscado BuscarBuscado(int pIdRS)
        {
            return ModeloFachada.GetInstancia().BuscarBuscado(pIdRS);
        }
    }
}
