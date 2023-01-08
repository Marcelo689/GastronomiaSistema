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
            this.textBoxQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoReceita = new System.Windows.Forms.ComboBox();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.ProdutosNomes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdutosCustos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.textBoxPrecoReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listViewReceitas = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrecoUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxNomeReceita = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBoxTempoPreparo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCustoLuz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletarLinha
            // 
            this.btnDeletarLinha.BackColor = System.Drawing.Color.Red;
            this.btnDeletarLinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLinha.Location = new System.Drawing.Point(366, 149);
            this.btnDeletarLinha.Name = "btnDeletarLinha";
            this.btnDeletarLinha.Size = new System.Drawing.Size(138, 21);
            this.btnDeletarLinha.TabIndex = 54;
            this.btnDeletarLinha.Text = "Deletar Linha";
            this.btnDeletarLinha.UseVisualStyleBackColor = false;
            this.btnDeletarLinha.Click += new System.EventHandler(this.btnDeletarLinha_Click);
            // 
            // listViewGastos
            // 
            this.listViewGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewGastos.FullRowSelect = true;
            this.listViewGastos.HideSelection = false;
            this.listViewGastos.Location = new System.Drawing.Point(6, 52);
            this.listViewGastos.Name = "listViewGastos";
            this.listViewGastos.Size = new System.Drawing.Size(229, 103);
            this.listViewGastos.TabIndex = 53;
            this.listViewGastos.UseCompatibleStateImageBehavior = false;
            this.listViewGastos.View = System.Windows.Forms.View.Details;
            this.listViewGastos.SelectedIndexChanged += new System.EventHandler(this.listViewGastos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Custo";
            this.columnHeader2.Width = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Preço de Custo";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(481, 34);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(28, 13);
            this.lblPrecoCusto.TabIndex = 51;
            this.lblPrecoCusto.Text = "0.00";
            this.lblPrecoCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Gastos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAdicionarGasto
            // 
            this.btnAdicionarGasto.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdicionarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarGasto.Location = new System.Drawing.Point(212, 17);
            this.btnAdicionarGasto.Name = "btnAdicionarGasto";
            this.btnAdicionarGasto.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarGasto.TabIndex = 49;
            this.btnAdicionarGasto.Text = "+";
            this.btnAdicionarGasto.UseVisualStyleBackColor = false;
            this.btnAdicionarGasto.Click += new System.EventHandler(this.btnAdicionarGasto_Click);
            // 
            // comboBoxGastos
            // 
            this.comboBoxGastos.FormattingEnabled = true;
            this.comboBoxGastos.Location = new System.Drawing.Point(51, 19);
            this.comboBoxGastos.Name = "comboBoxGastos";
            this.comboBoxGastos.Size = new System.Drawing.Size(157, 21);
            this.comboBoxGastos.TabIndex = 48;
            // 
            // textBoxPotenciaKwh
            // 
            this.textBoxPotenciaKwh.Location = new System.Drawing.Point(135, 78);
            this.textBoxPotenciaKwh.Name = "textBoxPotenciaKwh";
            this.textBoxPotenciaKwh.Size = new System.Drawing.Size(178, 21);
            this.textBoxPotenciaKwh.TabIndex = 47;
            this.textBoxPotenciaKwh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPotenciaKwh_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Potência em Kwh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tempo de preparo";
            // 
            // textBoxQuantidadeProduto
            // 
            this.textBoxQuantidadeProduto.Location = new System.Drawing.Point(240, 17);
            this.textBoxQuantidadeProduto.Name = "textBoxQuantidadeProduto";
            this.textBoxQuantidadeProduto.Size = new System.Drawing.Size(62, 20);
            this.textBoxQuantidadeProduto.TabIndex = 43;
            this.textBoxQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tipo da Receita";
            // 
            // comboBoxTipoReceita
            // 
            this.comboBoxTipoReceita.FormattingEnabled = true;
            this.comboBoxTipoReceita.Location = new System.Drawing.Point(135, 105);
            this.comboBoxTipoReceita.Name = "comboBoxTipoReceita";
            this.comboBoxTipoReceita.Size = new System.Drawing.Size(178, 23);
            this.comboBoxTipoReceita.TabIndex = 41;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdutosNomes,
            this.ProdutosCustos,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(9, 39);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(329, 112);
            this.listViewProdutos.TabIndex = 40;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listViewProdutos_SelectedIndexChanged);
            // 
            // ProdutosNomes
            // 
            this.ProdutosNomes.Text = "Nome";
            this.ProdutosNomes.Width = 150;
            // 
            // ProdutosCustos
            // 
            this.ProdutosCustos.Text = "Custo";
            this.ProdutosCustos.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(311, 14);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(27, 23);
            this.btnAdicionarProduto.TabIndex = 39;
            this.btnAdicionarProduto.Text = "+";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // textBoxPrecoReceita
            // 
            this.textBoxPrecoReceita.Location = new System.Drawing.Point(135, 54);
            this.textBoxPrecoReceita.Name = "textBoxPrecoReceita";
            this.textBoxPrecoReceita.Size = new System.Drawing.Size(178, 21);
            this.textBoxPrecoReceita.TabIndex = 37;
            this.textBoxPrecoReceita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecoReceita_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Produtos";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Location = new System.Drawing.Point(66, 16);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(168, 21);
            this.comboBoxProdutos.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Preço de Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(354, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 23);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listViewReceitas
            // 
            this.listViewReceitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome,
            this.headerPrecoUnidade,
            this.columnHeader5});
            this.listViewReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewReceitas.FullRowSelect = true;
            this.listViewReceitas.HideSelection = false;
            this.listViewReceitas.Location = new System.Drawing.Point(322, 20);
            this.listViewReceitas.Name = "listViewReceitas";
            this.listViewReceitas.Size = new System.Drawing.Size(436, 134);
            this.listViewReceitas.TabIndex = 31;
            this.listViewReceitas.UseCompatibleStateImageBehavior = false;
            this.listViewReceitas.View = System.Windows.Forms.View.Details;
            this.listViewReceitas.SelectedIndexChanged += new System.EventHandler(this.listViewReceitas_SelectedIndexChanged);
            // 
            // headerNome
            // 
            this.headerNome.Text = "Nome";
            this.headerNome.Width = 183;
            // 
            // headerPrecoUnidade
            // 
            this.headerPrecoUnidade.Text = "Preço de Venda";
            this.headerPrecoUnidade.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lucro";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 99;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Red;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(60, 415);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(202, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar Receita";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(233, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 42);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Gerenciar Receitas";
            // 
            // textBoxNomeReceita
            // 
            this.textBoxNomeReceita.Location = new System.Drawing.Point(135, 27);
            this.textBoxNomeReceita.Name = "textBoxNomeReceita";
            this.textBoxNomeReceita.Size = new System.Drawing.Size(178, 21);
            this.textBoxNomeReceita.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(575, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar Receita";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBoxTempoPreparo
            // 
            this.textBoxTempoPreparo.Location = new System.Drawing.Point(135, 133);
            this.textBoxTempoPreparo.Mask = "00:00:00";
            this.textBoxTempoPreparo.Name = "textBoxTempoPreparo";
            this.textBoxTempoPreparo.Size = new System.Drawing.Size(178, 21);
            this.textBoxTempoPreparo.TabIndex = 55;
            this.textBoxTempoPreparo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTempoPreparo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.textBoxNomeReceita);
            this.groupBox1.Controls.Add(this.textBoxTempoPreparo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPrecoReceita);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPotenciaKwh);
            this.groupBox1.Controls.Add(this.comboBoxTipoReceita);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listViewReceitas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 165);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receita";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.comboBoxGastos);
            this.groupBox2.Controls.Add(this.btnAdicionarGasto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.listViewGastos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(521, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 161);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos da Receita";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.listViewProdutos);
            this.groupBox3.Controls.Add(this.comboBoxProdutos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAdicionarProduto);
            this.groupBox3.Controls.Add(this.textBoxQuantidadeProduto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 161);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos da Receita";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.labelCustoLuz);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblPrecoCusto);
            this.groupBox4.Controls.Add(this.btnDeletarLinha);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(17, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(771, 189);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Items Dentro da Receita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Luz consumida na receita";
            // 
            // labelCustoLuz
            // 
            this.labelCustoLuz.AutoSize = true;
            this.labelCustoLuz.Location = new System.Drawing.Point(422, 107);
            this.labelCustoLuz.Name = "labelCustoLuz";
            this.labelCustoLuz.Size = new System.Drawing.Size(28, 13);
            this.labelCustoLuz.TabIndex = 59;
            this.labelCustoLuz.Text = "0.00";
            this.labelCustoLuz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GerenciarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "GerenciarReceitas";
            this.Text = "Gerenciar Receitas";
            this.Load += new System.EventHandler(this.GerenciarReceitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader ProdutosNomes;
        private System.Windows.Forms.ComboBox comboBoxTipoReceita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantidadeProduto;
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
        private System.Windows.Forms.MaskedTextBox textBoxTempoPreparo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCustoLuz;
    }
}