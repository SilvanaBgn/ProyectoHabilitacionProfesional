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
        private int idMotorBusqueda;

        /// <summary>
        /// Direccion web a la que pertenece el Motor de Búsqueda
        /// </summary>
        private Uri iDireccionMotorBusqueda;

        /// <summary>
        /// String que explica el Tipo de Motor de Búsqueda
        /// </summary>
        private string iTipoMotorBusqueda;


        /// <summary>
        /// Constructor
        /// </summary>
        public MotorBusqueda(Uri pDireccion, string pTipo)
        {
            this.iDireccionMotorBusqueda = pDireccion;
            this.iTipoMotorBusqueda = pTipo;
        }



        #region Properties
        public int id
        {
            get { return this.idMotorBusqueda; }
            set { this.idMotorBusqueda = value; }
        }

        public Uri Direccion
        {
            get { return this.iDireccionMotorBusqueda; }
            set { this.iDireccionMotorBusqueda = value; }
        }

        public string Tipo
        {
            get { return this.iTipoMotorBusqueda; }
        }
        #endregion
    }
}
