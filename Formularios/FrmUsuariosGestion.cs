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
        //variables locales

        private Usuario MiUsuario { get; set; }

        public DataTable ListaUsuariosNormal { get; set; }

        public int AdminU { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuario = new Usuario();
        }


        //Cargar los datos
        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            CargaDatosComboTipoRol();

            LimpiarFormulario();

            ActivarBotonAgregar();


        }


        //Llena la lista con los datos del usuario
        private void LlenarListaUsuarios()
        {
            //se llama la clase usuario para manipular los datos
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


        //Carga los datos del Combobox
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



        //Limpia los datos del formulario
        private void LimpiarFormulario()
        {

            TxtID.Clear();
            TxtCedula.Clear();
            TxtNombre.Clear();
            CbTipoRol.SelectedIndex = -1;

            TxtEmail.Clear();
            TxtPassword1.Clear();

        }

        //valida los datos
        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
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

        //boton que agrega
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos y que todos los campos esten llenos
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
                            //se agrega el usuario
                            if (Miusuario.Agregar())
                            {
                                MessageBox.Show("Usuario agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaUsuarios();
                                ActivarBotonAgregar();

                            }


                        }
                        else //valida que los datos ya existen
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


        //Activa el boton agregar
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

        //Activa solo los botones editar y eliminar
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


        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //valida que la fila esta seleccionada
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

        //boton que edita los datos
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos
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
                        //Edita los datos
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

        //boton que elimina los datos
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                Usuario Miusuario = new Usuario();

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                MiUsuario.IDUsuario = Convert.ToInt32(MiFila.Cells["IDUsuario"].Value);

                if (Miusuario.ConsultarPorID())
                {
                    //desactiva los datos
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

        //boton para limpiar los datos del formulario
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvListaUsuarios.ClearSelection();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCedula_Enter(object sender, EventArgs e)
        {
            //valida que la cedula exista, ya que es un dato requerido
            if (TxtCedula.Text == null)
            {
                TxtCedula.Clear();
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
        }

    }
}
