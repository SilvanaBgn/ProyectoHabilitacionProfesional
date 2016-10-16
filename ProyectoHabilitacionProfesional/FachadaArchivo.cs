using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    class FachadaArchivo
    {
        private List<Archivo> iListaArchivos;

        /// <summary>
        /// Constructor
        /// </summary>
        public FachadaArchivo()
        {
            this.iListaArchivos = new List<Archivo>();
        }

        public void NuevoArchivo (string pUnaRuta, TipoArchivo pTipo)
        {
            this.iListaArchivos.Add(new Archivo(pUnaRuta, DateTime.Today, pTipo));
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
