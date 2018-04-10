namespace toolLibraryCompiler.Tools.Builder
{
    public abstract class ToolBuilder<T> where T : Tool
    {
        protected T Instance;

        protected ToolBuilder<T> Name(string name) {
            this.Instance.Name = name;
            this.Instance.Description = name;
            return this;
        }

        protected ToolBuilder<T> Type(ToolType type) {
            this.Instance.Type = type;
            return this;
        }

        protected ToolBuilder<T> Width1(double width1) {
            this.Instance.Width1 = width1;
            return this;
        }

        protected ToolBuilder<T> Units(Unit units) {
            this.Instance.Units = units;
            return this;
        }

    }
}