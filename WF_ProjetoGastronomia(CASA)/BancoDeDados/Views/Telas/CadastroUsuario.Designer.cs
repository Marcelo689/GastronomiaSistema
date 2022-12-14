namespace BancoDeDados
{
    partial class CadastroUsuario
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkBoxIsAdministrador = new System.Windows.Forms.CheckBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.checkBoxUsuarioAtivo = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAcesso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmpresas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cadastrar Usuário";
            // 
            // mTextBoxSenha
            // 
            this.mTextBoxSenha.Location = new System.Drawing.Point(31, 147);
            this.mTextBoxSenha.Name = "mTextBoxSenha";
            this.mTextBoxSenha.PasswordChar = '*';
            this.mTextBoxSenha.Size = new System.Drawing.Size(272, 20);
            this.mTextBoxSenha.TabIndex = 6;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(31, 99);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(272, 20);
            this.textBoxUser.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(228, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // checkBoxIsAdministrador
            // 
            this.checkBoxIsAdministrador.AutoSize = true;
            this.checkBoxIsAdministrador.Location = new System.Drawing.Point(31, 222);
            this.checkBoxIsAdministrador.Name = "checkBoxIsAdministrador";
            this.checkBoxIsAdministrador.Size = new System.Drawing.Size(89, 17);
            this.checkBoxIsAdministrador.TabIndex = 8;
            this.checkBoxIsAdministrador.Text = "Administrador";
            this.checkBoxIsAdministrador.UseVisualStyleBackColor = true;
            this.checkBoxIsAdministrador.CheckedChanged += new System.EventHandler(this.checkBoxIsAdministrador_CheckedChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(31, 274);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // checkBoxUsuarioAtivo
            // 
            this.checkBoxUsuarioAtivo.AutoSize = true;
            this.checkBoxUsuarioAtivo.Location = new System.Drawing.Point(216, 232);
            this.checkBoxUsuarioAtivo.Name = "checkBoxUsuarioAtivo";
            this.checkBoxUsuarioAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxUsuarioAtivo.TabIndex = 10;
            this.checkBoxUsuarioAtivo.Text = "Ativo";
            this.checkBoxUsuarioAtivo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome,
            this.headerAtivo,
            this.headerAcesso});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(403, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 285);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // headerNome
            // 
            this.headerNome.Text = "Nome";
            this.headerNome.Width = 182;
            // 
            // headerAtivo
            // 
            this.headerAtivo.Text = "Ativo";
            this.headerAtivo.Width = 65;
            // 
            // headerAcesso
            // 
            this.headerAcesso.Text = "Nivel de Acesso";
            this.headerAcesso.Width = 133;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(130, 274);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Empresa";
            // 
            // comboBoxEmpresas
            // 
            this.comboBoxEmpresas.FormattingEnabled = true;
            this.comboBoxEmpresas.Location = new System.Drawing.Point(82, 185);
            this.comboBoxEmpresas.Name = "comboBoxEmpresas";
            this.comboBoxEmpresas.Size = new System.Drawing.Size(221, 21);
            this.comboBoxEmpresas.TabIndex = 15;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmpresas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBoxUsuarioAtivo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.checkBoxIsAdministrador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mTextBoxSenha);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mTextBoxSenha;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBoxIsAdministrador;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.CheckBox checkBoxUsuarioAtivo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headerNome;
        private System.Windows.Forms.ColumnHeader headerAtivo;
        private System.Windows.Forms.ColumnHeader headerAcesso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEmpresas;
    }
}