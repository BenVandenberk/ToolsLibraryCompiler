namespace toolLibraryCompiler.Tools.Builder
{
    public abstract class AngularToolBuilder : ToolBuilder
    {
        protected AngularToolBuilder(ToolType toolType) : base(toolType) { }

        protected AngularToolBuilder Angle(double angle) {
            ((AngularTool) this.Instance).Angle = angle;
            return this;
        }
    }
}