using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE_V2
{
    internal class UsuarioRepository
    {
        private static UsuarioRepository instancia;

        private List<Usuario> listaUsuario = new List<Usuario>();
        private UsuarioRepository() { }

        public static UsuarioRepository ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new UsuarioRepository();
            }
            return instancia;
        }

        public void GuardarUsuario(Usuario usuarioParametro)
        {
            listaUsuario.Add(usuarioParametro);
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return listaUsuario;
        }

        public Usuario ObtenerUsuarioPorUsuario(string ParametroUsuario)
        {
            return listaUsuario.Find(t => t.usuario == ParametroUsuario);

        }
    }
}
