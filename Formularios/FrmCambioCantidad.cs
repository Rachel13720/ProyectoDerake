using System;
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
    public partial class FrmCambioCantidad : Form
    {

        public FrmCambioCantidad()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Locales.ObjetosGlobales.MiFormGestionVentas.DtListaProductos.Rows)
            {
                if (Convert.ToInt32(Locales.ObjetosGlobales.MiFormGestionVentas.DgvListaVentas.SelectedRows[0].Cells["CIDProducto"].Value) ==
                    Convert.ToInt32(row["IDProducto"].ToString()))
                {
                    row["CantidadVendida"] = NudCantidad.Value;

                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
