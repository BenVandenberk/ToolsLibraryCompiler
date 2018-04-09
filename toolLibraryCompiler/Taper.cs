using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class Taper : AngularTool
    {
        public decimal Width2 { get; set; }
        public decimal Height1 { get; set; }

        public Taper(string name, string type, decimal width1, decimal angle, decimal width2, decimal height1) : base(name, type, width1, angle)
        {
            this.Width2 = width2;
            this.Height1 = height1;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine+
                $"D2={this.Width2}"+ Environment.NewLine+
                $"H1={this.Height1}";
        }
    }
}
