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
    }
}
