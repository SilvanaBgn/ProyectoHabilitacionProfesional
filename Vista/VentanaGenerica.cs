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
    public partial class VentanaGenerica : Form
    {
        public VentanaGenerica()
        {
            InitializeComponent();
            TablaControles.RowCount = 0;
            TablaControles.RowStyles.Clear();
            TablaControles.AutoScroll = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nuevo = "Nuevo " + (this.TablaControles.Controls.Count + 1);
            this.TablaControles.Controls.Add(new Item(nuevo, null, "http://www.facebook.com"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Item> mEliminados = new List<Item>();
            foreach (Item mItem in this.TablaControles.Controls)
            {
                if (mItem.cbItem.Checked)
                {
                    mEliminados.Add(mItem);
                }
            }

            foreach (Item mItemEliminar in mEliminados)
            {
                this.TablaControles.Controls.Remove(mItemEliminar);
            }
        }
    }
}
