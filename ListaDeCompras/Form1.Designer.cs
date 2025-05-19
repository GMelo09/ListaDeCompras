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
            this.libListaCompras = new System.Windows.Forms.ListBox();
            this.txbCadastrarItem = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libListaCompras
            // 
            this.libListaCompras.FormattingEnabled = true;
            this.libListaCompras.Location = new System.Drawing.Point(442, 12);
            this.libListaCompras.Name = "libListaCompras";
            this.libListaCompras.Size = new System.Drawing.Size(370, 433);
            this.libListaCompras.TabIndex = 2;
            this.libListaCompras.DoubleClick += new System.EventHandler(this.libListaCompras_DoubleClick);
            // 
            // txbCadastrarItem
            // 
            this.txbCadastrarItem.Location = new System.Drawing.Point(21, 141);
            this.txbCadastrarItem.Multiline = true;
            this.txbCadastrarItem.Name = "txbCadastrarItem";
            this.txbCadastrarItem.Size = new System.Drawing.Size(345, 48);
            this.txbCadastrarItem.TabIndex = 3;
            this.txbCadastrarItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCadastrarItem_KeyDown);
            this.txbCadastrarItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCadastrarItem_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.BackgroundImage = global::ListaDeCompras.Properties.Resources.Sem_Título_2;
            this.btnLimpar.Location = new System.Drawing.Point(120, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.White;
            this.lblAviso.Location = new System.Drawing.Point(655, 421);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(147, 13);
            this.lblAviso.TabIndex = 5;
            this.lblAviso.Text = "Clicar duas vezes para excluir";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.BackgroundImage = global::ListaDeCompras.Properties.Resources.Sem_Título_2;
            this.btnAdicionar.Location = new System.Drawing.Point(47, 205);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(279, 49);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListaDeCompras.Properties.Resources.MRC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 464);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbCadastrarItem);
            this.Controls.Add(this.libListaCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libListaCompras;
        private System.Windows.Forms.TextBox txbCadastrarItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAviso;
    }
}

