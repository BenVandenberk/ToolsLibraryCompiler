using System;

namespace toolLibraryCompiler.Tools
{
    public abstract class AngularTool : Tool
    {
        public double Angle { get; set; }

        protected AngularTool(string name, ToolType type, double width1, Unit units, double angle) : base(name, type, width1, units)
        {
            this.Angle = angle;
        }

        protected AngularTool() {
            
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"angle={this.Angle}";
        }
    }
}
