using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    internal class Rotate : Commands
    {
        public RotateFlipType rotateFlipType { get; }
        public void RotateImage(Bitmap newBitMap, RotateFlipType rotateFlipType)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            newBitMap.RotateFlip(rotateFlipType);
        }

        public Rotate(Bitmap newBitMap, RotateFlipType rotateFlipType) : base(newBitMap)
        {
            this.rotateFlipType= rotateFlipType;
        }
    }
}
