namespace toolLibraryCompiler.Tools.Builder
{
    public class EngraveBuilder : AngularToolBuilder
    {
        private EngraveBuilder(ToolType toolType) : base(toolType) { }

        public static EngraveBuilder NewBuilder() {
            return new EngraveBuilder(ToolType.ENGRAVE);
        }

        public EngraveBuilder G(double g) {
            As<Engrave>().G = g;
            return this;
        }

        public EngraveBuilder R(double r) {
            As<Engrave>().R = r;
            return this;
        }

        public EngraveBuilder B(double b) {
            As<Engrave>().B = b;
            return this;
        }
    }
}