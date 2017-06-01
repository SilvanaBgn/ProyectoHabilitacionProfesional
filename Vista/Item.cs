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
        private String iRuta { get; set; }

        public Item(String pCatNombre, Image pCatIcono, String pRuta)
        {
            InitializeComponent();
            if (pRuta != null)
                this.iRuta = pRuta;
            this.lblItem.Text = pCatNombre;
            this.AjustarLabel(this.lblItem);
            if (pCatIcono!=null)
                this.btnItem.Image = pCatIcono;
        }

        private void Categoria_SizeChanged(object sender, EventArgs e)
        {
            this.AjustarLabel(this.lblItem);
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

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (this.iRuta != null)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = iRuta;
                proc.Start();
            }
        }
    }
}
