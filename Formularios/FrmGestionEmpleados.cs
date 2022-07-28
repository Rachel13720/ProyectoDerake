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

        private Empleado MiEmpleadoLocal { get; set; }

        public DataTable ListaEmpleadosNormal { get; set; }

        public FrmGestionEmpleados()
        {
            InitializeComponent();

            MiEmpleadoLocal = new Empleado();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos del cliente
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
                            //agrega el cliente
                            if (MiEmpleado.Agregar())
                            {
                                MessageBox.Show("Empleado agregado correctamente", ":)", MessageBoxButtons.OK);

                                LimpiarFormulario();
                                LlenarListaEmpleados();
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
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //valida los datos del empleado
        private bool ValidarDatosRequeridos()
        {

            bool R = false;
            try
            {
                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtApellido.Text.Trim()))
                {
                    R = true;
                }
                else
                {
                    MessageBox.Show("Hay campos vacíos", ":(", MessageBoxButtons.OK);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }

            return R;
        }

        //llena la lista con los datos del empleado
        private void LlenarListaEmpleados()
        {

            Empleado MiEmpleado = new Empleado();
            try
            {
                //valida los datos de la busqueda
                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                     !string.IsNullOrEmpty(TxtApellido.Text.Trim()))
                {
                    //Si hay datos de busqueda
                    DgvListaEmpleados.DataSource = ListaEmpleadosNormal;

                }
                else
                {
                    //listado normal
                    ListaEmpleadosNormal = MiEmpleado.ListarTodos();
                    DgvListaEmpleados.DataSource = ListaEmpleadosNormal;

                }

                //X
                DgvListaEmpleados.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //limpia los datos del empleado en el formulario
        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtHoras.Clear();
            TxtPago.Clear();
            TxtSalario.Clear();

        }

        //Activa solo el boton agregar
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtSalario.Enabled = false;

        }

        //Activa solo el boton modificar y eliminar
        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtSalario.Enabled = false;

        }


        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos del cliente
                if (ValidarDatosRequeridos())
                {
                    Empleado MiEmpleado = new Empleado();

                    DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

                    MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);

                    MiEmpleado.Nombre = TxtNombre.Text.Trim();
                    MiEmpleado.Apellido = TxtApellido.Text.Trim();
                    MiEmpleado.HorasTrabajadas = Convert.ToInt32(TxtHoras.Text.Trim());
                    MiEmpleado.Salario = Convert.ToInt32(TxtSalario.Text.Trim());


                    //consulta al cliente por su ID
                    if (MiEmpleado.ConsultarPorID())
                    {
                        //Edita al cliente
                        if (MiEmpleado.Editar())
                        {
                            MessageBox.Show("Empleado modificado correctamente", ":)", MessageBoxButtons.OK);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Empleado MiEmpleado = new Empleado();

            DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

            MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);
            try
            {
                if (MiEmpleado.ConsultarPorID())
                {
                    //desactiva los datos
                    if (MiEmpleado.Desactivar())
                    {
                        MessageBox.Show("Empleado eliminado correctamente", ":)", MessageBoxButtons.OK);
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBtnAgregar();
            DgvListaEmpleados.ClearSelection();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            LlenarListaEmpleados();

            LimpiarFormulario();

            ActivarBtnAgregar();
        }

        private void DgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //valida si se ha seleccionado una fila en el datagridview
                if (DgvListaEmpleados.SelectedRows.Count == 1)
                {
                    LimpiarFormulario();

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



        private void TxtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);

        }

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);

        }

        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtHoras.Text) && !string.IsNullOrWhiteSpace(TxtPago.Text))
            {
                Calcular();
            }
        }

        private void TxtHoras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtHoras.Text) && !string.IsNullOrWhiteSpace(TxtPago.Text))
            {
                Calcular();
            }
        }
    }
}
