using System;

namespace toolLibraryCompiler.Tools
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
