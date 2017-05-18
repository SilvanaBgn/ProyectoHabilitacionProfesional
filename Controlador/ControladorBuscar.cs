using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorBuscar
    {
        /// <summary>
        /// Devuelve el Motor de Búsqueda según el tipo de motor de búsqueda indicado
        /// </summary>
        /// <param name="pIdRS">Tipo de Motor búsqueda</param>
        /// <returns>Devuelve el Motor de Busqueda encontrado</returns>
        public MotorBusqueda ObtenerMotor(string pTipoMotor)
        {
            return ModeloFachada.GetInstancia().ObtenerMotor(pTipoMotor);
        }
    }
}
