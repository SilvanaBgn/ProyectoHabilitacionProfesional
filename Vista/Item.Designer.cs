namespace Vista
{
    partial class Item
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnItem = new System.Windows.Forms.Button();
            this.cbItem = new System.Windows.Forms.CheckBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItem.Location = new System.Drawing.Point(3, 3);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(194, 145);
            this.btnItem.TabIndex = 0;
            this.btnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // cbItem
            // 
            this.cbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItem.AutoSize = true;
            this.cbItem.Location = new System.Drawing.Point(126, 12);
            this.cbItem.Name = "cbItem";
            this.cbItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbItem.Size = new System.Drawing.Size(62, 17);
            this.cbItem.TabIndex = 2;
            this.cbItem.Text = "Eliminar";
            this.cbItem.UseVisualStyleBackColor = true;
            // 
            // tbItem
            // 
            this.tbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItem.Font = new System.Drawing.Font("Arial Black", 14F);
            this.tbItem.Location = new System.Drawing.Point(3, 152);
            this.tbItem.Margin = new System.Windows.Forms.Padding(1);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.ReadOnly = true;
            this.tbItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbItem.Size = new System.Drawing.Size(194, 46);
            this.tbItem.TabIndex = 3;
            this.tbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.btnItem);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(200, 200);
            this.SizeChanged += new System.EventHandler(this.Categoria_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        public System.Windows.Forms.CheckBox cbItem;
        private System.Windows.Forms.TextBox tbItem;
    }
}
