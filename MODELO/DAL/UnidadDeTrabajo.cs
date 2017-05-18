using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class UnidadDeTrabajo : IDisposable
    {
        private ContextoAPP context = new ContextoAPP();
        private RepositorioGenerico<Archivo> iArchivoRepository;
        private RepositorioGenerico<Usuario> iUsuarioRepository;
        private RepositorioGenerico<Entretenimiento> iEntretenimientoRepository;
        private RepositorioGenerico<RedSocial> iRedSocialRepository;
        private RepositorioGenerico<Buscado> iBuscadoRepository;
        private RepositorioGenerico<Categoria> iCategoriaRepository;
        private RepositorioGenerico<MotorBusqueda> iMotorBusquedaRepository;


        /// <summary>
        /// Propiedad de Repositorio de Archivo
        /// </summary>
        public RepositorioGenerico<Archivo> RepositorioArchivo
        {
            get
            {
                if (this.iArchivoRepository == null)
                {
                    this.iArchivoRepository = new RepositorioGenerico<Archivo>(context);
                }
                return this.iArchivoRepository;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de Buscado
        /// </summary>
        public RepositorioGenerico<Buscado> RepositorioBuscado
        {
            get
            {
                if (this.iBuscadoRepository == null)
                {
                    this.iBuscadoRepository = new RepositorioGenerico<Buscado>(context);
                }
                return this.iBuscadoRepository;
            }
        }


        /// <summary>
        /// Propiedad de Repositorio de Categoria
        /// </summary>
        public RepositorioGenerico<Categoria> RepositorioCategoria
        {
            get
            {
                if (this.iCategoriaRepository == null)
                {
                    this.iCategoriaRepository = new RepositorioGenerico<Categoria>(context);
                }
                return this.iCategoriaRepository;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de Usuario
        /// </summary>
        public RepositorioGenerico<Usuario> RepositorioUsuario
        {
            get
            {
                if (this.iUsuarioRepository == null)
                {
                    this.iUsuarioRepository = new RepositorioGenerico<Usuario>(context);
                }
                return this.iUsuarioRepository;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de Entretenimineto
        /// </summary>
        public RepositorioGenerico<Entretenimiento> RepositorioEntretenimiento
        {
            get
            {
                if (this.iEntretenimientoRepository == null)
                {
                    this.iEntretenimientoRepository = new RepositorioGenerico<Entretenimiento>(context);
                }
                return this.iEntretenimientoRepository;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de RedSocial
        /// </summary>
        public RepositorioGenerico<RedSocial> RepositorioRedSocial
        {
            get
            {
                if (this.iRedSocialRepository == null)
                {
                    this.iRedSocialRepository = new RepositorioGenerico<RedSocial>(context);
                }
                return this.iRedSocialRepository;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de Motores de búsqueda
        /// </summary>
        public RepositorioGenerico<MotorBusqueda> RepositorioMotorBusqueda
        {
            get
            {
                if (this.iMotorBusquedaRepository == null)
                {
                    this.iMotorBusquedaRepository = new RepositorioGenerico<MotorBusqueda>(context);
                }
                return this.iMotorBusquedaRepository;
            }
        }





        /// <summary>
        /// Guardar cambios
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// No eliminado
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Eliminar Unidad de trabajo
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
