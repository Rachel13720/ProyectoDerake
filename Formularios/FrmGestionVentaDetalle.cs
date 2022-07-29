﻿using System;
using ProyectoDerake.Lógica;
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
    public partial class FrmGestionVentaDetalle : Form
    {
        //Variables gloables
        public DataTable ListaProductos { get; set; }

        public DataTable ListaProductosConFiltro { get; set; }

        public Producto MiProducto { get; set; }

        public Decimal ValorCan { get; set; }


        public FrmGestionVentaDetalle()
        {
            InitializeComponent();
            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();
            MiProducto = new Producto();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se evalua que haya una fila seleccionada en la lista y la cantidad sea mayor a cero
                if (DgvListaItems.SelectedRows.Count == 1 && NudCantidad.Value > 0) 
                {
                    //se valida que exista el producto
                    if (ValidarExistenciaProducto())
                    {

                        DataRow MiFila = Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.NewRow();

                        foreach (DataRow row in Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.Rows)
                        {
                            if (Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                                Convert.ToInt32(row["IDProducto"].ToString()))
                            {
                                MiFila["CantidadVendida"] = Convert.ToDecimal(row["CantidadVendida"]) + NudCantidad.Value;

                                this.DialogResult = DialogResult.OK;
                            }

                        }
                    } //se valida que no exista el producto
                    else if (!ValidarExistenciaProducto())
                    {
                        DataRow NuevaFila = Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.NewRow();

                        NuevaFila["IDProducto"] = Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value);

                        NuevaFila["Nombre"] = DgvListaItems.SelectedRows[0].Cells["CNombre"].Value.ToString();

                        NuevaFila["PrecioVenta"] = DgvListaItems.SelectedRows[0].Cells["CPrecio"].Value.ToString();

                        NuevaFila["CantidadVendida"] = NudCantidad.Value;

                        Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.Rows.Add(NuevaFila);

                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //se valida la existencia del producto con su Id
        private bool ValidarExistenciaProducto()
        {

            bool R = false;
            try
            {
                foreach (DataRow row in Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.Rows)
                {
                    if (Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                        Convert.ToInt32(row["IDProducto"].ToString()))
                    {
                        R = true;
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return R;

        }

        private void FrmGestionVentaDetalle_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        //llena los datos de la lista
        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnDetalle();

            DgvListaItems.DataSource = ListaProductos;

            DgvListaItems.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            ValorCan = Convert.ToDecimal(DgvListaItems.SelectedRows[0].Cells["CCantidad"].Value);

            NudCantidad.Maximum = ValorCan;
        }
    }
}
