﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class BullNose : Tool
    {
        public decimal Height1 { get; set; }
        public decimal Height2 { get; set; }

        public BullNose(string name, string type, decimal width1, decimal height1, decimal height2) : base(name, type, width1)
        {
            this.Height1 = height1;
            this.Height2 = height2;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"H1={this.Height1}"+ Environment.NewLine + 
                $"H2={this.Height2}";
        }
    }
}
