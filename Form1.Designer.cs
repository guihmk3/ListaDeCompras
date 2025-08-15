namespace ListaDeCompras
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnApagartd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::ListaDeCompras.Properties.Resources.logo;
            this.pibLogo.Location = new System.Drawing.Point(31, 24);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(119, 109);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(224, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(390, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "LISTA DE COMPRAS:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(12, 167);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(178, 20);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "NOME DO PRODUTO:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(12, 190);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(178, 24);
            this.txbProduto.TabIndex = 3;
            this.txbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbProduto_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdicionar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.Location = new System.Drawing.Point(31, 220);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(139, 38);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.ItemHeight = 17;
            this.libCompras.Location = new System.Drawing.Point(232, 129);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(382, 344);
            this.libCompras.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(263, 491);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(167, 41);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnApagartd
            // 
            this.btnApagartd.BackColor = System.Drawing.Color.Red;
            this.btnApagartd.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagartd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagartd.Location = new System.Drawing.Point(436, 491);
            this.btnApagartd.Name = "btnApagartd";
            this.btnApagartd.Size = new System.Drawing.Size(159, 41);
            this.btnApagartd.TabIndex = 7;
            this.btnApagartd.Text = "Limpar Lista";
            this.btnApagartd.UseVisualStyleBackColor = false;
            this.btnApagartd.Click += new System.EventHandler(this.btnApagartd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 588);
            this.Controls.Add(this.btnApagartd);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: LISTA DE COMPRAS ::";
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnApagartd;
    }
}

