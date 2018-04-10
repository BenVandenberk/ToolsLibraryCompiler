namespace toolLibraryCompiler.Tools.Builder
{
    public static class ToolBuilderFactory
    {
        public static ToolBuilder<T> BuilderFor<T>(ToolType type) where T : Tool {
            switch (type) {
                case ToolType.BALL_NOSE:
                    return (ToolBuilder<BallNose>)BallNoseBuilder.NewBuilder();
            }
        }
    }
}