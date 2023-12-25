using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp1
{
    public class Crop : Commands
    {
        public int x { get; }
        public int y { get; }
        public void CropImage(string input, string output, int x, int y)
        {
            using (Image originalImage = Image.FromFile(input)) // используем наше изображение
            {
                using (Bitmap InputImage = new Bitmap(input))
                {
                    if (x > InputImage.Width || y > InputImage.Height || x < 100 || y < 100)
                    {
                        throw new ArgumentException("Неверный формат ввода");
                    }
                }
                Rectangle cropArea = new Rectangle(0, 0, x, y);
                using (Bitmap croppedImage = new Bitmap(cropArea.Width, cropArea.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(croppedImage))
                    {
                        graphics.DrawImage(originalImage, new Rectangle(0, 0, cropArea.Width, cropArea.Height), cropArea, GraphicsUnit.Pixel);
                        croppedImage.Save(output, ImageFormat.Jpeg);
                    }
                }
            }
        }

        public Crop (string input, string output, int x, int y) : base(input, output)
        {
            this.x = x;
            this.y = y;
        }
    }
}
