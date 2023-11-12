namespace CurrencyExchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items = { "Ёлемент 1", "Ёлемент 2", "Ёлемент 3" };

            comboBox1.DataSource = items;
        }
    }
}