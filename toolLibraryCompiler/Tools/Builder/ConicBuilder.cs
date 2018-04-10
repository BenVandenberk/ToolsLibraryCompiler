namespace toolLibraryCompiler.Tools.Builder
{
    public class ConicBuilder : AngularToolBuilder
    {
        private ConicBuilder(ToolType toolType) : base(toolType) { }

        public static ConicBuilder NewBuilder() {
            return new ConicBuilder(ToolType.CONIC);
        }

        public ConicBuilder Height1(double height1) {
            As<Conic>().Height1 = height1;
            return this;
        }

        public ConicBuilder Height2(double height2) {
            As<Conic>().Height2 = height2;
            return this;
        }
    }
}