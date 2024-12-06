using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ENE_V2
{
    public partial class RegistroSueldo : Form
    {
        private Dictionary<string, double> afpPorcentajes = new Dictionary<string, double>
        {
            { "CUPRUM", 0.07 },
            { "MODELO", 0.09 },
            { "CAPITAL", 0.12 },
            { "PROVIDA", 0.13 }
        };
        private Dictionary<string, double> SaludPorcentajes = new Dictionary<string, double>
        {
            { "FONASA", 0.12 },
            { "CONSALUD", 0.13 },
            { "MASVIDA", 0.14 },
            { "BANMEDICA", 0.15 }
        };


        public RegistroSueldo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string horas = txtHoras.Text;
            int horasN;
            string extra = txtExtra.Text;
            int extraN;

            if (int.TryParse(horas, out horasN))
            {
                if (int.TryParse(extra, out extraN))
                {
                    string saludSeleccionada = cmbSalud.Text;
                    string afpSeleccionada = cmbAfp.Text;
                    int valorHoras = 5000;
                    int valorExtras = 7000;
                    int resultadoBruto = horasN * valorHoras + extraN * valorExtras;
                    txtBruto.Text = resultadoBruto.ToString();
                    double descuentoAfp = 0;
                    double descuentoSalud = 0;

                    if (afpPorcentajes.TryGetValue(afpSeleccionada, out double porcentajeAfp))
                    {
                        descuentoAfp = resultadoBruto * porcentajeAfp;
                    }
                    else
                    {
                        MessageBox.Show("AFP no válida. Por favor, introduce una AFP correcta.");
                    }
                    if (SaludPorcentajes.TryGetValue(saludSeleccionada, out double porcentajeSalud))
                    {
                        descuentoSalud = resultadoBruto * porcentajeSalud;
                    }
                    else
                    {
                        MessageBox.Show("Sistema de Salud no válido. Por favor, introduce uno correcto.");
                    }

                    double sueldoLiquido = resultadoBruto - (descuentoAfp + descuentoSalud);
                    txtLiquido.Text = sueldoLiquido.ToString("F2");

                }
                else
                {
                    MessageBox.Show("Por favor introduce un numero de horas extra VALIDO");
                }
            }
            else
            {
                MessageBox.Show("Por favor introduce un numero de horas VALIDO");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtExtra.Clear();
            txtBruto.Clear();
            txtExtra.Clear();
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
