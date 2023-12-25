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
        public void Add(string input, string output, string text, string position)
        {
            if (input == "") throw new ArgumentException("Файл не выбран");
            if (text == "") throw new ArgumentException("Текст не заполнен");
            if (position == "") throw new ArgumentException("Позиция не выбрана");
            using (Bitmap originalImage = new Bitmap(input))
            {
                using (Graphics g = Graphics.FromImage(originalImage))
                {
                    Font font = new Font("Arial", 20);
                    SolidBrush brush = new SolidBrush(Color.White);
                    int x = 0, y = 0;

                    if (position == "СВЕРХУ")
                    {
                        x = (originalImage.Width - (int)g.MeasureString(text, font).Width) / 2;
                        y = 10;
                    }
                    else if (position == "ПОСЕРЕДИНЕ")
                    {
                        x = (originalImage.Width - (int)g.MeasureString(text, font).Width) / 2;
                        y = (originalImage.Height - (int)g.MeasureString(text, font).Height) / 2;
                    }
                    else if (position == "СНИЗУ")
                    {
                        x = (originalImage.Width - (int)g.MeasureString(text, font).Width) / 2;
                        y = originalImage.Height - 60;
                    }
                    g.DrawString(text, font, brush, x, y);
                }
                originalImage.Save(output, ImageFormat.Jpeg);
            }
        }

        public Inscription(string input, string output, string text, string position) : base(input, output)
        {
            this.text=text;
            this.position=position;
        }
    }
}
