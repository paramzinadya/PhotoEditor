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
        public void Collage(Bitmap newBitMap, string input2)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            if (input2 == null) throw new ArgumentException("Второе изображение не загружено");

            using (Bitmap image2 = new Bitmap(input2))
            {
                int NewWidth = Math.Max(newBitMap.Width, image2.Width);
                int NewHeight = Math.Max(newBitMap.Height, image2.Height);
                newBitMap = new Bitmap(NewWidth * 2, NewHeight);
                using (Graphics g = Graphics.FromImage(newBitMap))
                {
                    g.DrawImage(newBitMap, new Rectangle(0, 0, newBitMap.Width, newBitMap.Height));
                    g.DrawImage(image2, new Rectangle(newBitMap.Width, 0, NewWidth, NewHeight));
                }
            }
        }

        public Collages(Bitmap newBitMap, string input2) : base(newBitMap)
        {
            this.input2 = input2;
        }
    }
}
