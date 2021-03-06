﻿using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFachada : IModeloFachada
    {
        private UnidadDeTrabajo iUnidadDeTrabajo = null;
        private static ModeloFachada instancia = null;


        /// <summary>
        /// Método de Singleton para obtener la instancia.
        /// </summary>
        /// <returns></returns>
        public static ModeloFachada GetInstancia()
        {
            if (instancia == null)
                instancia = new ModeloFachada();

            return instancia;
        }

        //Constructor de la clase ModeloFachada
        private ModeloFachada()
        {
            this.iUnidadDeTrabajo = new UnidadDeTrabajo();
        }

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
            Archivo iArchivo = iUnidadDeTrabajo.RepositorioArchivo.GetByID(pUnArchivo.ArchivoId);
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
            Entretenimiento iEntretenimiento = iUnidadDeTrabajo.RepositorioEntretenimiento.GetByID(pEntretenimiento.EntretenimientoId);
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
            RedSocial iRedSocial = iUnidadDeTrabajo.RepositorioRedSocial.GetByID(pUnaRedSocial.RedSocialId);
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
            Usuario iUsuario = iUnidadDeTrabajo.RepositorioUsuario.GetByID(pUnUsuario.UsuarioId);
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

        //PREGUNTAR SI BORRAR
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
            Buscado iBuscado = iUnidadDeTrabajo.RepositorioBuscado.GetByID(pUnBuscado.BuscadoId);
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
        #endregion //BORRAR

        #region Buscar
        /// <summary>
        /// Almacena una instancia de una busqueda
        /// </summary>
        public void CrearMotor(MotorBusqueda pUnMotor)
        {
            iUnidadDeTrabajo.RepositorioMotorBusqueda.Insert(pUnMotor);
            iUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtiene un elemnto buscado
        /// </summary>
        /// <param name="pMotor"></param>
        /// <returns>Motor de búsqueda requerido</returns>
        public MotorBusqueda ObtenerMotor(string pTipoMotor)
        {
            List<MotorBusqueda> mLista=((List<MotorBusqueda>)iUnidadDeTrabajo.RepositorioMotorBusqueda.Get(x=>x.TipoMotorBusqueda==pTipoMotor));
            MotorBusqueda mMotor;
            if (mLista.Count > 0)
            {
                mMotor = mLista[0];
            }
            else
            {
                mMotor = null;
            }
            return mMotor;
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
            Categoria iCategoria = iUnidadDeTrabajo.RepositorioCategoria.GetByID(pUnaCategoria.CategoriaId);
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

        /// <summary>
        /// Obtiene una determinada categoria
        /// </summary>
        /// <param name="pTipoCategoria"></param>
        /// <returns></returns>
        public Categoria BuscarCategoria(TipoCategoria pTipoCategoria)
        {
            return iUnidadDeTrabajo.RepositorioCategoria.Get(cat => cat.NombreCategoria == pTipoCategoria.ToString()).FirstOrDefault() ;
        }

        /// <summary>
        /// Obtiene todas las categorias
        /// </summary>
        /// <param name="pHuerfanas">Sí true, devuelve todas las categorías sin padre. Sino devuelve todas. Per defecto, false</param>
        public ICollection<Categoria> ObtenerCategorias(bool pHuerfanas = false)
        { 
            IQueryable<Categoria> resultado = iUnidadDeTrabajo.RepositorioCategoria.Queryable;
            if (pHuerfanas)
            {
                resultado = resultado.Where(cat => cat.CategoriaPadre == null);
            }
            return resultado.ToList();
        }

        /// <summary>
        /// Obtiene todas las categorias hijas de una categoría específica
        /// </summary>
        /// <param name="pIdCategoriaPadre">Id de la categoria padre</param>
        public ICollection<Categoria> ObtenerCategoriasHijas(int pIdCategoriaPadre)
        {
            return iUnidadDeTrabajo.RepositorioCategoria.Queryable.Where(cat => cat.CategoriaPadre.CategoriaId == pIdCategoriaPadre).ToList();
        }
        #endregion
    }
}
