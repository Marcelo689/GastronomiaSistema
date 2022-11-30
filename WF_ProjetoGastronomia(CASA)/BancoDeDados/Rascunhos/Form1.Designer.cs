namespace BancoDeDados
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(443, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar Imagem";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(414, 109);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(234, 154);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(592, 386);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPicture.TabIndex = 2;
            this.btnPicture.Text = "Picture box";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnPicture;
    }
}

