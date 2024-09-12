using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HzConverter
{
    public partial class TiempoCiclo : UserControl
    {
        public TiempoCiclo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los valores ingresados por el usuario
                double frecuencia = double.Parse(txtFrecuencia.Text);
                double tiempo = double.Parse(txtTiempo.Text);
                string unidad = cmbUnidad.SelectedItem.ToString();
                string unidadT = cmbTiempo.SelectedItem.ToString();

                // Convertimos la frecuencia a Hz
                double frecuenciaEnHz = ConvertirFrecuenciaAHz(frecuencia, unidad);

                // Convertimos el tiempo a Segundos
                double tiempoSeg = ConvertirTiempoASegundos(tiempo, unidadT);

                // Calculamos el tiempo por ciclo
                double tiempoPorCiclo = 1 / frecuenciaEnHz;

                // Calculamos el número de ciclos en el tiempo dado
                double numeroDeCiclos = frecuenciaEnHz * tiempoSeg;

                // Mostramos los resultados
                txtTiempoPorCiclo.Text = tiempoPorCiclo.ToString("G5") + " segundos";
                txtNumeroCiclos.Text = numeroDeCiclos.ToString("G5") + " ciclos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método que convierte la frecuencia a Hz en función de la unidad seleccionada
        double ConvertirFrecuenciaAHz(double frecuencia, string unidad)
        {
            switch (unidad)
            {
                case "Hz":
                    return frecuencia;
                case "KHz":
                    return frecuencia * 1_000;
                case "MHz":
                    return frecuencia * 1_000_000;
                case "GHz":
                    return frecuencia * 1_000_000_000;
                default:
                    throw new Exception("Unidad no válida");
            }
        }

        // Método que convierte el tiempo a Segundos en función de la unidad seleccionada
        double ConvertirTiempoASegundos(double tiempo, string unidad)
        {
            switch (unidad)
            {
                case "Segundos":
                    return tiempo;
                case "Milisegundos":
                    return tiempo / 1_000;
                case "Microsegundos":
                    return tiempo / 1_000_000;
                case "Nanosegundos":
                    return tiempo / 1_000_000_000;
                case "Picosegundos":
                    return tiempo / 1_000_000_000_000;
                default:
                    throw new Exception("Unidad no válida");
            }
        }

        private void txtFrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void TiempoCiclo_Load(object sender, EventArgs e)
        {
            cmbUnidad.SelectedIndex = 0;
            cmbTiempo.SelectedIndex = 0;
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
            ValidateTB();
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            ValidateTB();
        }

        private void ValidateTB()
        {
            if (txtFrecuencia.Text != "" && txtTiempo.Text != "") btnCalcular.Enabled = true;
            else btnCalcular.Enabled = false;
        }
    }
}
