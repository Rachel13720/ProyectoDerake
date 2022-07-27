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
        //variables globales
        public DataTable ListaProductos { get; set; }

        private Producto MiProducto { get; set; }

        public FrmGestionProductos()
        {
            InitializeComponent();

            MiProducto = new Producto();
        }



        //Carga los datos del Combobox
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

        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            CargaDatosComboTipoCategoria();

            LlenarListaProductos();

            LimpiarFormulario();

            ActivarBotonAgregar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try { 
            //valida los datos del producto
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo producto?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    Producto MiProducto = new Producto();

                    MiProducto.Nombre = TxtNombre.Text.Trim();
                    MiProducto.Cantidad = Convert.ToInt32(TxtCantidad.Text.Trim()); 
                    MiProducto.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                    MiProducto.Comentario = TxtComentario.Text.Trim();
                    MiProducto.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);

                    bool NombreExiste = MiProducto.ConsultarPorNombre();

                    if (!NombreExiste)
                    {
                        //se agrega el producto 
                        if (MiProducto.Agregar())
                        {
                            MessageBox.Show("Producto agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaProductos();
                            ActivarBotonAgregar();

                        }

                    }
                    else
                    {
                        //valida que los datos ya existen
                        if (NombreExiste)
                        {
                            MessageBox.Show("El nombre ya esta en uso", ":(", MessageBoxButtons.OK);
                            TxtNombre.Focus();
                            TxtNombre.SelectAll();

                        }

                    }

                }
            }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //valida los datos
        private bool ValidarDatosRequeridos()
        {
             
            bool R = false;
            try { 
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCantidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtComentario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                 CboxTipoCategoria.SelectedIndex > -1)
            {

                R = true;

            }
                return R;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //limpia el formulario
        private void LimpiarFormulario()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtComentario.Clear();
            CboxTipoCategoria.SelectedIndex = -1;

        }

        //activa solo los botones de modificar y eliminar
        private void ActivarModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCodigo.Enabled = false;
        }

        //activa solo el boton agregar
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCodigo.Enabled = false;
        }


        //Llena los datos de la lista
        private void LlenarListaProductos()
        {
            ListaProductos = MiProducto.ListarEnDetalle();

            DgvListaProductos.DataSource = ListaProductos;

            DgvListaProductos.ClearSelection();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try { 
            //valida los datos existentes y los modifica
            if (ValidarDatosRequeridos())
            {
                Producto MiProducto = new Producto();


                DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];

                MiProducto.IDProducto = Convert.ToInt32(MiFila.Cells["IDProducto"].Value);

                MiProducto.Nombre = TxtNombre.Text.Trim();
                MiProducto.Cantidad = Convert.ToInt32(MiFila.Cells["Cantidad"].Value);
                MiProducto.Precio = Convert.ToInt32(MiFila.Cells["Precio"].Value);
                MiProducto.Comentario = TxtComentario.Text.Trim();
                MiProducto.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);

                if (MiProducto.ConsultarPorID())
                {
                    //se editan los datos
                    if (MiProducto.Editar())
                    {
                        MessageBox.Show("Producto modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                        LlenarListaProductos();
                    }
                }
            }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
                Producto MiProducto = new Producto();

                DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];

                MiProducto.IDProducto = Convert.ToInt32(MiFila.Cells["IDProducto"].Value);

            try { 
                if (MiProducto.ConsultarPorID())
                {
                    //desactiva los datos 
                    if (MiProducto.Desactivar())
                    {
                        MessageBox.Show("Producto eliminado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                        LlenarListaProductos();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvListaProductos.ClearSelection();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
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
            catch (Exception ex)
            {
                throw;
            }

        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }
    }
}
