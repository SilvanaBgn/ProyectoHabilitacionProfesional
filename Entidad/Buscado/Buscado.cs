using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Buscado
    {
        /// <summary>
        /// Id con la que se identifica la busqueda
        /// </summary>
        public int BuscadoId { get; set; }

        /// <summary>
        /// String que representa la cadena que se busco
        /// </summary>
        public string CadenaBuscada { get; set; }

        /// <summary>
        /// Fecha que se hizo la busqueda
        /// </summary>
        public DateTime FechaBuscado { get; set; }

        /// <summary>
        /// Tipo del elemento buscado
        /// </summary>
        public TipoBuscado TipoBuscado { get; }

        /// <summary>
        /// ID del Usuario 
        /// </summary>
        public int UsuarioId { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Buscado() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pCadenaBuscada">cadena que se ha buscado</param>
        /// <param name="pFechaBuscado">fecha de la búsqueda</param>
        public Buscado(string pCadenaBuscada,DateTime pFechaBuscado,TipoBuscado pTipo)
        {
            this.CadenaBuscada = pCadenaBuscada;
            this.FechaBuscado = pFechaBuscado;
            this.TipoBuscado = pTipo;
        }
    }
}
