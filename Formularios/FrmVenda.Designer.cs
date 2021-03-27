
namespace Prova_SUM_Software.Formularios
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.tblytvendas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlvendasdomes = new System.Windows.Forms.Panel();
            this.dgvvendasdomes = new System.Windows.Forms.DataGridView();
            this.lblvendasdomes = new System.Windows.Forms.Label();
            this.pnldados = new System.Windows.Forms.Panel();
            this.btncancelarvenda = new System.Windows.Forms.Button();
            this.btnsalvavenda = new System.Windows.Forms.Button();
            this.rtxtmensagem = new System.Windows.Forms.RichTextBox();
            this.lbltexto = new System.Windows.Forms.Label();
            this.btnnovavenda = new System.Windows.Forms.Button();
            this.txtemailcliente = new System.Windows.Forms.TextBox();
            this.lblemailcliente = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.ntxtqtdproduto = new System.Windows.Forms.NumericUpDown();
            this.lblquantidadeproduto = new System.Windows.Forms.Label();
            this.lbldatadavenda = new System.Windows.Forms.Label();
            this.dtpdatavenda = new System.Windows.Forms.DateTimePicker();
            this.txtvalorproduto = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblnomeproduto = new System.Windows.Forms.Label();
            this.lbldadosdavenda = new System.Windows.Forms.Label();
            this.lblbuscavenda = new System.Windows.Forms.Label();
            this.txtbuscavenda = new System.Windows.Forms.TextBox();
            this.lblfiltrovenda = new System.Windows.Forms.Label();
            this.cbxfiltrovenda = new System.Windows.Forms.ComboBox();
            this.pbxbuscavenda = new System.Windows.Forms.PictureBox();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.cbxproduto = new System.Windows.Forms.ComboBox();
            this.btnenviaremail = new System.Windows.Forms.Button();
            this.tblytvendas.SuspendLayout();
            this.pnlvendasdomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendasdomes)).BeginInit();
            this.pnldados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtqtdproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscavenda)).BeginInit();
            this.SuspendLayout();
            // 
            // tblytvendas
            // 
            this.tblytvendas.ColumnCount = 2;
            this.tblytvendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblytvendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblytvendas.Controls.Add(this.pnlvendasdomes, 0, 0);
            this.tblytvendas.Controls.Add(this.pnldados, 1, 0);
            this.tblytvendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblytvendas.Location = new System.Drawing.Point(0, 0);
            this.tblytvendas.Margin = new System.Windows.Forms.Padding(0);
            this.tblytvendas.Name = "tblytvendas";
            this.tblytvendas.RowCount = 1;
            this.tblytvendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblytvendas.Size = new System.Drawing.Size(735, 450);
            this.tblytvendas.TabIndex = 0;
            // 
            // pnlvendasdomes
            // 
            this.pnlvendasdomes.Controls.Add(this.lblfiltrovenda);
            this.pnlvendasdomes.Controls.Add(this.cbxfiltrovenda);
            this.pnlvendasdomes.Controls.Add(this.pbxbuscavenda);
            this.pnlvendasdomes.Controls.Add(this.lblbuscavenda);
            this.pnlvendasdomes.Controls.Add(this.txtbuscavenda);
            this.pnlvendasdomes.Controls.Add(this.dgvvendasdomes);
            this.pnlvendasdomes.Controls.Add(this.lblvendasdomes);
            this.pnlvendasdomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlvendasdomes.Location = new System.Drawing.Point(3, 3);
            this.pnlvendasdomes.Name = "pnlvendasdomes";
            this.pnlvendasdomes.Size = new System.Drawing.Size(361, 444);
            this.pnlvendasdomes.TabIndex = 0;
            // 
            // dgvvendasdomes
            // 
            this.dgvvendasdomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvvendasdomes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvvendasdomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendasdomes.Location = new System.Drawing.Point(9, 89);
            this.dgvvendasdomes.Name = "dgvvendasdomes";
            this.dgvvendasdomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvvendasdomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvendasdomes.Size = new System.Drawing.Size(339, 349);
            this.dgvvendasdomes.TabIndex = 13;
            this.dgvvendasdomes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendasdomes_CellDoubleClick);
            // 
            // lblvendasdomes
            // 
            this.lblvendasdomes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblvendasdomes.AutoSize = true;
            this.lblvendasdomes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendasdomes.Location = new System.Drawing.Point(118, 10);
            this.lblvendasdomes.Name = "lblvendasdomes";
            this.lblvendasdomes.Size = new System.Drawing.Size(124, 21);
            this.lblvendasdomes.TabIndex = 0;
            this.lblvendasdomes.Text = "Vendas do mês";
            // 
            // pnldados
            // 
            this.pnldados.Controls.Add(this.btnenviaremail);
            this.pnldados.Controls.Add(this.cbxproduto);
            this.pnldados.Controls.Add(this.cbxcliente);
            this.pnldados.Controls.Add(this.btncancelarvenda);
            this.pnldados.Controls.Add(this.btnsalvavenda);
            this.pnldados.Controls.Add(this.rtxtmensagem);
            this.pnldados.Controls.Add(this.lbltexto);
            this.pnldados.Controls.Add(this.btnnovavenda);
            this.pnldados.Controls.Add(this.txtemailcliente);
            this.pnldados.Controls.Add(this.lblemailcliente);
            this.pnldados.Controls.Add(this.lblcliente);
            this.pnldados.Controls.Add(this.ntxtqtdproduto);
            this.pnldados.Controls.Add(this.lblquantidadeproduto);
            this.pnldados.Controls.Add(this.lbldatadavenda);
            this.pnldados.Controls.Add(this.dtpdatavenda);
            this.pnldados.Controls.Add(this.txtvalorproduto);
            this.pnldados.Controls.Add(this.lblvalor);
            this.pnldados.Controls.Add(this.lblnomeproduto);
            this.pnldados.Controls.Add(this.lbldadosdavenda);
            this.pnldados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldados.Location = new System.Drawing.Point(370, 3);
            this.pnldados.Name = "pnldados";
            this.pnldados.Size = new System.Drawing.Size(362, 444);
            this.pnldados.TabIndex = 1;
            // 
            // btncancelarvenda
            // 
            this.btncancelarvenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancelarvenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelarvenda.Enabled = false;
            this.btncancelarvenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelarvenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarvenda.Location = new System.Drawing.Point(199, 262);
            this.btncancelarvenda.Name = "btncancelarvenda";
            this.btncancelarvenda.Size = new System.Drawing.Size(110, 27);
            this.btncancelarvenda.TabIndex = 18;
            this.btncancelarvenda.Text = "Cancelar Venda";
            this.btncancelarvenda.UseVisualStyleBackColor = false;
            this.btncancelarvenda.Visible = false;
            this.btncancelarvenda.Click += new System.EventHandler(this.btncancelarvenda_Click);
            // 
            // btnsalvavenda
            // 
            this.btnsalvavenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalvavenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalvavenda.Enabled = false;
            this.btnsalvavenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvavenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvavenda.Location = new System.Drawing.Point(42, 262);
            this.btnsalvavenda.Name = "btnsalvavenda";
            this.btnsalvavenda.Size = new System.Drawing.Size(110, 27);
            this.btnsalvavenda.TabIndex = 17;
            this.btnsalvavenda.Text = "Confirmar Venda";
            this.btnsalvavenda.UseVisualStyleBackColor = false;
            this.btnsalvavenda.Visible = false;
            this.btnsalvavenda.Click += new System.EventHandler(this.btnsalvavenda_Click);
            // 
            // rtxtmensagem
            // 
            this.rtxtmensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtmensagem.Enabled = false;
            this.rtxtmensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtmensagem.Location = new System.Drawing.Point(13, 321);
            this.rtxtmensagem.Name = "rtxtmensagem";
            this.rtxtmensagem.Size = new System.Drawing.Size(335, 84);
            this.rtxtmensagem.TabIndex = 16;
            this.rtxtmensagem.Text = "";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(13, 297);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(76, 17);
            this.lbltexto.TabIndex = 15;
            this.lbltexto.Text = "Mensagem:";
            // 
            // btnnovavenda
            // 
            this.btnnovavenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnnovavenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnovavenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovavenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovavenda.Location = new System.Drawing.Point(126, 47);
            this.btnnovavenda.Name = "btnnovavenda";
            this.btnnovavenda.Size = new System.Drawing.Size(110, 27);
            this.btnnovavenda.TabIndex = 14;
            this.btnnovavenda.Text = "Nova Venda";
            this.btnnovavenda.UseVisualStyleBackColor = false;
            this.btnnovavenda.Click += new System.EventHandler(this.btnnovavenda_Click);
            // 
            // txtemailcliente
            // 
            this.txtemailcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemailcliente.Enabled = false;
            this.txtemailcliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcliente.Location = new System.Drawing.Point(71, 224);
            this.txtemailcliente.Name = "txtemailcliente";
            this.txtemailcliente.Size = new System.Drawing.Size(277, 25);
            this.txtemailcliente.TabIndex = 13;
            // 
            // lblemailcliente
            // 
            this.lblemailcliente.AutoSize = true;
            this.lblemailcliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailcliente.Location = new System.Drawing.Point(13, 228);
            this.lblemailcliente.Name = "lblemailcliente";
            this.lblemailcliente.Size = new System.Drawing.Size(47, 17);
            this.lblemailcliente.TabIndex = 12;
            this.lblemailcliente.Text = "E-mail:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(13, 193);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(50, 17);
            this.lblcliente.TabIndex = 10;
            this.lblcliente.Text = "Cliente:";
            // 
            // ntxtqtdproduto
            // 
            this.ntxtqtdproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtqtdproduto.Location = new System.Drawing.Point(102, 124);
            this.ntxtqtdproduto.Name = "ntxtqtdproduto";
            this.ntxtqtdproduto.Size = new System.Drawing.Size(50, 25);
            this.ntxtqtdproduto.TabIndex = 9;
            // 
            // lblquantidadeproduto
            // 
            this.lblquantidadeproduto.AutoSize = true;
            this.lblquantidadeproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantidadeproduto.Location = new System.Drawing.Point(13, 128);
            this.lblquantidadeproduto.Name = "lblquantidadeproduto";
            this.lblquantidadeproduto.Size = new System.Drawing.Size(79, 17);
            this.lblquantidadeproduto.TabIndex = 4;
            this.lblquantidadeproduto.Text = "Quantidade:";
            // 
            // lbldatadavenda
            // 
            this.lbldatadavenda.AutoSize = true;
            this.lbldatadavenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatadavenda.Location = new System.Drawing.Point(13, 161);
            this.lbldatadavenda.Name = "lbldatadavenda";
            this.lbldatadavenda.Size = new System.Drawing.Size(96, 17);
            this.lbldatadavenda.TabIndex = 8;
            this.lbldatadavenda.Text = "Data da venda:";
            // 
            // dtpdatavenda
            // 
            this.dtpdatavenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpdatavenda.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdatavenda.Location = new System.Drawing.Point(116, 159);
            this.dtpdatavenda.Name = "dtpdatavenda";
            this.dtpdatavenda.Size = new System.Drawing.Size(232, 20);
            this.dtpdatavenda.TabIndex = 7;
            // 
            // txtvalorproduto
            // 
            this.txtvalorproduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalorproduto.Enabled = false;
            this.txtvalorproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorproduto.Location = new System.Drawing.Point(213, 124);
            this.txtvalorproduto.Name = "txtvalorproduto";
            this.txtvalorproduto.Size = new System.Drawing.Size(135, 25);
            this.txtvalorproduto.TabIndex = 6;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(162, 128);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(41, 17);
            this.lblvalor.TabIndex = 5;
            this.lblvalor.Text = "Valor:";
            // 
            // lblnomeproduto
            // 
            this.lblnomeproduto.AutoSize = true;
            this.lblnomeproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeproduto.Location = new System.Drawing.Point(13, 93);
            this.lblnomeproduto.Name = "lblnomeproduto";
            this.lblnomeproduto.Size = new System.Drawing.Size(58, 17);
            this.lblnomeproduto.TabIndex = 3;
            this.lblnomeproduto.Text = "Produto:";
            // 
            // lbldadosdavenda
            // 
            this.lbldadosdavenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldadosdavenda.AutoSize = true;
            this.lbldadosdavenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldadosdavenda.Location = new System.Drawing.Point(115, 10);
            this.lbldadosdavenda.Name = "lbldadosdavenda";
            this.lbldadosdavenda.Size = new System.Drawing.Size(132, 21);
            this.lbldadosdavenda.TabIndex = 1;
            this.lbldadosdavenda.Text = "Dados da venda";
            // 
            // lblbuscavenda
            // 
            this.lblbuscavenda.AutoSize = true;
            this.lblbuscavenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscavenda.Location = new System.Drawing.Point(6, 39);
            this.lblbuscavenda.Name = "lblbuscavenda";
            this.lblbuscavenda.Size = new System.Drawing.Size(169, 17);
            this.lblbuscavenda.TabIndex = 15;
            this.lblbuscavenda.Text = "Procure pelo seu produto:";
            // 
            // txtbuscavenda
            // 
            this.txtbuscavenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscavenda.Location = new System.Drawing.Point(9, 61);
            this.txtbuscavenda.Name = "txtbuscavenda";
            this.txtbuscavenda.Size = new System.Drawing.Size(162, 20);
            this.txtbuscavenda.TabIndex = 14;
            this.txtbuscavenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscavenda_KeyUp);
            // 
            // lblfiltrovenda
            // 
            this.lblfiltrovenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfiltrovenda.AutoSize = true;
            this.lblfiltrovenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrovenda.Location = new System.Drawing.Point(178, 39);
            this.lblfiltrovenda.Name = "lblfiltrovenda";
            this.lblfiltrovenda.Size = new System.Drawing.Size(45, 17);
            this.lblfiltrovenda.TabIndex = 18;
            this.lblfiltrovenda.Text = "Filtro:";
            // 
            // cbxfiltrovenda
            // 
            this.cbxfiltrovenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxfiltrovenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfiltrovenda.FormattingEnabled = true;
            this.cbxfiltrovenda.Items.AddRange(new object[] {
            "Produto",
            "Valor",
            "Cliente",
            "Email",
            "Data_Venda",
            "Quantidade"});
            this.cbxfiltrovenda.Location = new System.Drawing.Point(181, 61);
            this.cbxfiltrovenda.Name = "cbxfiltrovenda";
            this.cbxfiltrovenda.Size = new System.Drawing.Size(121, 21);
            this.cbxfiltrovenda.TabIndex = 17;
            // 
            // pbxbuscavenda
            // 
            this.pbxbuscavenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxbuscavenda.BackgroundImage = global::Prova_SUM_Software.Properties.Resources.loupe;
            this.pbxbuscavenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxbuscavenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxbuscavenda.Location = new System.Drawing.Point(308, 56);
            this.pbxbuscavenda.Name = "pbxbuscavenda";
            this.pbxbuscavenda.Size = new System.Drawing.Size(40, 30);
            this.pbxbuscavenda.TabIndex = 16;
            this.pbxbuscavenda.TabStop = false;
            this.pbxbuscavenda.Click += new System.EventHandler(this.pbxbuscavenda_Click);
            // 
            // cbxcliente
            // 
            this.cbxcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(71, 189);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(277, 25);
            this.cbxcliente.TabIndex = 19;
            this.cbxcliente.SelectedIndexChanged += new System.EventHandler(this.cbxcliente_SelectedIndexChanged);
            this.cbxcliente.Enter += new System.EventHandler(this.cbxcliente_Enter);
            this.cbxcliente.Leave += new System.EventHandler(this.cbxcliente_Leave);
            // 
            // cbxproduto
            // 
            this.cbxproduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxproduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxproduto.FormattingEnabled = true;
            this.cbxproduto.Location = new System.Drawing.Point(77, 89);
            this.cbxproduto.Name = "cbxproduto";
            this.cbxproduto.Size = new System.Drawing.Size(277, 25);
            this.cbxproduto.TabIndex = 20;
            this.cbxproduto.SelectedIndexChanged += new System.EventHandler(this.cbxproduto_SelectedIndexChanged);
            this.cbxproduto.Enter += new System.EventHandler(this.cbxproduto_Enter);
            this.cbxproduto.Leave += new System.EventHandler(this.cbxproduto_Leave);
            // 
            // btnenviaremail
            // 
            this.btnenviaremail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnenviaremail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnenviaremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviaremail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviaremail.Location = new System.Drawing.Point(126, 411);
            this.btnenviaremail.Name = "btnenviaremail";
            this.btnenviaremail.Size = new System.Drawing.Size(110, 27);
            this.btnenviaremail.TabIndex = 21;
            this.btnenviaremail.Text = "Enviar e-mail";
            this.btnenviaremail.UseVisualStyleBackColor = false;
            this.btnenviaremail.Click += new System.EventHandler(this.btnenviaremail_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.tblytvendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.tblytvendas.ResumeLayout(false);
            this.pnlvendasdomes.ResumeLayout(false);
            this.pnlvendasdomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendasdomes)).EndInit();
            this.pnldados.ResumeLayout(false);
            this.pnldados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtqtdproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscavenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblytvendas;
        private System.Windows.Forms.Panel pnlvendasdomes;
        private System.Windows.Forms.Label lblvendasdomes;
        private System.Windows.Forms.Panel pnldados;
        private System.Windows.Forms.DataGridView dgvvendasdomes;
        private System.Windows.Forms.TextBox txtvalorproduto;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblnomeproduto;
        private System.Windows.Forms.Label lbldadosdavenda;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.NumericUpDown ntxtqtdproduto;
        private System.Windows.Forms.Label lblquantidadeproduto;
        private System.Windows.Forms.Label lbldatadavenda;
        private System.Windows.Forms.DateTimePicker dtpdatavenda;
        private System.Windows.Forms.TextBox txtemailcliente;
        private System.Windows.Forms.Label lblemailcliente;
        private System.Windows.Forms.Button btncancelarvenda;
        private System.Windows.Forms.Button btnsalvavenda;
        private System.Windows.Forms.RichTextBox rtxtmensagem;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Button btnnovavenda;
        private System.Windows.Forms.Label lblbuscavenda;
        private System.Windows.Forms.TextBox txtbuscavenda;
        private System.Windows.Forms.Label lblfiltrovenda;
        private System.Windows.Forms.ComboBox cbxfiltrovenda;
        private System.Windows.Forms.PictureBox pbxbuscavenda;
        private System.Windows.Forms.ComboBox cbxproduto;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.Button btnenviaremail;
    }
}