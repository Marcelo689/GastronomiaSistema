using BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados.Rascunhos
{
    public class Rascunhos
    {

        public void SalvarImagemNoBanco1()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            string sSelectedPat = "";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPat = fbd.SelectedPath;
            }
            else
                return;
            var imageBytes = File.ReadAllBytes(sSelectedPat);
            BDContexto contexto = new BDContexto();
            var usuario = new Usuario()
            {
                Nome = "Marcelo",
                Acesso = Usuario.NivelAcesso.Administrador,
                Senha = "123",
                Imagem = imageBytes,
            };
            // contexto.Usuarios.Add(usuario);

            contexto.SaveChanges();

        }
        public void SalvarImagemNoBanco2()
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            string sFileName = "";
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            var imageBytes = File.ReadAllBytes(sFileName);
            BDContexto contexto = new BDContexto();
            var usuario = new Usuario()
            {
                Nome = "Marcelo",
                Acesso = Usuario.NivelAcesso.Administrador,
                Senha = "123",
                Imagem = imageBytes,
            };
            //contexto.Usuarios.Add(usuario);

            contexto.SaveChanges();

        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            //pictureBox.
            //pictureBox.ImageLocation = "http://www.dotnetperls.com/favicon.ico";
            //pictureBox.Image.Save(@"C:\Users\marce\Pictures\telescopio.png",ImageFormat.Png);
            //pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            BDContexto contexto = new BDContexto();

            //Usuario usuario = contexto.Usuarios.ToList().Where( u => u.Id == 1).First();

            //var imagemByte = usuario.Imagem;

            //int ArraySize = imagemByte.GetUpperBound(0);

            //MemoryStream ms = new MemoryStream(imagemByte, 0, ArraySize);
            //pictureBox.Image = Image.FromStream(ms);


        }
    }
}
