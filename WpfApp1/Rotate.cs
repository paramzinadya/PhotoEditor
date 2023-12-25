using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;

namespace WpfApp1
{
    internal class Rotate : Commands
    {
        public RotateFlipType rotateFlipType { get; }
        public void RotateImage(string input, string output, RotateFlipType rotateFlipType)
        {
            using (Bitmap originalImage = new Bitmap(input))
            {
                originalImage.RotateFlip(rotateFlipType);
                originalImage.Save(output, ImageFormat.Jpeg);
            }
        }

        public Rotate(string input, string output, RotateFlipType rotateFlipType) : base(input, output)
        {
            this.rotateFlipType= rotateFlipType;
        }
    }
}
