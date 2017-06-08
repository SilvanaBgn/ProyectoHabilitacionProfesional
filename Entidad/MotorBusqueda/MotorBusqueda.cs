using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class MotorBusqueda
    {
        /// <summary>
        /// Codigo numerico que identifica al Motor de Búsqueda
        /// </summary>
        public int MotorBusquedaId { get; set; }

        /// <summary>
        /// Direccion web a la que pertenece el Motor de Búsqueda
        /// </summary>
        public Uri DireccionMotorBusqueda { get; set; }

        /// <summary>
        /// String que explica el Tipo de Motor de Búsqueda
        /// </summary>
        public string TipoMotorBusqueda { get; }


        /// <summary>
        /// Constructor
        /// </summary>
        public MotorBusqueda() { }

        /// <summary>
        /// Constructor
        /// </summary>
        public MotorBusqueda(Uri pDireccion, string pTipo)
        {
            this.DireccionMotorBusqueda = pDireccion;
            this.TipoMotorBusqueda = pTipo;
        }
    }
}
