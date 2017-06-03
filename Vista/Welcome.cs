using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            //Simulamos un click de mouse en el boton "nueva pestaña" para la primer pestaña
            var lastIndex = this.tabControl.TabCount - 1;
            tabControl_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 1,
                                                            this.tabControl.GetTabRect(lastIndex).X,
                                                            this.tabControl.GetTabRect(lastIndex).Y, 0));
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl.TabCount - 1;
            if (this.tabControl.GetTabRect(lastIndex).Contains(e.Location))
            {
                //crear nueva pestaña
                this.tabControl.TabPages.Insert(lastIndex, "Nueva Pestaña");
                //cambiar el color de fondo
                this.tabControl.TabPages[lastIndex].BackColor = System.Drawing.Color.Silver;
                //crear el contenido de la pestaña
                Pestaña newPestaña = new Pestaña(false);
                //ajustar para rellenar
                newPestaña.Dock = DockStyle.Fill;
                //vincular el evento de click en un boton lateral que cambiará el nombre de la pestaña
                newPestaña.PestañaChanged += new EventHandler(Pestaña_ButtonClicked);
                //colocarlo en el contenedor
                this.tabControl.TabPages[lastIndex].Controls.Add(newPestaña);
                //posicionarse en la pestaña recien creada
                this.tabControl.SelectedIndex = lastIndex;
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl.TabCount - 1)
                e.Cancel = true;
        }

        private void Pestaña_ButtonClicked(object sender, EventArgs e)
        {
            Pestaña iPestañaAlterada = (Pestaña)sender;
            this.tabControl.SelectedTab.Text = iPestañaAlterada.NombrePestaña;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
