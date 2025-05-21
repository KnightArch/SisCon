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
            UpdateCustoTotal();
        }

        private void textBoxMargemRiscoGTD_TextChanged(object sender, EventArgs e)
        {
            UpdateCustoTotal();
        }

        private void UpdateCustoTotal()
        {
            // Remove o símbolo de porcentagem, espaços e outros caracteres não numéricos do campo de margem
            string margemTexto = textBoxMargemRiscoGTD.Text.Replace("%", "").Trim();

            // Tenta obter o valor da energia (removendo símbolo de moeda)
            if (decimal.TryParse(textBoxValorEnergia.Text, System.Globalization.NumberStyles.Currency, 
                System.Globalization.CultureInfo.CurrentCulture, out decimal valorEnergia) &&
                decimal.TryParse(margemTexto, out decimal margem))
            {
                // margem deve ser digitada como "10" para 10%
                decimal custoTotal = valorEnergia + (valorEnergia * (margem / 100m));
                textBoxCustoTotal.Text = custoTotal.ToString("C");
            }
            else
            {
                textBoxCustoTotal.Text = string.Empty;
            }
        }

        private void textBoxCustoTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
