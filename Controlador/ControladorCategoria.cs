using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace CONTROLADOR
{
    class ControladorCategoria
    {
        /// <summary>
        /// Crea una nueva categoria
        /// </summary>
        /// <param name="pCategoria">Categoria a crear</param>
        public void NuevaCategoria(Categoria pCategoria)
        {
            this.ModeloFachada.CrearCategoria(pCategoria);
        }

        /// <summary>
        /// Elimina la categoria indicada del usuario
        /// </summary>
        /// <param name="pIdBuscado">Id de categoria que se quiere eliminar</param>
        public void EliminarCategoria(int pId)
        {
            Categoria cat = this.ModeloFachada.BuscarCategoria(pId);
            this.ModeloFachada.EliminarCategoria(cat);
        }

        /// <summary>
        /// Busca la categoria indicada
        /// </summary>
        /// <param name="pIdRS">Id de la categoria a buscar</param>
        /// <returns>Devuelve la categoria encontrada</returns>
        public Categoria BuscarCategoria(int pIdRS)
        {
            return this.ModeloFachada.BuscarCategoria(pIdRS);
        }
    }
}
