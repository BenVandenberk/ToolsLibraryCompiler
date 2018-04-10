namespace toolLibraryCompiler.Tools.Builder
{
    public class TaperBuilder : AngularToolBuilder
    {
        private TaperBuilder(ToolType toolType) : base(toolType) { }

        public static TaperBuilder NewBuilder() {
            return new TaperBuilder(ToolType.TAPER);
        }

        public TaperBuilder Width2(double width2) {
            As<Taper>().Width2 = width2;
            return this;
        }

        public TaperBuilder Height1(double height1) {
            As<Taper>().Height1 = height1;
            return this;
        }
    }
}