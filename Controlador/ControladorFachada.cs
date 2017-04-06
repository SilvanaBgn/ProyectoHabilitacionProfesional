
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using ENTIDAD;

namespace CONTROLADOR
{
    public class ControladorFachada
    {
        IModeloFachada ModeloFachada;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorFachada()
        {
            this.ModeloFachada=new ModeloFachada();
        }


        #region Red Social
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
        #endregion

        #region Entretenimiento
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
            Entretenimiento ent= this.ModeloFachada.BuscarEntretenimiento(pIdEntretenimiento);
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
        #endregion

        #region Archivo
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
            Archivo archivo=this.ModeloFachada.BuscarArchivo(pIdArchivo);
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
        #endregion

        #region Usuario
        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pUsuario">Usuario que se desea crear</param>
        public void NuevoUsuario(Usuario pUsuario)
        {
            this.ModeloFachada.CrearUsuario(pUsuario);
        }
        
        /// <summary>
        /// Modifica el usuario indicado
        /// </summary>
        /// <param name="pNuevosDatos">Usuario con los datos nuevos</param>
        public void ModificarUsuario(Usuario pNuevosDatos)
        {
            this.ModeloFachada.ModificarUsuario(pNuevosDatos);
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario a eliminar</param>
        public void EliminarUsuario(int pIdUSR)
        {
            Usuario usuario=this.ModeloFachada.BuscarUsuario(pIdUSR);
            this.ModeloFachada.EliminarUsuario(usuario);
        }

        /// <summary>
        /// Busca el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        /// <returns>Devuelve el usuario encontrado</returns>
        public Usuario BuscarUsuario(int pIdUSR)
        {
            return this.ModeloFachada.BuscarUsuario(pIdUSR);
        }
        #endregion

        #region Buscado
        /// <summary>
        /// Crea una nuevo Buscado
        /// </summary>
        /// <param name="pBuscado">Buscado a crear</param>
        public void NuevoBuscado(Buscado pBuscado)
        {
            this.ModeloFachada.CrearBuscado(pBuscado);
        }

        /// <summary>
        /// Elimina el buscado indicado del usuario
        /// </summary>
        /// <param name="pIdBuscado">Id del buscado que se quiere eliminar</param>
        public void EliminarBuscado(int pIdBuscado)
        {
            Buscado bus=this.ModeloFachada.BuscarBuscado(pIdBuscado);
            this.ModeloFachada.EliminarBuscado(bus);
        }

        /// <summary>
        /// Busca el Buscado indicado
        /// </summary>
        /// <param name="pIdRS">Id del Buscado a buscar</param>
        /// <returns>Devuelve el Buscado encontrado</returns>
        public Buscado BuscarBuscado(int pIdRS)
        {
            return this.ModeloFachada.BuscarBuscado(pIdRS);
        }
        #endregion

        #region Categoria
        /// <summary>
        /// Crea una nueva categoria
        /// </summary>
        /// <param name="pCategoria">Categoria a crear</param>
        public void NuevaCategoria(Categoria pCategoria)
        {
            this.ModeloFachada.CrearCategoria(pCategoria);
        }

        /// <summary>
        /// Elimina la categoria indicada del usuario
        /// </summary>
        /// <param name="pIdBuscado">Id de categoria que se quiere eliminar</param>
        public void EliminarCategoria(int pId)
        {
            Categoria cat = this.ModeloFachada.BuscarCategoria(pId);
            this.ModeloFachada.EliminarCategoria(cat);
        }

        /// <summary>
        /// Busca la categoria indicada
        /// </summary>
        /// <param name="pIdRS">Id de la categoria a buscar</param>
        /// <returns>Devuelve la categoria encontrada</returns>
        public Categoria BuscarCategoria(int pIdRS)
        {
            return this.ModeloFachada.BuscarCategoria(pIdRS);
        }
        #endregion
    }
}
