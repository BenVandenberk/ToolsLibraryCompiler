using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolLibraryCompiler
{
    class Tool
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Width1 { get; set; }
        public string Description { get; set; }
        public string Units { get; set; }
        public decimal Color { get; set; }
        public bool CanEngrave { get; set; }


        public Tool(string name, string type, decimal width1)
        {
            this.Name = name;
            this.Type = type;
            this.Width1 = width1;
            this.Description = name;

            switch (type)
            {
                case "BallNose":
                    this.CanEngrave = true;
                    this.Color = 16776960;
                    break;
                case "BullNose":
                    this.CanEngrave = false;
                    this.Color = 8421376;
                    break;
                case "Conic":
                    this.CanEngrave = true;
                    this.Color = 32768;
                    break;
                case "DrillBit":
                    this.CanEngrave = false;
                    this.Color = 255;
                    break;
                case "EndMill":
                    this.CanEngrave = false;
                    this.Color = 16711680;
                    break;
                case "Engrave":
                    this.CanEngrave = true;
                    this.Color = 128;
                    break;
                case "Engrave2":
                    this.CanEngrave = true;
                    this.Color = 255;
                    break;
                case "Spherical":
                    this.CanEngrave = true;
                    this.Color = 32896;
                    break;
                case "Taper":
                    this.CanEngrave = true;
                    this.Color = 16776960;
                    break;
            }
        }

        public override string ToString()
        {
            return $"[{this.Name}]{Environment.NewLine} " +
                $"Description={this.Description}{Environment.NewLine}" +
                $"D1={this.Width1}{Environment.NewLine}" +
                $"Units=su{this.Units}{Environment.NewLine}" +
                $"Color={this.Color}{Environment.NewLine}" + 
                $"Can_Engrave={this.CanEngrave}"+
                $"ToolType={this.Type}";
        }
    }
}
