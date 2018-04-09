using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class BallNose : Tool
    {
        public decimal Height1 { get; set; }

        public BallNose(string name, string type, string units, decimal width1, decimal height1) : base(name, type, width1, units)
        {
            this.Height1 = height1;            
        }

        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine +
                $"H1={this.Height1}";
        }
    }
}
