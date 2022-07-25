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
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo empleado?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    Empleado MiEmpleado = new Empleado();

                    MiEmpleado.Nombre = TxtNombre.Text.Trim();
                    MiEmpleado.Apellido = TxtApellido.Text.Trim();

                    DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

                    MiEmpleado.HorasTrabajadas = Convert.ToInt32(MiFila.Cells["HorasTrabajadas"].Value);
                    MiEmpleado.Salario = Convert.ToInt32(MiFila.Cells["Salario"].Value);

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

        //valida los datos del empleado
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

        //llena la lista con los datos del empleado
        private void LlenarListaEmpleados()
        {
            Empleado MiEmpleado = new Empleado();

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
        //limpia los datos del empleado en el formulario
        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtHoras.Clear();

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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {
                Empleado MiEmpleado = new Empleado();

                DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

                MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);

                MiEmpleado.Nombre = TxtNombre.Text.Trim();
                MiEmpleado.Apellido = TxtApellido.Text.Trim();
                MiEmpleado.HorasTrabajadas = Convert.ToInt32(MiFila.Cells["HorasTrabajadas"].Value);
                MiEmpleado.Salario = Convert.ToInt32(MiFila.Cells["Salario"].Value);


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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Empleado MiEmpleado = new Empleado();

            DataGridViewRow MiFila = DgvListaEmpleados.SelectedRows[0];

            MiEmpleado.IDEmpleado = Convert.ToInt32(MiFila.Cells["IDEmpleado"].Value);

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
    }
}
