
namespace Prova_SUM_Software.Formularios
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtbuscacliente = new System.Windows.Forms.TextBox();
            this.cbxfiltrocliente = new System.Windows.Forms.ComboBox();
            this.lblbuscacliente = new System.Windows.Forms.Label();
            this.lblfiltrocliente = new System.Windows.Forms.Label();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.btnnovocliente = new System.Windows.Forms.Button();
            this.pbxbuscacliente = new System.Windows.Forms.PictureBox();
            this.pnlnovocliente = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvarcliente = new System.Windows.Forms.Button();
            this.txtemaildocliente = new System.Windows.Forms.TextBox();
            this.lblemaildocliente = new System.Windows.Forms.Label();
            this.txtnomecliente = new System.Windows.Forms.TextBox();
            this.lblnomedocliente = new System.Windows.Forms.Label();
            this.lblnovocliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscacliente)).BeginInit();
            this.pnlnovocliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscacliente
            // 
            this.txtbuscacliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscacliente.Location = new System.Drawing.Point(12, 36);
            this.txtbuscacliente.Name = "txtbuscacliente";
            this.txtbuscacliente.Size = new System.Drawing.Size(423, 20);
            this.txtbuscacliente.TabIndex = 0;
            this.txtbuscacliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscacliente_KeyUp);
            // 
            // cbxfiltrocliente
            // 
            this.cbxfiltrocliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxfiltrocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfiltrocliente.FormattingEnabled = true;
            this.cbxfiltrocliente.Items.AddRange(new object[] {
            "Nome",
            "Email"});
            this.cbxfiltrocliente.Location = new System.Drawing.Point(441, 36);
            this.cbxfiltrocliente.Name = "cbxfiltrocliente";
            this.cbxfiltrocliente.Size = new System.Drawing.Size(121, 21);
            this.cbxfiltrocliente.TabIndex = 2;
            // 
            // lblbuscacliente
            // 
            this.lblbuscacliente.AutoSize = true;
            this.lblbuscacliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscacliente.Location = new System.Drawing.Point(9, 14);
            this.lblbuscacliente.Name = "lblbuscacliente";
            this.lblbuscacliente.Size = new System.Drawing.Size(160, 17);
            this.lblbuscacliente.TabIndex = 3;
            this.lblbuscacliente.Text = "Procure pelo seu cliente:";
            // 
            // lblfiltrocliente
            // 
            this.lblfiltrocliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfiltrocliente.AutoSize = true;
            this.lblfiltrocliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrocliente.Location = new System.Drawing.Point(438, 14);
            this.lblfiltrocliente.Name = "lblfiltrocliente";
            this.lblfiltrocliente.Size = new System.Drawing.Size(45, 17);
            this.lblfiltrocliente.TabIndex = 4;
            this.lblfiltrocliente.Text = "Filtro:";
            // 
            // dgvclientes
            // 
            this.dgvclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclientes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(12, 71);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclientes.Size = new System.Drawing.Size(712, 375);
            this.dgvclientes.TabIndex = 5;
            // 
            // btnnovocliente
            // 
            this.btnnovocliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnovocliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnovocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovocliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovocliente.Location = new System.Drawing.Point(614, 33);
            this.btnnovocliente.Name = "btnnovocliente";
            this.btnnovocliente.Size = new System.Drawing.Size(110, 27);
            this.btnnovocliente.TabIndex = 6;
            this.btnnovocliente.Text = "Novo Cliente";
            this.btnnovocliente.UseVisualStyleBackColor = false;
            this.btnnovocliente.Click += new System.EventHandler(this.btnnovocliente_Click);
            // 
            // pbxbuscacliente
            // 
            this.pbxbuscacliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxbuscacliente.BackgroundImage = global::Prova_SUM_Software.Properties.Resources.loupe;
            this.pbxbuscacliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxbuscacliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxbuscacliente.Location = new System.Drawing.Point(568, 31);
            this.pbxbuscacliente.Name = "pbxbuscacliente";
            this.pbxbuscacliente.Size = new System.Drawing.Size(40, 30);
            this.pbxbuscacliente.TabIndex = 1;
            this.pbxbuscacliente.TabStop = false;
            this.pbxbuscacliente.Click += new System.EventHandler(this.pbxbuscacliente_Click);
            // 
            // pnlnovocliente
            // 
            this.pnlnovocliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlnovocliente.Controls.Add(this.btncancelar);
            this.pnlnovocliente.Controls.Add(this.btnsalvarcliente);
            this.pnlnovocliente.Controls.Add(this.txtemaildocliente);
            this.pnlnovocliente.Controls.Add(this.lblemaildocliente);
            this.pnlnovocliente.Controls.Add(this.txtnomecliente);
            this.pnlnovocliente.Controls.Add(this.lblnovocliente);
            this.pnlnovocliente.Controls.Add(this.lblnomedocliente);
            this.pnlnovocliente.Location = new System.Drawing.Point(8, 12);
            this.pnlnovocliente.Name = "pnlnovocliente";
            this.pnlnovocliente.Size = new System.Drawing.Size(716, 434);
            this.pnlnovocliente.TabIndex = 7;
            this.pnlnovocliente.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(365, 117);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 27);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvarcliente
            // 
            this.btnsalvarcliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalvarcliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalvarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarcliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarcliente.Location = new System.Drawing.Point(229, 117);
            this.btnsalvarcliente.Name = "btnsalvarcliente";
            this.btnsalvarcliente.Size = new System.Drawing.Size(110, 27);
            this.btnsalvarcliente.TabIndex = 13;
            this.btnsalvarcliente.Text = "Salvar";
            this.btnsalvarcliente.UseVisualStyleBackColor = false;
            this.btnsalvarcliente.Click += new System.EventHandler(this.btnsalvarcliente_Click);
            // 
            // txtemaildocliente
            // 
            this.txtemaildocliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemaildocliente.Location = new System.Drawing.Point(70, 78);
            this.txtemaildocliente.Name = "txtemaildocliente";
            this.txtemaildocliente.Size = new System.Drawing.Size(631, 20);
            this.txtemaildocliente.TabIndex = 12;
            // 
            // lblemaildocliente
            // 
            this.lblemaildocliente.AutoSize = true;
            this.lblemaildocliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemaildocliente.Location = new System.Drawing.Point(17, 80);
            this.lblemaildocliente.Name = "lblemaildocliente";
            this.lblemaildocliente.Size = new System.Drawing.Size(47, 17);
            this.lblemaildocliente.TabIndex = 11;
            this.lblemaildocliente.Text = "e-mail:";
            // 
            // txtnomecliente
            // 
            this.txtnomecliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnomecliente.Location = new System.Drawing.Point(70, 48);
            this.txtnomecliente.Name = "txtnomecliente";
            this.txtnomecliente.Size = new System.Drawing.Size(631, 20);
            this.txtnomecliente.TabIndex = 10;
            // 
            // lblnomedocliente
            // 
            this.lblnomedocliente.AutoSize = true;
            this.lblnomedocliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomedocliente.Location = new System.Drawing.Point(17, 50);
            this.lblnomedocliente.Name = "lblnomedocliente";
            this.lblnomedocliente.Size = new System.Drawing.Size(47, 17);
            this.lblnomedocliente.TabIndex = 9;
            this.lblnomedocliente.Text = "Nome:";
            // 
            // lblnovocliente
            // 
            this.lblnovocliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnovocliente.AutoSize = true;
            this.lblnovocliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovocliente.Location = new System.Drawing.Point(303, 14);
            this.lblnovocliente.Name = "lblnovocliente";
            this.lblnovocliente.Size = new System.Drawing.Size(110, 21);
            this.lblnovocliente.TabIndex = 8;
            this.lblnovocliente.Text = "Novo Cliente";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.pnlnovocliente);
            this.Controls.Add(this.btnnovocliente);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.lblfiltrocliente);
            this.Controls.Add(this.lblbuscacliente);
            this.Controls.Add(this.cbxfiltrocliente);
            this.Controls.Add(this.pbxbuscacliente);
            this.Controls.Add(this.txtbuscacliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscacliente)).EndInit();
            this.pnlnovocliente.ResumeLayout(false);
            this.pnlnovocliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscacliente;
        private System.Windows.Forms.PictureBox pbxbuscacliente;
        private System.Windows.Forms.ComboBox cbxfiltrocliente;
        private System.Windows.Forms.Label lblbuscacliente;
        private System.Windows.Forms.Label lblfiltrocliente;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.Button btnnovocliente;
        private System.Windows.Forms.Panel pnlnovocliente;
        private System.Windows.Forms.TextBox txtemaildocliente;
        private System.Windows.Forms.Label lblemaildocliente;
        private System.Windows.Forms.TextBox txtnomecliente;
        private System.Windows.Forms.Label lblnomedocliente;
        private System.Windows.Forms.Label lblnovocliente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvarcliente;
    }
}