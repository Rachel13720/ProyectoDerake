
namespace ProyectoDerake.Formularios
{
    partial class FrmGestionClientes
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
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.gbx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCliente,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Direccion});
            this.DgvListaClientes.Location = new System.Drawing.Point(23, 325);
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaClientes.Size = new System.Drawing.Size(720, 326);
            this.DgvListaClientes.TabIndex = 0;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            // 
            // IDCliente
            // 
            this.IDCliente.DataPropertyName = "IDCliente";
            this.IDCliente.HeaderText = "Código";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Location = new System.Drawing.Point(23, 284);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(139, 35);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.Location = new System.Drawing.Point(168, 284);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(139, 35);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Location = new System.Drawing.Point(313, 284);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(139, 35);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Location = new System.Drawing.Point(458, 284);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(139, 35);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.Location = new System.Drawing.Point(603, 284);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(139, 35);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.TxtTelefono.Location = new System.Drawing.Point(6, 160);
            this.TxtTelefono.MaxLength = 8;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(203, 25);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.TxtApellido.Location = new System.Drawing.Point(6, 102);
            this.TxtApellido.MaxLength = 30;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(203, 25);
            this.TxtApellido.TabIndex = 7;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(6, 37);
            this.TxtNombre.MaxLength = 25;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(203, 25);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.TxtDireccion.Location = new System.Drawing.Point(359, 38);
            this.TxtDireccion.MaxLength = 255;
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(322, 88);
            this.TxtDireccion.TabIndex = 9;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(3, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(57, 16);
            this.LblNombre.TabIndex = 10;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblApellido.Location = new System.Drawing.Point(3, 83);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 11;
            this.LblApellido.Text = "Apellido";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(3, 141);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(60, 16);
            this.LblTelefono.TabIndex = 12;
            this.LblTelefono.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.LblDireccion.Location = new System.Drawing.Point(366, 19);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(63, 16);
            this.LblDireccion.TabIndex = 13;
            this.LblDireccion.Text = "Dirección";
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.TxtNombre);
            this.gbx1.Controls.Add(this.LblDireccion);
            this.gbx1.Controls.Add(this.TxtTelefono);
            this.gbx1.Controls.Add(this.TxtDireccion);
            this.gbx1.Controls.Add(this.LblTelefono);
            this.gbx1.Controls.Add(this.TxtApellido);
            this.gbx1.Controls.Add(this.LblApellido);
            this.gbx1.Controls.Add(this.LblNombre);
            this.gbx1.Location = new System.Drawing.Point(23, 73);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(719, 193);
            this.gbx1.TabIndex = 14;
            this.gbx1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "CONTROL DE REGISTRO DE CLIENTES";
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvListaClientes);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.FrmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Label label1;
    }
}