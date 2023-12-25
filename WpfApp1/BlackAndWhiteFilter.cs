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
        public override void Create(string Input, string Output, ColorMatrix colorMatrix)
        {
            ColorMatrix NewColors = new ColorMatrix(new float[][] { new float[] { 0.299f, 0.299f, 0.299f, 0, 0 }, new float[] { 0.587f, 0.587f, 0.587f, 0, 0 }, new float[] { 0.114f, 0.114f, 0.114f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
            base.Create(Input, Output, NewColors);
        }

        public BlackAndWhiteFilter(string input, string output, ColorMatrix colorMatrix) : base(input, output)
        {
            this.colorMatrix = colorMatrix;
        }
    }
}
