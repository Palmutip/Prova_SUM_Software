using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prova_SUM_Software.Conexao
{
    class ConectaMySQL
    {
        private string server = string.Empty;
        private string port = string.Empty;
        private string database = string.Empty;
        private string uid = string.Empty;
        private string password = string.Empty;

        public MySqlConnection AbreMySQL()
        {
                MySqlConnection conexao = new MySqlConnection($"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};Convert Zero Datetime=True");
                conexao.Open();
                return conexao;

        }
        public MySqlConnection FechaMySQL()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.Close();
            return conexao;
        }
        public void ExecutaComando(string SQL)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = SQL;

            mySqlCommand.Connection = AbreMySQL();

            mySqlCommand.ExecuteNonQuery();
        }
        public MySqlDataReader ExecutaConsulta(string SQL)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = SQL;

            mySqlCommand.Connection = AbreMySQL();

            return mySqlCommand.ExecuteReader();
        }
    }
}
