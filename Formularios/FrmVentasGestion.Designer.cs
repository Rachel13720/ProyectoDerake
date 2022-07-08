
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblComentario = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblMiUsuario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAgregarItem = new System.Windows.Forms.ToolStripLabel();
            this.BtnModificarItem = new System.Windows.Forms.ToolStripLabel();
            this.BtnEliminarItem = new System.Windows.Forms.ToolStripLabel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnCrearVenta = new System.Windows.Forms.Button();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CNombre,
            this.CCantidadVendida,
            this.CPrecioVenta});
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(445, 54);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(232, 112);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(217, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 23);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 23);
            this.textBox2.TabIndex = 6;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Location = new System.Drawing.Point(488, 35);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(136, 16);
            this.LblEmpleado.TabIndex = 5;
            this.LblEmpleado.Text = "Comentario (opcional)";
            // 
            // LblComentario
            // 
            this.LblComentario.AutoSize = true;
            this.LblComentario.Location = new System.Drawing.Point(269, 99);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(67, 16);
            this.LblComentario.TabIndex = 4;
            this.LblComentario.Text = "Empleado";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(77, 99);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(47, 16);
            this.LblCliente.TabIndex = 3;
            this.LblCliente.Text = "Cliente";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Location = new System.Drawing.Point(245, 35);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(117, 16);
            this.LblFactura.TabIndex = 2;
            this.LblFactura.Text = "Número de Factura";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(20, 35);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(173, 16);
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
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(35, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 357);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregarItem,
            this.BtnModificarItem,
            this.BtnEliminarItem});
            this.toolStrip1.Location = new System.Drawing.Point(3, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 620);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 23);
            this.textBox1.TabIndex = 4;
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
            // FrmVentasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(788, 664);
            this.Controls.Add(this.BtnCrearVenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVentasGestion";
            this.Text = "FrmVentasGestion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnCrearVenta;
        private System.Windows.Forms.Label LblMiUsuario;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}