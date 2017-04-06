using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace CONTROLADOR
{
    public class ControladorEntretenimiento
    {
        /// <summary>
        /// Crea un nuevo entretenimiento
        /// </summary>
        /// <param name="pEntretenimiento">Entretenimiento a crear</param>
        public void NuevoEntretenimiento(Entretenimiento pEntretenimiento)
        {
            this.ModeloFachada.CrearEntretenimiento(pEntretenimiento);
        }

        /// <summary>
        /// Elimina el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        public void EliminarEntretenimiento(int pIdEntretenimiento)
        {
            Entretenimiento ent = this.ModeloFachada.BuscarEntretenimiento(pIdEntretenimiento);
            this.ModeloFachada.EliminarEntretenimiento(ent);
        }

        /// <summary>
        /// Busca el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        /// <returns></returns>
        public Entretenimiento BuscarEntretenimiento(int pIdEntretenimiento)
        {
            return this.ModeloFachada.BuscarEntretenimiento(pIdEntretenimiento);
        }

        /// <summary>
        /// Permite acceder a la página web del entretenimiento
        /// </summary>
        /// <param name="idEnt">identificador del entretenimiento que se quiere acceder</param>
        public void AccederEntretenimiento(int idEnt)
        {
            //HACER
            //String baseUri = "http://www.google.com.ar";
            //HttpWebRequest connection =
            //(HttpWebRequest)HttpWebRequest.Create(baseUri);
        }
    }
}
