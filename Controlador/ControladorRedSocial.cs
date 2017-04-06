using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorRedSocial
    {
        /// <summary>
        /// Crea una nueva red social
        /// </summary>
        /// <param name="pRedSocial">Red social a crear</param>
        public void NuevaRedSocial(RedSocial pRedSocial)
        {
            this.ModeloFachada.CrearRedSocial(pRedSocial);
        }

        /// <summary>
        /// Elimina la red social indicada del usuario
        /// </summary>
        /// <param name="pIdRS">Id de la red social que se quiere eliminar</param>
        public void EliminarRedSocial(int pIdRS)
        {
            RedSocial red = this.ModeloFachada.BuscarRedSocial(pIdRS);
            this.ModeloFachada.EliminarRedSocial(red);
        }

        /// <summary>
        /// Busca la red social indicada
        /// </summary>
        /// <param name="pIdRS">Id de la red social</param>
        /// <returns>Devuelve la red social buscada</returns>
        public RedSocial BuscarRedSocial(int pIdRS)
        {
            return this.ModeloFachada.BuscarRedSocial(pIdRS);
        }

        /// <summary>
        /// Permite acceder a la cuenta de una red social 
        /// </summary>
        /// <param name="idRS">id de la red social, la cual incluye los datos necesarios para acceder a la cuenta</param>
        public void AccederRedSocial(int idRS)
        {
            //HACER
        }
    }
}
