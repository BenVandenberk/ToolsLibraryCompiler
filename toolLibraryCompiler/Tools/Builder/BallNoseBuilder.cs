namespace toolLibraryCompiler.Tools.Builder
{
    public class BallNoseBuilder : ToolBuilder<BallNose>
    {
        protected BallNoseBuilder() {
            this.Instance = new BallNose();
        }

        public static BallNoseBuilder NewBuilder() {
            return new BallNoseBuilder();
        }

        public BallNoseBuilder Height1(double height1) {
            this.Instance.Height1 = height1;
            return this;
        }
    }
}