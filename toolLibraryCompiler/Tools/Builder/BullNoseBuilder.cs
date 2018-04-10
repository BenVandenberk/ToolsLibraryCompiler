namespace toolLibraryCompiler.Tools.Builder
{
    public class BullNoseBuilder : ToolBuilder
    {
        private BullNoseBuilder(ToolType toolType) : base(toolType) { }

        public static BullNoseBuilder NewBuilder() {
            return new BullNoseBuilder(ToolType.BULL_NOSE);
        }

        public BullNoseBuilder Height1(double height1) {
            As<BullNose>().Height1 = height1;
            return this;
        }

        public BullNoseBuilder Height2(double height2) {
            As<BullNose>().Height2 = height2;
            return this;
        }
    }
}