using System;

namespace toolLibraryCompiler.Tools
{
    public class Tool
    {
        public string Name { get; set; }
        public ToolType Type { get; set; }
        public decimal Width1 { get; set; }
        public string Description { get; set; }
        public string Units { get; set; }

        public Tool(string name, string type, decimal width1, string units)
        {
            this.Name = name;
            this.Type = type;
            this.Width1 = width1;
            this.Description = name;
            this.Units = units;

            switch (type)
            {
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
