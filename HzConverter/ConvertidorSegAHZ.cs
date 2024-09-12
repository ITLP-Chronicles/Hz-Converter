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
    public partial class ConvertidorSegAHZ : UserControl
    {
        public ConvertidorSegAHZ()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hzNotConverted = numericUpDown1.Value;
            var hz = ConvertToHz(comboBox1.Text, hzNotConverted);
            var seconds = 1 / hz;
            label2.Text = $"Segundos: {seconds}";
        }

        private decimal ConvertToHz(string unidad, decimal frecuencia)
        {
            switch (unidad)
            {
                case "Hz":
                    return frecuencia;
                case "kHz":
                    return frecuencia * 1_000;
                case "MHz":
                    return frecuencia * 1_000_000;
                case "GHz":
                    return frecuencia * 1_000_000_000;
                default:
                    throw new Exception("Unidad no válida");
            }
        }
    }
}
