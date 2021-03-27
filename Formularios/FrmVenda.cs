using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova_SUM_Software.Modelos;

namespace Prova_SUM_Software.Formularios
{
    public partial class FrmVenda : Form
    {
        #region Inicializando Variaveis Globais
        DateTime data_Venda;
        int quantidade;
        ClienteDTO cliente = new ClienteDTO();
        ProdutoDTO produto = new ProdutoDTO();
        VendaDTO venda = new VendaDTO();
        bool buscando = false;
        #endregion

        #region Funções gerais do software
        private void LimpaCampos()
        {
            //Controles da parte esquerda do formulário
            cbxfiltrovenda.SelectedIndex = -1;
            txtbuscavenda.Text = string.Empty;
            
            //Controles da parte direita do formulário
            cbxproduto.Text = string.Empty;
            cbxproduto.SelectedIndex = -1;
            txtvalorproduto.Text = string.Empty;
            cbxcliente.Text = string.Empty;
            cbxcliente.SelectedIndex = -1;
            txtemailcliente.Text = string.Empty;
            ntxtqtdproduto.Value = 0;
            dtpdatavenda.Value = DateTime.Today;
            rtxtmensagem.Text = string.Empty;
        }
        private void BloqueiaCampos()
        {
            dgvvendasdomes.Enabled = false;
            //txtbuscavenda.Text = string.Empty;
            txtbuscavenda.Enabled = false;
            //cbxfiltrovenda.SelectedIndex = -1;
            cbxfiltrovenda.Enabled = false;
            pbxbuscavenda.Enabled = false;

            btnsalvavenda.Enabled = true;
            btnsalvavenda.Visible = true;
            btncancelarvenda.Enabled = true;
            btncancelarvenda.Visible = true;

            dgvvendasdomes.DataSource = venda.DtAtualizaVenda();

            LimpaCampos();
        }
        private void LiberaCampos()
        {
            dgvvendasdomes.Enabled = true;
            //txtbuscavenda.Text = string.Empty;
            txtbuscavenda.Enabled = true;
            //cbxfiltrovenda.SelectedIndex = -1;
            cbxfiltrovenda.Enabled = true;
            pbxbuscavenda.Enabled = true;

            btnsalvavenda.Enabled = false;
            btnsalvavenda.Visible = false;
            btncancelarvenda.Enabled = false;
            btncancelarvenda.Visible = false;

            LimpaCampos();
        }
        #endregion

        public FrmVenda()
        {
            InitializeComponent();

            //Atualizando os dados do DataGridView
            dgvvendasdomes.DataSource = venda.DtAtualizaVenda();

            //Alimentando as ComboBox
            cbxproduto.DataSource = venda.DtBuscaTabela("Nome","Produtos");
            //cbxproduto.DisplayMember = "Produto";
            cbxproduto.ValueMember = "Nome";
            cbxproduto.SelectedIndex = -1;
            cbxcliente.DataSource = venda.DtBuscaTabela("Nome", "Clientes");
            //cbxcliente.DisplayMember = "Cliente";
            cbxcliente.ValueMember = "Nome";
            cbxcliente.SelectedIndex = -1;
        }

        private void btnnovavenda_Click(object sender, EventArgs e)
        {
            BloqueiaCampos();
        }

        private void btncancelarvenda_Click(object sender, EventArgs e)
        {
            LiberaCampos();
        }

        private void btnsalvavenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (ntxtqtdproduto.Value <= 0)
                {
                    MessageBox.Show("Quantidade deve ser maior que zero", "Atenção");
                }
                else
                {
                    if (cbxproduto.Text == string.Empty || txtvalorproduto.Text == string.Empty || cbxcliente.Text == string.Empty || txtemailcliente.Text == string.Empty)
                    {
                        MessageBox.Show("Verifique se você preencheu todos os campos", "Atenção");
                    }
                    else
                    {
                        produto.Nome = cbxproduto.Text;
                        produto.Valor = Convert.ToDouble(txtvalorproduto.Text);
                        cliente.Nome = cbxcliente.Text;
                        cliente.Email = txtemailcliente.Text;
                        data_Venda = dtpdatavenda.Value;
                        Convert.ToDateTime(data_Venda).ToString("dd/MM/yyyy");
                        quantidade = Convert.ToInt32(ntxtqtdproduto.Value);

                        VendaDTO novavenda = new VendaDTO(produto,cliente,data_Venda,quantidade);
                        novavenda.InsereVenda();
                        dgvvendasdomes.DataSource = novavenda.DtAtualizaVenda();
                        LiberaCampos();

                        rtxtmensagem.Text = "Prezado cliente " + cliente.Nome + "\n\nVocê acabou de comprar " + produto.Nome +
                            ". Esperamos que você esteja satisfeito. Em caso de problemas com o produto ou dúvidas quanto a sua" +
                            " utilização, entre em contato conosco no email suporte@ficticio.com.br ou pelo telefone (35) 99999-9999" +
                            "\n\nAtenciosamente\nLoja Ficticia.";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Houve algum problema em salvar os dados da venda.\nContate o suporte técnico", "Atenção");
                
            }
            finally
            {
                MessageBox.Show("Venda realizada!", "Sucesso");
            }
        }

        private void dgvvendasdomes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvvendasdomes.CurrentRow.Cells[0].Value.ToString());
                VendaDTO novavenda = new VendaDTO(id);
                novavenda.SelecionaVenda();

                //Varivel de controle das combobox
                //buscando = true;

                //Atribuindo os campos do produto
                cbxproduto.SelectedValue = novavenda.NomeProduto;
                ntxtqtdproduto.Value = novavenda.Quantidade;
                dtpdatavenda.Value = novavenda.Data_Venda;
                txtvalorproduto.Text = novavenda.ValorProduto.ToString();

                //Atribuindo os campos do cliente
                cbxproduto.SelectedValue = novavenda.EmailCliente;
                txtemailcliente.Text = novavenda.EmailCliente;
            }
            catch
            {
                MessageBox.Show("Houve algum problema selecionar a venda.\nContate o suporte técnico", "Atenção");
            }
            finally
            {
                //buscando = false;
            }

        }

        private void cbxproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(buscando)
            {
                string aux = cbxproduto.SelectedValue.ToString();
                txtvalorproduto.Text = produto.SelecionaValorProduto(aux);
            }
        }

        private void cbxproduto_Enter(object sender, EventArgs e)
        {
            buscando = true;
        }

        private void cbxproduto_Leave(object sender, EventArgs e)
        {
            buscando = false;
        }
    }
}
