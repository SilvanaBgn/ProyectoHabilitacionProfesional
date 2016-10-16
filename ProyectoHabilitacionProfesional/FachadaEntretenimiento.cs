using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    public class FachadaEntretenimiento
    {
        private List<Entretenimiento> iListaEntretenimientos;

        /// <summary>
        /// Constructor
        /// </summary>
        public FachadaEntretenimiento()
        {
            this.iListaEntretenimientos = new List<Entretenimiento>();
        }

        /// <summary>
        /// Crea un nuevo entretenimiento
        /// </summary>
        /// <param name="pDireccion">Dirección URI del entretenimiento</param>
        public void NuevoEntretenimiento(Uri pDireccion, TipoEntretenimiento pTipo)
        {
            this.iListaEntretenimientos.Add(new Entretenimiento(pDireccion, pTipo));
        }

        /// <summary>
        /// Elimina el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        public void EliminarEntretenimiento(int pIdEntretenimiento)
        {
            this.iListaEntretenimientos.Remove
                (this.BuscarEntretenimiento(pIdEntretenimiento));
        }

        /// <summary>
        /// Busca el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        /// <returns></returns>
        public Entretenimiento BuscarEntretenimiento(int pIdEntretenimiento)
        {
            return this.iListaEntretenimientos.Find(x => x.id == pIdEntretenimiento);
        }

    }
}
