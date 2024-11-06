using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class BlueFilter : Filters
    {
        public ColorMatrix colorMatrix { get; }
        public override void Create(Bitmap newBitMap, ColorMatrix colorMatrix)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            ColorMatrix NewColors = new ColorMatrix(new float[][] { new float[] { 0.5f, 0.1f, 0.5f, 0.1f, 0.1f }, new float[] { 0, 0.5f, 0, 0, 0 }, new float[] { 0, 0, 0.5f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
            base.Create(newBitMap, NewColors);
        }

        public BlueFilter(Bitmap newBitMap, ColorMatrix colorMatrix) : base(newBitMap)
        {
            this.colorMatrix = colorMatrix;
        }
    }
}
