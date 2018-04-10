using System;

namespace toolLibraryCompiler.Tools
{
    public class EndMill : Tool
    {
        public static readonly bool CAN_ENGRAVE = false;
        public static readonly int COLOR = 16711680;

        public double Height1 { get; set; }

        public EndMill(string name, ToolType type, double width1, Unit units, double height1) : base(name, type, width1, units)
        {
            this.Height1 = height1;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine+
                $"H1={this.Height1}";
        }
    }
}
