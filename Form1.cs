using MySql.Data.MySqlClient;
using System.Data;

namespace CurrencyExchanger
{


    public partial class Form1 : Form
    {
        decimal rubBuy;
        decimal rubSell;
        decimal usdBuy;
        decimal usdSell;
        decimal eurBuy;
        decimal eurSell;


        private readonly string userStatus;
        public Form1(string status)
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
            label4.Text = string.Empty;
            userStatus = status;
            SetupButtonVisibility();
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            MessageBox.Show("Не забудьте выставить корректные курсы валют!!", "Внимание!");
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            currency_edit currencyform = new currency_edit();
            currencyform.ShowDialog();
        }

        private void SetupButtonVisibility()
        {
            if (userStatus == "admin")
            {
                adminButton.Visible = true;
                dbButton.Visible = true;
            }
            else
            {
                adminButton.Visible = false;
                dbButton.Visible = false;
            }
        }

        
        // Обработчик события изменения выбранного элемента в первом ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка второго ListBox
            listBox2.Items.Clear();

            // Получение выбранной валюты в первом ListBox
            string selectedCurrency = listBox1.SelectedItem.ToString();

            // Список всех валют
            string[] allCurrencies = { "KZT", "RUB", "USD", "EUR" };

            if (selectedCurrency == "KZT")
            {
                // Если выбрана KZT, удаляем KZT из второго ListBox
                foreach (string currency in allCurrencies)
                {
                    if (currency != "KZT")
                    {
                        listBox2.Items.Add(currency);
                    }
                }
            }
            else
            {
                // Если выбрана не KZT, то во втором ListBox оставляем только KZT
                listBox2.Items.Add("KZT");
                listBox2.SelectedItem = "KZT";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal i;
            decimal curr_to_amount = 0.0m;

            //блок со всякими првоерками
            if (idTextBox.Text == "" || idTextBox.Text.Length != 12 || !long.TryParse(idTextBox.Text, out long _))
            {
                MessageBox.Show("Поле ИИН либо пустое, либо содержит больше/меньше символов!", "Операция невозможна!");
                return;
            }

            string monthString = idTextBox.Text.Substring(2, 2);
            string dayString = idTextBox.Text.Substring(4, 2);

            // Проверка, что месяц - это число от 01 до 12
            if (!int.TryParse(monthString, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Номер месяца должен быть от 01 до 12.", "Операция невозможна!");
                return;
            }

            // Проверка, что день - это число от 01 до 31
            if (!int.TryParse(dayString, out int day) || day < 1 || day > 31)
            {
                MessageBox.Show("Число дня должно быть от 01 до 31.", "Операция невозможна!");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым!", "Операция невозможна!");
                return;
            }
            else if (!decimal.TryParse(textBox1.Text, out i))
            {
                MessageBox.Show("Вводите только числа!", "Операция невозможна!");
                return;
            }

            if (textBox1.Text == "0")
            {
                MessageBox.Show("Значение не может быть равно нулю!", "Операция невозможна!");
                return;
            }

            if (i < 0)
            {
                MessageBox.Show("Значение не может быть отрицательным!", "Операция невозможна!");
                return;
            }

            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите вторую валюту для обмена!", "Операция невозможна!");
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
                rubSell = GlobalCurrencies.rub_sell;
                decimal conver = i / rubSell;
                label4.Text = conver.ToString("F2") + "\t RUB";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "EUR")
            {
                eurSell = GlobalCurrencies.eur_sell;
                decimal conver = i / eurSell;
                label4.Text = conver.ToString("F2") + "\t EUR";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "USD")
            {
                usdSell = GlobalCurrencies.usd_sell;
                decimal conver = i / usdSell;
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
                rubBuy = GlobalCurrencies.rub_buy;
                decimal conver = i * rubBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
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
                eurBuy = GlobalCurrencies.eur_buy;
                decimal conver = i * eurBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
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
                usdBuy = GlobalCurrencies.usd_buy;
                decimal conver = i * usdBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
                curr_to_amount = conver;
            }

            string clientID = idTextBox.Text;
            string curr_from = listBox1.SelectedItem.ToString();
            string curr_to = listBox2.SelectedItem.ToString();
            decimal curr_from_amount = i;
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd HH:mm:ss");


            dataBase db = new dataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions` (`iin`, `date`, `curr_fr_type`, `curr_fr_amount`, `curr_to_type`, `curr_to_amount`) VALUES (@iin, @datetime, @currfrom, @currfamount, @currto, @currtamount)", db.getConnection());

            command.Parameters.Add("@iin", MySqlDbType.VarChar).Value = clientID;
            command.Parameters.Add("@datetime", MySqlDbType.DateTime).Value = time;
            command.Parameters.Add("@currfrom", MySqlDbType.VarChar).Value = curr_from;
            command.Parameters.Add("@currfamount", MySqlDbType.Decimal).Value = curr_from_amount;
            command.Parameters.Add("@currto", MySqlDbType.VarChar).Value = curr_to;
            command.Parameters.Add("@currtamount", MySqlDbType.Decimal).Value = curr_to_amount;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Транзакция проведена успешно!");
            else
                MessageBox.Show("Транзакция не прошла!");

            db.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currency_edit currencyform = new currency_edit();
            currencyform.ShowDialog();
        }

        private void chechSum_Click(object sender, EventArgs e)
        {
            rubBuy = GlobalCurrencies.rub_buy;
            usdBuy = GlobalCurrencies.usd_buy;
            eurBuy = GlobalCurrencies.eur_buy;
            rubSell = GlobalCurrencies.rub_sell;
            usdSell = GlobalCurrencies.usd_sell;
            eurSell = GlobalCurrencies.eur_sell;
            label6.Text = rubBuy.ToString();
            label7.Text = usdBuy.ToString();
            label8.Text = eurBuy.ToString();
            label9.Text = rubSell.ToString();
            label10.Text = usdSell.ToString();
            label11.Text = eurSell.ToString();

            decimal i;
            decimal curr_to_amount = 0.0m;

            //блок со всякими првоерками

            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым!", "Операция невозможна!");
                return;
            }
            else if (!decimal.TryParse(textBox1.Text, out i))
            {
                MessageBox.Show("Вводите только числа!", "Операция невозможна!");
                return;
            }

            if (textBox1.Text == "0")
            {
                MessageBox.Show("Значение не может быть равно нулю!", "Операция невозможна!");
                return;
            }

            if (i < 0)
            {
                MessageBox.Show("Значение не может быть отрицательным!", "Операция невозможна!");
                return;
            }

            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите вторую валюту для обмена!", "Операция невозможна!");
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
                rubSell = GlobalCurrencies.rub_sell;
                decimal conver = i / rubSell;
                label4.Text = conver.ToString("F2") + "\t RUB";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "EUR")
            {
                eurSell = GlobalCurrencies.eur_sell;
                decimal conver = i / eurSell;
                label4.Text = conver.ToString("F2") + "\t EUR";
                curr_to_amount = conver;
            }
            else if (listBox1.SelectedItem == "KZT" && listBox2.SelectedItem == "USD")
            {
                usdSell = GlobalCurrencies.usd_sell;
                decimal conver = i / usdSell;
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
                rubBuy = GlobalCurrencies.rub_buy;
                decimal conver = i * rubBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
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
                eurBuy = GlobalCurrencies.eur_buy;
                decimal conver = i * eurBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
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
                usdBuy = GlobalCurrencies.usd_buy;
                decimal conver = i * usdBuy;
                label4.Text = conver.ToString("F2") + "\t KZT";
                curr_to_amount = conver;
            }
        }

        private void dbButton_Click_1(object sender, EventArgs e)
        {
            table table = new table();
            table.ShowDialog();
        }
    }



}
