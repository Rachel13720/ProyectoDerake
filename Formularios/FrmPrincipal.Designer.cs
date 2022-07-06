
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
            this.mantenimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rolesDeUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mantenimientosToolStripMenuItem1,
            this.procesosToolStripMenuItem1,
            this.reportesToolStripMenuItem1,
            this.acercaDeToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(632, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(146, 450);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenimientosToolStripMenuItem1
            // 
            this.mantenimientosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.productosToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.toolStripSeparator5,
            this.rolesDeUsuariosToolStripMenuItem1,
            this.categoríaDeProductosToolStripMenuItem1});
            this.mantenimientosToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientosToolStripMenuItem1.Name = "mantenimientosToolStripMenuItem1";
            this.mantenimientosToolStripMenuItem1.Size = new System.Drawing.Size(140, 23);
            this.mantenimientosToolStripMenuItem1.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(249, 6);
            // 
            // rolesDeUsuariosToolStripMenuItem1
            // 
            this.rolesDeUsuariosToolStripMenuItem1.Name = "rolesDeUsuariosToolStripMenuItem1";
            this.rolesDeUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.rolesDeUsuariosToolStripMenuItem1.Text = "Roles de usuarios";
            this.rolesDeUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.rolesDeUsuariosToolStripMenuItem1_Click);
            // 
            // categoríaDeProductosToolStripMenuItem1
            // 
            this.categoríaDeProductosToolStripMenuItem1.Name = "categoríaDeProductosToolStripMenuItem1";
            this.categoríaDeProductosToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.categoríaDeProductosToolStripMenuItem1.Text = "Categoría de productos";
            this.categoríaDeProductosToolStripMenuItem1.Click += new System.EventHandler(this.categoríaDeProductosToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem1
            // 
            this.procesosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeVentasToolStripMenuItem});
            this.procesosToolStripMenuItem1.Name = "procesosToolStripMenuItem1";
            this.procesosToolStripMenuItem1.Size = new System.Drawing.Size(87, 23);
            this.procesosToolStripMenuItem1.Text = "Procesos";
            // 
            // gestiónDeVentasToolStripMenuItem
            // 
            this.gestiónDeVentasToolStripMenuItem.Name = "gestiónDeVentasToolStripMenuItem";
            this.gestiónDeVentasToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.gestiónDeVentasToolStripMenuItem.Text = "Gestión de Ventas";
            this.gestiónDeVentasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeVentasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeVentasToolStripMenuItem1,
            this.listaDeClientesToolStripMenuItem1,
            this.listaDeEmpleadosToolStripMenuItem1,
            this.listaDeProductosToolStripMenuItem1});
            this.reportesToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(88, 23);
            this.reportesToolStripMenuItem1.Text = "Reportes";
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
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónToolStripMenuItem1
            // 
            this.informaciónToolStripMenuItem1.Name = "informaciónToolStripMenuItem1";
            this.informaciónToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.informaciónToolStripMenuItem1.Text = "Información";
            this.informaciónToolStripMenuItem1.Click += new System.EventHandler(this.informaciónToolStripMenuItem1_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(138, 23);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoríaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}