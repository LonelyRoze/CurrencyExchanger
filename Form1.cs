using MySql.Data.MySqlClient;
using System.Data;

namespace CurrencyExchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
            label4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float i;
            double curr_to_amount = 0.0;

            //блок со всякими првоерками
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым!", "Операция невозможна!");
                return;
            }
            else if (!float.TryParse(textBox1.Text, out i))
            {
                MessageBox.Show("Вводите только числа!", "Операция невозможна!");
                return;
            }

            if (textBox1.Text == "0")
            {
                MessageBox.Show("Значение не может быть равно нулю!", "Операция невозможна!"); 
                return;   
            }

            if (idTextBox.Text == "" || idTextBox.Text.Length != 12)
            {
                MessageBox.Show("Проверье поле ИИН!", "Операция невозможна!");
                return;
            }



            //операции c тенге\
            if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "KZT")
            {
                MessageBox.Show("Нельзя обменять валюту на неё же!", "Операция невозможна!");
                return;
            }
            if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "RUB")
            {
                double conver = i / 5;
                label4.Text = conver.ToString("F2") + "\t RUB";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "EUR")
            {
                double conver = i / 500;
                label4.Text = conver.ToString("F2") + "\t EUR";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "USD")
            {
                double conver = i / 450;
                label4.Text = conver.ToString("F2") + "\t USD";
                curr_to_amount = conver;
            }


            //операции c рублем\
            if (listBox1.SelectedItem == "RUB" && listBox2.SelectedItem == "RUB")
            {
                MessageBox.Show("Нельзя обменять валюту на неё же!", "Операция невозможна!");
                return;
            }
            if (listBox1.SelectedItem == "RUB" && listBox2.SelectedItem == "KZT")
            {
                double conver = i * 5;
                label4.Text = conver.ToString("F2") + "\t KZT";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "RUB" && listBox2.SelectedItem == "EUR")
            {
                double conver = i / 98;
                label4.Text = conver.ToString("F2") + "\t EUR";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "RUB" && listBox2.SelectedItem == "USD")
            {
                double conver = i / 92;
                label4.Text = conver.ToString("F2") + "\t USD";
                curr_to_amount = conver;
            }


            //операции c евро\
            if (listBox1.SelectedItem == "EUR" && listBox2.SelectedItem == "EUR")
            {
                MessageBox.Show("Нельзя обменять валюту на неё же!", "Операция невозможна!");
                return;
            }
            if (listBox1.SelectedItem == "EUR" && listBox2.SelectedItem == "KZT")
            {
                double conver = i * 500;
                label4.Text = conver.ToString("F2") + "\t KZT";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "EUR" && listBox2.SelectedItem == "RUB")
            {
                double conver = i * 98;
                label4.Text = conver.ToString("F2") + "\t RUB";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "EUR" && listBox2.SelectedItem == "USD")
            {
                double conver = i * 1.07;
                label4.Text = conver.ToString("F2") + "\t USD";
                curr_to_amount = conver;
            }


            //операции c долларом\
            if (listBox1.SelectedItem == "USD" && listBox2.SelectedItem == "USD")
            {
                MessageBox.Show("Нельзя обменять валюту на неё же!", "Операция невозможна!");
                return;
            }
            if (listBox1.SelectedItem == "USD" && listBox2.SelectedItem == "KZT")
            {
                double conver = i * 450;
                label4.Text = conver.ToString("F2") + "\t KZT";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "USD" && listBox2.SelectedItem == "RUB")
            {
                double conver = i * 92;
                label4.Text = conver.ToString("F2") + "\t RUB";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "USD" && listBox2.SelectedItem == "EUR")
            {
                double conver = i / 1.07;
                label4.Text = conver.ToString("F2") + "\t EUR";
                curr_to_amount = conver;
            }

            string clientID = idTextBox.Text;
            string curr_from = listBox1.SelectedItem.ToString();
            string curr_to = listBox2.SelectedItem.ToString();
            float curr_from_amount = i;
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd HH:mm:ss");


            dataBase db = new dataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions` (`iin`, `date`, `curr_fr_type`, `curr_fr_amount`, `curr_to_type`, `curr_to_amount`) VALUES (@iin, @datetime, @currfrom, @currfamount, @currto, @currtamount)", db.getConnection());

            command.Parameters.Add("@iin", MySqlDbType.VarChar).Value = clientID;
            command.Parameters.Add("@datetime", MySqlDbType.DateTime).Value = time;
            command.Parameters.Add("@currfrom", MySqlDbType.VarChar).Value = curr_from;
            command.Parameters.Add("@currfamount", MySqlDbType.Float).Value = curr_from_amount;
            command.Parameters.Add("@currto", MySqlDbType.VarChar).Value = curr_to;
            command.Parameters.Add("@currtamount", MySqlDbType.Double).Value = curr_to_amount;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Транзакция проведена успешно!");
            else
                MessageBox.Show("Транзакция не прошла!");

            db.closeConnection();





        }
    }



}
