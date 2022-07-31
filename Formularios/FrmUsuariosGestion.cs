using ProyectoDerake.Lógica;
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
    public partial class FrmUsuariosGestion : Form
    {
        //variables locales.
        private Usuario MiUsuario { get; set; }

        public DataTable ListaUsuariosNormal { get; set; }

        public int AdminU { get; set; }

        //Método que carga las variables locales en el constructor.
        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuario = new Usuario();
            ListaUsuariosNormal = new DataTable();
        }


        //Método que carga los métodos del formulario
        //Evento que llena la lista de usuarios
        //Carga los datos del combo de rol
        //Activa el botón de agregar 
        //Limpia el formulario.
        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            CargaDatosComboTipoRol();

            LimpiarFormulario();

            ActivarBotonAgregar();


        }


        //Llena la lista con los datos del usuario.
        private void LlenarListaUsuarios()
        {
            //se llama la clase usuario para manipular los datos.
            Usuario MiUsuario = new Usuario();
            try
            {
                ListaUsuariosNormal = MiUsuario.ListarTodos();

                DgvListaUsuarios.DataSource = ListaUsuariosNormal;

                DgvListaUsuarios.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Método que carga los datos del rol
        //en el combo.
        private void CargaDatosComboTipoRol()
        {

            UsuarioRol MiUsuarioRol = new UsuarioRol();

            DataTable datos = new DataTable();

            datos = MiUsuarioRol.Listar();

            CbTipoRol.ValueMember = "ID";

            CbTipoRol.DisplayMember = "Descripcion";

            CbTipoRol.DataSource = datos;

            CbTipoRol.SelectedIndex = -1;

        }


        //Método que permite limpiar los campos del formulario.
        private void LimpiarFormulario()
        {

            TxtID.Clear();
            TxtCedula.Clear();
            TxtNombre.Clear();
            CbTipoRol.SelectedIndex = -1;

            TxtEmail.Clear();
            TxtPassword1.Clear();

        }

        //Método que valida los campos del formulario.
        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPassword1.Text.Trim()) &&
                     CbTipoRol.SelectedIndex > -1 &&
                     Herramientas.ValidarEmail(TxtEmail.Text.Trim()) == true ||
                     Herramientas.ValidarPass(TxtPassword1.Text.Trim()) == true)
                {
                    R = true;
                }
                else
                {
                    MessageBox.Show("Hay un campo vacío o un dato incorrecto, verifique que la contraseña y/o el email sean válidos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return R;
        }

        //Método que agrega el usuario al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Usuario
        //Al agregar el usuario, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del usuario.
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se emplea este método para validar los campos
                //Se emplean dos métodos para validar existencias
                //y así no existan datos repetidos
                //con los datos ingresados.
                if (ValidarDatosRequeridos())
                {
                    DialogResult RespuestaUsuario = MessageBox.Show("¿Esta seguro de agregar el nuevo usuario?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                    if (RespuestaUsuario == DialogResult.Yes)
                    {

                        Usuario Miusuario = new Usuario();

                        Miusuario.Cedula = TxtCedula.Text.Trim();
                        Miusuario.Nombre = TxtNombre.Text.Trim();

                        Miusuario.Email = TxtEmail.Text.Trim();

                        Miusuario.Contrasennia = TxtPassword1.Text.Trim();
                        Miusuario.Rol.IDUsuarioRol = Convert.ToInt32(CbTipoRol.SelectedValue);

                        bool CedulaExiste = Miusuario.ConsultarPorCedula();

                        bool EmailExiste = Miusuario.ConsultarPorEmail();

                        if (!CedulaExiste && !EmailExiste)
                        {

                            //Se emplea el método agregar de la clase
                            //Se emplea el método de limpiar el formulario
                            //Se emplea el método para llenar la lista con los usuarios
                            //Se emplea el método para activar el botón de agregar.
                            if (Miusuario.Agregar())
                            {
                                MessageBox.Show("Usuario agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaUsuarios();
                                ActivarBotonAgregar();

                            }


                        }
                        else //Se validan los textbox de cédula e email en caso
                             //de que ya existan estos datos registrados.
                        {
                            if (CedulaExiste)
                            {
                                MessageBox.Show("La Cedula ya esta siendo usada", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCedula.Focus();
                                TxtCedula.SelectAll();

                            }
                            else if (EmailExiste)
                            {
                                MessageBox.Show("El Email ya esta siendo usada", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtEmail.Focus();
                                TxtEmail.SelectAll();

                            }

                        }

                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Activa el botón de agregar
        //Desactiva los botones de eliminar
        //y editar
        //Inhabilita el textbox del identificador
        //Habilita el textbox de contraseña y cédula
        //y el combo de rol.
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtID.Enabled = false;
            TxtCedula.Enabled = true;
            TxtPassword1.Enabled = true;
            CbTipoRol.Enabled = true;
        }

        //Activa solo los botones de editar y eliminar
        //Desactiva el botón de agregar
        //Inhabilita el textbox del identificador,
        //de contraseña, de cédula y del combo de rol.
        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtID.Enabled = false;
            TxtCedula.Enabled = false;
            TxtPassword1.Enabled = false;
            CbTipoRol.Enabled = false;
        }

        //Desactiva los botones de agregar, editar y eliminar
        ////Inhabilita el textbox del identificador,
        //de contraseña, de cédula y del combo de rol.
        private void DesactivarBotones()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtID.Enabled = false;
            TxtCedula.Enabled = false;
            TxtPassword1.Enabled = false;
            CbTipoRol.Enabled = false;
        }

        //Método que permite letras y números 
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }

        //Método que permite seleccionar una fila del datagridview
        //Se emplea el método de activar el botón editar y eliminar
        //En caso de ser el administrador, se emplea el método para
        //desactivar los botones agregar, desactivar y eliminar si 
        //selecciona la fila con el identificador del usuario principal.
        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaUsuarios.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                    TxtID.Text = Convert.ToString(MiFila.Cells["ColIDUsuario"].Value);
                    TxtNombre.Text = Convert.ToString(MiFila.Cells["ColNombre"].Value);
                    TxtCedula.Text = Convert.ToString(MiFila.Cells["Cedula"].Value);
                    TxtEmail.Text = Convert.ToString(MiFila.Cells["Email"].Value);

                    foreach (DataRowView data in CbTipoRol.Items)
                    {
                        if (data.Row[1].ToString().Equals(MiFila.Cells["Rol"].Value))
                        {
                            CbTipoRol.SelectedValue = data.Row[0];
                        }
                    }

                    ActivarEditarYEliminar();


                    AdminU = Convert.ToInt32(DgvListaUsuarios.SelectedRows[0].Cells["ColIDUsuario"].Value);

                    if (AdminU == 1)
                    {
                        DesactivarBotones();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que permite editar los datos del usuario
        //Se emplea el método de consulta por Id de la clase
        //de usuario para poder editar sus datos
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del usuario
        //Se emplea el método para activar el botón de agregar.
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    Usuario Miusuario = new Usuario();

                    Miusuario.IDUsuario = Convert.ToInt32(TxtID.Text.Trim());

                    Miusuario.Cedula = TxtCedula.Text.Trim();
                    Miusuario.Nombre = TxtNombre.Text.Trim();
                    Miusuario.Email = TxtEmail.Text.Trim();
                    Miusuario.Contrasennia = "";

                    Miusuario.Rol.IDUsuarioRol = Convert.ToInt32(CbTipoRol.SelectedValue);

                    if (Miusuario.ConsultarPorID())
                    {
                        //Se emplea el método editar de la clase.
                        if (Miusuario.Editar())
                        {
                            MessageBox.Show("Usuario modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaUsuarios();
                            ActivarBotonAgregar();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite eliminar los datos del usuario
        //Se emplea el método de consulta por Id de la clase
        //de usuario para poder eliminar sus datos.
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del usuario
        //Se emplea el método para activar el botón de agregar.
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario Miusuario = new Usuario();

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                MiUsuario.IDUsuario = Convert.ToInt32(MiFila.Cells["IDUsuario"].Value);

                if (Miusuario.ConsultarPorID())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (Miusuario.Desactivar())
                    {
                        MessageBox.Show("Usuario eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaUsuarios();
                        ActivarBotonAgregar();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite limpiar el formulario
        //Se emplea el método para activar el botón de agregar
        //Se limpia la fila seleccionada.
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvListaUsuarios.ClearSelection();
        }

        //Método que permite salir del formulario.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que permite solo números 
        //en el textbox de cédula.
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //Método que permite letras minúsculas y números 
        //en el textbox de email.
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
        }

    }
}
