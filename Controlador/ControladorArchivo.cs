using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace CONTROLADOR
{
    public class ControladorArchivo
    {
        /// <summary>
        /// Crea un nuevo archivo
        /// </summary>
        /// <param name="pUnArchivo">archivo a crear</param>
        public void NuevoArchivo(Archivo pUnArchivo)
        {
            this.ModeloFachada.CrearArchivo(pUnArchivo);
        }

        /// <summary>
        /// elimina el archivo indicado
        /// </summary>
        /// <param name="pIdArchivo">id del archivo que se quiere eliminar</param>
        public void EliminarArchivo(int pIdArchivo)
        {
            Archivo archivo = this.ModeloFachada.BuscarArchivo(pIdArchivo);
            this.ModeloFachada.EliminarArchivo(archivo);
        }

        /// <summary>
        /// Busca un archivo determinado
        /// </summary>
        /// <param name="pIdArchivo">id del archivo que se quiere buscar</param>
        /// <returns>Devuelve el archivo buscado</returns>
        public Archivo BuscarArchivo(int pIdArchivo)
        {
            return this.ModeloFachada.BuscarArchivo(pIdArchivo);
        }

        ///// <summary>
        ///// Busca un archivo cuyo nombre se asemeje a la cadena pasada
        ///// </summary>
        //public List<Archivo> BuscarArchivo(string cadena)
        //{
        //    //VERR  HACER
        //    //return this.ModeloFachada.BuscarArchivo(cadena);            
        //}
    }
}
