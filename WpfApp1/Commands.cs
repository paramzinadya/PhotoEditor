using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Commands
    {
        public Bitmap newBitmap;

        public Commands(Bitmap newBitmap)
        {
            this.newBitmap = newBitmap;
        }
    }
}
