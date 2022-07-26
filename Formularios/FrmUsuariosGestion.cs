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

        public bool FlagCambiarContrasennia { get; set; }

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

            //valida los datos de la busqueda
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                 CbTipoRol.SelectedIndex > -1)
            {
                //Si hay datos de busqueda
                DgvListaUsuarios.DataSource = ListaUsuariosNormal;

            }
            else
            {
                //listado normal
                ListaUsuariosNormal = MiUsuario.ListarTodos();
                DgvListaUsuarios.DataSource = ListaUsuariosNormal;

            }

            //X
            DgvListaUsuarios.ClearSelection();
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

            FlagCambiarContrasennia = false;
        }

        //valida los datos
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) && 
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                 CbTipoRol.SelectedIndex > -1)
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtPassword1.Text.Trim()))
                    {
                        R = true;
                    }
                }

                //Se utiliza la herramienta para validar el email
                if (Herramientas.ValidarEmail(TxtEmail.Text.Trim()))
                {
                    //Se utiliza la herramienta para validar la contraseña
                    if (Herramientas.ValidarPass(TxtPassword1.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña inválida", "Aviso del Sistema", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Email invalido", "Aviso del Sistema", MessageBoxButtons.OK);
                }

                return R;
            }

            return R;
        }

        //boton que agrega
        private void BtnAgregar_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaUsuarios();
                            ActivarBotonAgregar();

                        }


                    }
                    else //valida que los datos ya existen
                    {
                        if (CedulaExiste)
                        {
                            MessageBox.Show("La Cedula ya esta siendo usada", ":(", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();

                        }
                        else if (EmailExiste)
                        {
                            MessageBox.Show("El Email ya esta siendo usada", ":(", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();

                        }

                    }

                }

            }
        }


        //valida el email
        private bool ValidarEmail()
        {
            bool r = false;

            if (Herramientas.ValidarEmail(TxtEmail.Text.Trim()))
            {

                r = true;

            }
            else
            {

                MessageBox.Show("El email no es válido", ":(", MessageBoxButtons.OK);

            }
            return r;
        }

        //valida la contraseña
        private bool ValidarContrasennia()
        {
            bool r = false;

            if (Herramientas.ValidarPass(TxtPassword1.Text.Trim()))
            {

                r = true;

            }
            else
            {

                MessageBox.Show("La contraseña es válida", ":)", MessageBoxButtons.OK);

            }
            return r;
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


        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
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
            }

        }

    //boton que edita los datos
    private void BtnEditar_Click(object sender, EventArgs e)
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

                //valida el cambio de la contraseña 
                if (FlagCambiarContrasennia)
                {
                    Miusuario.Contrasennia = TxtPassword1.Text.Trim();
                }

                Miusuario.Rol.IDUsuarioRol = Convert.ToInt32(CbTipoRol.SelectedValue);

                if (Miusuario.ConsultarPorID())
                {
                    //Edita los datos
                    if (Miusuario.Editar())
                    {
                        MessageBox.Show("Usuario modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios();
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        //boton que elimina los datos
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Usuario Miusuario = new Usuario();

            Miusuario.IDUsuario = Convert.ToInt32(TxtID.Text.Trim());

            if (Miusuario.ConsultarPorID())
            {
                //desactiva los datos
                if (Miusuario.Desactivar())
                {
                        MessageBox.Show("Usuario eliminado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                }
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
