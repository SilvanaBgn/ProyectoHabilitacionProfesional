using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDAD
{
    public class Entretenimiento
    {
        /// <summary>
        /// Codigo numerico que identifica al entretenimiento
        /// </summary>
        public int EntretenimientoId { get; set; }

        /// <summary>
        /// Direccion web a la que pertenece el entretenimiento
        /// </summary>
        public string DireccionEntretenimiento { get; set; }

        /// <summary>
        /// Tipo de entretenimiento
        /// </summary>
        public TipoEntretenimiento TipoEntretenimiento { get; }

        /// <summary>
        /// ID del Usuario 
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        /// Objeto Usuario
        /// </summary>
        //public virtual Usuario Usuario { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Entretenimiento() { }

        /// <summary>
        /// Constructor
        /// </summary>
        public Entretenimiento(string pDireccion, TipoEntretenimiento pTipo)
        {
            this.DireccionEntretenimiento = pDireccion;
            this.TipoEntretenimiento = pTipo;
        }
    }
}
