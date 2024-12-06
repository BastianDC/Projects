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
    public partial class MantenedorUsuarios : Form
    {
        UsuarioService usuarioService = new UsuarioService();
        public MantenedorUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario InstanciaUsuario = new Usuario
            {
                clave = txtClave.Text,
                tipo = comboBox1.Text,
                usuario = txtUsuario.Text,
            };

            try
            {
                usuarioService.AgregarUsuario(InstanciaUsuario);
                MessageBox.Show("Usuario ingresado exitosamente");

                txtClave.Clear();
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUsuario(txtUsuario.Text);
            string usuario = usuarioInstancia.usuario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
