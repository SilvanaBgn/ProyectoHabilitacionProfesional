using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;

namespace CONTROLADOR
{
    public static class ControladorCategoria
    {
        /// <summary>
        /// Crea un nuevo categoria
        /// </summary>
        /// <param name="pCategoria">Categoria a crear</param>
        public static void NuevoCategoria(Categoria pCategoria)
        {
            ModeloFachada.GetInstancia().CrearCategoria(pCategoria);
        }

        /// <summary>
        /// Elimina el categoria indicado
        /// </summary>
        /// <param name="pIdCategoria">Id del categoria</param>
        public static void EliminarCategoria(int pIdCategoria)
        {
            Categoria ent = ModeloFachada.GetInstancia().BuscarCategoria(pIdCategoria);
            ModeloFachada.GetInstancia().EliminarCategoria(ent);
        }

        /// <summary>
        /// Busca la categoria indicado
        /// </summary>
        /// <param name="pIdCategoria">Id de categoria</param>
        /// <returns></returns>
        public static Categoria BuscarCategoria(int pIdCategoria)
        {
            return ModeloFachada.GetInstancia().BuscarCategoria(pIdCategoria);
        }

        /// <summary>
        /// Busca la categoria indicada
        /// </summary>
        /// <param name="pTipoCategoria">Tipo de categoria</param>
        /// <returns></returns>
        public static Categoria BuscarCategoria(TipoCategoria pTipoCategoria)
        {
            return ModeloFachada.GetInstancia().BuscarCategoria(pTipoCategoria);
        }

        /// <summary>
        /// Obtiene todas las categorias
        /// </summary>
        /// <param name="pHuerfanas">Sí true, devuelve todas las categorías sin padre. Sino devuelve todas. Per defecto, false</param>
        public static ICollection<Categoria> ObtenerCategorias(bool pHuerfanas = false)
        {
            return ModeloFachada.GetInstancia().ObtenerCategorias(pHuerfanas);
        }

        /// <summary>
        /// Obtiene todas las categorias hijas de una categoría específica
        /// </summary>
        /// <param name="pIdCategoriaPadre">Id de la categoria padre</param>
        public static ICollection<Categoria> ObtenerCategoriasHijas(int pIdCategoriaPadre)
        {
            return ModeloFachada.GetInstancia().ObtenerCategoriasHijas(pIdCategoriaPadre);
        }

        /// <summary>
        /// Obtiene todas las categorias hijas de una categoría específica
        /// </summary>
        /// <param name="pIdCategoriaPadre">Id de la categoria padre</param>
        public static bool EsPadre(int pIdCategoriaPadre)
        {
            return ModeloFachada.GetInstancia().ObtenerCategoriasHijas(pIdCategoriaPadre).Count>0;
        }
    }
}
