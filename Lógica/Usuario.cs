using System;
using System.Collections.Generic;
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
        public UsuarioRol MiRol { get; set; }

        //Constructor
        public Usuario()
        {
            MiRol = new UsuarioRol();
        }

        //Metodos
    }
}
