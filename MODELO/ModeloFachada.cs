using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFachada : IModeloFachada
    {
        private UnidadDeTrabajo iUnidadDeTrabajo = new UnidadDeTrabajo();
     
        #region Archivo
        /// <summary>
        /// Crea una nueva instancia de la clase Archivo
        /// </summary>
        /// <param name="pUnaRuta"></param>
        public void CrearArchivo(Archivo pUnArchivo)
        {
            iUnidadDeTrabajo.RepositorioArchivo.Insert(pUnArchivo);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Eliminar un Archivo
        /// </summary>
        /// <param name="pUnArchivo"></param>
        public void EliminarArchivo(Archivo pUnArchivo)
        {
            Archivo iArchivo = iUnidadDeTrabajo.RepositorioArchivo.GetByID(pUnArchivo.Id);
            iUnidadDeTrabajo.RepositorioArchivo.Delete(iArchivo);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtener un Archivo mediante un ID
        /// </summary>
        /// <param name="pIdArchivo"></param>
        /// <returns></returns>
        public Archivo BuscarArchivo(int pIdArchivo)
        {
            return iUnidadDeTrabajo.RepositorioArchivo.GetByID(pIdArchivo);
        }
        #endregion

        #region Entretenimiento
        /// <summary>
        /// Crea un nuevo entretenimiento
        /// </summary>
        /// <param name="pDireccion">Dirección URI del entretenimiento</param>
        public void CrearEntretenimiento(Entretenimiento pUnEntretenimiento)
        {
            iUnidadDeTrabajo.RepositorioEntretenimiento.Insert(pUnEntretenimiento);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        public void EliminarEntretenimiento(Entretenimiento pEntretenimiento)
        {
            Entretenimiento iEntretenimiento = iUnidadDeTrabajo.RepositorioEntretenimiento.GetByID(pEntretenimiento.id);
            iUnidadDeTrabajo.RepositorioEntretenimiento.Delete(iEntretenimiento);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Busca el entretenimiento indicado
        /// </summary>
        /// <param name="pIdEntretenimiento">Id del entretenimiento</param>
        /// <returns></returns>
        public Entretenimiento BuscarEntretenimiento(int pIdEntretenimiento)
        {
            return iUnidadDeTrabajo.RepositorioEntretenimiento.GetByID(pIdEntretenimiento);
        }
        #endregion

        #region RedSocial
        /// <summary>
        /// Permite crear una nueva red social
        /// </summary>
        /// <param name="pUnaRedSocial"></param>
        public void CrearRedSocial(RedSocial pUnaRedSocial)
        {
            iUnidadDeTrabajo.RepositorioRedSocial.Insert(pUnaRedSocial);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina la red social indicada del usuario
        /// </summary>
        /// <param name="pIdRS">Id de la red social que se quiere eliminar</param>
        public void EliminarRedSocial(RedSocial pUnaRedSocial)
        {
            RedSocial iRedSocial = iUnidadDeTrabajo.RepositorioRedSocial.GetByID(pUnaRedSocial.IdRedSocial);
            iUnidadDeTrabajo.RepositorioRedSocial.Delete(iRedSocial);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Busca la red social indicada
        /// </summary>
        /// <param name="pIdRS">Id de la red social</param>
        /// <returns>Devuelve la red social buscada</returns>
        public RedSocial BuscarRedSocial(int pIdRS)
        {
            return iUnidadDeTrabajo.RepositorioRedSocial.GetByID(pIdRS);
        }
        #endregion

        #region Usuario
        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pDireccion">Dirección URI del entretenimiento</param>
        public void CrearUsuario(Usuario pUnUsuario)
        {
            iUnidadDeTrabajo.RepositorioUsuario.Insert(pUnUsuario);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        public void EliminarUsuario(Usuario pUnUsuario)
        {
            Usuario iUsuario = iUnidadDeTrabajo.RepositorioUsuario.GetByID(pUnUsuario.IdUsuario);
            iUnidadDeTrabajo.RepositorioUsuario.Delete(iUsuario);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina el usuario indicado
        /// </summary>
        /// <param name="pIdUSR">Id del usuario</param>
        /// <returns>Devuelve el usuario encontrado</returns>
        public Usuario BuscarUsuario(int pIdUSR)
        {
            return iUnidadDeTrabajo.RepositorioUsuario.GetByID(pIdUSR);
        }


        /// <summary>
        /// Actualiza Banner
        /// </summary>
        /// <param name="pBanner"></param>
        public void ModificarUsuario(Usuario pUsuario)
        {
            iUnidadDeTrabajo.RepositorioUsuario.Update(pUsuario);
            iUnidadDeTrabajo.Save();
        }

        #endregion

        #region Buscado
        /// <summary>
        /// Almacena una instancia de una busqueda
        /// </summary>
        /// <param name="pUnBuscado"></param>
        public void CrearBuscado(Buscado pUnBuscado)
        {
            iUnidadDeTrabajo.RepositorioBuscado.Insert(pUnBuscado);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina un elemento buscado
        /// </summary>
        /// <param name="pUnBuscado"></param>
        public void EliminarBuscado(Buscado pUnBuscado)
        {
            Buscado iBuscado = iUnidadDeTrabajo.RepositorioBuscado.GetByID(pUnBuscado.Id);
            iUnidadDeTrabajo.RepositorioBuscado.Delete(pUnBuscado);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtiene un elemnto buscado
        /// </summary>
        /// <param name="pIdBuscado"></param>
        /// <returns></returns>
        public Buscado BuscarBuscado(int pIdBuscado)
        {
            return iUnidadDeTrabajo.RepositorioBuscado.GetByID(pIdBuscado);

        }
        #endregion

        #region Categoria
        /// <summary>
        /// Almacena una categoria
        /// </summary>
        /// <param name="pUnaCategoria"></param>
        public void CrearCategoria(Categoria pUnaCategoria)
        {
            iUnidadDeTrabajo.RepositorioCategoria.Insert(pUnaCategoria);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Elimina una categoria almacenada
        /// </summary>
        /// <param name="pUnaCategoria"></param>
        public void EliminarCategoria(Categoria pUnaCategoria)
        {
            Categoria iCategoria = iUnidadDeTrabajo.RepositorioCategoria.GetByID(pUnaCategoria.Id);
            iUnidadDeTrabajo.RepositorioCategoria.Delete(pUnaCategoria);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtiene una determinada categoria
        /// </summary>
        /// <param name="pIdCategoria"></param>
        /// <returns></returns>
        public Categoria BuscarCategoria(int pIdCategoria)
        {
            return iUnidadDeTrabajo.RepositorioCategoria.GetByID(pIdCategoria);
        }
        #endregion
    }
}
