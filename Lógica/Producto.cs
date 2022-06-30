using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class Producto
    {

        //Atributos
        public int IDProducto { get; set; }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public string Comentario { get; set; }
        
        //Composición
        ProductoCategoria MiCategoria { get; set; }

        //Constructor
        public Producto()
        {
            MiCategoria = new ProductoCategoria();
        }

        //Metodos
    }
}
