using System;

namespace toolLibraryCompiler.Tools
{
    public class BallNose : Tool
    {
        public static readonly bool CAN_ENGRAVE = true;
        public static readonly int COLOR = 16776960;

        public double Height1 { get; set; }

        public BallNose(string name, ToolType type, double width1, Unit units, double height1) : base(name, type, width1, units)
        {
            this.Height1 = height1;            
        }

        public BallNose() {
            
        }

        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine +
                $"H1={this.Height1}";
        }
    }
}
