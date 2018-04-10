using System;

namespace toolLibraryCompiler.Tools
{
    public class Engrave : AngularTool
    {
        public static readonly bool CAN_ENGRAVE = true;
        public static readonly int COLOR = 128;

        public double G {get;set;}
        public double R { get; set; }
        public double B { get; set; }

        public Engrave(string name, ToolType type, double width1, Unit units, double angle, double g, double r, double b) : base(name, type, width1, units, angle)
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
