using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CurrencyExchanger
{
    public partial class login : Form
    {
        string status;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginTextBox.Text;
            string passUser = passTextBox.Text;

            dataBase dataBase = new dataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @uL AND `pass` = @uP", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string status = table.Rows[0]["type"].ToString();
                MessageBox.Show("Yes!");
                Form1 MainWindow = new Form1(status);
                MainWindow.ShowDialog();
            }
            else
                MessageBox.Show("No.");
        }
    }
}
