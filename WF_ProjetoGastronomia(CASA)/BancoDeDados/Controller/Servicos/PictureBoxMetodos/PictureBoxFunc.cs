using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Servicos.PictureBoxMetodos
{
    public class PictureBoxFunc
    {
        public void RetornaImagemParaPictureBox(byte[] image, PictureBox pictureBox)
        {
            int ArraySize = image.GetUpperBound(0);

            MemoryStream ms = new MemoryStream(image, 0, ArraySize);
            pictureBox.Image = Image.FromStream(ms);
        }
        public byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public void PreenchePictureBox(PictureBox pictureBox)
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
            var imageByte = File.ReadAllBytes(sFileName);
            int ArraySize = imageByte.GetUpperBound(0);
            MemoryStream ms = new MemoryStream(imageByte, 0, ArraySize);
            pictureBox.Image = Image.FromStream(ms);
        }
    }
}
