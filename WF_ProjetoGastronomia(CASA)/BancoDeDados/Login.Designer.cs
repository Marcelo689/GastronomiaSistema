namespace BancoDeDados
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btnLogar = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.mTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxManterLogin = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(362, 353);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 0;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(282, 239);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(272, 20);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // mTextBoxSenha
            // 
            this.mTextBoxSenha.Location = new System.Drawing.Point(282, 282);
            this.mTextBoxSenha.Name = "mTextBoxSenha";
            this.mTextBoxSenha.PasswordChar = '*';
            this.mTextBoxSenha.Size = new System.Drawing.Size(272, 20);
            this.mTextBoxSenha.TabIndex = 2;
            this.mTextBoxSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextBox_MaskInputRejected);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(355, 165);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Login";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrarUsuario,
            this.menuItemEditarUsuario});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(50, 20);
            this.menuItem.Text = "Menu";
            // 
            // menuItemCadastrarUsuario
            // 
            this.menuItemCadastrarUsuario.Name = "menuItemCadastrarUsuario";
            this.menuItemCadastrarUsuario.Size = new System.Drawing.Size(180, 22);
            this.menuItemCadastrarUsuario.Text = "Cadastrar Usuário";
            this.menuItemCadastrarUsuario.Click += new System.EventHandler(this.menuItemCadastrarUsuario_Click);
            // 
            // menuItemEditarUsuario
            // 
            this.menuItemEditarUsuario.Name = "menuItemEditarUsuario";
            this.menuItemEditarUsuario.Size = new System.Drawing.Size(180, 22);
            this.menuItemEditarUsuario.Text = "Editar Usuário";
            this.menuItemEditarUsuario.Click += new System.EventHandler(this.menuItemEditarUsuario_Click);
            // 
            // checkBoxManterLogin
            // 
            this.checkBoxManterLogin.AutoSize = true;
            this.checkBoxManterLogin.Location = new System.Drawing.Point(282, 320);
            this.checkBoxManterLogin.Name = "checkBoxManterLogin";
            this.checkBoxManterLogin.Size = new System.Drawing.Size(88, 17);
            this.checkBoxManterLogin.TabIndex = 6;
            this.checkBoxManterLogin.Text = "Manter Login";
            this.checkBoxManterLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxManterLogin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mTextBoxSenha);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.MaskedTextBox mTextBoxSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditarUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxManterLogin;
    }
}