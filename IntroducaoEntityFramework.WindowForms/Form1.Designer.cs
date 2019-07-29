namespace IntroducaoEntityFramework.WindowForms
{
    partial class Form1
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNomeLoja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescricaoLoja = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbDescricaoProduto = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastroProdutoNomeLoja = new System.Windows.Forms.Button();
            this.btnPesquisarLojaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaPorNome = new System.Windows.Forms.Button();
            this.btnAumentarPreco = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnRemoveLoja = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 33);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Loja";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbDescricaoLoja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNomeLoja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 185);
            this.panel1.TabIndex = 2;
            // 
            // tbNomeLoja
            // 
            this.tbNomeLoja.Location = new System.Drawing.Point(88, 11);
            this.tbNomeLoja.Name = "tbNomeLoja";
            this.tbNomeLoja.Size = new System.Drawing.Size(308, 20);
            this.tbNomeLoja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da loja";
            // 
            // rtbDescricaoLoja
            // 
            this.rtbDescricaoLoja.Location = new System.Drawing.Point(12, 55);
            this.rtbDescricaoLoja.Name = "rtbDescricaoLoja";
            this.rtbDescricaoLoja.Size = new System.Drawing.Size(384, 96);
            this.rtbDescricaoLoja.TabIndex = 4;
            this.rtbDescricaoLoja.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbValorProduto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rtbDescricaoProduto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbNomeProduto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 176);
            this.panel2.TabIndex = 3;
            // 
            // rtbDescricaoProduto
            // 
            this.rtbDescricaoProduto.Location = new System.Drawing.Point(3, 123);
            this.rtbDescricaoProduto.Name = "rtbDescricaoProduto";
            this.rtbDescricaoProduto.Size = new System.Drawing.Size(393, 50);
            this.rtbDescricaoProduto.TabIndex = 8;
            this.rtbDescricaoProduto.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição do Produto";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(102, 14);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(294, 20);
            this.tbNomeProduto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Produto";
            // 
            // tbValorProduto
            // 
            this.tbValorProduto.Location = new System.Drawing.Point(102, 50);
            this.tbValorProduto.Name = "tbValorProduto";
            this.tbValorProduto.Size = new System.Drawing.Size(78, 20);
            this.tbValorProduto.TabIndex = 10;
            this.tbValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorProduto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "valor do Produto";
            // 
            // btnCadastroProdutoNomeLoja
            // 
            this.btnCadastroProdutoNomeLoja.Location = new System.Drawing.Point(131, 405);
            this.btnCadastroProdutoNomeLoja.Name = "btnCadastroProdutoNomeLoja";
            this.btnCadastroProdutoNomeLoja.Size = new System.Drawing.Size(201, 34);
            this.btnCadastroProdutoNomeLoja.TabIndex = 4;
            this.btnCadastroProdutoNomeLoja.Text = "Cadastrar Produto  pelo nome da loja";
            this.btnCadastroProdutoNomeLoja.UseVisualStyleBackColor = true;
            this.btnCadastroProdutoNomeLoja.Click += new System.EventHandler(this.BtnCadastroProdutoNomeLoja_Click);
            // 
            // btnPesquisarLojaProduto
            // 
            this.btnPesquisarLojaProduto.Location = new System.Drawing.Point(426, 237);
            this.btnPesquisarLojaProduto.Name = "btnPesquisarLojaProduto";
            this.btnPesquisarLojaProduto.Size = new System.Drawing.Size(193, 33);
            this.btnPesquisarLojaProduto.TabIndex = 5;
            this.btnPesquisarLojaProduto.Text = "Pesquisar Loja por produto";
            this.btnPesquisarLojaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarLojaProduto.Click += new System.EventHandler(this.BtnPesquisarLojaProduto_Click);
            // 
            // btnPesquisaPorNome
            // 
            this.btnPesquisaPorNome.Location = new System.Drawing.Point(426, 23);
            this.btnPesquisaPorNome.Name = "btnPesquisaPorNome";
            this.btnPesquisaPorNome.Size = new System.Drawing.Size(193, 33);
            this.btnPesquisaPorNome.TabIndex = 6;
            this.btnPesquisaPorNome.Text = "Pesquisar Loja por nome";
            this.btnPesquisaPorNome.UseVisualStyleBackColor = true;
            this.btnPesquisaPorNome.Click += new System.EventHandler(this.BtnPesquisaPorNome_Click);
            // 
            // btnAumentarPreco
            // 
            this.btnAumentarPreco.Location = new System.Drawing.Point(426, 60);
            this.btnAumentarPreco.Name = "btnAumentarPreco";
            this.btnAumentarPreco.Size = new System.Drawing.Size(193, 33);
            this.btnAumentarPreco.TabIndex = 7;
            this.btnAumentarPreco.Text = "Aumentar 10% no valor dos produtos";
            this.btnAumentarPreco.UseVisualStyleBackColor = true;
            this.btnAumentarPreco.Click += new System.EventHandler(this.BtnAumentarPreco_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(426, 276);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(193, 33);
            this.btnPesquisarProduto.TabIndex = 8;
            this.btnPesquisarProduto.Text = "Pesquisar produto";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.BtnPesquisarProduto_Click);
            // 
            // btnRemoveLoja
            // 
            this.btnRemoveLoja.Location = new System.Drawing.Point(426, 99);
            this.btnRemoveLoja.Name = "btnRemoveLoja";
            this.btnRemoveLoja.Size = new System.Drawing.Size(193, 33);
            this.btnRemoveLoja.TabIndex = 9;
            this.btnRemoveLoja.Text = "Remover Loja";
            this.btnRemoveLoja.UseVisualStyleBackColor = true;
            this.btnRemoveLoja.Click += new System.EventHandler(this.BtnRemoveLoja_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(426, 320);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(193, 33);
            this.btnRemoverProduto.TabIndex = 10;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.BtnRemoverProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnRemoveLoja);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.btnAumentarPreco);
            this.Controls.Add(this.btnPesquisaPorNome);
            this.Controls.Add(this.btnPesquisarLojaProduto);
            this.Controls.Add(this.btnCadastroProdutoNomeLoja);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbDescricaoLoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeLoja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbValorProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbDescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastroProdutoNomeLoja;
        private System.Windows.Forms.Button btnPesquisarLojaProduto;
        private System.Windows.Forms.Button btnPesquisaPorNome;
        private System.Windows.Forms.Button btnAumentarPreco;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnRemoveLoja;
        private System.Windows.Forms.Button btnRemoverProduto;
    }
}

