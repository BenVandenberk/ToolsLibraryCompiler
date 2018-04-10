namespace toolLibraryCompiler.Tools.Builder
{
    public class BallNoseBuilder : ToolBuilder
    {
        private BallNoseBuilder(ToolType toolType) : base(toolType) {
        }

        public static BallNoseBuilder NewBuilder() {
            return new BallNoseBuilder(ToolType.BALL_NOSE);
        }

        public BallNoseBuilder Height1(double height1) {
            As<BallNose>().Height1 = height1;
            return this;
        }
    }
}