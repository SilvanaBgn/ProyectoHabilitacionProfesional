using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace MODELO
{
    public interface IModeloFachada
    {
        #region Crear
        void CrearArchivo(Archivo pUnArchivo);
        void CrearEntretenimiento(Entretenimiento pUnEntretenimiento);
        void CrearRedSocial(RedSocial pUnaRedSocial);
        void CrearUsuario(Usuario pUnUsuario);
        void CrearBuscado(Buscado pUnBuscado);
        void CrearCategoria(Categoria pUnaCategoria);
        #endregion
        #region Eliminar
        void EliminarArchivo(Archivo pUnArchivo);
        void EliminarEntretenimiento(Entretenimiento pUnEntretenimiento);
        void EliminarRedSocial(RedSocial pUnaRedSocial);
        void EliminarUsuario(Usuario pUnUsuario);
        void EliminarBuscado(Buscado pUnBuscado);
        void EliminarCategoria(Categoria pUnaCategoria);
        #endregion
        #region Buscar
        Archivo BuscarArchivo(int pIdArchivo);
        Entretenimiento BuscarEntretenimiento(int pIdEntretenimiento);
        RedSocial BuscarRedSocial(int pIdRedSocial);
        Usuario BuscarUsuario(int pIdUsuario);
        Buscado BuscarBuscado(int pIdBuscado);
        Categoria BuscarCategoria(int pIdCategoria);
        #endregion
        #region Modificar
        void ModificarUsuario(Usuario pUnUsuario);
        #endregion
    }
}
