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
    public class VendaDTO :EntidadeBase
    {
        //Conexão com o Banco de Dados
        ConectaMySQL conectaMySQL = new ConectaMySQL();

        private ProdutoDTO Produto { get; set; }
        private ClienteDTO Cliente { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime Data_Venda { get; set; }
        public int Quantidade { get; set; }

        public VendaDTO(ProdutoDTO produto, ClienteDTO cliente, DateTime dataVenda, int quantidade)
        {
            this.Produto = produto;
            this.Cliente = cliente;
            this.Data_Venda = dataVenda;
            this.Quantidade = quantidade;
        }
        public VendaDTO(int id)
        {
            this.Id = id;
        }
        public VendaDTO()
        {

        }
        public DataTable DtAtualizaVenda()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Id, Produto, Valor AS 'Preço (R$)', Cliente, Email AS 'e-mail', " +
                "Data_Venda AS 'Data da Venda', Quantidade from Vendas";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable DtBuscaTabela(string campo, string tabela)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select " + campo +" from " + tabela;

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public void SelecionaVenda()
        {
            string SQL;
            SQL = "Select * from Vendas where Id=" + this.Id;

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                NomeProduto = dados["Produto"].ToString();
                ValorProduto = Convert.ToDouble(dados["Valor"].ToString());
                NomeCliente = dados["Cliente"].ToString();
                EmailCliente = dados["Email"].ToString();
                Data_Venda = Convert.ToDateTime(dados["Data_Venda"].ToString());
                Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
            }
            conectaMySQL.FechaMySQL();
        }
        public void InsereVenda()
        {
            string SQL;

            SQL = "Insert into Vendas (Produto, Valor, Cliente, Email, Data_Venda, Quantidade) " +
            "values('" + Produto.Nome + "','" + Produto.Valor + "','" + Cliente.Nome + "','" + Cliente.Email + "'," +
            "'" + Data_Venda + "','" + Quantidade + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void UpdateVenda()
        {
            string SQL;

            SQL = "Update Vendas set Produto ='" + Produto.Nome + "', Valor ='" + Produto.Valor + "', Cliente ='" + Cliente.Nome + "'," +
                " Email ='" + Cliente.Email + "', Data_Venda ='" + Data_Venda + "', Quantidade ='" + Quantidade + "' where Id =" + this.Id + ";";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void DeletaVenda()
        {
            string SQL;

            SQL = "Delete from Vendas where Id=" + this.Id + ";";
            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }

    }
}
