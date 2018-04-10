using System;

namespace toolLibraryCompiler.Tools.Builder
{
    public static class ToolsFactory
    {
        public static Tool NewGeneralTool(string name, ToolType type, double width1, Unit units) {
            return null;
        }

        private static Tool Of(ToolType type) {
            switch (type) {
                case ToolType.BALL_NOSE:
                    return new BallNose();
                case ToolType.BULL_NOSE:
                    return new BullNose();
                case ToolType.CONIC:
                    return new Conic();
                case ToolType.DRILL_BIT:
                    return new DrillBit();
                case ToolType.END_MILL:
                    return new EndMill();
                case ToolType.ENGRAVE:
                    return new Engrave();
                case ToolType.ENGRAVE2:
                    return new Engrave2();
                case ToolType.SPHERICAL:
                    return new Spherical();
                case ToolType.TAPER:
                    return new Taper();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}