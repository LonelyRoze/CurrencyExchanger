using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    internal class dataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=currency_db");




        public void openConnection() 
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable GetData(string query)
        { 
            MySqlCommand cmd = new MySqlCommand(query, getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            openConnection();
            adapter.Fill(table);
            closeConnection();  

            return table;
        }

    }
}
