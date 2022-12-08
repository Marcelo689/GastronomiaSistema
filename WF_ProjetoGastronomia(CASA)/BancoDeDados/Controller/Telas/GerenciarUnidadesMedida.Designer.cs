using BancoDeDados.Controller.Model;

namespace BancoDeDados.Controller.Telas
{
    partial class GerenciarUnidadeMedida
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxNomeUnidadeMedida = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnLimpar.Location = new System.Drawing.Point(140, 237);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(362, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 356);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // headerNome
            // 
            this.headerNome.Text = "Nome";
            this.headerNome.Width = 421;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(40, 237);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(156, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 37);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Gerenciar Unidade de Medida";
            // 
            // textBoxNomeUnidadeMedida
            // 
            this.textBoxNomeUnidadeMedida.Location = new System.Drawing.Point(40, 98);
            this.textBoxNomeUnidadeMedida.Name = "textBoxNomeUnidadeMedida";
            this.textBoxNomeUnidadeMedida.Size = new System.Drawing.Size(272, 20);
            this.textBoxNomeUnidadeMedida.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(237, 237);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.Location = new System.Drawing.Point(40, 157);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(272, 20);
            this.textBoxSigla.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sigla";
            // 
            // GerenciarUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxNomeUnidadeMedida);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "GerenciarUnidadeMedida";
            this.Text = "GerenciarUnidadeMedida";
            this.Load += new System.EventHandler(this.GerenciarUnidadeMedida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headerNome;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBoxNomeUnidadeMedida;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textBoxSigla;
        private System.Windows.Forms.Label label2;
    }
}