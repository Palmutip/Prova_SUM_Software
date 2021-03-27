using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Prova_SUM_Software.Conexao;


namespace Prova_SUM_Software.Modelos
{
    public class ClienteDTO
    {
        //Conexão com o Banco de Dados
        ConectaMySQL conectaMySQL = new ConectaMySQL();

        public string Nome { get; set; }
        public string Email { get; set; }

        public void InsereCliente()
        {
            string SQL;

            SQL = "Insert into Clientes (Nome, Email) " +
            "values('" + Nome + "','" + Email + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public DataTable DtAtualizaCliente()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Nome AS 'Cliente', Email AS 'e-mail' from Clientes";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable DtAtualizaCliente(string valor, string coluna)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Nome AS 'Cliente', Email AS 'e-mail' from Clientes where "+ coluna +" like '%" + valor + "%'";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
    }
}
