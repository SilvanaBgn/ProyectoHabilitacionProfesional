using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class RedSocial
    {
        /// <summary>
        /// Identificación única del la red social
        /// </summary>
        public int RedSocialId { get; set; }

        /// <summary>
        /// Dirección Uri de la red social
        /// </summary>
        public string DireccionRedSocial { get; set; }

        /// <summary>
        /// Nombre de la cuenta de usuario de la red social
        /// </summary>
        public string NombreCuenta { get; set; }

        /// <summary>
        /// Clave de la cuenta de usuario de la red social
        /// </summary>
        public string ClaveCuenta { get; set; }

        /// <summary>
        /// Nombre de la red social que se quiere guardar
        /// </summary>
        public string NombreRedSocial { get; set; }

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
        public RedSocial() { }

        /// <summary>
        /// Constructor
        /// </summary>
        public RedSocial(string pDir, string pNomCuenta, string pClaveCuenta, string pNomRS)
        {
            this.DireccionRedSocial = pDir;
            this.NombreCuenta = pNomCuenta;
            this.ClaveCuenta = pClaveCuenta;
            this.NombreRedSocial = pNomRS;
        }
    }
}
