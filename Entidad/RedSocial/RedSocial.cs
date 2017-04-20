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
        private int idRedSocial;
        
        /// <summary>
        /// Dirección Uri de la red social
        /// </summary>
        private Uri iDireccionRedSocial;

        /// <summary>
        /// Nombre de la cuenta de usuario de la red social
        /// </summary>
        private string iNombreCuenta;

        /// <summary>
        /// Clave de la cuenta de usuario de la red social
        /// </summary>
        private string iClaveCuenta;

        /// <summary>
        /// Nombre de la red social que se quiere guardar
        /// </summary>
        private string iNombreRedSocial;

        /// <summary>
        /// ID del Usuario 
        /// </summary>
        public int UsuarioId { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public RedSocial(Uri pDir, string pNomCuenta, string pClaveCuenta, string pNomRS)
        {
            this.iDireccionRedSocial = pDir;
            this.iNombreCuenta = pNomCuenta;
            this.iClaveCuenta = pClaveCuenta;
            this.iNombreRedSocial = pNomRS;
        }

        #region Properties
        public string NombreCuenta
        {
            get { return this.iNombreCuenta; }
            set { this.iNombreCuenta = value; }
        }

        public string ClaveCuenta
        {
            get { return this.iClaveCuenta; }
            set { this.iClaveCuenta = value; }
        }

        public string NombreRedSocial
        {
            get { return this.iNombreRedSocial; }
            set { this.iNombreRedSocial = value; }
        }

        public Uri DireccionRedSocial
        {
            get { return this.iDireccionRedSocial; }
            set { this.iDireccionRedSocial = value; }
        }

        public int IdRedSocial
        {
            get { return this.idRedSocial; }
            set { this.idRedSocial = value; }
        }

        #endregion
    }
}
