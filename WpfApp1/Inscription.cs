using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1
{
    public class Inscription : Commands
    {
        public string text { get; }
        public string position { get; }
        public void Add(Bitmap newBitMap, string text, string position)
        {
            if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
            if (text == "") throw new ArgumentException("Текст не заполнен");
            if (position == "") throw new ArgumentException("Позиция не выбрана");
            using (Graphics g = Graphics.FromImage(newBitMap))
            {
                Font font = new Font("Arial", 20);
                SolidBrush brush = new SolidBrush(Color.White);
                int x = 0, y = 0;

                if (position == "СВЕРХУ")
                {
                    x = (newBitMap.Width - (int)g.MeasureString(text, font).Width) / 2;
                    y = 10;
                }
                else if (position == "ПОСЕРЕДИНЕ")
                {
                    x = (newBitMap.Width - (int)g.MeasureString(text, font).Width) / 2;
                    y = (newBitMap.Height - (int)g.MeasureString(text, font).Height) / 2;
                }
                else if (position == "СНИЗУ")
                {
                    x = (newBitMap.Width - (int)g.MeasureString(text, font).Width) / 2;
                    y = newBitMap.Height - 60;
                }
                g.DrawString(text, font, brush, x, y);
            }
        }

        public Inscription(Bitmap newBitMap, string text, string position) : base(newBitMap)
        {
            this.text=text;
            this.position=position;
        }
    }
}
