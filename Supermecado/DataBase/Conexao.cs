using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Supermecado.DataBase
{
    class Conexao
    {
        //private string connectionString = "server=192.168.0.119;port=3306;UserId=root;database=supermecado; password=19499226";
        private string connectionString = "server=localhost;port=3307;UserId=root;database=supermecado;password=19499726";
    
        public MySqlConnection SqlConn { get; set; }

        public Conexao()
        {
            SqlConn = conectarMySql();
        }

        public MySqlConnection conectarMySql()
        {
            SqlConn = new MySqlConnection(connectionString);

            if (SqlConn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    SqlConn.Open();
                    return SqlConn;
                }
                catch(MySqlException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    MessageBox.Show(ex.Message.ToString());
                    return null;
                }
            }

            return SqlConn;
        }

        //Metodo para desconectar
        public void desconectar()
        {
            if(SqlConn.State == System.Data.ConnectionState.Open)
            {
                SqlConn.Close();
            }
        }
    }
}
