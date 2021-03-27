
namespace Prova_SUM_Software
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.topmenuprincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnomedosistema = new System.Windows.Forms.Label();
            this.topmenuprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // topmenuprincipal
            // 
            this.topmenuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.topmenuprincipal.Location = new System.Drawing.Point(0, 0);
            this.topmenuprincipal.Name = "topmenuprincipal";
            this.topmenuprincipal.Size = new System.Drawing.Size(923, 24);
            this.topmenuprincipal.TabIndex = 0;
            this.topmenuprincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasRealizadasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasRealizadasToolStripMenuItem
            // 
            this.vendasRealizadasToolStripMenuItem.Name = "vendasRealizadasToolStripMenuItem";
            this.vendasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasRealizadasToolStripMenuItem.Text = "Vendas do mês";
            this.vendasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.vendasRealizadasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoUsarToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // comoUsarToolStripMenuItem
            // 
            this.comoUsarToolStripMenuItem.Name = "comoUsarToolStripMenuItem";
            this.comoUsarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comoUsarToolStripMenuItem.Text = "Como Usar";
            this.comoUsarToolStripMenuItem.Click += new System.EventHandler(this.comoUsarToolStripMenuItem_Click);
            // 
            // lblnomedosistema
            // 
            this.lblnomedosistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblnomedosistema.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomedosistema.Location = new System.Drawing.Point(0, 24);
            this.lblnomedosistema.Name = "lblnomedosistema";
            this.lblnomedosistema.Size = new System.Drawing.Size(923, 520);
            this.lblnomedosistema.TabIndex = 1;
            this.lblnomedosistema.Text = "SISTEMA COMERCIAL";
            this.lblnomedosistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 544);
            this.Controls.Add(this.lblnomedosistema);
            this.Controls.Add(this.topmenuprincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topmenuprincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Comercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topmenuprincipal.ResumeLayout(false);
            this.topmenuprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topmenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUsarToolStripMenuItem;
        private System.Windows.Forms.Label lblnomedosistema;
    }
}

