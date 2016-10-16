using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoHabilitacionProfesional
{
    public class Entretenimiento
    {
        /// <summary>
        /// Codigo numerico que identifica al entretenimiento
        /// </summary>
        private int idEntretenimiento;

        /// <summary>
        /// Direccion web a la que pertenece el entretenimiento
        /// </summary>
        private Uri iDireccionEntretenimiento;

        /// <summary>
        /// Tipo de entretenimiento
        /// </summary>
        private TipoEntretenimiento iTipoEntretenimiento;

        /// <summary>
        /// Constructor
        /// </summary>
        public Entretenimiento(Uri pDireccion, TipoEntretenimiento pTipo)
        {
            this.iDireccionEntretenimiento = pDireccion;
            this.iTipoEntretenimiento = pTipo;
        }

        #region Properties
        public int id
        {
            get { return this.idEntretenimiento; }
            set { this.idEntretenimiento = value; }
        }

        public Uri Direccion
        {
            get { return this.iDireccionEntretenimiento; }
            set { this.iDireccionEntretenimiento = value; }
        }

        public TipoEntretenimiento Tipo
        {
            get { return this.iTipoEntretenimiento; }
        }
        #endregion

    }
}
