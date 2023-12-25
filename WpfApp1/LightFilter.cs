using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LightFilter : Filters
    {
        public ColorMatrix colorMatrix { get; }
        public override void Create(string Input, string Output, ColorMatrix colorMatrix)
        {
            ColorMatrix NewColors = new ColorMatrix(new float[][] { new float[] { 1.5f, 0, 0, 0, 0 }, new float[] { 0, 1.5f, 0, 0, 0 }, new float[] { 0, 0, 1.5f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
            base.Create(Input, Output, NewColors);
        }

        public LightFilter(string input, string output, ColorMatrix colorMatrix) : base(input, output)
        {
            this.colorMatrix = colorMatrix;
        }
    }
}
