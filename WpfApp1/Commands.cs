using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Commands
    {
        public string input { get; }
        public string output { get; }

        public Commands(string input, string output)
        {
            this.input=input;
            this.output=output;
        }
    }
}
