using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDerake.Locales
{
    public static class ObjetosGlobales
    {
        public static Form MiFormPrincipal = new Formularios.FrmPrincipal();

        public static Lógica.Usuario MiUsuarioGlobal = new Lógica.Usuario();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        public static Formularios.FrmVentasGestion MiFormGestionVentas = new Formularios.FrmVentasGestion();

        public static Formularios.FrmGestionClientes MiFormGestionClientes = new Formularios.FrmGestionClientes();

        public static Formularios.FrmGestionEmpleados MiFormGestionEmpleados = new Formularios.FrmGestionEmpleados();

        public static Formularios.FrmGestionProductos MiFormGestionProductos = new Formularios.FrmGestionProductos();

        public static Formularios.FrmGestionVentaDetalle MiFormGestionDetalle = new Formularios.FrmGestionVentaDetalle();

        public static Formularios.FrmInformacion MiFormInfo = new Formularios.FrmInformacion();


    }
}
