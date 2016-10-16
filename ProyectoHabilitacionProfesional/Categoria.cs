using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    public class Categoria
    {
        private int idCategoria;
        private string iNombreCategoria;
        private TipoCategoria iTipoCategoria;
        private List<Tutorial> iListaTutoriales;
        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Categoria(string pNombre, TipoCategoria pTipo)
        {
            this.iNombreCategoria = pNombre;
            this.iTipoCategoria = pTipo;
            this.iListaTutoriales = new List<Tutorial>();
        }

        #region Métodos
        /// <summary>
        /// Agrega un tutorial a la lista de tutoriales que tiene esta categoría
        /// </summary>
        /// <param name="pRutaTutorial">Ruta al archivo tutorial</param>
        public void AgregarTutorial(string pRutaTutorial)
        {
            if (this.iListaTutoriales.Exists(x => x.RutaTutorial != pRutaTutorial))
                this.iListaTutoriales.Add(new Tutorial(pRutaTutorial));
        }

        /// <summary>
        /// Abre el tutorial indicado
        /// </summary>
        /// <param name="idTutorial">ID del tutorial que se desea abrir</param>
        public void AbrirTutorial(int idTutorial)
        {
            //Hacer
        }

        /// <summary>
        /// Busca el tutorial indicado
        /// </summary>
        /// <param name="idTutorial">ID del tutorial que se desea bsucar</param>
        public void BuscarTutorial(int idTutorial)
        {
            //Hacer
        }
        
        #endregion

        #region Properties
        public int Id
        {
            get { return this.idCategoria; }
            set { this.idCategoria = value; }
        }

        public string NombreCategoria
        {
            get { return this.iNombreCategoria; }
            set { this.iNombreCategoria = value; }
        }

        public TipoCategoria Tipo
        {
            get { return this.iTipoCategoria; }
        }
        #endregion
    }
}
