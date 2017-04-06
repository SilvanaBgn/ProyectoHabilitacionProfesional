using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorUsuario
    {
        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pUsuario">Usuario que se desea crear</param>
        public void NuevoUsuario(Usuario pUsuario)
        {
            ModeloFachada.GetInstancia().CrearUsuario(pUsuario);
        }

        /// <summary>
        /// Modifica el usuario indicado
        /// </summary>
        /// <param name="pNuevosDatos">Usuario con los datos nuevos</param>
        public void ModificarUsuario(Usuario pNuevosDatos)
        {
            ModeloFachada.GetInstancia().ModificarUsuario(pNuevosDatos);
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario a eliminar</param>
        public void EliminarUsuario(int pIdUSR)
        {
            Usuario usuario = ModeloFachada.GetInstancia().BuscarUsuario(pIdUSR);
            ModeloFachada.GetInstancia().EliminarUsuario(usuario);
        }

        /// <summary>
        /// Busca el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        /// <returns>Devuelve el usuario encontrado</returns>
        public Usuario BuscarUsuario(int pIdUSR)
        {
            return ModeloFachada.GetInstancia().BuscarUsuario(pIdUSR);
        }
    }
}
