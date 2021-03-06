﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class Engrave2 : AngularTool
    {
        public decimal Width2 { get; set; }

        public Engrave2(string name, string type, decimal width1, decimal angle, decimal width2) : base(name, type, width1, angle)
        {
            this.Width2 = width2;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"D2={this.Width2}";
        }
    }
}
