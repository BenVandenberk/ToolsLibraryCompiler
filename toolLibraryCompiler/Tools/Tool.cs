using System;

namespace toolLibraryCompiler.Tools
{
    public class Tool
    {
        public string Name { get; set; }
        public ToolType Type { get; set; }
        public double Width1 { get; set; }
        public string Description { get; set; }
        public Unit Units { get; set; }

        public Tool(string name, ToolType type, double width1, Unit units)
        {
            this.Name = name;
            this.Type = type;
            this.Width1 = width1;
            this.Description = name;
            this.Units = units;
        }

        public override string ToString()
        {
            return $"[{this.Name}]{Environment.NewLine} " +
                $"Description={this.Description}{Environment.NewLine}" +
                $"D1={this.Width1}{Environment.NewLine}" +
                $"Units=su{this.Units}{Environment.NewLine}" +
                $"ToolType={this.Type}";
        }
    }
}
