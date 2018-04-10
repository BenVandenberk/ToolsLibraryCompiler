using System;

namespace toolLibraryCompiler.Tools
{
    public class Engrave2 : AngularTool
    {
        public static readonly bool CAN_ENGRAVE = true;
        public static readonly int COLOR = 255;

        public double Width2 { get; set; }

        public Engrave2(string name, ToolType type, double width1, Unit units, double angle, double width2) : base(name, type, width1, units, angle)
        {
            this.Width2 = width2;
        }

        public Engrave2() {
            
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"D2={this.Width2}";
        }
    }
}
