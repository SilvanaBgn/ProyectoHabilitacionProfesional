﻿namespace Vista
{
    partial class ItemLateral
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
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnItem.Location = new System.Drawing.Point(0, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(210, 65);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "Categoria#";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // ItemLateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnItem);
            this.Name = "ItemLateral";
            this.Size = new System.Drawing.Size(210, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
    }
}
