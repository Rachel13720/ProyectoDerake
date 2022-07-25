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
        public Venta MiVenta { get; set; }

        public DataTable DtListaProductos { get; set; }

        public FrmVentasGestion()
        {
            InitializeComponent();

            MiVenta = new Venta();

            DtListaProductos = new DataTable();

        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            Form FormBuscarItem = new FrmGestionVentaDetalle();

            DialogResult Resp = FormBuscarItem.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                DgvListaVentas.DataSource = DtListaProductos;

                TxtTotal.Text = string.Format("{0:C2}", Totalizar());

            }
        }

        //metodo que totaliza la cantidad 
        private decimal Totalizar()
        {
            decimal R = 0;

            if (DtListaProductos.Rows.Count > 0)
            {
                //valida que existan datos en la lista
                foreach (DataRow item in DtListaProductos.Rows)
                {
                    R += Convert.ToDecimal(item["CantidadVendida"]) * Convert.ToDecimal(item["PrecioVenta"]);

                }

            }


            return R;

        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            //Valida los datos de la venta
            if (ValidarVenta())
            {
                MiVenta.Fecha = DtpFecha.Value.Date;
                MiVenta.MiCliente.IDCliente = Convert.ToInt32(CboxCliente.SelectedValue);
                MiVenta.MiEmpleado.IDEmpleado = Convert.ToInt32(CboxEmpleado.SelectedValue);
                MiVenta.MiUsuario.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                MiVenta.NumeroFactura = Convert.ToInt32(TxtNumeroFactura.Text.Trim());
                MiVenta.Comentario = TxtComentario.Text.Trim();

                LlenarDetallesDeVenta();

                //Agrega la venta y permite que se imprima el reporte
                if (MiVenta.Agregar())
                {
                    MessageBox.Show("La venta se registro correctamente", ":)", MessageBoxButtons.OK);

                    ReportDocument MiReporteVenta = new ReportDocument();

                    MiReporteVenta = new Reportes.ReporteVenta();

                    MiReporteVenta = MiVenta.Imprimir(MiReporteVenta);

                    FrmVisualizadorReportes MiFormReport = new FrmVisualizadorReportes();

                    MiFormReport.CrvVisualizador.ReportSource = MiReporteVenta;
                    MiFormReport.Show();

                    //Se visualiza el reporte
                    MiFormReport.CrvVisualizador.Zoom(1);


                    Limpiar();
                }
            }
        }

        //valida los datos, para realizar la venta
        private bool ValidarVenta()
        {

            bool R = false;

            if (DtpFecha.Value.Date <= DateTime.Now.Date
                && CboxCliente.SelectedIndex > -1 &&
                !string.IsNullOrEmpty(TxtNumeroFactura.Text.Trim()) &&
                DtListaProductos.Rows.Count > 0)
            {
                R = true;

            }
            else
            { //valida que la fecha no sea mayor a la actual
                if (DtpFecha.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show(@"La fecha de la factura no puede ser superior a la fecha actual", "Error de validacion", MessageBoxButtons.OK);

                    return false;
                }

                //Hace demas validaciones
                if (ValidarVenta())
                {

                    MiVenta.Fecha = DtpFecha.Value.Date;
                    MiVenta.MiCliente.IDCliente = Convert.ToInt32(CboxCliente.SelectedIndex);

                    MiVenta.MiUsuario.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                    MiVenta.NumeroFactura = Convert.ToInt32(TxtNumeroFactura.Text.Trim()); ;
                    MiVenta.Comentario = TxtComentario.Text.Trim();

                    LlenarDetallesDeVenta();

                    //Se agrega la venta y se realiza el reporte
                    if (MiVenta.Agregar())
                    {
                        MessageBox.Show("La venta se registro correctamente", ":)", MessageBoxButtons.OK);

                        //ReportDocument MiReporteVenta = new ReportDocument();

                        Limpiar();

                    }




                }

            }


            return R;


        }


        //Llena los datos de lista de detalles de la venta
        private void LlenarDetallesDeVenta()
        {
            //Valida las filas de la lista
            foreach (DataRow fila in DtListaProductos.Rows)
            {
                VentaDetalle detalle = new VentaDetalle();

                detalle.MiProducto.IDProducto = Convert.ToInt32(fila["IDProducto"]);
                detalle.CantidadVendida = Convert.ToInt32(fila["CantidadVendida"]);
                detalle.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);

                detalle.MiProducto.Nombre = fila["Nombre"].ToString();

                MiVenta.ListaDetalle.Add(detalle);

            }



        }


        private void BtnModificarItem_Click(object sender, EventArgs e)
        {
            Form FormCambio = new Formularios.FrmCambioCantidad();

            DialogResult Resp = FormCambio.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                DgvListaVentas.DataSource = DtListaProductos;
            }
        }

        private void FrmVentasGestion_Load(object sender, EventArgs e)
        {
            LblMiUsuario.Text = "Venta registrada por " + Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            CargarDatosEmpleado();

            CargarDatosCliente();

            TxtTotal.Enabled = false;

            Limpiar();
        }


        private void Limpiar()
        {
            DtpFecha.Value = DateTime.Now.Date;

            TxtNumeroFactura.Clear();
            CboxCliente.SelectedIndex = -1;
            CboxEmpleado.SelectedIndex = -1;
            TxtComentario.Clear();

            //cargar el esquema que debe tener el datatable
            //este esquema no tiene datos, solamente asigna la estructua adecuada al datatable
            //segun el SP proporcionado

            DtListaProductos = MiVenta.AsignarEsquemaDetalle();

            DgvListaVentas.DataSource = DtListaProductos;


        }

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

        private void CargarDatosEmpleado()
        {
            Cliente ObjCliente = new Cliente();

            DataTable Datos = new DataTable();

            Datos = ObjCliente.ListarTodos();

            CboxCliente.ValueMember = "IDCliente";
            CboxCliente.DisplayMember = "Nombre";

            CboxCliente.DataSource = Datos;

            CboxCliente.SelectedIndex = -1;

        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
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


            TxtTotal.Text = string.Format("{0:C2}", Totalizar());

        }
    }
}
