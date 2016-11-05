using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using Entidad;

namespace Controlador
{
    public class ControladorEntretenimiento
    {
        private List<Entretenimiento> iListaEntretenimientos;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorEntretenimiento()
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

        /// <summary>
        /// Permite acceder a la página web del entretenimiento
        /// </summary>
        /// <param name="idEnt">identificador del entretenimiento que se quiere acceder</param>
        public void AccederEntretenimiento(int idEnt)
        {
            String baseUri = "http://www.google.com.ar";
            HttpWebRequest connection =
            (HttpWebRequest)HttpWebRequest.Create(baseUri);
        }
    }
}
