using System;

namespace toolLibraryCompiler.Tools
{
    public class Taper : AngularTool
    {
        public static readonly bool CAN_ENGRAVE = true;
        public static readonly int COLOR = 16776960;

        public double Width2 { get; set; }
        public double Height1 { get; set; }

        public Taper(string name, ToolType type, double width1, Unit units, double angle, double width2, double height1) : base(name, type, width1, units, angle)
        {
            this.Width2 = width2;
            this.Height1 = height1;
        }

        public Taper() {
            
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine+
                $"D2={this.Width2}"+ Environment.NewLine+
                $"H1={this.Height1}";
        }
    }
}
