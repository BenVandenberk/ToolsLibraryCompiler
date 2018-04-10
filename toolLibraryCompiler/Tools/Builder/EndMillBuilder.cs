namespace toolLibraryCompiler.Tools.Builder
{
    public class EndMillBuilder : ToolBuilder
    {
        private EndMillBuilder(ToolType toolType) : base(toolType) { }

        public static EndMillBuilder NewBuilder() {
            return new EndMillBuilder(ToolType.END_MILL);
        }

        public EndMillBuilder Heigth1(double heigth1) {
            As<EndMill>().Height1 = heigth1;
            return this;
        }
    }
}