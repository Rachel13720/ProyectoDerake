using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class Cliente
    {
        //Atributos
        public int IDCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        //Constructor
        public Cliente()
        {

        }

        //Metodos

        //agrega los datos del clientes en la BD
        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteAgregar");

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

        //Edita los datos del cliente en la BD
        public bool Editar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.IDCliente));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteEditar");

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

        //Desactiva los datos del cliente en la BD
        public bool Desactivar()
        {
            bool R = false;
            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.IDCliente));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteDesactivar");

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


        //Consulta los datos del cliente por el ID, en la BD
        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.IDCliente));

                DataTable retorno = MiConexion.DMLSelect("SPClienteConsultarPorID");

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

        //Consula los datos del cliente por la cedula, en la BD
        public bool ConsultarPorNombre()
        {
            bool R = false;
            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                DataTable retorno = MiConexion.DMLSelect("SPClienteConsultarPorNombre");

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


        //Lista los datos del cliente en la BD
        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPClientesListarTodos");

            return R;
        }

        ////Consula los datos del cliente en la BD
        public Cliente Consultar(int pIDCliente)
        {
            Cliente R = new Cliente();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", pIDCliente));

            DataTable DatosCliente = new DataTable();
            DatosCliente = MyCnn.DMLSelect("SPClienteConsultar");

            //Valida los datos del cliente
            if (DatosCliente.Rows.Count > 0)
            {

                DataRow MiFila = DatosCliente.Rows[0];

                R.IDCliente = Convert.ToInt32(MiFila["IDCliente"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Apellido = Convert.ToString(MiFila["Apellido"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);

            }

            return R;
        }


    }
}
