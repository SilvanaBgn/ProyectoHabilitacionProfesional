using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    public class FachadaRedSocial
    {
        private List<RedSocial> iListaRedesSociales;

        /// <summary>
        /// Constructor
        /// </summary>
        public FachadaRedSocial()
        {
            this.iListaRedesSociales = new List<RedSocial>();
        }

        /// <summary>
        /// Crea una nueva red social
        /// </summary>
        /// <param name="pDir">Dirección Uri de la red social</param>
        /// <param name="pNomCuenta"> Nombre de la cuenta de usuario de la red social</param>
        /// <param name="pClaveCuenta">Clave de la cuenta de usuario de la red social</param>
        /// <param name="pNomRS">Nombre de la red social que se quiere crear</param>
        public void NuevaRedSocial(Uri pDir, string pNomCuenta, string pClaveCuenta, string pNomRS)
        {
            this.iListaRedesSociales.Add(new RedSocial(pDir,pNomCuenta, pClaveCuenta, pNomRS));
        }

        /// <summary>
        /// Elimina el usuario de la red social indicada
        /// </summary>
        /// <param name="pIdRS">Id de la red social que se quiere eliminar</param>
        public void EliminarUsuario(int pIdRS)
        {
            this.iListaRedesSociales.Remove
                (this.BuscarRedSocial(pIdRS));
        }

        /// <summary>
        /// Busca la red social indicada
        /// </summary>
        /// <param name="pIdRS">Id de la red social</param>
        /// <returns>Devuelve la red social buscada</returns>
        public RedSocial BuscarRedSocial(int pIdRS)
        {
            return this.iListaRedesSociales.Find(x => x.IdRedSocial == pIdRS);
        }

    }
}
