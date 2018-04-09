using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class AngularTool : Tool
    {
        public decimal Angle { get; set; }

        public AngularTool(string name, string type, decimal width1, decimal angle) : base(name, type, width1)
        {
            this.Angle = angle;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"angle={this.Angle}";
        }
    }
}
