namespace toolLibraryCompiler.Tools.Builder
{
    public class DrillBitBuilder : AngularToolBuilder
    {
        private DrillBitBuilder(ToolType toolType) : base(toolType) { }

        public static DrillBitBuilder NewBuilder() {
            return new DrillBitBuilder(ToolType.DRILL_BIT);
        }

        public DrillBitBuilder Height1(double height1) {
            As<DrillBit>().Height1 = height1;
            return this;
        }

        public DrillBitBuilder Height2(double height2) {
            As<DrillBit>().Height2 = height2;
            return this;
        }
    }
}