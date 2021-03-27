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
        //private static FuncoesBanco func = new FuncoesBanco();
        public MySqlConnection AbreMySQL()
        {
                MySqlConnection conexao = new MySqlConnection("SERVER=108.179.252.199;PORT=3306;DATABASE=mysola97_prova;UID=mysola97_testeus ;PASSWORD=SenhaForte321123;Convert Zero Datetime=True");
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
