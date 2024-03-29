﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public ProductoCategoria MiCategoria { get; set; }

        //Constructor
        public Producto()
        {
            MiCategoria = new ProductoCategoria();
        }

        //Metodos

        //agrega los datos del producto en la BD
        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Precio", this.Precio));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Comentario", this.Comentario));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdCategoria", this.MiCategoria.IDProductoCategoria));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoAgregar");

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

        //edita los datos del producto en la BD
        public bool Editar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdProducto", this.IDProducto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Precio", this.Precio));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Comentario", this.Comentario));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdCategoria", this.MiCategoria.IDProductoCategoria));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoEditar");

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

        //Desactiva los datos del producto en la BD
        public bool Desactivar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdProducto", this.IDProducto));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoDesactivar");

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

        //Consulta los datos del producto en la BD
        public Producto Consultar(int pIDProducto)
        {
            Producto R = new Producto();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdProducto", pIDProducto));

            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.DMLSelect("SPProductoConsultar");

            if (DatosProducto.Rows.Count > 0)
            {

                DataRow MiFila = DatosProducto.Rows[0];

                R.IDProducto = Convert.ToInt32(MiFila["IDProducto"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Cantidad = Convert.ToInt32(MiFila["Cantidad"]);
                R.Precio = Convert.ToInt32(MiFila["Precio"]);
                R.Comentario = Convert.ToString(MiFila["Comentario"]);
                R.MiCategoria.IDProductoCategoria = Convert.ToInt32(MiFila["IdCategoria"]);

            }
            return R;
        }

        //Consulta los datos del producto en la BD, por ID
        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdProducto", this.IDProducto));

                DataTable retorno = MiConexion.DMLSelect("SPProductoConsultarPorID");

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

        //Consula los datos del producto por la categoria, en la BD
        public bool ConsultarPorNombre()
        {
            bool R = false;
            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                DataTable retorno = MiConexion.DMLSelect("SPProductoConsultarPorNombre");

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

        //lista los datos del producto en la BD
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPProductosListarTodos");

            return R;
        }

        //Lista en detalle los datos del producto en la BD
        public DataTable ListarEnDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPProductoListarEnDetalle");

            return R;
        }
        
    }
}
