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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //valida el usuario y su contraseña
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string u = TxtUsuario.Text.Trim();
                string p = TxtContrasennia.Text.Trim();

                Lógica.Usuario MiUsuario = new Lógica.Usuario();

                int IdUsuarioValidado = MiUsuario.ValidarLogin(u, p);

                //si los datos del usuario son correctos ingresa al formulario principal
                if (IdUsuarioValidado > 0)
                {
                    Locales.ObjetosGlobales.MiUsuarioGlobal = MiUsuario.Consultar(IdUsuarioValidado);

                    Locales.ObjetosGlobales.MiFormPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son incorrectos", ":(", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }

            }
        }

    private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
    
}
