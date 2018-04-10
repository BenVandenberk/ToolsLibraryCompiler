namespace toolLibraryCompiler.Tools.Builder
{
    public class SphericalBuilder : AngularToolBuilder
    {
        private SphericalBuilder(ToolType toolType) : base(toolType) { }

        public static SphericalBuilder NewBuilder() {
            return new SphericalBuilder(ToolType.SPHERICAL);
        }

        public SphericalBuilder Width2(double width2) {
            As<Spherical>().Width2 = width2;
            return this;
        }

        public SphericalBuilder Height1(double height1) {
            As<Spherical>().Height1 = height1;
            return this;
        }

        public SphericalBuilder Height2(double height2) {
            As<Spherical>().Height2 = height2;
            return this;
        }
    }
}