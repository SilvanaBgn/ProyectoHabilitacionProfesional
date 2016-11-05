using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    class ControladorArchivo
    {
        private List<Archivo> iListaArchivos;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorArchivo()
        {
            this.iListaArchivos = new List<Archivo>();
        }

        public void NuevoArchivo (string pUnaRuta)
        {
            this.iListaArchivos.Add(new Archivo(pUnaRuta, DateTime.Today, ObtenerTipoArchivo()));
        }

        private TipoArchivo ObtenerTipoArchivo()
        {
            
            return new TipoArchivo();
        }

        public void EliminarArchivo (Archivo pUnArchivo)
        {
            //Falta eliminar del sistema!!!

            this.iListaArchivos.Remove(pUnArchivo);
        }

        public List<Archivo> BuscarArchivo (string pNombre, TipoArchivo unTipo)
        {
            //HACER
            return new List<Archivo>();
        }
    }
}
