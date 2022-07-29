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
            try
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
                        MessageBox.Show("Usuario o contraseña son incorrectos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtContrasennia.Focus();
                        TxtContrasennia.SelectAll();
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
