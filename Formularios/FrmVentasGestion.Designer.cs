
namespace ProyectoDerake.Formularios
{
    partial class FrmVentasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasGestion));
            this.DgvListaVentas = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxEmpleado = new System.Windows.Forms.ComboBox();
            this.CboxCliente = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblComentario = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblMiUsuario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TstpVentas = new System.Windows.Forms.ToolStrip();
            this.BtnAgregarItem = new System.Windows.Forms.ToolStripLabel();
            this.BtnModificarItem = new System.Windows.Forms.ToolStripLabel();
            this.BtnEliminarItem = new System.Windows.Forms.ToolStripLabel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnCrearVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TstpVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaVentas
            // 
            this.DgvListaVentas.AllowUserToAddRows = false;
            this.DgvListaVentas.AllowUserToDeleteRows = false;
            this.DgvListaVentas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CNombre,
            this.CCantidadVendida,
            this.CPrecioVenta});
            this.DgvListaVentas.Location = new System.Drawing.Point(3, 47);
            this.DgvListaVentas.Name = "DgvListaVentas";
            this.DgvListaVentas.ReadOnly = true;
            this.DgvListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaVentas.Size = new System.Drawing.Size(705, 304);
            this.DgvListaVentas.TabIndex = 0;
            // 
            // CIDProducto
            // 
            this.CIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Código";
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            this.CIDProducto.Width = 85;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Producto";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CCantidadVendida
            // 
            this.CCantidadVendida.DataPropertyName = "CantidadVendida";
            this.CCantidadVendida.HeaderText = "Cantidad";
            this.CCantidadVendida.Name = "CCantidadVendida";
            this.CCantidadVendida.ReadOnly = true;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxEmpleado);
            this.groupBox1.Controls.Add(this.CboxCliente);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.TxtComentario);
            this.groupBox1.Controls.Add(this.TxtNumeroFactura);
            this.groupBox1.Controls.Add(this.LblEmpleado);
            this.groupBox1.Controls.Add(this.LblComentario);
            this.groupBox1.Controls.Add(this.LblCliente);
            this.groupBox1.Controls.Add(this.LblFactura);
            this.groupBox1.Controls.Add(this.LblFecha);
            this.groupBox1.Controls.Add(this.LblMiUsuario);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CboxEmpleado
            // 
            this.CboxEmpleado.FormattingEnabled = true;
            this.CboxEmpleado.Location = new System.Drawing.Point(217, 118);
            this.CboxEmpleado.Name = "CboxEmpleado";
            this.CboxEmpleado.Size = new System.Drawing.Size(175, 24);
            this.CboxEmpleado.TabIndex = 13;
            // 
            // CboxCliente
            // 
            this.CboxCliente.FormattingEnabled = true;
            this.CboxCliente.Location = new System.Drawing.Point(18, 118);
            this.CboxCliente.Name = "CboxCliente";
            this.CboxCliente.Size = new System.Drawing.Size(175, 24);
            this.CboxCliente.TabIndex = 12;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(18, 54);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(175, 23);
            this.DtpFecha.TabIndex = 11;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(445, 54);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(232, 112);
            this.TxtComentario.TabIndex = 10;
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumeroFactura.Location = new System.Drawing.Point(217, 54);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(175, 23);
            this.TxtNumeroFactura.TabIndex = 7;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblEmpleado.Location = new System.Drawing.Point(488, 35);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(140, 16);
            this.LblEmpleado.TabIndex = 5;
            this.LblEmpleado.Text = "Comentario (opcional)";
            // 
            // LblComentario
            // 
            this.LblComentario.AutoSize = true;
            this.LblComentario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentario.Location = new System.Drawing.Point(269, 99);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(67, 16);
            this.LblComentario.TabIndex = 4;
            this.LblComentario.Text = "Empleado";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblCliente.Location = new System.Drawing.Point(77, 99);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(49, 16);
            this.LblCliente.TabIndex = 3;
            this.LblCliente.Text = "Cliente";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblFactura.Location = new System.Drawing.Point(245, 35);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(122, 16);
            this.LblFactura.TabIndex = 2;
            this.LblFactura.Text = "Número de Factura";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblFecha.Location = new System.Drawing.Point(20, 35);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(181, 16);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha del registro de la venta";
            // 
            // LblMiUsuario
            // 
            this.LblMiUsuario.AutoSize = true;
            this.LblMiUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMiUsuario.Location = new System.Drawing.Point(15, 176);
            this.LblMiUsuario.Name = "LblMiUsuario";
            this.LblMiUsuario.Size = new System.Drawing.Size(46, 17);
            this.LblMiUsuario.TabIndex = 0;
            this.LblMiUsuario.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TstpVentas);
            this.groupBox2.Controls.Add(this.DgvListaVentas);
            this.groupBox2.Location = new System.Drawing.Point(35, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 357);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // TstpVentas
            // 
            this.TstpVentas.BackColor = System.Drawing.Color.SlateGray;
            this.TstpVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregarItem,
            this.BtnModificarItem,
            this.BtnEliminarItem});
            this.TstpVentas.Location = new System.Drawing.Point(3, 19);
            this.TstpVentas.Name = "TstpVentas";
            this.TstpVentas.Size = new System.Drawing.Size(705, 25);
            this.TstpVentas.TabIndex = 1;
            this.TstpVentas.Text = "toolStrip1";
            // 
            // BtnAgregarItem
            // 
            this.BtnAgregarItem.ActiveLinkColor = System.Drawing.Color.Red;
            this.BtnAgregarItem.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregarItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarItem.Image")));
            this.BtnAgregarItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BtnAgregarItem.Name = "BtnAgregarItem";
            this.BtnAgregarItem.Size = new System.Drawing.Size(132, 22);
            this.BtnAgregarItem.Text = "Agregar Producto";
            this.BtnAgregarItem.ToolTipText = "Agregar Producto";
            this.BtnAgregarItem.Click += new System.EventHandler(this.BtnAgregarItem_Click);
            // 
            // BtnModificarItem
            // 
            this.BtnModificarItem.BackColor = System.Drawing.Color.Orange;
            this.BtnModificarItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificarItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarItem.Image")));
            this.BtnModificarItem.Name = "BtnModificarItem";
            this.BtnModificarItem.Size = new System.Drawing.Size(139, 22);
            this.BtnModificarItem.Text = "Modificar Producto";
            this.BtnModificarItem.ToolTipText = "Modificar Producto";
            this.BtnModificarItem.Click += new System.EventHandler(this.BtnModificarItem_Click);
            // 
            // BtnEliminarItem
            // 
            this.BtnEliminarItem.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminarItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarItem.Image")));
            this.BtnEliminarItem.Name = "BtnEliminarItem";
            this.BtnEliminarItem.Size = new System.Drawing.Size(130, 22);
            this.BtnEliminarItem.Text = "Eliminar Producto";
            this.BtnEliminarItem.ToolTipText = "Eliminar Producto";
            this.BtnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(49, 620);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(137, 19);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Total de la venta: ";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(203, 620);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(315, 23);
            this.TxtTotal.TabIndex = 4;
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnCrearVenta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCrearVenta.Location = new System.Drawing.Point(595, 614);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Size = new System.Drawing.Size(139, 35);
            this.BtnCrearVenta.TabIndex = 5;
            this.BtnCrearVenta.Text = "Crear Venta";
            this.BtnCrearVenta.UseVisualStyleBackColor = false;
            this.BtnCrearVenta.Click += new System.EventHandler(this.BtnCrearVenta_Click);
            // 
            // FrmVentasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(788, 664);
            this.Controls.Add(this.BtnCrearVenta);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVentasGestion";
            this.Text = "Gestión de Ventas";
            this.Load += new System.EventHandler(this.FrmVentasGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TstpVentas.ResumeLayout(false);
            this.TstpVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvListaVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip TstpVentas;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnCrearVenta;
        private System.Windows.Forms.Label LblMiUsuario;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblComentario;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ToolStripLabel BtnAgregarItem;
        private System.Windows.Forms.ToolStripLabel BtnModificarItem;
        private System.Windows.Forms.ToolStripLabel BtnEliminarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CboxEmpleado;
        private System.Windows.Forms.ComboBox CboxCliente;
    }
}