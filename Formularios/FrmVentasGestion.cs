using CrystalDecisions.CrystalReports.Engine;
using ProyectoDerake.Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDerake.Formularios
{
    public partial class FrmVentasGestion : Form
    {
        //Variables locales
        public Venta MiVenta { get; set; }

        public DataTable DtListaProductos { get; set; }

        //Método que carga las variables locales en el constructor
        public FrmVentasGestion()
        {
            InitializeComponent();

            MiVenta = new Venta();

            DtListaProductos = new DataTable();

        }

        //Método que muestra la lista de productos para agregarlos
        //al datagridview de la venta
        //agrega el total de la venta con la fórmula respectiva.
        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {

            Form FormBuscarItem = new FrmGestionVentaDetalle();

            DialogResult Resp = FormBuscarItem.ShowDialog();
            try
            {
                if (Resp == DialogResult.OK)
                {
                    DgvListaVentas.DataSource = DtListaProductos;

                    TxtTotal.Text = string.Format("{0:C2}", Totalizar());

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que permite calcular el total de la venta
        //multiplica la cantidad por el precio.
        private decimal Totalizar()
        {
            decimal R = 0;
            try
            {
                if (DtListaProductos.Rows.Count > 0)
                {
                    //Valida que existan datos en la lista.
                    foreach (DataRow item in DtListaProductos.Rows)
                    {
                        R += Convert.ToDecimal(item["CantidadVendida"]) * Convert.ToDecimal(item["PrecioVenta"]);

                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return R;

        }

        //Método que crea la venta y genera el reporte
        //Valida los campos de texto
        //Se emplea el método de agregar la venta
        //Al agregar la vent, se imprime el reporte
        //y se limpia el formulario.
        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //Se emplea este método para validar los campos
                //Se emplea un método para llenar el datagridview
                //con los datos ingresados.
                if (ValidarVenta())
                {
                    MiVenta.Fecha = DtpFecha.Value.Date;
                    MiVenta.MiCliente.IDCliente = Convert.ToInt32(CboxCliente.SelectedValue);
                    MiVenta.MiEmpleado.IDEmpleado = Convert.ToInt32(CboxEmpleado.SelectedValue);
                    MiVenta.MiUsuario.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                    MiVenta.NumeroFactura = Convert.ToInt32(TxtNumeroFactura.Text.Trim());
                    MiVenta.Comentario = TxtComentario.Text.Trim();

                    LlenarDetallesDeVenta();


                    //Se emplea el método agregar de la clase
                    //Llama el método imprimir, para generar el reporte.
                    if (MiVenta.Agregar())
                    {
                        MessageBox.Show("La venta se registro correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        ReportDocument MiReporteVenta = new ReportDocument();

                        MiReporteVenta = new Reportes.ReporteVenta();

                        MiReporteVenta = MiVenta.Imprimir(MiReporteVenta);

                        FrmVisualizadorReportes MiFormReport = new FrmVisualizadorReportes();

                        MiFormReport.CrvVisualizador.ReportSource = MiReporteVenta;
                        MiFormReport.Show();

                        //Se muestra el reporte.
                        MiFormReport.CrvVisualizador.Zoom(1);

                        Limpiar();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que valida los campos para realizar la venta. 
        private bool ValidarVenta()
        {

            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (DtpFecha.Value.Date <= DateTime.Now.Date &&
                    CboxCliente.SelectedIndex > -1 &&
                    CboxEmpleado.SelectedIndex > -1 &&
                    !string.IsNullOrEmpty(TxtNumeroFactura.Text.Trim()) &&
                    DtListaProductos.Rows.Count > 0)
                {
                    R = true;

                }
                else
                {
                    MessageBox.Show("Existen espacios sin texto, ingrese los datos restantes", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Se valida que la fecha no sea mayor a la actual.
                    if (DtpFecha.Value.Date > DateTime.Now.Date)
                    {
                        MessageBox.Show(@"La fecha de la factura no puede ser superior a la fecha actual", "Error de validacion", MessageBoxButtons.OK);

                        return false;
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return R;

        }


        //Llena la lista con los detalles de la venta.
        private void LlenarDetallesDeVenta()
        {
            try
            {
                //Valida las filas de la lista y agrega línea de detalle.
                foreach (DataRow fila in DtListaProductos.Rows)
                {
                    //se llama la clase venta detalle para manipular los datos.
                    VentaDetalle detalle = new VentaDetalle();

                    detalle.MiProducto.IDProducto = Convert.ToInt32(fila["IDProducto"]);
                    detalle.CantidadVendida = Convert.ToInt32(fila["CantidadVendida"]);
                    detalle.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);

                    detalle.MiProducto.Nombre = fila["Nombre"].ToString();

                    MiVenta.ListaDetalle.Add(detalle);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método que carga los métodos del formulario
        //Evento que carga el usuario a cargo del sistema
        //Carga los datos del combo de empleado y de cliente
        //Inhabilita el campo del total
        //Limpia el formulario.
        private void FrmVentasGestion_Load(object sender, EventArgs e)
        {
            LblMiUsuario.Text = "Venta registrada por " + Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            CargarDatosEmpleado();

            CargarDatosCliente();

            TxtTotal.Enabled = false;

            Limpiar();
        }


        //Método que permite limpiar los campos del formulario.
        private void Limpiar()
        {

            DtpFecha.Value = DateTime.Now.Date;

            TxtNumeroFactura.Clear();
            CboxCliente.SelectedIndex = -1;
            CboxEmpleado.SelectedIndex = -1;
            TxtComentario.Clear();
            TxtTotal.Clear();

            //cargar el esquema del datatable
            //este esquema no contiene datos, solo asigna la estructura
            //necesaria para el datatable
            //según el procedimiento almacenado proporcionado.

            DtListaProductos = MiVenta.AsignarEsquemaDetalle();

            DgvListaVentas.DataSource = DtListaProductos;

        }

        //Método que carga los datos del cliente
        //en el combo
        private void CargarDatosCliente()
        {
            Cliente ObjCliente = new Cliente();

            DataTable Datos = new DataTable();

            Datos = ObjCliente.ListarTodos();

            CboxCliente.ValueMember = "IDCliente";
            CboxCliente.DisplayMember = "Nombre";

            CboxCliente.DataSource = Datos;

            CboxCliente.SelectedIndex = -1;

        }

        //Método que carga los datos del empleado 
        //en el combo
        private void CargarDatosEmpleado()
        {
            Empleado ObjEmpleado = new Empleado();

            DataTable Datos = new DataTable();

            Datos = ObjEmpleado.ListarTodos();

            CboxEmpleado.ValueMember = "IDEmpleado";
            CboxEmpleado.DisplayMember = "Nombre";

            CboxEmpleado.DataSource = Datos;

            CboxEmpleado.SelectedIndex = -1;

        }

        //Método que permite eliminar la fila del datagridview
        //toma el identificador para poder eliminarlo
        //realiza los cambios en el datatable.
        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DtListaProductos.Rows.Count; i++)
                {
                    DataRow row = DtListaProductos.Rows[i];

                    if (Convert.ToInt32(DgvListaVentas.SelectedRows[0].Cells["CIDProducto"].Value) ==
                        Convert.ToInt32(row["IDProducto"].ToString()))
                    {
                        row.Delete();
                    }

                }

                DtListaProductos.AcceptChanges();
                DgvListaVentas.DataSource = DtListaProductos;
                TxtTotal.Clear();

                TxtTotal.Text = string.Format("{0:C2}", Totalizar());
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que permite solo números
        //en el textbox de Numero de factura.
        private void TxtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //Método que permite solo letras y números 
        //en el textbox de comentario.
        private void TxtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }
    }
}
