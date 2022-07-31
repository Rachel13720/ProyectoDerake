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
    public partial class FrmGestionProductos : Form
    {
        //variables locales
        public DataTable ListaProductos { get; set; }

        private Producto MiProducto { get; set; }

        //Método que carga las variables locales en el constructor
        public FrmGestionProductos()
        {
            InitializeComponent();
            MiProducto = new Producto();
            ListaProductos = new DataTable();
        }



        //Método que carga los datos de la categoria
        //en el combo.
        private void CargaDatosComboTipoCategoria()
        {
            ProductoCategoria MiCategoria = new ProductoCategoria();

            DataTable datos = new DataTable();

            datos = MiCategoria.Listar();

            CboxTipoCategoria.ValueMember = "ID";

            CboxTipoCategoria.DisplayMember = "Categoria";

            CboxTipoCategoria.DataSource = datos;

            CboxTipoCategoria.SelectedIndex = -1;

        }

        //Método que carga los métodos del formulario
        //Evento que llena la lista de productos
        //Carga los datos del combo de categoria
        //Activa el botón de agregar 
        //Limpia el formulario.
        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            CargaDatosComboTipoCategoria();

            LlenarListaProductos();

            LimpiarFormulario();

            ActivarBotonAgregar();
        }

        //Método que agrega el producto al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Producto
        //Al agregar el producto, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del producto.
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

                    DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo producto?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                    if (Respuesta == DialogResult.Yes)
                    {
                        MiProducto.Nombre = TxtNombre.Text.Trim();
                        MiProducto.Cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
                        MiProducto.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                        MiProducto.Comentario = TxtComentario.Text.Trim();
                        MiProducto.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);

                        bool NombreExiste = MiProducto.ConsultarPorNombre();

                        if (!NombreExiste)
                        {
                            //Se emplea el método agregar de la clase
                            //Se emplea el método de limpiar el formulario
                            //Se emplea el método para llenar la lista con los productos
                            //Se emplea el método para activar el botón de agregar. 
                            if (MiProducto.Agregar())
                            {
                                MessageBox.Show("Producto agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaProductos();
                                ActivarBotonAgregar();

                            }

                        }
                        else
                        {
                            //Se validan el nombre del producto en caso
                            //de que ya existan estos datos registrados.
                            if (NombreExiste)
                            {
                                MessageBox.Show("El nombre ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    !string.IsNullOrEmpty(TxtCantidad.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtComentario.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                    DgvListaProductos.Rows.Count < 1 &&
                    CboxTipoCategoria.SelectedIndex > -1)
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


        //Método que permite limpiar los campos del formulario.
        private void LimpiarFormulario()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtComentario.Clear();
            CboxTipoCategoria.SelectedIndex = -1;

        }

        //Activa solo los botones de editar y eliminar
        //Desactiva el botón de agregar
        //Inhabilita el textbox del identificador.
        private void ActivarModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCodigo.Enabled = false;
        }

        //Activa el botón de agregar
        //Desactiva los botones de eliminar
        //y editar
        //Inhabilita el textbox del identificador.
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCodigo.Enabled = false;
        }


        //Llena la lista con los datos del producto.
        private void LlenarListaProductos()
        {
            ListaProductos = MiProducto.ListarEnDetalle();

            DgvListaProductos.DataSource = ListaProductos;

            DgvListaProductos.ClearSelection();

        }

        //Método que permite editar los datos del producto
        //Se emplea el método de consulta por Id de la clase
        //de producto para poder editar sus datos
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del producto
        //Se emplea el método para activar el botón de agregar.
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    Producto MiProducto = new Producto();


                    DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];

                    MiProducto.IDProducto = Convert.ToInt32(MiFila.Cells["IDProducto"].Value);

                    MiProducto.Nombre = TxtNombre.Text.Trim();
                    MiProducto.Cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
                    MiProducto.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                    MiProducto.Comentario = TxtComentario.Text.Trim();
                    MiProducto.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);

                    if (MiProducto.ConsultarPorID())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiProducto.Editar())
                        {
                            MessageBox.Show("Producto modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            ActivarBotonAgregar();
                            LlenarListaProductos();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite eliminar los datos del producto
        //Se emplea el método de consulta por Id de la clase
        //de producto para poder eliminar sus datos.
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del producto
        //Se emplea el método para activar el botón de agregar.
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Producto MiProducto = new Producto();

            DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];

            MiProducto.IDProducto = Convert.ToInt32(MiFila.Cells["IDProducto"].Value);

            try
            {
                if (MiProducto.ConsultarPorID())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiProducto.Desactivar())
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                        LlenarListaProductos();
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
            DgvListaProductos.ClearSelection();
        }

        //Método que permite salir del formulario.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que permite seleccionar una fila del datagridview
        //Se emplea el método de activar el botón editar y eliminar.
        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaProductos.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];


                    TxtCodigo.Text = Convert.ToString(MiFila.Cells["IDProducto"].Value);
                    TxtNombre.Text = Convert.ToString(MiFila.Cells["Nombre"].Value);
                    TxtComentario.Text = Convert.ToString(MiFila.Cells["Comentario"].Value);
                    TxtCantidad.Text = Convert.ToString(MiFila.Cells["Cantidad"].Value);
                    TxtPrecio.Text = Convert.ToString(MiFila.Cells["Precio"].Value);

                    foreach (DataRowView data in CboxTipoCategoria.Items)
                    {
                        if (data.Row[1].ToString().Equals(MiFila.Cells["Categoria"].Value))
                        {
                            CboxTipoCategoria.SelectedValue = data.Row[0];
                        }
                    }

                    ActivarModificarYEliminar();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que permite solo números 
        //en el textbox de cantidad.
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //Método que permite solo números 
        //en el textbox de precio.
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //Método que permite solo letras
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        //Método que permite letras y números 
        //en el textbox de comentario.
        private void TxtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }

    }
}
