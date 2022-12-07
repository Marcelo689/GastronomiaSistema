namespace BancoDeDados.Controller.Telas
{
    partial class GerenciarReceitas
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
            this.textBoxPrecoReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrecoUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxNomeReceita = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ProdutosNomes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxTipoReceita = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPrecoReceita
            // 
            this.textBoxPrecoReceita.Location = new System.Drawing.Point(145, 127);
            this.textBoxPrecoReceita.Name = "textBoxPrecoReceita";
            this.textBoxPrecoReceita.Size = new System.Drawing.Size(167, 20);
            this.textBoxPrecoReceita.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Produtos";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Location = new System.Drawing.Point(92, 165);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(182, 21);
            this.comboBoxProdutos.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Preço da unidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(134, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 23);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome,
            this.headerPrecoUnidade});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(574, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(214, 406);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // headerNome
            // 
            this.headerNome.Text = "Nome";
            this.headerNome.Width = 98;
            // 
            // headerPrecoUnidade
            // 
            this.headerPrecoUnidade.Text = "Preço";
            this.headerPrecoUnidade.Width = 109;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(23, 415);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(91, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 37);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Gerenciar Receitas";
            // 
            // textBoxNomeReceita
            // 
            this.textBoxNomeReceita.Location = new System.Drawing.Point(40, 98);
            this.textBoxNomeReceita.Name = "textBoxNomeReceita";
            this.textBoxNomeReceita.Size = new System.Drawing.Size(272, 20);
            this.textBoxNomeReceita.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(233, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Produtos na Receita";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(348, 163);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(32, 23);
            this.btnAdicionarProduto.TabIndex = 39;
            this.btnAdicionarProduto.Text = "+";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdutosNomes});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 222);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(289, 187);
            this.listView2.TabIndex = 40;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ProdutosNomes
            // 
            this.ProdutosNomes.Text = "Nome";
            this.ProdutosNomes.Width = 291;
            // 
            // comboBoxTipoReceita
            // 
            this.comboBoxTipoReceita.FormattingEnabled = true;
            this.comboBoxTipoReceita.Location = new System.Drawing.Point(407, 98);
            this.comboBoxTipoReceita.Name = "comboBoxTipoReceita";
            this.comboBoxTipoReceita.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTipoReceita.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tipo da Receita";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // GerenciarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoReceita);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrecoReceita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxNomeReceita);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "GerenciarReceitas";
            this.Text = "GerenciarReceitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrecoReceita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headerNome;
        private System.Windows.Forms.ColumnHeader headerPrecoUnidade;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBoxNomeReceita;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ProdutosNomes;
        private System.Windows.Forms.ComboBox comboBoxTipoReceita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}