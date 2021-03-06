﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Categoria
    {
        /// <summary>
        /// Id con el que se identifica a la categoría
        /// </summary>
        public int CategoriaId { get; set; }

        /// <summary>
        /// Id con el que se identifica a la categoría
        /// </summary>
        public virtual Categoria CategoriaPadre { get; set; }

        /// <summary>
        /// Nombre con el que se identifica a la categoría
        /// </summary>
        public string NombreCategoria { get; set; }

        /// <summary>
        /// Lista de tutoriales pertenecientes a esta categoría
        /// </summary>
        public virtual List<Tutorial> ListaTutoriales{ get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Categoria() { }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Categoria(TipoCategoria pTipo, Categoria pCategoriaPadre = null)
        {
            this.NombreCategoria = pTipo.ToString();
            this.CategoriaPadre = pCategoriaPadre;
            this.ListaTutoriales = new List<Tutorial>();
        }

        #region Métodos
        /// <summary>
        /// Agrega un tutorial a la lista de tutoriales que tiene esta categoría
        /// </summary>
        /// <param name="pRutaTutorial">Ruta al archivo tutorial</param>
        public void AgregarTutorial(string pRutaTutorial)
        {
            if (this.ListaTutoriales.ToList().Exists(x => x.RutaTutorial != pRutaTutorial))
                this.ListaTutoriales.Add(new Tutorial(pRutaTutorial));
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
    }
}
