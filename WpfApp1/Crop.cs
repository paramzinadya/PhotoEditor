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
        public void CropImage(Bitmap newBitMap, int x, int y)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            if (x > newBitMap.Width || y > newBitMap.Height || x < 100 || y < 100)
            {
                throw new ArgumentException("Неверный формат ввода");
            }
            Rectangle cropArea = new Rectangle(0, 0, x, y);
            Bitmap croppedImage = new Bitmap(newBitMap);
            newBitMap = new Bitmap(cropArea.Width, cropArea.Height);
            using (Graphics graphics = Graphics.FromImage(newBitMap))
            {
                graphics.DrawImage(croppedImage, new Rectangle(0, 0, cropArea.Width, cropArea.Height), cropArea, GraphicsUnit.Pixel);
            }
        }

        public Crop (Bitmap newBitMap, int x, int y) : base(newBitMap)
        {
            this.x = x;
            this.y = y;
        }
    }
}
