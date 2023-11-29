using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class currency_edit : Form
    {

        private readonly string userStatus;
        public currency_edit(string status)
        {
            InitializeComponent();
            userStatus = status;
            SetupButtonVisibility();
            buyRub.Text = GlobalCurrencies.rub_buy.ToString();
            sellRub.Text = GlobalCurrencies.rub_sell.ToString();
            buyUsd.Text = GlobalCurrencies.usd_buy.ToString();
            sellUsd.Text = GlobalCurrencies.usd_sell.ToString();
            buyEur.Text = GlobalCurrencies.eur_buy.ToString();
            sellEur.Text = GlobalCurrencies.eur_sell.ToString();
        }

        private void SetupButtonVisibility()
        {
            if (userStatus == "admin")
            {
                saveButton.Visible = true;
            }
            else
            {
                saveButton.Visible = false;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (!decimal.TryParse(buyRub.Text, out decimal rubBuy) || rubBuy <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс рубля!", "Операция невозможна!");
                return;
            }

            if (!decimal.TryParse(sellRub.Text, out decimal rubSell) || rubSell <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс рубля!", "Операция невозможна!");
                return;
            }

            if (!decimal.TryParse(buyUsd.Text, out decimal usdBuy) || usdBuy <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс доллара!", "Операция невозможна!");
                return;
            }

            if (!decimal.TryParse(sellUsd.Text, out decimal usdSell) || usdSell <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс доллара!", "Операция невозможна!");
                return;
            }

            if (!decimal.TryParse(sellEur.Text, out decimal eurSell) || eurSell <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс евро!", "Операция невозможна!");
                return;
            }

            if (!decimal.TryParse(buyEur.Text, out decimal eurBuy) || eurBuy <= 0)
            {
                isValid = false;
                MessageBox.Show("Некорректный курс евро!", "Операция невозможна!");
                return;
            }


            if (isValid)
            {
                GlobalCurrencies.rub_buy = decimal.Parse(buyRub.Text);
                GlobalCurrencies.rub_sell = decimal.Parse(sellRub.Text);
                GlobalCurrencies.usd_buy = decimal.Parse(buyUsd.Text);
                GlobalCurrencies.usd_sell = decimal.Parse(sellUsd.Text);
                GlobalCurrencies.eur_buy = decimal.Parse(buyEur.Text);
                GlobalCurrencies.eur_sell = decimal.Parse(sellEur.Text);
            }
        }
    }
    public static class GlobalCurrencies
    {
        public static decimal rub_buy { get; set; }
        public static decimal rub_sell { get; set; }
        public static decimal usd_buy { get; set; }
        public static decimal usd_sell { get; set; }
        public static decimal eur_buy { get; set; }
        public static decimal eur_sell { get; set; }
    }
}
