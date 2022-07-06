using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{

    public class UsuarioRol
    {
        //Atributos
        public int IDUsuarioRol { get; set; }

        public string Rol { get; set; }

        //Métodos
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPUsuarioRolListar");

            return R;
        }

    }
}
