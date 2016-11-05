using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHabilitacionProfesional
{
    public class Tutorial
    {
        private int idTutorial;
        private string iRutaTutorial;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pRuta">ruta de archivo del tutorial correspondiente</param>
        public Tutorial(string pRuta)
        {
            this.iRutaTutorial = pRuta;
        }

        #region Properties
        public int Id
        {
            get { return this.idTutorial; }
            set { this.idTutorial = value; }
        }

        public string RutaTutorial
        {
            get { return this.iRutaTutorial; }
            set { this.iRutaTutorial = value; }
        }
        #endregion
    }
}
