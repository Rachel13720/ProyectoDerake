﻿
namespace ProyectoDerake.Formularios
{
    partial class FrmGestionVentaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblCant = new System.Windows.Forms.Label();
            this.CboxSuma = new System.Windows.Forms.CheckBox();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.PnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CNombres,
            this.CCantidad,
            this.CPrecio,
            this.CComentario});
            this.DgvListaItems.Location = new System.Drawing.Point(31, 36);
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.Size = new System.Drawing.Size(600, 322);
            this.DgvListaItems.TabIndex = 0;
            // 
            // PnlDatos
            // 
            this.PnlDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PnlDatos.Controls.Add(this.CboxSuma);
            this.PnlDatos.Controls.Add(this.LblCant);
            this.PnlDatos.Controls.Add(this.NudCantidad);
            this.PnlDatos.Location = new System.Drawing.Point(31, 393);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(600, 155);
            this.PnlDatos.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAceptar.Location = new System.Drawing.Point(672, 412);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(102, 33);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(672, 490);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 33);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NudCantidad
            // 
            this.NudCantidad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.NudCantidad.Location = new System.Drawing.Point(211, 73);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(168, 25);
            this.NudCantidad.TabIndex = 3;
            // 
            // LblCant
            // 
            this.LblCant.AutoSize = true;
            this.LblCant.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.LblCant.Location = new System.Drawing.Point(230, 44);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(119, 17);
            this.LblCant.TabIndex = 4;
            this.LblCant.Text = "Cantidad a vender";
            // 
            // CboxSuma
            // 
            this.CboxSuma.AutoSize = true;
            this.CboxSuma.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.CboxSuma.Location = new System.Drawing.Point(184, 119);
            this.CboxSuma.Name = "CboxSuma";
            this.CboxSuma.Size = new System.Drawing.Size(267, 21);
            this.CboxSuma.TabIndex = 5;
            this.CboxSuma.Text = "Sumar cantidad del producto en la lista";
            this.CboxSuma.UseVisualStyleBackColor = true;
            // 
            // CIDProducto
            // 
            this.CIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDProducto.HeaderText = "Código";
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.Width = 80;
            // 
            // CNombres
            // 
            this.CNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombres.HeaderText = "Descripción";
            this.CNombres.Name = "CNombres";
            this.CNombres.Width = 150;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            // 
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CComentario
            // 
            this.CComentario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CComentario.HeaderText = "Comentario";
            this.CComentario.Name = "CComentario";
            // 
            // FrmGestionVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.DgvListaItems);
            this.Name = "FrmGestionVentaDetalle";
            this.Text = "Gestion de Detalles de Venta";
            this.Load += new System.EventHandler(this.FrmGestionVentaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.Panel PnlDatos;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CComentario;
        private System.Windows.Forms.CheckBox CboxSuma;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.NumericUpDown NudCantidad;
    }
}