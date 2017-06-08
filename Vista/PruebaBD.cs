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
        ControladorBuscar iControladorBuscar;
        ControladorEntretenimiento iControladorEntretenimiento;
        ControladorRedSocial iControladorRedSocial;
        ControladorUsuario iControladorUsuario;

        public PruebaBD()
        {
            InitializeComponent();
            this.iControladorArchivo = new ControladorArchivo();
            this.iControladorBuscar = new ControladorBuscar();
            this.iControladorEntretenimiento = new ControladorEntretenimiento();
            this.iControladorRedSocial = new ControladorRedSocial();
            this.iControladorUsuario = new ControladorUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usuario mUsuario = new Usuario("Juan", "123", "juan@gmail.com");
            //Usuario mUsuario = this.iControladorUsuario.BuscarUsuario(1);

            //RedSocial mRedSocial = new RedSocial("https://www.facebook.com/", "Facebook", "admin", "Juancitoo");

            //mUsuario.ListRedesSociales.Remove(mUsuario.ListRedesSociales[1]);

            ////this.iControladorUsuario.NuevoUsuario(mUsuario);
            //this.iControladorUsuario.ModificarUsuario(mUsuario);
            //this.iControladorRedSocial.EliminarRedSocial(2);
            this.iControladorUsuario.EliminarUsuario(1);

            //this.iControladorRedSocial.NuevaRedSocial(mRedSocial);
        }
    }
}
