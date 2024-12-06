using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE_V2
{
    public partial class LoginFrm : Form
    {
        UsuarioService usuarioService = new UsuarioService();
        public LoginFrm()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioService usuarioService = new UsuarioService();

            string usuariotxt = txtUsuario.Text;
            string clavetxt = txtClave.Text;

            try
            {

                Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUsuario(usuariotxt);

                string nombreUsuario = usuarioInstancia.usuario;
                string clave = usuarioInstancia.clave;
                string tipo = usuarioInstancia.tipo;

                if (nombreUsuario == usuariotxt && clavetxt == clave)
                {
                    if (tipo == "Administrador")
                    {
                        TrabajadoresFrm AdminFrm = new TrabajadoresFrm();
                        AdminFrm.Show();
                    }
                    else if (tipo == "Usuario")
                    {
                        RegistroSueldo UserFrm = new RegistroSueldo();
                        UserFrm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o clave no son correctos");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error al consultar usuario " + ex);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorUsuarios mantenedorUsuarios = new MantenedorUsuarios();
            mantenedorUsuarios.Show();
        }
    }
}
