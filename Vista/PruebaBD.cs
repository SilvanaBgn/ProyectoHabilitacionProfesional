using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using ENTIDAD;

namespace Vista
{
    public partial class PruebaBD : Form
    {
        ControladorArchivo iControladorArchivo;
        ControladorMotorBusqueda iControladorMotorBusqueda;
        ControladorEntretenimiento iControladorEntretenimiento;
        ControladorRedSocial iControladorRedSocial;
        ControladorUsuario iControladorUsuario;

        public PruebaBD()
        {
            InitializeComponent();
            this.iControladorArchivo = new ControladorArchivo();
            this.iControladorMotorBusqueda = new ControladorMotorBusqueda();
            this.iControladorEntretenimiento = new ControladorEntretenimiento();
            this.iControladorRedSocial = new ControladorRedSocial();
            this.iControladorUsuario = new ControladorUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MotorBusqueda mMotor = new MotorBusqueda("www.youtube.com/results?search_query=", "video");
            //this.iControladorMotorBusqueda.NuevoMotorBusqueda(mMotor);

            this.iControladorMotorBusqueda.Buscar("video", "marama");
        }
    }
}
