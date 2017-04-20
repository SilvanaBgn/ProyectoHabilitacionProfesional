using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        /// <summary>
        /// ID del usuario
        /// </summary>
        private int idUsuario;

        /// <summary>
        /// Nombre de la cuenta del usuario
        /// </summary>
        private string iNombreUsuario;

        /// <summary>
        /// Clave de la cuenta del usuario
        /// </summary>
        private string iClaveUsuario;

        /// <summary>
        /// Correo electrónico del usuario
        /// </summary>
        private string iCorreoElectronico;

        /// <summary>
        /// Lista de entretenimientos pertenecientes al Usuario
        /// </summary>
        public virtual ICollection<Entretenimiento> iListEntretenimientos { get; set; }

        /// <summary>
        /// Lista de Redes sociales pertenecientes al Usuario
        /// </summary>
        public virtual ICollection<RedSocial> iListRedesSociales { get; set; }

        /// <summary>
        /// Lista de Buscados pertenecientes al Usuario
        /// </summary>
        public virtual ICollection<Buscado> iListBuscados { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta del usuario</param>
        /// <param name="pClave">Clave de la cuenta del usuario</param>
        /// <param name="pMail">Correo electrónico del usuario</param>
        public Usuario(string pNombre, string pClave, string pMail)
        {
            this.iNombreUsuario = pNombre;
            this.iClaveUsuario = pClave;

            //Usar método privado Email_bien_escrito() para validar la exp reg
            //si no pasa la validación, LANZAR EXCEPCIÓN
            this.iCorreoElectronico = pMail;
        }

        #region Métodos públicos
        
        #endregion

        #region Métodos privados
        /// <summary>
        /// Método privado para validar si el correo electrónico es válido estructuralmente.
        /// </summary>
        /// <returns>Devuelve true si es el e-mail indicado está bien escrito, sino false</returns>
        private Boolean EmailBienEscrito(String pEmail)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            bool resultado = false;
            if (Regex.IsMatch(pEmail, expresion))
            {
                if (Regex.Replace(pEmail, expresion, String.Empty).Length == 0)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        #endregion

        #region Properties
        public string NombreCuentaUsuario
        {
            get { return this.iNombreUsuario; }
            set { this.iNombreUsuario = value; }
        }

        public string ClaveCuentaUsuario
        {
            get { return this.iClaveUsuario; }
            set { this.iClaveUsuario = value; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }

        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.IdUsuario = value; }
        }
        #endregion
    }
}
