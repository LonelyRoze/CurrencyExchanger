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
    public partial class table : Form
    {

        public table()
        {
            InitializeComponent();
        }


        private void table_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase db = new dataBase();
            DataTable table = new DataTable();
            dataGridView1.DataSource = db.GetData("SELECT * FROM transactions");
        }
    }
}
