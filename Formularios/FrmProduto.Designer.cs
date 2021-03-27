
namespace Prova_SUM_Software.Formularios
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.btnnovoproduto = new System.Windows.Forms.Button();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.lblfiltroproduto = new System.Windows.Forms.Label();
            this.lblbuscaproduto = new System.Windows.Forms.Label();
            this.cbxfiltroproduto = new System.Windows.Forms.ComboBox();
            this.pbxbuscaproduto = new System.Windows.Forms.PictureBox();
            this.txtbuscaproduto = new System.Windows.Forms.TextBox();
            this.pnlnovoproduto = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvarproduto = new System.Windows.Forms.Button();
            this.txtvalorproduto = new System.Windows.Forms.TextBox();
            this.lblemaildoproduto = new System.Windows.Forms.Label();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.lblnovoproduto = new System.Windows.Forms.Label();
            this.lblnomedoproduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscaproduto)).BeginInit();
            this.pnlnovoproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovoproduto
            // 
            this.btnnovoproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnovoproduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnovoproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovoproduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovoproduto.Location = new System.Drawing.Point(614, 33);
            this.btnnovoproduto.Name = "btnnovoproduto";
            this.btnnovoproduto.Size = new System.Drawing.Size(110, 27);
            this.btnnovoproduto.TabIndex = 13;
            this.btnnovoproduto.Text = "Novo Produto";
            this.btnnovoproduto.UseVisualStyleBackColor = false;
            this.btnnovoproduto.Click += new System.EventHandler(this.btnnovoproduto_Click);
            // 
            // dgvproduto
            // 
            this.dgvproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproduto.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Location = new System.Drawing.Point(12, 71);
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(712, 375);
            this.dgvproduto.TabIndex = 12;
            // 
            // lblfiltroproduto
            // 
            this.lblfiltroproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfiltroproduto.AutoSize = true;
            this.lblfiltroproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltroproduto.Location = new System.Drawing.Point(438, 14);
            this.lblfiltroproduto.Name = "lblfiltroproduto";
            this.lblfiltroproduto.Size = new System.Drawing.Size(45, 17);
            this.lblfiltroproduto.TabIndex = 11;
            this.lblfiltroproduto.Text = "Filtro:";
            // 
            // lblbuscaproduto
            // 
            this.lblbuscaproduto.AutoSize = true;
            this.lblbuscaproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscaproduto.Location = new System.Drawing.Point(9, 14);
            this.lblbuscaproduto.Name = "lblbuscaproduto";
            this.lblbuscaproduto.Size = new System.Drawing.Size(169, 17);
            this.lblbuscaproduto.TabIndex = 10;
            this.lblbuscaproduto.Text = "Procure pelo seu produto:";
            // 
            // cbxfiltroproduto
            // 
            this.cbxfiltroproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxfiltroproduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfiltroproduto.FormattingEnabled = true;
            this.cbxfiltroproduto.Items.AddRange(new object[] {
            "Nome",
            "Valor"});
            this.cbxfiltroproduto.Location = new System.Drawing.Point(441, 36);
            this.cbxfiltroproduto.Name = "cbxfiltroproduto";
            this.cbxfiltroproduto.Size = new System.Drawing.Size(121, 21);
            this.cbxfiltroproduto.TabIndex = 9;
            // 
            // pbxbuscaproduto
            // 
            this.pbxbuscaproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxbuscaproduto.BackgroundImage = global::Prova_SUM_Software.Properties.Resources.loupe;
            this.pbxbuscaproduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxbuscaproduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxbuscaproduto.Location = new System.Drawing.Point(568, 31);
            this.pbxbuscaproduto.Name = "pbxbuscaproduto";
            this.pbxbuscaproduto.Size = new System.Drawing.Size(40, 30);
            this.pbxbuscaproduto.TabIndex = 8;
            this.pbxbuscaproduto.TabStop = false;
            this.pbxbuscaproduto.Click += new System.EventHandler(this.pbxbuscaproduto_Click);
            // 
            // txtbuscaproduto
            // 
            this.txtbuscaproduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscaproduto.Location = new System.Drawing.Point(12, 36);
            this.txtbuscaproduto.Name = "txtbuscaproduto";
            this.txtbuscaproduto.Size = new System.Drawing.Size(423, 20);
            this.txtbuscaproduto.TabIndex = 7;
            this.txtbuscaproduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscaproduto_KeyUp);
            // 
            // pnlnovoproduto
            // 
            this.pnlnovoproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlnovoproduto.Controls.Add(this.btncancelar);
            this.pnlnovoproduto.Controls.Add(this.btnsalvarproduto);
            this.pnlnovoproduto.Controls.Add(this.txtvalorproduto);
            this.pnlnovoproduto.Controls.Add(this.lblemaildoproduto);
            this.pnlnovoproduto.Controls.Add(this.txtnomeproduto);
            this.pnlnovoproduto.Controls.Add(this.lblnovoproduto);
            this.pnlnovoproduto.Controls.Add(this.lblnomedoproduto);
            this.pnlnovoproduto.Location = new System.Drawing.Point(2, 4);
            this.pnlnovoproduto.Name = "pnlnovoproduto";
            this.pnlnovoproduto.Size = new System.Drawing.Size(723, 442);
            this.pnlnovoproduto.TabIndex = 14;
            this.pnlnovoproduto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(368, 117);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 27);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvarproduto
            // 
            this.btnsalvarproduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalvarproduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalvarproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarproduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarproduto.Location = new System.Drawing.Point(232, 117);
            this.btnsalvarproduto.Name = "btnsalvarproduto";
            this.btnsalvarproduto.Size = new System.Drawing.Size(110, 27);
            this.btnsalvarproduto.TabIndex = 13;
            this.btnsalvarproduto.Text = "Salvar";
            this.btnsalvarproduto.UseVisualStyleBackColor = false;
            this.btnsalvarproduto.Click += new System.EventHandler(this.btnsalvarproduto_Click);
            // 
            // txtvalorproduto
            // 
            this.txtvalorproduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalorproduto.Location = new System.Drawing.Point(70, 78);
            this.txtvalorproduto.Name = "txtvalorproduto";
            this.txtvalorproduto.Size = new System.Drawing.Size(638, 20);
            this.txtvalorproduto.TabIndex = 12;
            // 
            // lblemaildoproduto
            // 
            this.lblemaildoproduto.AutoSize = true;
            this.lblemaildoproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemaildoproduto.Location = new System.Drawing.Point(23, 80);
            this.lblemaildoproduto.Name = "lblemaildoproduto";
            this.lblemaildoproduto.Size = new System.Drawing.Size(41, 17);
            this.lblemaildoproduto.TabIndex = 11;
            this.lblemaildoproduto.Text = "Valor:";
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnomeproduto.Location = new System.Drawing.Point(70, 48);
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(638, 20);
            this.txtnomeproduto.TabIndex = 10;
            // 
            // lblnovoproduto
            // 
            this.lblnovoproduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnovoproduto.AutoSize = true;
            this.lblnovoproduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovoproduto.Location = new System.Drawing.Point(306, 14);
            this.lblnovoproduto.Name = "lblnovoproduto";
            this.lblnovoproduto.Size = new System.Drawing.Size(118, 21);
            this.lblnovoproduto.TabIndex = 8;
            this.lblnovoproduto.Text = "Novo Produto";
            // 
            // lblnomedoproduto
            // 
            this.lblnomedoproduto.AutoSize = true;
            this.lblnomedoproduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomedoproduto.Location = new System.Drawing.Point(17, 50);
            this.lblnomedoproduto.Name = "lblnomedoproduto";
            this.lblnomedoproduto.Size = new System.Drawing.Size(47, 17);
            this.lblnomedoproduto.TabIndex = 9;
            this.lblnomedoproduto.Text = "Nome:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.pnlnovoproduto);
            this.Controls.Add(this.btnnovoproduto);
            this.Controls.Add(this.dgvproduto);
            this.Controls.Add(this.lblfiltroproduto);
            this.Controls.Add(this.lblbuscaproduto);
            this.Controls.Add(this.cbxfiltroproduto);
            this.Controls.Add(this.pbxbuscaproduto);
            this.Controls.Add(this.txtbuscaproduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbuscaproduto)).EndInit();
            this.pnlnovoproduto.ResumeLayout(false);
            this.pnlnovoproduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovoproduto;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.Label lblfiltroproduto;
        private System.Windows.Forms.Label lblbuscaproduto;
        private System.Windows.Forms.ComboBox cbxfiltroproduto;
        private System.Windows.Forms.PictureBox pbxbuscaproduto;
        private System.Windows.Forms.TextBox txtbuscaproduto;
        private System.Windows.Forms.Panel pnlnovoproduto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvarproduto;
        private System.Windows.Forms.TextBox txtvalorproduto;
        private System.Windows.Forms.Label lblemaildoproduto;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.Label lblnovoproduto;
        private System.Windows.Forms.Label lblnomedoproduto;
    }
}