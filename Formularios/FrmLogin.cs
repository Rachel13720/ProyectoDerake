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


        //Método que permite ingresar al sistema
        //valida los campos de texto según los datos 
        //que se encuentra en la base de datos
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida el usuario y su contraseña,
                //que no esten vacíos los campos
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

                    }//En caso contrario muestra un mensaje
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

        //Método que permite ver la contraseña al presionar el botón
        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        //Método que no permite ver la contraseña al soltar el botón
        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        //Método que permite letras y números en campo de texto de usuario
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        //Método que permite salir del sistema al presionar el
        //botón con ícono de apagado
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
