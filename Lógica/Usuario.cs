using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDerake.Lógica
{
    public class Usuario
    {

        //Atributos
        public int IDUsuario { get; set; }
        
        public string Nombre { get; set; }

        public string Contrasennia { get; set; }

        //Composición
        public UsuarioRol Rol { get; set; }

        //Constructor
        public Usuario()
        {
            Rol = new UsuarioRol();
        }

        //Metodos
        public bool Agregar()
        {
            bool R = false;

            //codigo permite agregar usuario
            //en la base datos

            try
            {
                Conexion MiCnn = new Conexion();

                Crypto MiEncriptador = new Crypto();

                //Lista de parametros que lleva al SP
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                string MiPasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", MiPasswordEncriptado));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdRol", this.Rol.IDUsuarioRol));
                
                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioAgregar");

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

        public bool Editar()
        {
            bool R = false;

            //codigo permite editar usuario
            //en la base datos

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegaran al SP
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDUsuario));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                Crypto MiEncriptador = new Crypto();
                string PasswordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasennia))
                {
                    PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
                }

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", PasswordEncriptado));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdRol", this.Rol.IDUsuarioRol));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEditar");


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

        public bool Desactivar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegaran al SP
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDUsuario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEliminar");

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

        public Usuario Consultar(int pIDUsuario)
        {
            Usuario R = new Usuario();

            //esta funcion retorna un objeto de tipo usuario con la data correspondiente
            //para el ID suministrado a traves del parametro.

            Conexion MyCnn = new Conexion();

            //se debe agregar un para,etro que pueda llegar al SP con el valor del ID del Usuario
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", pIDUsuario));

            DataTable DatosUsuario = new DataTable();
            DatosUsuario = MyCnn.DMLSelect("SPUsuarioConsultar");

            //se evalua que el DT tenga datos y se asignan al objeto de retorno R
            if (DatosUsuario.Rows.Count > 0)
            {
                //si se evalua correctamente quiere decir que si existe un usuario con el ID
                //proporcionado, se procede a extraer los datos e ingresarlos en los atributos del 
                //objeto que sera retornado

                DataRow MiFila = DatosUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(MiFila["IDUsuario"]);

                R.Nombre = Convert.ToString(MiFila["Nombre"]);

                R.Contrasennia = Convert.ToString(MiFila["Contrasennia"]);

                R.Rol.IDUsuarioRol = Convert.ToInt32(MiFila["IDUsuarioRol"]);
                R.Rol.Rol = Convert.ToString(MiFila["Rol"]);

            }

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDUsuario));

                DataTable retorno = MiConexion.DMLSelect("SPUsuarioConsultarPorID");

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


        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPUsuariosListarTodos");

            return R;
        }


        public int ValidarLogin(string pUsuario, string pPass)
        {
            int R = 0;

            this.Nombre = pUsuario;
            this.Contrasennia = pPass;

            Crypto MiEncriptador = new Crypto();

            string PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@User", this.Nombre));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", PasswordEncriptado));

            DataTable Respuesta = MiCnn.DMLSelect("SPUsuarioValidarLogin");

            if (Respuesta != null && Respuesta.Rows.Count > 0)
            {
                DataRow MiFila = Respuesta.Rows[0];

                R = Convert.ToInt32(MiFila["IDUsuario"]);
            }

            return R;
        }
    }
}
