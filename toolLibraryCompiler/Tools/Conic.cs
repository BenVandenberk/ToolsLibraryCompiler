using System;

namespace toolLibraryCompiler.Tools
{
    public class Conic : AngularTool
    {
        public static readonly bool CAN_ENGRAVE = true;
        public static readonly int COLOR = 32768;

        public double Height1 { get; set; }
        public double Height2 { get; set; }

        public Conic(string name, ToolType type, double width1, Unit units, double angle, double height1, double height2) : base(name, type, width1, units, angle)
        {
            this.Height1 = height1;
            this.Height2 = height2;
        }

        public Conic() {
            
        }

        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine+
                $"H1={this.Height1}" + Environment.NewLine+
                $"H2={this.Height2}";
        }
    }
}
