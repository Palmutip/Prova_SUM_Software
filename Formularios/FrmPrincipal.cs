using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova_SUM_Software.Formularios;

namespace Prova_SUM_Software
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Funcões para abrir formulários
        private void AbrirFormCliente()
        {
            Application.Run(new FrmCliente());
        }
        private void AbrirFormProduto()
        {
            Application.Run(new FrmProduto());
        }
        private void AbrirFormVenda()
        {
            Application.Run(new FrmVenda());
        }
        #endregion

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCliente>().Count() == 0)
            {
                Thread nt;
                nt = new Thread(AbrirFormCliente);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmProduto>().Count() == 0)
            {
                Thread nt;
                nt = new Thread(AbrirFormProduto);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void vendasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVenda>().Count() == 0)
            {
                Thread nt;
                nt = new Thread(AbrirFormVenda);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void comoUsarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para realizar uma venda no sistema comercial:\n\n-Realize o Cadastro do seu Produto.\n-Realize o Cadastro de seu Cliente." +
                "\n-Acesse o menu de vendas e clique em Nova Venda.\n-Depois de preencher os campos, clique em confirmar venda.", "Ajuda");
        }
    }
}
