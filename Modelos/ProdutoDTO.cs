using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_SUM_Software.Conexao;

namespace Prova_SUM_Software.Modelos
{
    public class ProdutoDTO 
    {
        //Conexão com o Banco de Dados
        ConectaMySQL conectaMySQL = new ConectaMySQL();

        public string Nome { get; set; }
        public double Valor { get; set; }

        public void InsereProduto()
        {
            string SQL;

            SQL = "Insert into Produtos (Nome, Valor) " +
            "values('" + Nome + "','" + Valor + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public DataTable DtAtualizaProduto()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Nome AS 'Produto', Valor AS 'Preço (R$)' from Produtos";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable DtAtualizaProduto(string valor, string coluna)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Nome AS 'Produto', Valor AS 'Preço (R$)' from Produtos where " + coluna + " like '%" + valor + "%'";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public string SelecionaValorProduto(string nome)
        {
            string SQL;
            SQL = "Select Valor from Produtos where Nome like '%" + nome + "%'";

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                Valor = Convert.ToDouble(dados["Valor"].ToString());
            }
            conectaMySQL.FechaMySQL();
            return Valor.ToString();
        }
    }
}
