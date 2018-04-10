using System;

namespace toolLibraryCompiler.Tools
{
    class EndMill : Tool
    {
        public static readonly bool CAN_ENGRAVE = false;
        public static readonly int COLOR = 16711680;
        public decimal Height1 { get; set; }

        public EndMill(string name, string type, decimal width1, decimal height1) : base(name, type, width1)
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
