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
    public partial class FrmGestionEmpleados : Form
    {
        //Variables locales.
        private Empleado MiEmpleadoLocal { get; set; }

        public DataTable ListaEmpleadosNormal { get; set; }

        //Método que carga las variables locales en el constructor.
        public FrmGestionEmpleados()
        {
            InitializeComponent();
            ListaEmpleadosNormal = new DataTable();
            MiEmpleadoLocal = new Empleado();
        }

        //Método que agrega el empleado al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Empleado
        //Al agregar el empleado, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del empleado.
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

                    DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo empleado?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                    if (Respuesta == DialogResult.Yes)
                    {

                        Empleado MiEmpleado = new Empleado();

                        MiEmpleado.Nombre = TxtNombre.Text.Trim();
                        MiEmpleado.Apellido = TxtApellido.Text.Trim();
                        MiEmpleado.HorasTrabajadas = Convert.ToInt32(TxtHoras.Text.Trim());
                        MiEmpleado.Salario = Convert.ToInt32(TxtSalario.Text.Trim());

                        bool NombreExiste = MiEmpleado.ConsultarPorNombre();


                        if (!NombreExiste)
                        {
                            //Se emplea el método agregar de la clase
                            //Se emplea el método de limpiar el formulario
                            //Se emplea el método para llenar la lista con los empleados
                            //Se emplea el método para activar el botón de agregar.
                            if (MiEmpleado.Agregar())
                            {
                                MessageBox.Show("Empleado agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaEmpleados();
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
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }

            return R;
        }

        //Llena la lista con los datos del usuario.
        private void LlenarListaEmpleados()
        {
            //se llama la clase empleado para manipular los datos.
            Empleado MiEmpleado = new Empleado();
            try
            {
                ListaEmpleadosNormal = MiEmpleado.ListarTodos();

                DgvListaEmpleados.DataSource = ListaEmpleadosNormal;

                DgvListaEmpleados.ClearSelection();
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
            TxtApellido.Clear();
            TxtHoras.Clear();
            TxtPago.Clear();
            TxtSalario.Clear();

        }

        //Activa el botón de agregar
        //Desactiva los botones de eliminar
        //y editar
        //Inhabilita el textbox del salario.
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtSalario.Enabled = false;

        }

        //Activa solo los botones de editar y eliminar
        //Desactiva el botón de agregar
        //Inhabilita el textbox del salario.
        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtSalario.Enabled = false;

        }

        //Método que permite solo letras
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        //Método que permite solo letras
        //en el textbox de apellido.
        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        //Método que permite editar los datos del empleado
        //Se emplea el método de consulta por Id de la clase
        //de empleado para poder editar sus datos
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del empleado
        //Se emplea el método para activar el botón de agregar.
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    Empleado MiEmpleado = new Empleado();

                    DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

                    MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);

                    MiEmpleado.Nombre = TxtNombre.Text.Trim();
                    MiEmpleado.Apellido = TxtApellido.Text.Trim();
                    MiEmpleado.HorasTrabajadas = Convert.ToInt32(TxtHoras.Text.Trim());
                    MiEmpleado.Salario = Convert.ToInt32(TxtSalario.Text.Trim());

                    if (MiEmpleado.ConsultarPorID())
                    {

                        //Se emplea el método editar de la clase.
                        if (MiEmpleado.Editar())
                        {
                            MessageBox.Show("Empleado modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaEmpleados();
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

        //Método que permite eliminar los datos del empleado
        //Se emplea el método de consulta por Id de la clase
        //de empleado para poder eliminar sus datos.
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del empleado
        //Se emplea el método para activar el botón de agregar.
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Empleado MiEmpleado = new Empleado();

            DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

            MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);
            try
            {
                if (MiEmpleado.ConsultarPorID())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiEmpleado.Desactivar())
                    {
                        MessageBox.Show("Empleado eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        ActivarBtnAgregar();
                        LlenarListaEmpleados();
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
            DgvListaEmpleados.ClearSelection();
        }

        //Método que permite salir del formulario.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que carga los métodos del formulario
        //Evento que llena la lista de empleados
        //Activa el botón de agregar 
        //Limpia el formulario.
        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            LlenarListaEmpleados();

            LimpiarFormulario();

            ActivarBtnAgregar();
        }

        //Método que permite seleccionar una fila del datagridview
        //Se emplea el método de activar el botón editar y eliminar.
        private void DgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaEmpleados.SelectedRows.Count == 1)
                {
                    DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

                    int IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);

                    MiEmpleadoLocal = new Empleado();

                    MiEmpleadoLocal = MiEmpleadoLocal.Consultar(IDEmpleado);

                    TxtNombre.Text = Convert.ToString(MiFila.Cells["Nombre"].Value);
                    TxtApellido.Text = Convert.ToString(MiFila.Cells["Apellido"].Value);
                    TxtHoras.Text = Convert.ToString(MiFila.Cells["HorasTrabajadas"].Value);
                    TxtSalario.Text = Convert.ToString(MiFila.Cells["Salario"].Value);

                    ActivarBtnModificarYEliminar();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite calcular el salario de los empleados
        //multiplica las horas por el pago. 
        private void Calcular()
        {

            double ht, ph, sal;

            try
            {
                ht = Convert.ToDouble(TxtHoras.Text.Trim());
                ph = Convert.ToDouble(TxtPago.Text.Trim());

                sal = ht * ph;

                TxtSalario.Text = sal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //Método que permite solo números 
        //en el textbox de horas.
        private void TxtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);

        }

        //Método que permite solo números 
        //en el textbox de pago.
        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);

        }

        //Método que permite llamar el método de calcular y
        //realizar el calculo al escribir en el campo de texto.
        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtHoras.Text) && !string.IsNullOrWhiteSpace(TxtPago.Text))
            {
                Calcular();
            }
        }

        //Método que permite llamar el método de calcular y
        //realizar el calculo al escribir en el campo de texto.
        private void TxtHoras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtHoras.Text) && !string.IsNullOrWhiteSpace(TxtPago.Text))
            {
                Calcular();
            }
        }
    }
}
