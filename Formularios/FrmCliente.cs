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
    public partial class FrmCliente : Form
    {
        #region Inicializando variaveis
        ClienteDTO cliente = new ClienteDTO();
        #endregion

        #region Funções gerais do software
        private void LimpaCampos()
        {
            txtbuscacliente.Text = string.Empty;
            txtnomecliente.Text = string.Empty;
            txtemaildocliente.Text = string.Empty;

            cbxfiltrocliente.SelectedIndex = -1;
        }
        #endregion

        public FrmCliente()
        {
            InitializeComponent();
            dgvclientes.DataSource = cliente.DtAtualizaCliente();
        }

        private void btnnovocliente_Click(object sender, EventArgs e)
        {
            pnlnovocliente.Visible = true;
            LimpaCampos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            pnlnovocliente.Visible = false;
            LimpaCampos();
        }

        private void btnsalvarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnomecliente.Text == string.Empty || txtemaildocliente.Text == string.Empty)
                {
                    MessageBox.Show("Verifique se você preencheu todos os campos", "Atenção");
                }
                else
                {

                    cliente.Nome = txtnomecliente.Text;
                    cliente.Email = txtemaildocliente.Text;

                    
                    cliente.InsereCliente();
                    dgvclientes.DataSource = cliente.DtAtualizaCliente();
                }
            }
            catch
            {
                MessageBox.Show("Houve algum problema em salvar os dados do cliente.\nContate o suporte técnico", "Atenção");
                
            }
            finally
            {
                pnlnovocliente.Visible = false;
                LimpaCampos();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso");
            }
        }

        private void txtbuscacliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if(txtbuscacliente.Text == string.Empty)
                    {
                        dgvclientes.DataSource = cliente.DtAtualizaCliente();
                    }
                    else
                    {
                        dgvclientes.DataSource = cliente.DtAtualizaCliente(txtbuscacliente.Text, cbxfiltrocliente.Text);
                    }
                    LimpaCampos();
                }
            }
            catch
            {
                MessageBox.Show("Houve algum problema em buscar os dados do cliente.\nContate o suporte técnico", "Atenção");
                
            }
        }

        private void pbxbuscacliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtbuscacliente.Text == string.Empty)
                    {
                    dgvclientes.DataSource = cliente.DtAtualizaCliente();
                }
                else
                {
                    dgvclientes.DataSource = cliente.DtAtualizaCliente(txtbuscacliente.Text, cbxfiltrocliente.Text);
                }
                LimpaCampos();
            }
            catch
            {
                MessageBox.Show("Houve algum problema em buscar os dados do cliente.\nContate o suporte técnico", "Atenção");
                
            }
        }
    }
}
