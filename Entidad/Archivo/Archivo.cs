using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Archivo
    {
        /// <summary>
        /// Id con el que se identifica al archivo
        /// </summary>
        private int idArchivo;

        /// <summary>
        /// String que representa la ruta del archivo
        /// </summary>
        private string iRutaArchivo;

        /// <summary>
        /// Fecha en que se modificó el archivo
        /// </summary>
        private DateTime iFechaModificado;

        /// <summary>
        /// Tipo del archivo
        /// </summary>
        private TipoArchivo iTipoArchivo;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pCadenaBuscada">ruta del archivo</param>
        /// <param name="pFechaBuscado">fecha de modificación del archivo</param>
        public Archivo(string pRuta,DateTime pFecha, TipoArchivo pTipo)
        {
            this.iRutaArchivo = pRuta;
            this.iFechaModificado = pFecha;
            this.iTipoArchivo = pTipo;
        }


        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura de la id de la busqueda
        /// </summary>
        public int Id
        {
            get { return this.idArchivo; }
            set { this.idArchivo = value; }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de la busqueda
        /// </summary>
        public DateTime FechaBuscado
        {
            get { return this.iFechaModificado; }
            set { this.iFechaModificado = value;}
        }

        /// <summary>
        /// Propiedad de lectura del tipo del archivo
        /// </summary>
        public TipoArchivo Tipo
        {
            get { return this.iTipoArchivo; }
        }
        #endregion
    }
}
