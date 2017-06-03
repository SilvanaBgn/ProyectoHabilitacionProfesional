using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            IList<ItemLateral> iCategoriasLaterales = new List<ItemLateral>();
            ItemLateral cosavacia = new ItemLateral("Cosas Varias","formcosasvarias",false);
            ItemLateral pornocatolicos = new ItemLateral("Porno para Católicos","formpornoparacatolicos",true);
            ItemLateral fuentessabiduria = new ItemLateral("Fuentes de Sabiduria","formfuentesdesabiduria",false);
            iCategoriasLaterales.Add(cosavacia);
            iCategoriasLaterales.Add(pornocatolicos);
            iCategoriasLaterales.Add(fuentessabiduria);
            foreach (ItemLateral catLat in iCategoriasLaterales)
            {
                catLat.Dock = DockStyle.Fill;
                catLat.ItemLateralClicked += new EventHandler(ItemLateral_ButtonClicked);
                this.tlpBarraLateral.Controls.Add(catLat);
            }
        }

        private void CargarPanelDerecho(string pValorUnico)
        {
            //vaciar panel derecho
            this.tlpTablaControles.Controls.Clear();
            //obtener la lista de Items dependientes de este item por su valor unico.
            IList<Item> iItems = new List<Item>();
            Item cosavacia = new Item("Cosas Varias","formcosasvarias",null,false);
            Item pornocatolicos = new Item("Porno para Católicos","formpornoparacatolicos",null,true);
            Item pornocatolicos2 = new Item("Porno para Católicos", "formpornoparacatolicos", null, true);
            Item pornocatolicos3 = new Item("Porno para Católicos", "formpornoparacatolicos", null, true);
            Item fuentessabiduria = new Item("Fuentes de Sabiduria","formfuentesdesabiduria",null,false);
            Item fuentessabiduria2 = new Item("Fuentes de Sabiduria", "formfuentesdesabiduria", null, false);
            iItems.Add(cosavacia);
            iItems.Add(pornocatolicos);
            iItems.Add(pornocatolicos2);
            iItems.Add(pornocatolicos3);
            iItems.Add(fuentessabiduria);
            iItems.Add(fuentessabiduria2);
            //cargar nuevos items el panel derechoD
            foreach (Item item in iItems)
            {
                item.Anchor = AnchorStyles.Top;
                item.ItemClicked += new EventHandler(Item_ButtonClicked);
                this.tlpTablaControles.Controls.Add(item);
            }
        }

        private void FormatearPanelDerecho(bool pModoFinal)
        {
            //Modo final contiene los botones agregar y eliminar
            //En modo final se muestan los botones
            this.btnAgregar.Visible = pModoFinal;
            this.btnAgregar.Enabled = pModoFinal;
            this.btnEliminar.Visible = pModoFinal;
            this.btnEliminar.Enabled = pModoFinal;
            this.tlpTablaControles.Location = new Point(this.tlpBarraLateral.Right + 6, 0);
            if (pModoFinal)
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
            CargarPanelDerecho(iClickedItemLateral.Valor);
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
            CargarPanelDerecho(iClickedItem.Valor);
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
