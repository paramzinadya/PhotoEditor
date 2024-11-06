using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LightFilter : Filters
    {
        public ColorMatrix colorMatrix { get; }
        public override void Create(Bitmap newBitMap, ColorMatrix colorMatrix)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            ColorMatrix NewColors = new ColorMatrix(new float[][] { new float[] { 1.5f, 0, 0, 0, 0 }, new float[] { 0, 1.5f, 0, 0, 0 }, new float[] { 0, 0, 1.5f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
            base.Create(newBitMap, NewColors);
        }

        public LightFilter(Bitmap newBitMap, ColorMatrix colorMatrix) : base(newBitMap)
        {
            this.colorMatrix = colorMatrix;
        }
    }
}
