using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Controlador
{
    class ControladorUsuario
    {
        private List<Usuario> iListaUsuarios; //esto va a ser el RepositorioUsuarios

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorUsuario()
        {
            this.iListaUsuarios = new List<Usuario>();
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pDireccion">Dirección URI del entretenimiento</param>
        public void NuevoUsuario(string pNombre, string pClave, string pMail)
        {
            this.iListaUsuarios.Add(new Usuario(pNombre, pClave, pMail));
        }


        /// <summary>
        /// Modifica el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        /// <param name="pNuevosDatos">Objeto de tipo Usuario con los datos nuevos</param>
        public void ModificarUsuario(int pIdUSR, Usuario pNuevosDatos)
        {
            Usuario usuarioModificado=this.BuscarUsuario(pIdUSR);
            this.iListaUsuarios.Remove(usuarioModificado);

            //Hacemos lo siguiente, ya que el Id del usuario original no se puede modificar:
            usuarioModificado.ClaveCuentaUsuario = pNuevosDatos.ClaveCuentaUsuario;
            usuarioModificado.CorreoElectronico = pNuevosDatos.CorreoElectronico;
            usuarioModificado.NombreCuentaUsuario = pNuevosDatos.NombreCuentaUsuario;
            this.iListaUsuarios.Add(usuarioModificado);
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        public void EliminarUsuario(int pIdUSR)
        {
            this.iListaUsuarios.Remove
                (this.BuscarUsuario(pIdUSR));
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        /// <returns>Devuelve el usuario encontrado</returns>
        public Usuario BuscarUsuario(int pIdUSR)
        {
            return this.iListaUsuarios.Find(x => x.IdUsuario == pIdUSR);
        }

        
    }
}
