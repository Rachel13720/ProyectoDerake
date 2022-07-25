using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class ProductoCategoria
    {
        //Atributos
        public int IDProductoCategoria { get; set; }

        public string MiCategoria { get; set; }

        //Metodos
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPProductoCategoriaListar");

            return R;
        }
    }
}
