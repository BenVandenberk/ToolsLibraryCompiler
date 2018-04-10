﻿using System;

namespace toolLibraryCompiler.Tools
{
    class DrillBit : AngularTool
    {
        public static readonly bool CAN_ENGRAVE = false;
        public static readonly int COLOR = 255;

        public decimal Height1 { get; set; }
        public decimal Height2 { get; set; }

        public DrillBit(string name, string type, decimal width1, decimal angle, decimal height1, decimal height2) : base(name, type, width1, angle)
        {
            this.Height1 = height1;
            this.Height2 = height2;
        }

        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine +
                $"H1={this.Height1}"+ Environment.NewLine+
                $"H2={this.Height2}";
        }
    }
}