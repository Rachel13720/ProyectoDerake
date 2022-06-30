using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class VentaDetalle
    {

        //Atributos
        public decimal CantidadVendida { get; set; }
        public decimal PrecioVenta { get; set; }
        public Producto MiProducto { get; set; }

        //Constructor

        public VentaDetalle()
        {
            MiProducto = new Producto();
        }
    }
}
