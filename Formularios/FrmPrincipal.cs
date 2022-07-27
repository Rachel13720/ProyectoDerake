using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDerake.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            //TODO
            //Debemos hacer un switch para que los accesos a menus sean adecuados
            //segun el rol que tenga el  usuario logueado

            switch (Locales.ObjetosGlobales.MiUsuarioGlobal.Rol.IDUsuarioRol)
            {
                //admin
                case 1:
                    //por el momento no haremos nada ya que el admin tiene acceso 
                    //a todo
                    break;
                case 2:
                    //ocultamos las opciones de menu que no le corresponden al usuario 
                    //normal
                    MantenimientosToolStripMenuItem1.Visible = true;
                    UsuariosToolStripMenuItem1.Visible = false;
                    ProcesosToolStripMenuItem1.Visible = false;

                    break;
            }
        }

        private void GestiónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionVentas.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionVentas = new FrmVentasGestion();
                Locales.ObjetosGlobales.MiFormGestionVentas.Show();
            }
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionUsuarios.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionUsuarios = new FrmUsuariosGestion();
                Locales.ObjetosGlobales.MiFormGestionUsuarios.Show();
            }
        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionProductos.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionProductos = new FrmGestionProductos();
                Locales.ObjetosGlobales.MiFormGestionProductos.Show();
            }
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionClientes.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionClientes = new FrmGestionClientes();
                Locales.ObjetosGlobales.MiFormGestionClientes.Show();
            }
        }

        private void EmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionEmpleados.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionEmpleados = new FrmGestionEmpleados();
                Locales.ObjetosGlobales.MiFormGestionEmpleados.Show();
            }
        }
        private void SalirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InformaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormInfo.Visible)
            {
                Locales.ObjetosGlobales.MiFormInfo = new FrmInformacion();
                Locales.ObjetosGlobales.MiFormInfo.Show();
            }
        }

    }
}
