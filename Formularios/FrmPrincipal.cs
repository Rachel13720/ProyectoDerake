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

        //Carga las opciones del menú según los permisos del usuario
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
                    //el administrador tiene acceso a todo
                    break;

                case 2:
                    //ocultamos las opciones de menu que no le corresponden al usuario 
                    //normal
                    //no muestra el botón de usuarios ni de ventas
                    BtnAcercaDe.Visible = true;
                    BtnUsuarios.Enabled = false;
                    BtnVentas.Enabled = false;

                    break;
                case 3:
                    //ocultamos las opciones de menu que no le corresponden al usuario 
                    //normal, por ser inactivo
                    //no muestra el botón de usuarios ni de ventas
                    BtnAcercaDe.Visible = true;
                    BtnUsuarios.Enabled = false;
                    BtnVentas.Enabled = false;

                    break;
            }
        }

        //Método que muestra el formulario de usuarios al presionar
        //el botón de usuarios
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionUsuarios.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionUsuarios = new FrmUsuariosGestion();
                Locales.ObjetosGlobales.MiFormGestionUsuarios.Show();
            }
        }

        //Método que muestra el formulario de productos al presionar
        //el botón de productos
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionProductos.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionProductos = new FrmGestionProductos();
                Locales.ObjetosGlobales.MiFormGestionProductos.Show();
            }
        }

        //Método que muestra el formulario de clientes al presionar
        //el botón de clientes
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionClientes.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionClientes = new FrmGestionClientes();
                Locales.ObjetosGlobales.MiFormGestionClientes.Show();
            }
        }

        //Método que muestra el formulario de clientes al presionar
        //el botón de clientes
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionEmpleados.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionEmpleados = new FrmGestionEmpleados();
                Locales.ObjetosGlobales.MiFormGestionEmpleados.Show();
            }
        }

        //Método que muestra el formulario de ventas al presionar
        //el botón de ventas
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionVentas.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionVentas = new FrmVentasGestion();
                Locales.ObjetosGlobales.MiFormGestionVentas.Show();
            }
        }

        //Método que muestra el formulario de información al presionar
        //el botón de información
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormInfo.Visible)
            {
                Locales.ObjetosGlobales.MiFormInfo = new FrmInformacion();
                Locales.ObjetosGlobales.MiFormInfo.Show();
            }
        }

        //Método que cierra la aplicación al presionar
        //el botón de salir
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
