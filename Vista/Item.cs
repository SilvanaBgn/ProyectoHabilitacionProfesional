using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vista
{
    public partial class Item : UserControl
    {
        public String NombrePublico { get; set; }
        public int? CategoriaId { get; set; } = null;
        public String Valor { get; set; } = null;
        public Image Icono { get; set; } = null;

        //contructor para items finales
        public Item(String pNombrePublico, string pValor, Image pIcono = null)
        {
            InitializeComponent();
            if (pNombrePublico != null)
            { 
                this.NombrePublico = pNombrePublico;
                this.tbItem.Text = pNombrePublico;
            }
            if (pValor != null)
                this.Valor = pValor;
            //this.AjustarLabel(this.lblItem);
            if (pIcono != null)
                this.btnItem.Image = pIcono;
        }

        //contructor para items de categorias
        public Item(String pNombrePublico, int pCategoriaId)
        {
            InitializeComponent();
            if (pNombrePublico != null)
            {
                this.NombrePublico = pNombrePublico;
                this.tbItem.Text = pNombrePublico;
            }
            this.CategoriaId = pCategoriaId;
        }

        private void Categoria_SizeChanged(object sender, EventArgs e)
        {
            //this.AjustarLabel(this.lblItem);
        }

        /// <summary>
        /// Ajusta el tamaño de fuente de un label para que no se corte sí es más largo que el controlador.
        /// </summary>
        /// <param name="pLabel"></param>
        private void AjustarLabel(Label pLabel)
        {
            if (pLabel != null)
            {
                if (pLabel.Width <= System.Windows.Forms.TextRenderer.MeasureText(pLabel.Text, new Font(pLabel.Font.FontFamily, pLabel.Font.Size, pLabel.Font.Style)).Width)
                {
                    while (pLabel.Width < System.Windows.Forms.TextRenderer.MeasureText(pLabel.Text, new Font(pLabel.Font.FontFamily, pLabel.Font.Size, pLabel.Font.Style)).Width)
                    {
                        pLabel.Font = new Font(pLabel.Font.FontFamily, pLabel.Font.Size - 0.5f, pLabel.Font.Style);
                    }
                }
                else
                {
                    while (pLabel.Width > System.Windows.Forms.TextRenderer.MeasureText(pLabel.Text, new Font(pLabel.Font.FontFamily, pLabel.Font.Size, pLabel.Font.Style)).Width
                    && pLabel.Font.Height < pLabel.Height)
                    {
                        pLabel.Font = new Font(pLabel.Font.FontFamily, pLabel.Font.Size + 0.5f, pLabel.Font.Style);
                    }
                }
            }
        }

        public event EventHandler ItemClicked;

        protected virtual void onItemClicked(EventArgs e)
        {
            var handler = ItemClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        } 

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (this.CategoriaId != null)
            {
                onItemClicked(e);
            }
            else if (this.Valor != null)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = this.Valor;
                proc.Start();
            }
            else
                MessageBox.Show("Algo anda mal");
        }
    }
}
