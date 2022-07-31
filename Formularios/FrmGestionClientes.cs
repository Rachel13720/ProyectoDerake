﻿using ProyectoDerake.Lógica;
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

        //variables locales.
        private Cliente MiClienteLocal { get; set; }

        public DataTable ListaClientesNormal { get; set; }

        //Método que carga las variables locales en el constructor.
        public FrmGestionClientes()
        {
            InitializeComponent();

            MiClienteLocal = new Cliente();
        }

        //Método que agrega el cliente al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Cliente
        //Al agregar el cliente, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del cliente.
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se emplea este método para validar los campos
                //Se emplea un método para validar existencias
                //y así no existan datos repetidos
                //con los datos ingresados.
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
                            //Se emplea el método agregar de la clase
                            //Se emplea el método de limpiar el formulario
                            //Se emplea el método para llenar la lista con los clientes
                            //Se emplea el método para activar el botón de agregar.
                            if (MiCliente.Agregar())
                            {
                                MessageBox.Show("Cliente agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaClientes();
                                ActivarBtnAgregar();

                            }


                        }
                        else
                        {
                            //Se validan los textbox de nombre en caso
                            //de que ya existan estos datos registrados.
                            if (NombreExiste)
                            {
                                MessageBox.Show("El Nombre ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtNombre.Focus();
                                TxtNombre.SelectAll();

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


        //Método que valida los campos del formulario.
        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtApellido.Text.Trim()))
                {
                    R = true;
                }
                else
                {
                    MessageBox.Show("Hay campos vacíos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return R;
        }

        //Método que carga los métodos del formulario
        //Evento que llena la lista de clientes
        //Activa el botón de agregar 
        //Limpia el formulario.
        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();

            LimpiarFormulario();

            ActivarBtnAgregar();
        }


        //Llena la lista con los datos del usuario.
        private void LlenarListaClientes()
        {
            //se llama la clase empleado para manipular los datos.
            Cliente MiCliente = new Cliente();
            try
            {
                ListaClientesNormal = MiCliente.ListarTodos();

                DgvListaClientes.DataSource = ListaClientesNormal;

                DgvListaClientes.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite limpiar los campos del formulario.
        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            TxtApellido.Clear();

        }

        //Activa el botón de agregar
        //Desactiva los botones de eliminar
        //y editar.
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

        }

        //Activa solo los botones de editar y eliminar
        //Desactiva el botón de agregar.
        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }

        //Método que permite editar los datos del cliente
        //Se emplea el método de consulta por Id de la clase
        //de cliente para poder editar sus datos
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del cliente
        //Se emplea el método para activar el botón de agregar.
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    Cliente MiCliente = new Cliente();

                    DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                    MiCliente.IDCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

                    MiCliente.Nombre = TxtNombre.Text.Trim();
                    MiCliente.Apellido = TxtApellido.Text.Trim();
                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();

                    if (MiCliente.ConsultarPorID())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiCliente.Editar())
                        {
                            MessageBox.Show("Cliente modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaClientes();
                            ActivarBtnAgregar();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que permite eliminar los datos del cliente
        //Se emplea el método de consulta por Id de la clase
        //de cliente para poder eliminar sus datos.
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del cliente
        //Se emplea el método para activar el botón de agregar.
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Cliente MiCliente = new Cliente();

            DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

            MiCliente.IDCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

            try
            {
                if (MiCliente.ConsultarPorID())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiCliente.Desactivar())
                    {
                        MessageBox.Show("Cliente eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        ActivarBtnAgregar();
                        LlenarListaClientes();
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
            ActivarBtnAgregar();
            DgvListaClientes.ClearSelection();
        }

        //Método que permite salir del formulario.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que permite seleccionar una fila del datagridview
        //Se emplea el método de activar el botón editar y eliminar.
        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite solo letras 
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        //Método que permite solo letras 
        //en el textbox de nombre.
        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        //Método que permite solo letras y números
        //en el textbox de dirección.
        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        //Método que permite solo números 
        //en el textbox de teléfono.
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }
    }
}
