namespace HzConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tiempoCiclo1.btnCalcular.Click += UpdateFrequencyGraph;
        }
        private void UpdateFrequencyGraph(object sender, EventArgs e)
        {
            frequencyGraph1.Frequency = Convert.ToInt32(tiempoCiclo1.txtFrecuencia.Text);
            frequencyGraph1.Invalidate();
        }
    }
}
