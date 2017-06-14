using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using ENTIDAD;

namespace Vista
{
    public partial class Pestaña : UserControl
    {
        public string NombrePestaña { get; set; } = null;

        public Pestaña(bool pModoFinal)
        {
            InitializeComponent();
            tlpTablaControles.RowCount = 0;
            tlpTablaControles.RowStyles.Clear();
            tlpTablaControles.AutoScroll = true;
            this.CargarBarraLateral();
            this.FormatearPanelDerecho(pModoFinal);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Item> mEliminados = new List<Item>();
            foreach (Item mItem in this.tlpTablaControles.Controls)
            {
                if (mItem.cbItem.Checked)
                {
                    mEliminados.Add(mItem);
                }
            }

            foreach (Item mItemEliminar in mEliminados)
            {
                this.tlpTablaControles.Controls.Remove(mItemEliminar);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nuevo = "Nuevo " + (this.tlpTablaControles.Controls.Count + 1);
            this.tlpTablaControles.Controls.Add(new Item(nuevo, "http://www.facebook.com"));
        }

        private void CargarBarraLateral()
        {
            //Obtener lista de categorias laterales de base de datos
            foreach (Categoria categoriaHuerfana in ControladorCategoria.ObtenerCategorias(true))
            {
                //Crear item laterales
                ItemLateral mNewItemLateral = new ItemLateral(categoriaHuerfana.NombreCategoria, categoriaHuerfana.CategoriaId,ControladorCategoria.EsPadre(categoriaHuerfana.CategoriaId));
                //Cargarlo a la coleccion de controles
                mNewItemLateral.Dock = DockStyle.Fill;
                mNewItemLateral.ItemLateralClicked += new EventHandler(ItemLateral_ButtonClicked);
                this.tlpBarraLateral.Controls.Add(mNewItemLateral);
            }
        }

        private void CargarPanelDerecho(int pCategoriaId)
        {
            //vaciar panel derecho
            this.tlpTablaControles.Controls.Clear();
            foreach (Categoria categoria in ControladorCategoria.ObtenerCategoriasHijas(pCategoriaId))
            {
                //Crear item
                Item mNewItem = new Item(categoria.NombreCategoria, categoria.CategoriaId);
                //Cargar nuevo item en el panel derecho
                mNewItem.Anchor = AnchorStyles.Top;
                mNewItem.ItemClicked += new EventHandler(Item_ButtonClicked);
                this.tlpTablaControles.Controls.Add(mNewItem);
            }
        }

        private void FormatearPanelDerecho(bool pEsPadre)
        {
            bool mNoPadre = !pEsPadre;
            //Sí un item NO es padre de categorías, contiene los botones agregar y eliminar.
            //En modo final se muestan los botones
            this.btnAgregar.Visible = mNoPadre;
            this.btnAgregar.Enabled = mNoPadre;
            this.btnEliminar.Visible = mNoPadre;
            this.btnEliminar.Enabled = mNoPadre;
            this.tlpTablaControles.Location = new Point(this.tlpBarraLateral.Right + 6, 0);
            if (mNoPadre)
            {
                this.tlpTablaControles.Width = this.Width - this.tlpBarraLateral.Width - this.btnAgregar.Width - 6 * 2;
            }
            else
            {
                this.tlpTablaControles.Width = this.Width - this.tlpBarraLateral.Width - 6;
            }
        }

        private void ItemLateral_ButtonClicked(object sender, EventArgs e)
        {
            //convertir el sender en item lateral
            ItemLateral iClickedItemLateral = (ItemLateral)sender;
            //extraer datos del item lateral
            this.NombrePestaña = iClickedItemLateral.NombrePublico;
            //cambiar el contenido del panel derecho
            FormatearPanelDerecho(iClickedItemLateral.CategoriaDeCategorias);
            CargarPanelDerecho(iClickedItemLateral.CategoriaId);
            //reactivar boton previamente desactivado
            foreach (ItemLateral mItemLateral in tlpBarraLateral.Controls)
            {
                if (!mItemLateral.Enabled)
                {
                    mItemLateral.Enabled = true;
                }
            }
            //desactivar boton clickeado
            iClickedItemLateral.Enabled = false;
            //Llamar al evento para cambiar el nombre de la pestaña
            OnItemLateralClicked(e);
        }

        private void Item_ButtonClicked(object sender, EventArgs e)
        {
            //convertir el sender en item lateral
            Item iClickedItem = (Item)sender;
            //extraer datos del item lateral
            this.NombrePestaña = iClickedItem.NombrePublico;
            //cambiar el contenido del panel derecho, el parametro es true porque ya no puede haber más pantallas de categorias
            FormatearPanelDerecho(true);
            CargarPanelDerecho((int)iClickedItem.CategoriaId);
            //Llamar al evento para cambiar el nombre de la pestaña
            OnItemLateralClicked(e);
        }

        public event EventHandler PestañaChanged;

        protected virtual void OnItemLateralClicked(EventArgs e)
        {
            var handler = PestañaChanged;
            if (handler != null)
                handler(this, e);
        }
    }
}
