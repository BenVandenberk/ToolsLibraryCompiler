using System;

namespace toolLibraryCompiler.Tools
{
    public class AngularTool : Tool
    {
        public double Angle { get; set; }

        public AngularTool(string name, ToolType type, double width1, Unit units, double angle) : base(name, type, width1, units)
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
