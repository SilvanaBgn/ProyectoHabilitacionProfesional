using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    public class Buscado
    {
        /// <summary>
        /// Id con la que se identifica la busqueda
        /// </summary>
        private int idBuscado;

        /// <summary>
        /// String que representa la cadena que se busco
        /// </summary>
        private string iCadenaBuscada;

        /// <summary>
        /// Fecha que se hizo la busqueda
        /// </summary>
        private DateTime iFechaBuscado;

        /// <summary>
        /// Tipo del elemento buscado
        /// </summary>
        private TipoBuscado iTipoBuscado;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pCadenaBuscada">cadena que se ha buscado</param>
        /// <param name="pFechaBuscado">fecha de la búsqueda</param>
        public Buscado(string pCadenaBuscada,DateTime pFechaBuscado,TipoBuscado pTipo)
        {
            this.iCadenaBuscada = pCadenaBuscada;
            this.iFechaBuscado = pFechaBuscado;
            this.iTipoBuscado = pTipo;
        }

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura de la id de la busqueda
        /// </summary>
        public int Id
        {
            get { return this.idBuscado; }
            set { this.idBuscado = value; }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de la busqueda
        /// </summary>
        public DateTime FechaBuscado
        {
            get { return this.iFechaBuscado; }
            set { this.iFechaBuscado = value;}
        }

        /// <summary>
        /// Propiedad de lectura del tipo del elemento buscado
        /// </summary>
        public TipoBuscado Tipo
        {
            get { return this.iTipoBuscado; }
        }

        #endregion
    }
}
