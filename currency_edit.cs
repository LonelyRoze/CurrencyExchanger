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
        public currency_edit()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            GlobalCurrencies.rub_buy = decimal.Parse(buyRub.Text);
            GlobalCurrencies.rub_sell = decimal.Parse(sellRub.Text);
            GlobalCurrencies.usd_buy = decimal.Parse(buyUsd.Text);
            GlobalCurrencies.usd_sell = decimal.Parse(sellUsd.Text);
            GlobalCurrencies.eur_buy = decimal.Parse(buyEur.Text);
            GlobalCurrencies.eur_sell = decimal.Parse(sellEur.Text);
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
