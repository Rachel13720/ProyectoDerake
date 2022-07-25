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
    public partial class FrmGestionClientes : Form
    {

        //variables globales
        private Cliente MiClienteLocal { get; set; }

        public DataTable ListaClientesNormal { get; set; }


        public FrmGestionClientes()
        {
            InitializeComponent();

            MiClienteLocal = new Cliente();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo cliente?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    Cliente MiCliente = new Cliente();

                    MiCliente.Nombre = TxtNombre.Text.Trim();
                    MiCliente.Apellido = TxtApellido.Text.Trim();
                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();

                    bool NombreExiste = MiCliente.ConsultarPorNombre();


                    if (!NombreExiste)
                    {
                        //agrega el cliente
                        if (MiCliente.Agregar())
                        {
                            MessageBox.Show("Cliente agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaClientes();
                            ActivarBtnAgregar();

                        }


                    }
                    else
                    {
                        //valida que los datos ya existen
                        if (NombreExiste)
                        {
                            MessageBox.Show("El Nombre ya esta en uso", ":(", MessageBoxButtons.OK);
                            TxtNombre.Focus();
                            TxtNombre.SelectAll();

                        }

                    }

                }
            }
        }


        //valida los datos del cliente
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtApellido.Text.Trim()))
            {
                R = true;
            }

            return R;
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();

            LimpiarFormulario();

            ActivarBtnAgregar();
        }


        //llena la lista con los datos del cliente
        private void LlenarListaClientes()
        {
            Cliente MiCliente = new Cliente();

            //valida los datos de la busqueda
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtApellido.Text.Trim()))
            {
                //Si hay datos de busqueda
                DgvListaClientes.DataSource = ListaClientesNormal;

            }
            else
            {
                //listado normal
                ListaClientesNormal = MiCliente.ListarTodos();
                DgvListaClientes.DataSource = ListaClientesNormal;

            }

            //X
            DgvListaClientes.ClearSelection();
        }

        //limpia los datos del cliente en el formulario
        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            TxtApellido.Clear();

        }

        //Activa solo el boton agregar
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

        }

        //Activa solo el boton modificar y eliminar
        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {
                Cliente MiCliente = new Cliente();

                DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                MiCliente.IDCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

                MiCliente.Nombre = TxtNombre.Text.Trim();
                MiCliente.Apellido = TxtApellido.Text.Trim();
                MiCliente.Telefono = TxtTelefono.Text.Trim();
                MiCliente.Direccion = TxtDireccion.Text.Trim();

                //consulta al cliente por su ID
                if (MiCliente.ConsultarPorID())
                {
                    //Edita al cliente
                    if (MiCliente.Editar())
                    {
                        MessageBox.Show("Cliente modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaClientes();
                        ActivarBtnAgregar();
                    }
                }
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Cliente MiCliente = new Cliente();

            DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

            MiCliente.IDCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

            if (MiCliente.ConsultarPorID())
            {
                //desactiva los datos
                if (MiCliente.Desactivar())
                {
                    MessageBox.Show("Cliente eliminado correctamente", ":)", MessageBoxButtons.OK);
                    LimpiarFormulario();
                    ActivarBtnAgregar();
                    LlenarListaClientes();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBtnAgregar();
            DgvListaClientes.ClearSelection();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //valida si se ha seleccionado una fila en el datagridview
            if (DgvListaClientes.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                int IDCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

                MiClienteLocal = new Cliente();

                MiClienteLocal = MiClienteLocal.Consultar(IDCliente);

                TxtNombre.Text = MiClienteLocal.Nombre;
                TxtApellido.Text = MiClienteLocal.Apellido;
                TxtTelefono.Text = MiClienteLocal.Telefono;
                TxtDireccion.Text = MiClienteLocal.Direccion;

                ActivarBtnModificarYEliminar();
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

    }
}
