using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class BlackAndWhiteFilter : Filters
    {
        public ColorMatrix colorMatrix { get; }
        public override void Create(Bitmap newBitMap, ColorMatrix colorMatrix)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            ColorMatrix NewColors = new ColorMatrix(new float[][] { new float[] { 0.299f, 0.299f, 0.299f, 0, 0 }, new float[] { 0.587f, 0.587f, 0.587f, 0, 0 }, new float[] { 0.114f, 0.114f, 0.114f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
            base.Create(newBitMap, NewColors);
        }

        public BlackAndWhiteFilter(Bitmap newBitMap, ColorMatrix colorMatrix) : base(newBitMap)
        {
            this.colorMatrix = colorMatrix;
        }
    }
}
