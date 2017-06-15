using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;
using System.Diagnostics;

namespace CONTROLADOR
{
    public class ControladorMotorBusqueda
    {
        /// <summary>
        /// Crea una nueva red social
        /// </summary>
        /// <param name="pRedSocial">Red social a crear</param>
        public void NuevoMotorBusqueda(MotorBusqueda pMotor)
        {
            (ModeloFachada.GetInstancia()).CrearMotor(pMotor);
        }

        public void Buscar(string pTipoMotor, string pCadenaABuscar)
        {
            MotorBusqueda mMotor=this.ObtenerMotor(pTipoMotor);
            string busqueda = mMotor.DireccionMotorBusqueda + pCadenaABuscar;
            //Process.Start("http://localhost:81/HabilitacionProfesional/index.php/API/redireccionarA/"+variable);
            Process.Start(busqueda);

        }

        /// <summary>
        /// Devuelve el Motor de Búsqueda según el tipo de motor de búsqueda indicado
        /// </summary>
        /// <param name="pIdRS">Tipo de Motor búsqueda</param>
        /// <returns>Devuelve el Motor de Busqueda encontrado</returns>
        private MotorBusqueda ObtenerMotor(string pTipoMotor)
        {
            return ModeloFachada.GetInstancia().ObtenerMotor(pTipoMotor);
        }
    }
}
