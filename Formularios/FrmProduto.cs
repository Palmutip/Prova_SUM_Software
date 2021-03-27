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
    public partial class FrmProduto : Form
    {
        #region Inicializando variaveis
        ProdutoDTO produto = new ProdutoDTO();
        #endregion

        #region Funções gerais do software
        private void LimpaCampos()
        {
            txtbuscaproduto.Text = string.Empty;
            txtnomeproduto.Text = string.Empty;
            txtvalorproduto.Text = string.Empty;

            cbxfiltroproduto.SelectedIndex = -1;
        }
        #endregion

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnnovoproduto_Click(object sender, EventArgs e)
        {
            pnlnovoproduto.Visible = true;
            LimpaCampos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            pnlnovoproduto.Visible = false;
            LimpaCampos();
        }

        private void txtbuscaproduto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtbuscaproduto.Text == string.Empty)
                    {
                        dgvproduto.DataSource = produto.DtAtualizaProduto();
                    }
                    else
                    {
                        dgvproduto.DataSource = produto.DtAtualizaProduto(txtbuscaproduto.Text, cbxfiltroproduto.Text);
                    }
                    LimpaCampos();
                }
            }
            catch
            {
                MessageBox.Show("Houve algum problema em buscar os dados do produto.\nContate o suporte técnico", "Atenção");
                throw;
            }
        }

        private void pbxbuscaproduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbuscaproduto.Text == string.Empty)
                {
                    dgvproduto.DataSource = produto.DtAtualizaProduto();
                }
                else
                {
                    dgvproduto.DataSource = produto.DtAtualizaProduto(txtbuscaproduto.Text, cbxfiltroproduto.Text);
                }
                LimpaCampos();
            }
            catch
            {
                MessageBox.Show("Houve algum problema em buscar os dados do produto.\nContate o suporte técnico", "Atenção");
                throw;
            }
        }

        private void btnsalvarproduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnomeproduto.Text == string.Empty || txtvalorproduto.Text == string.Empty)
                {
                    MessageBox.Show("Verifique se você preencheu todos os campos", "Atenção");
                }
                else
                {

                    produto.Nome = txtnomeproduto.Text;
                    produto.Valor = Convert.ToDouble(txtvalorproduto.Text);

                    produto.InsereProduto();
                    dgvproduto.DataSource = produto.DtAtualizaProduto();
                }
            }
            catch
            {
                MessageBox.Show("Houve algum problema em salvar os dados do cliente.\nContate o suporte técnico", "Atenção");
                throw;
            }
            finally
            {
                pnlnovoproduto.Visible = false;
                LimpaCampos();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso");
            }
        }
    }
}
