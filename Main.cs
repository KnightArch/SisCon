namespace SisCon
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConsumo_TextChanged(object sender, EventArgs e)
        {
            UpdateValorEnergia();
        }

        private void textBoxValorConta_TextChanged(object sender, EventArgs e)
        {
            UpdateValorEnergia();
        }

        private void UpdateValorEnergia()
        {
            if (decimal.TryParse(textBoxValorConta.Text, out decimal valorConta) &&
                decimal.TryParse(textBoxConsumo.Text, out decimal valorConsumo) &&
                valorConsumo != 0)
            {
                decimal resultado = valorConta / valorConsumo;
                textBoxValorEnergia.Text = resultado.ToString("C");
            }
            else
            {
                textBoxValorEnergia.Text = string.Empty;
            }
        }

        private void textBoxMargemRiscoGTD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCustoTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
