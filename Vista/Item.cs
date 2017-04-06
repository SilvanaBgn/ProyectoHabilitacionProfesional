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
        private String iChrome { get; set; } = @"%AppData%\..\Local\Google\Chrome\Application\chrome.exe";
        private String iRutaArchivo { get; set; } = null;
        private String iRutaPrograma { get; set; } = null;
        private Uri iRutaWeb { get; set; } = null;

        public Item(String pCatNombre, Image pCatIcono, String pRuta)
        {
            InitializeComponent();
            if (pRuta.EndsWith(".exe"))
            {
                iRutaPrograma = pRuta;
            }
            else
            {
                iRutaArchivo = pRuta;
            }
            this.lblItem.Text = pCatNombre;
            this.AjustarLabel(this.lblItem);
            if (pCatIcono!=null)
                this.btnItem.Image = pCatIcono;
        }

        public Item(String pCatNombre, Image pCatIcono, Uri pURL)
        {
            InitializeComponent();
            if (pURL!=null)
            {
                this.iRutaWeb = pURL;
            }
            this.lblItem.Text = pCatNombre;
            this.AjustarLabel(this.lblItem);
            if (pCatIcono != null)
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
            if (this.iRutaArchivo != null)
            {

            }
            else if (this.iRutaWeb != null)
            {
                //AplicacionWindows.Iniciar("firefox",iRutaWeb.ToString());
            }
            else if (this.iRutaPrograma != null)
            {
               // AplicacionWindows.Iniciar(iRutaPrograma,null);
            }
            else
            {
                //error
            }
        }
    }
}
