using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Collages : Commands
    {
        public string input2 { get; }
        public void Collage(string input, string input2, string output)
        {

            using (Bitmap image1 = new Bitmap(input))
            using (Bitmap image2 = new Bitmap(input2))
            {
                int NewWidth = Math.Max(image1.Width, image2.Width);
                int NewHeight = Math.Max(image1.Height, image2.Height);
                using (Bitmap collage = new Bitmap(NewWidth * 2, NewHeight))
                {
                    using (Graphics g = Graphics.FromImage(collage))
                    {
                        g.DrawImage(image1, new Rectangle(0, 0, image1.Width, image1.Height));
                        g.DrawImage(image2, new Rectangle(image1.Width, 0, NewWidth, NewHeight));
                    }
                    collage.Save(output, ImageFormat.Jpeg);
                }
                
            }
        }

        public Collages(string input, string input2, string output) : base(input, output)
        {
            this.input2 = input2;
        }
    }
}
