using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Filters
    {
        public string input { get; }
        public string output { get; }

        public virtual void Create(string Input, string Output, ColorMatrix colorMatrix)
        {
            using (Bitmap InputImage = new Bitmap(Input))
            {
                using (Graphics graphics = Graphics.FromImage(InputImage))
                {
                    ImageAttributes imageattributes = new ImageAttributes();
                    imageattributes.SetColorMatrix(colorMatrix);
                    graphics.DrawImage(InputImage, new Rectangle(0, 0, InputImage.Width, InputImage.Height), 0, 0, InputImage.Width, InputImage.Height, GraphicsUnit.Pixel, imageattributes);
                }
                InputImage.Save(Output, ImageFormat.Jpeg);
            }
        }

        public Filters(string input, string output)
        {
            this.input=input;
            this.output=output;
        }
    }
}
