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
        public Bitmap newBitMap;

        public virtual void Create(Bitmap newBitMap, ColorMatrix colorMatrix)
        {
            using (Graphics graphics = Graphics.FromImage(newBitMap))
            {
                ImageAttributes imageattributes = new ImageAttributes();
                imageattributes.SetColorMatrix(colorMatrix);
                graphics.DrawImage(newBitMap, new Rectangle(0, 0, newBitMap.Width, newBitMap.Height), 0, 0, newBitMap.Width, newBitMap.Height, GraphicsUnit.Pixel, imageattributes);
            }           
        }

        public Filters(Bitmap newBitMap)
        {
            this.newBitMap=newBitMap;
        }
    }
}
