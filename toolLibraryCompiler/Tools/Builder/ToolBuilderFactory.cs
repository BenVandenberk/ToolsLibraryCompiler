using System;

namespace toolLibraryCompiler.Tools.Builder
{
    public static class ToolBuilderFactory
    {
        public static ToolBuilder BuilderFor(ToolType type) {
            switch (type) {
                case ToolType.BALL_NOSE:
                    return BallNoseBuilder.NewBuilder();
                case ToolType.BULL_NOSE:
                    return BullNoseBuilder.NewBuilder();
                case ToolType.CONIC:
                    return ConicBuilder.NewBuilder();
                case ToolType.DRILL_BIT:
                    return DrillBitBuilder.NewBuilder();
                case ToolType.END_MILL:
                    return EndMillBuilder.NewBuilder();
                case ToolType.ENGRAVE:
                    return EngraveBuilder.NewBuilder();
                case ToolType.ENGRAVE2:
                    return Engrave2Builder.NewBuilder();
                case ToolType.SPHERICAL:
                    return SphericalBuilder.NewBuilder();
                case ToolType.TAPER:
                    return TaperBuilder.NewBuilder();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}