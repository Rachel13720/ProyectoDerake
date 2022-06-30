using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class Venta
    {
        //Atributos
        public int IDVenta { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroFactura { get; set; }

        public string Comentario { get; set; }
        
        //Composicion
        public List<VentaDetalle> ListaDetalle { get; set; }

        public Usuario MiUsuario { get; set; }

        public Cliente MiCliente { get; set; }

        public Empleado MiEmpleado { get; set; }

        //Constructor
        public Venta()
        {
            ListaDetalle = new List<VentaDetalle>();
            MiUsuario = new Usuario();
            MiCliente = new Cliente();
            MiEmpleado = new Empleado();
        }

        //Metodos


    }
}
