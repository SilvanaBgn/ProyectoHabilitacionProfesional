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
        public int UsuarioId { get; set; }

        /// <summary>
        /// Nombre de la cuenta del usuario
        /// </summary>
        public string NombreCuentaUsuario { get; set; }

        /// <summary>
        /// Clave de la cuenta del usuario
        /// </summary>
        public string ClaveCuentaUsuario { get; set; }

        /// <summary>
        /// Correo electrónico del usuario
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Lista de entretenimientos pertenecientes al Usuario
        /// </summary>
        public virtual List<Entretenimiento> ListEntretenimientos { get; set; }

        /// <summary>
        /// Lista de Redes sociales pertenecientes al Usuario
        /// </summary>
        public virtual List<RedSocial> ListRedesSociales { get; set; }

        ///// <summary>
        ///// Lista de Buscados pertenecientes al Usuario
        ///// </summary>
        //public virtual ICollection<Buscado> ListBuscados { get; set; }



        /// <summary>
        /// Constructor
        /// </summary>
        public Usuario() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta del usuario</param>
        /// <param name="pClave">Clave de la cuenta del usuario</param>
        /// <param name="pMail">Correo electrónico del usuario</param>
        public Usuario(string pNombre, string pClave, string pMail)
        {
            this.NombreCuentaUsuario = pNombre;
            this.ClaveCuentaUsuario = pClave;

            //Usar método privado Email_bien_escrito() para validar la exp reg
            //si no pasa la validación, LANZAR EXCEPCIÓN
            this.CorreoElectronico = pMail;
            //this.ListEntretenimientos=new List<Entretenimiento>()
            this.ListRedesSociales = new List<RedSocial>();
        }

        #region Métodos públicos
        
        #endregion

        #region Métodos privados
        /// <summary>
        /// Método privado para validar si el correo electrónico es válido estructuralmente.
        /// </summary>
        /// <returns>Devuelve true si es el e-mail indicado está bien escrito, sino false</returns>
        public Boolean EmailBienEscrito(String pEmail)
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
    }
}
