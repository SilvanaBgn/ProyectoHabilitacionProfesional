﻿using System;
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
    public partial class ItemLateral : UserControl
    {
        public string NombrePublico { get; set; }
        public int CategoriaId { get; set; }
        public bool CategoriaDeCategorias { get; set; } = false;

        public ItemLateral()
        {
            InitializeComponent();
        }

        public ItemLateral(string pNombrePublico, int pCategoriaId, bool pCategoriadeCategorias)
        {
            InitializeComponent();
            if (pNombrePublico != null)
            {
                NombrePublico = pNombrePublico;
                this.btnItem.Text = pNombrePublico;
            }
            CategoriaId = pCategoriaId;
            CategoriaDeCategorias = pCategoriadeCategorias;
        }

        public event EventHandler ItemLateralClicked;

        protected virtual void OnItemLateralClicked(EventArgs e)
        {
            var handler = ItemLateralClicked;
            if (handler != null)
                handler(this, e);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            OnItemLateralClicked(e);
        }
    }
}
