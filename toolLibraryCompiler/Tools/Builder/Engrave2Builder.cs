namespace toolLibraryCompiler.Tools.Builder
{
    public class Engrave2Builder : AngularToolBuilder
    {
        private Engrave2Builder(ToolType toolType) : base(toolType) { }

        public static Engrave2Builder NewBuilder() {
            return new Engrave2Builder(ToolType.ENGRAVE2);
        }

        public Engrave2Builder Width2(double width2) {
            As<Engrave2>().Width2 = width2;
            return this;
        }
    }
}