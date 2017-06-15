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
        public int ArchivoId { get; set; }

        /// <summary>
        /// String que representa la ruta del archivo
        /// </summary>
        public string RutaArchivo { get; set; }

        /// <summary>
        /// Fecha en que se modificó el archivo
        /// </summary>
        public DateTime FechaModificado { get; set; }

        /// <summary>
        /// Tipo del archivo
        /// </summary>
        public TipoArchivo TipoArchivo { get; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Archivo(){ }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pCadenaBuscada">ruta del archivo</param>
        /// <param name="pFechaBuscado">fecha de modificación del archivo</param>
        public Archivo(string pRuta,DateTime pFecha, TipoArchivo pTipo)
        {
            this.RutaArchivo = pRuta;
            this.FechaModificado = pFecha;
            this.TipoArchivo = pTipo;
        }
    }
}
