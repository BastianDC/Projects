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


    public partial class TrabajadoresFrm : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();

        private void CargarRutEnCombobox()
        {
            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

            cmbBuscar.Items.Clear();
            cmbBuscar.Items.Add("TODOS");

            foreach (var trabajador in trabajadores)
            {
                cmbBuscar.Items.Add(trabajador.Rut);
            }
        }

        private List<string> listaRut = new List<string>();
        private List<string> listaNombre = new List<string>();
        private List<string> listaApellido = new List<string>();
        private List<string> listaDireccion = new List<string>();
        private List<string> listaTelefono = new List<string>();
        private List<string> listaHora = new List<string>();
        private List<string> listaExtra = new List<string>();
        public TrabajadoresFrm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string hora = txtHora.Text;
            string extra = txtExtra.Text;

            listaRut.Add(rut);
            listaNombre.Add(nombre);
            listaApellido.Add(apellido);
            listaDireccion.Add(direccion);
            listaTelefono.Add(telefono);
            listaHora.Add(hora);
            listaExtra.Add(extra);

            cmbBuscar.Items.Clear();
            cmbBuscar.Items.AddRange(listaRut.ToArray());

            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtHora.Clear();
            txtExtra.Clear();
        }
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbBuscar.SelectedIndex;

            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("Rut");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Telefono");

            tabla.Rows.Add(listaRut[index], listaNombre[index], listaApellido[index], listaTelefono[index]);

            dgvResultado.DataSource = tabla;
            dgvResultado.Refresh();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
                var row = dgvResultado.SelectedRows[0];

                try
                {
                    trabajadorService.EditarTrabajador(txtRut.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
                    MessageBox.Show("Trabajador modificado exitosamente");

                    CargarRutEnCombobox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar trabajador: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un trabajador para modificar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorUsuarios mantenedorUsuarios = new MantenedorUsuarios();
            mantenedorUsuarios.Show();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvResultado.Refresh();
        }
    }
}
