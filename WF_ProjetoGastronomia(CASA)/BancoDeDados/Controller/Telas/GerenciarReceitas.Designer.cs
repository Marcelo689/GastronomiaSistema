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
            this.btnDeletarLinha = new System.Windows.Forms.Button();
            this.listViewGastos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdicionarGasto = new System.Windows.Forms.Button();
            this.comboBoxGastos = new System.Windows.Forms.ComboBox();
            this.textBoxPotenciaKwh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tempoDePreparo = new System.Windows.Forms.DateTimePicker();
            this.textBoxQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoReceita = new System.Windows.Forms.ComboBox();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.ProdutosNomes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdutosCustos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrecoReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listViewReceitas = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrecoUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxNomeReceita = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeletarLinha
            // 
            this.btnDeletarLinha.Location = new System.Drawing.Point(321, 388);
            this.btnDeletarLinha.Name = "btnDeletarLinha";
            this.btnDeletarLinha.Size = new System.Drawing.Size(114, 21);
            this.btnDeletarLinha.TabIndex = 54;
            this.btnDeletarLinha.Text = "Deletar Linha";
            this.btnDeletarLinha.UseVisualStyleBackColor = true;
            this.btnDeletarLinha.Click += new System.EventHandler(this.btnDeletarLinha_Click);
            // 
            // listViewGastos
            // 
            this.listViewGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewGastos.FullRowSelect = true;
            this.listViewGastos.HideSelection = false;
            this.listViewGastos.Location = new System.Drawing.Point(321, 222);
            this.listViewGastos.Name = "listViewGastos";
            this.listViewGastos.Size = new System.Drawing.Size(229, 160);
            this.listViewGastos.TabIndex = 53;
            this.listViewGastos.UseCompatibleStateImageBehavior = false;
            this.listViewGastos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Custo";
            this.columnHeader2.Width = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Preço de Custo";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(540, 392);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(28, 13);
            this.lblPrecoCusto.TabIndex = 51;
            this.lblPrecoCusto.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Gastos";
            // 
            // btnAdicionarGasto
            // 
            this.btnAdicionarGasto.Location = new System.Drawing.Point(527, 185);
            this.btnAdicionarGasto.Name = "btnAdicionarGasto";
            this.btnAdicionarGasto.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarGasto.TabIndex = 49;
            this.btnAdicionarGasto.Text = "+";
            this.btnAdicionarGasto.UseVisualStyleBackColor = true;
            this.btnAdicionarGasto.Click += new System.EventHandler(this.btnAdicionarGasto_Click);
            // 
            // comboBoxGastos
            // 
            this.comboBoxGastos.FormattingEnabled = true;
            this.comboBoxGastos.Location = new System.Drawing.Point(364, 187);
            this.comboBoxGastos.Name = "comboBoxGastos";
            this.comboBoxGastos.Size = new System.Drawing.Size(157, 21);
            this.comboBoxGastos.TabIndex = 48;
            // 
            // textBoxPotenciaKwh
            // 
            this.textBoxPotenciaKwh.Location = new System.Drawing.Point(131, 153);
            this.textBoxPotenciaKwh.Name = "textBoxPotenciaKwh";
            this.textBoxPotenciaKwh.Size = new System.Drawing.Size(167, 20);
            this.textBoxPotenciaKwh.TabIndex = 47;
            this.textBoxPotenciaKwh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPotenciaKwh_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Potência em Kwh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tempo de preparo";
            // 
            // tempoDePreparo
            // 
            this.tempoDePreparo.Location = new System.Drawing.Point(418, 125);
            this.tempoDePreparo.Name = "tempoDePreparo";
            this.tempoDePreparo.Size = new System.Drawing.Size(132, 20);
            this.tempoDePreparo.TabIndex = 44;
            // 
            // textBoxQuantidadeProduto
            // 
            this.textBoxQuantidadeProduto.Location = new System.Drawing.Point(208, 182);
            this.textBoxQuantidadeProduto.Name = "textBoxQuantidadeProduto";
            this.textBoxQuantidadeProduto.Size = new System.Drawing.Size(62, 20);
            this.textBoxQuantidadeProduto.TabIndex = 43;
            this.textBoxQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            // comboBoxTipoReceita
            // 
            this.comboBoxTipoReceita.FormattingEnabled = true;
            this.comboBoxTipoReceita.Location = new System.Drawing.Point(418, 98);
            this.comboBoxTipoReceita.Name = "comboBoxTipoReceita";
            this.comboBoxTipoReceita.Size = new System.Drawing.Size(132, 21);
            this.comboBoxTipoReceita.TabIndex = 41;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdutosNomes,
            this.ProdutosCustos});
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(23, 222);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(289, 187);
            this.listViewProdutos.TabIndex = 40;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listViewProdutos_SelectedIndexChanged);
            // 
            // ProdutosNomes
            // 
            this.ProdutosNomes.Text = "Nome";
            this.ProdutosNomes.Width = 186;
            // 
            // ProdutosCustos
            // 
            this.ProdutosCustos.Text = "Custo";
            this.ProdutosCustos.Width = 98;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(271, 180);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(27, 23);
            this.btnAdicionarProduto.TabIndex = 39;
            this.btnAdicionarProduto.Text = "+";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
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
            // textBoxPrecoReceita
            // 
            this.textBoxPrecoReceita.Location = new System.Drawing.Point(131, 127);
            this.textBoxPrecoReceita.Name = "textBoxPrecoReceita";
            this.textBoxPrecoReceita.Size = new System.Drawing.Size(167, 20);
            this.textBoxPrecoReceita.TabIndex = 37;
            this.textBoxPrecoReceita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecoReceita_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Produtos";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Location = new System.Drawing.Point(78, 181);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(124, 21);
            this.comboBoxProdutos.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Preço da unidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(225, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 23);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listViewReceitas
            // 
            this.listViewReceitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome,
            this.headerPrecoUnidade});
            this.listViewReceitas.FullRowSelect = true;
            this.listViewReceitas.HideSelection = false;
            this.listViewReceitas.Location = new System.Drawing.Point(574, 32);
            this.listViewReceitas.Name = "listViewReceitas";
            this.listViewReceitas.Size = new System.Drawing.Size(214, 406);
            this.listViewReceitas.TabIndex = 31;
            this.listViewReceitas.UseCompatibleStateImageBehavior = false;
            this.listViewReceitas.View = System.Windows.Forms.View.Details;
            this.listViewReceitas.SelectedIndexChanged += new System.EventHandler(this.listViewReceitas_SelectedIndexChanged);
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
            this.btnDeletar.Size = new System.Drawing.Size(196, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
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
            this.textBoxNomeReceita.Location = new System.Drawing.Point(26, 101);
            this.textBoxNomeReceita.Name = "textBoxNomeReceita";
            this.textBoxNomeReceita.Size = new System.Drawing.Size(272, 20);
            this.textBoxNomeReceita.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(383, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar Receita";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // GerenciarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarLinha);
            this.Controls.Add(this.listViewGastos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdicionarGasto);
            this.Controls.Add(this.comboBoxGastos);
            this.Controls.Add(this.textBoxPotenciaKwh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tempoDePreparo);
            this.Controls.Add(this.textBoxQuantidadeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoReceita);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrecoReceita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listViewReceitas);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxNomeReceita);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "GerenciarReceitas";
            this.Text = "GerenciarReceitas";
            this.Load += new System.EventHandler(this.GerenciarReceitas_Load);
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
        private System.Windows.Forms.ListView listViewReceitas;
        private System.Windows.Forms.ColumnHeader headerNome;
        private System.Windows.Forms.ColumnHeader headerPrecoUnidade;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBoxNomeReceita;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader ProdutosNomes;
        private System.Windows.Forms.ComboBox comboBoxTipoReceita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantidadeProduto;
        private System.Windows.Forms.DateTimePicker tempoDePreparo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPotenciaKwh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGastos;
        private System.Windows.Forms.Button btnAdicionarGasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader ProdutosCustos;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewGastos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDeletarLinha;
    }
}