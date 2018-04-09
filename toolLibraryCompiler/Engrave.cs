using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class Engrave : AngularTool
    {
        public decimal G {get;set;}
        public decimal R { get; set; }
        public decimal B { get; set; }

        public Engrave(string name, string type, decimal width1, decimal angle, decimal g, decimal r, decimal b) : base(name, type, width1, angle)
        {
            this.G = g;
            this.R = r;
            this.B = b;
        }

        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine+
                $"g={this.G}"+ Environment.NewLine+
                $"r={this.R}"+ Environment.NewLine+
                $"b={this.B}";
        }
    }
}
