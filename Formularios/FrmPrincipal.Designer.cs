
namespace ProyectoDerake.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.LblTitulo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MantenimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ProcesosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GestiónDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario});
            this.LblTitulo.Location = new System.Drawing.Point(0, 428);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(632, 22);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(18, 17);
            this.LblUsuario.Text = "U";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientosToolStripMenuItem1,
            this.ProcesosToolStripMenuItem1,
            this.ReportesToolStripMenuItem1,
            this.AcercaDeToolStripMenuItem,
            this.SalirDelSistemaToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(632, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(146, 450);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MantenimientosToolStripMenuItem1
            // 
            this.MantenimientosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem1,
            this.ProductosToolStripMenuItem1,
            this.ClientesToolStripMenuItem1,
            this.EmpleadosToolStripMenuItem1,
            this.toolStripSeparator5});
            this.MantenimientosToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MantenimientosToolStripMenuItem1.Name = "MantenimientosToolStripMenuItem1";
            this.MantenimientosToolStripMenuItem1.Size = new System.Drawing.Size(140, 23);
            this.MantenimientosToolStripMenuItem1.Text = "Mantenimientos";
            // 
            // UsuariosToolStripMenuItem1
            // 
            this.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1";
            this.UsuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.UsuariosToolStripMenuItem1.Text = "Usuarios";
            this.UsuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // ProductosToolStripMenuItem1
            // 
            this.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1";
            this.ProductosToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.ProductosToolStripMenuItem1.Text = "Productos";
            this.ProductosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // ClientesToolStripMenuItem1
            // 
            this.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1";
            this.ClientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.ClientesToolStripMenuItem1.Text = "Clientes";
            this.ClientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // EmpleadosToolStripMenuItem1
            // 
            this.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1";
            this.EmpleadosToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.EmpleadosToolStripMenuItem1.Text = "Empleados";
            this.EmpleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // ProcesosToolStripMenuItem1
            // 
            this.ProcesosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestiónDeVentasToolStripMenuItem});
            this.ProcesosToolStripMenuItem1.Name = "ProcesosToolStripMenuItem1";
            this.ProcesosToolStripMenuItem1.Size = new System.Drawing.Size(87, 23);
            this.ProcesosToolStripMenuItem1.Text = "Procesos";
            // 
            // GestiónDeVentasToolStripMenuItem
            // 
            this.GestiónDeVentasToolStripMenuItem.Name = "GestiónDeVentasToolStripMenuItem";
            this.GestiónDeVentasToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.GestiónDeVentasToolStripMenuItem.Text = "Gestión de Ventas";
            this.GestiónDeVentasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeVentasToolStripMenuItem_Click);
            // 
            // ReportesToolStripMenuItem1
            // 
            this.ReportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeVentasToolStripMenuItem1,
            this.listaDeClientesToolStripMenuItem1,
            this.listaDeEmpleadosToolStripMenuItem1,
            this.listaDeProductosToolStripMenuItem1});
            this.ReportesToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1";
            this.ReportesToolStripMenuItem1.Size = new System.Drawing.Size(88, 23);
            this.ReportesToolStripMenuItem1.Text = "Reportes";
            // 
            // reportesDeVentasToolStripMenuItem1
            // 
            this.reportesDeVentasToolStripMenuItem1.Name = "reportesDeVentasToolStripMenuItem1";
            this.reportesDeVentasToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.reportesDeVentasToolStripMenuItem1.Text = "Reportes de Ventas";
            // 
            // listaDeClientesToolStripMenuItem1
            // 
            this.listaDeClientesToolStripMenuItem1.Name = "listaDeClientesToolStripMenuItem1";
            this.listaDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.listaDeClientesToolStripMenuItem1.Text = "Lista de Clientes";
            // 
            // listaDeEmpleadosToolStripMenuItem1
            // 
            this.listaDeEmpleadosToolStripMenuItem1.Name = "listaDeEmpleadosToolStripMenuItem1";
            this.listaDeEmpleadosToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.listaDeEmpleadosToolStripMenuItem1.Text = "Lista de Empleados";
            // 
            // listaDeProductosToolStripMenuItem1
            // 
            this.listaDeProductosToolStripMenuItem1.Name = "listaDeProductosToolStripMenuItem1";
            this.listaDeProductosToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.listaDeProductosToolStripMenuItem1.Text = "Lista de Productos";
            // 
            // AcercaDeToolStripMenuItem
            // 
            this.AcercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem1});
            this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
            this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.AcercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónToolStripMenuItem1
            // 
            this.informaciónToolStripMenuItem1.Name = "informaciónToolStripMenuItem1";
            this.informaciónToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.informaciónToolStripMenuItem1.Text = "Información";
            this.informaciónToolStripMenuItem1.Click += new System.EventHandler(this.informaciónToolStripMenuItem1_Click);
            // 
            // SalirDelSistemaToolStripMenuItem
            // 
            this.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem";
            this.SalirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(138, 23);
            this.SalirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.SalirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control DERAKE 2018 S.A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.LblTitulo.ResumeLayout(false);
            this.LblTitulo.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip LblTitulo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MantenimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ProcesosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GestiónDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SalirDelSistemaToolStripMenuItem;
    }
}