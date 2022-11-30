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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(228, 91);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cadastrar Usuário";
            // 
            // mTextBoxSenha
            // 
            this.mTextBoxSenha.Location = new System.Drawing.Point(235, 253);
            this.mTextBoxSenha.Name = "mTextBoxSenha";
            this.mTextBoxSenha.PasswordChar = '*';
            this.mTextBoxSenha.Size = new System.Drawing.Size(272, 20);
            this.mTextBoxSenha.TabIndex = 6;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(235, 218);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(272, 20);
            this.textBoxUser.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(284, 314);
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
            this.checkBoxIsAdministrador.Location = new System.Drawing.Point(235, 291);
            this.checkBoxIsAdministrador.Name = "checkBoxIsAdministrador";
            this.checkBoxIsAdministrador.Size = new System.Drawing.Size(89, 17);
            this.checkBoxIsAdministrador.TabIndex = 8;
            this.checkBoxIsAdministrador.Text = "Administrador";
            this.checkBoxIsAdministrador.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxIsAdministrador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mTextBoxSenha);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mTextBoxSenha;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBoxIsAdministrador;
    }
}