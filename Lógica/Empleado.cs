using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class Empleado
    {
        //Atributos
        public int IDEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int HorasTrabajadas { get; set; }

        public int Salario { get; set; }

        //Constructor
        public Empleado()
        {
            
        }

        //Metodos

        //agrega los datos del empleados en la BD
        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@HorasTrabajadas", this.HorasTrabajadas));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Salario", this.Salario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPEmpleadoAgregar");

                if (retorno > 0)
                {
                    R = true;
                }


            }
            catch (Exception)
            {

                throw;
            }


            return R;
        }

        //Edita los datos del empleado en la BD
        public bool Editar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdEmpleado", this.IDEmpleado));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@HorasTrabajadas", this.HorasTrabajadas));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Salario", this.Salario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPEmpleadoEditar");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }


            return R;
        }

        //Desactiva los datos del empleado en la BD
        public bool Desactivar()
        {
            bool R = false;
            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdEmpleado", this.IDEmpleado));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPEmpleadoDesactivar");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }


        //Consulta los datos del empleado por el ID, en la BD
        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdEmpleado", this.IDEmpleado));

                DataTable retorno = MiConexion.DMLSelect("SPEmpleadoConsultarPorID");

                if (retorno.Rows.Count > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return R;
        }

        //Consula los datos del empleado por la cedula, en la BD
        public bool ConsultarPorNombre()
        {
            bool R = false;
            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                DataTable retorno = MiConexion.DMLSelect("SPEmpleadoConsultarPorNombre");

                if (retorno.Rows.Count > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return R;
        }


        //Lista los datos del empleado en la BD
        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPEmpleadosListarTodos");

            return R;
        }

        ////Consula los datos del empleado en la BD
        public Empleado Consultar(int pIDEmpleado)
        {
            Empleado R = new Empleado();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdEmpleado", pIDEmpleado));

            DataTable DatosEmpleado = new DataTable();
            DatosEmpleado = MyCnn.DMLSelect("SPEmpleadoConsultar");

            //Valida los datos del empleado
            if (DatosEmpleado.Rows.Count > 0)
            {

                DataRow MiFila = DatosEmpleado.Rows[0];

                R.IDEmpleado = Convert.ToInt32(MiFila["IDEmpleado"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Apellido = Convert.ToString(MiFila["Apellido"]);
                R.HorasTrabajadas = Convert.ToInt32(MiFila["HorasTrabajadas"]);
                R.Salario = Convert.ToInt32(MiFila["Salario"]);

            }

            return R;
        }
    }
}
