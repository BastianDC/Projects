using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE_V2
{
    internal class UsuarioService
    {
        private UsuarioRepository usuarioRepository = UsuarioRepository.ObtenerInstancia();
        public void AgregarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.usuario) || string.IsNullOrEmpty(usuario.clave) || string.IsNullOrEmpty(usuario.tipo))
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            usuarioRepository.GuardarUsuario(usuario);
        }
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return usuarioRepository.ObtenerTodosUsuarios();
        }
        public Usuario ObtenerUsuarioPorUsuario(string ParametroUsuario)
        {
            return usuarioRepository.ObtenerUsuarioPorUsuario(ParametroUsuario);
        }
    }
}
