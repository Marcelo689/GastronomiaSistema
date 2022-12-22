namespace BancoDeDados
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUnidadesDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.labelEmpresaNome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarEmpresaToolStripMenuItem,
            this.menuItemCadastrarUsuario,
            this.gerenciarUnidadesDeMedidaToolStripMenuItem,
            this.tipoReceitaToolStripMenuItem,
            this.gerenciarProdutosToolStripMenuItem,
            this.gerenciarGastosToolStripMenuItem,
            this.gerenciarReceitasToolStripMenuItem,
            this.gerenciarPedidosToolStripMenuItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(50, 20);
            this.menuItem.Text = "Menu";
            // 
            // gerenciarEmpresaToolStripMenuItem
            // 
            this.gerenciarEmpresaToolStripMenuItem.Name = "gerenciarEmpresaToolStripMenuItem";
            this.gerenciarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarEmpresaToolStripMenuItem.Text = "Gerenciar Empresa";
            this.gerenciarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEmpresaToolStripMenuItem_Click);
            // 
            // menuItemCadastrarUsuario
            // 
            this.menuItemCadastrarUsuario.Name = "menuItemCadastrarUsuario";
            this.menuItemCadastrarUsuario.Size = new System.Drawing.Size(235, 22);
            this.menuItemCadastrarUsuario.Text = "Gerenciar Usuários";
            this.menuItemCadastrarUsuario.Click += new System.EventHandler(this.menuItemCadastrarUsuario_Click);
            // 
            // gerenciarUnidadesDeMedidaToolStripMenuItem
            // 
            this.gerenciarUnidadesDeMedidaToolStripMenuItem.Name = "gerenciarUnidadesDeMedidaToolStripMenuItem";
            this.gerenciarUnidadesDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarUnidadesDeMedidaToolStripMenuItem.Text = "Gerenciar Unidades de Medida";
            this.gerenciarUnidadesDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUnidadesDeMedidaToolStripMenuItem_Click);
            // 
            // tipoReceitaToolStripMenuItem
            // 
            this.tipoReceitaToolStripMenuItem.Name = "tipoReceitaToolStripMenuItem";
            this.tipoReceitaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.tipoReceitaToolStripMenuItem.Text = "Gerenciar Tipo Receita";
            this.tipoReceitaToolStripMenuItem.Click += new System.EventHandler(this.tipoReceitaToolStripMenuItem_Click);
            // 
            // gerenciarProdutosToolStripMenuItem
            // 
            this.gerenciarProdutosToolStripMenuItem.Name = "gerenciarProdutosToolStripMenuItem";
            this.gerenciarProdutosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarProdutosToolStripMenuItem.Text = "Gerenciar Produtos";
            this.gerenciarProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarProdutosToolStripMenuItem_Click);
            // 
            // gerenciarGastosToolStripMenuItem
            // 
            this.gerenciarGastosToolStripMenuItem.Name = "gerenciarGastosToolStripMenuItem";
            this.gerenciarGastosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarGastosToolStripMenuItem.Text = "Gerenciar Gastos";
            this.gerenciarGastosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarGastosToolStripMenuItem_Click);
            // 
            // gerenciarReceitasToolStripMenuItem
            // 
            this.gerenciarReceitasToolStripMenuItem.Name = "gerenciarReceitasToolStripMenuItem";
            this.gerenciarReceitasToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarReceitasToolStripMenuItem.Text = "Gerenciar Receitas";
            this.gerenciarReceitasToolStripMenuItem.Click += new System.EventHandler(this.gerenciarReceitasToolStripMenuItem_Click);
            // 
            // gerenciarPedidosToolStripMenuItem
            // 
            this.gerenciarPedidosToolStripMenuItem.Name = "gerenciarPedidosToolStripMenuItem";
            this.gerenciarPedidosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerenciarPedidosToolStripMenuItem.Text = "Gerenciar Pedidos";
            this.gerenciarPedidosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarPedidosToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogarToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // pictureBoxLogoEmpresa
            // 
            this.pictureBoxLogoEmpresa.Location = new System.Drawing.Point(112, 122);
            this.pictureBoxLogoEmpresa.Name = "pictureBoxLogoEmpresa";
            this.pictureBoxLogoEmpresa.Size = new System.Drawing.Size(502, 243);
            this.pictureBoxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoEmpresa.TabIndex = 6;
            this.pictureBoxLogoEmpresa.TabStop = false;
            // 
            // labelEmpresaNome
            // 
            this.labelEmpresaNome.AutoSize = true;
            this.labelEmpresaNome.Location = new System.Drawing.Point(316, 75);
            this.labelEmpresaNome.Name = "labelEmpresaNome";
            this.labelEmpresaNome.Size = new System.Drawing.Size(0, 13);
            this.labelEmpresaNome.TabIndex = 7;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEmpresaNome);
            this.Controls.Add(this.pictureBoxLogoEmpresa);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormularioPrincipal";
            this.Text = "Tela Principal";
            this.Activated += new System.EventHandler(this.FormularioPrincipal_Activated);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormularioPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUnidadesDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarPedidosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLogoEmpresa;
        private System.Windows.Forms.Label labelEmpresaNome;
    }
}