using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE_V2
{
    internal class Usuario
    {
        public enum TipoUsuario
        {
            Administrador,
            Usuario
        }

        public string usuario { get; set; }
        public string clave { get; set; }
        public string tipo { get; set; }
    }
}
