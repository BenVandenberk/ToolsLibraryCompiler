using System;

namespace toolLibraryCompiler.Tools.Builder
{
    public abstract class ToolBuilder : IBuilder<Tool>
    {
        protected Tool Instance;

        protected ToolBuilder(ToolType toolType) {
            switch (toolType) {
                case ToolType.BALL_NOSE:
                    this.Instance = new BallNose();
                    break;
                case ToolType.BULL_NOSE:
                    this.Instance = new BullNose();
                    break;
                case ToolType.CONIC:
                    this.Instance = new Conic();
                    break;
                case ToolType.DRILL_BIT:
                    this.Instance = new DrillBit();
                    break;
                case ToolType.END_MILL:
                    this.Instance = new EndMill();
                    break;
                case ToolType.ENGRAVE:
                    this.Instance = new Engrave();
                    break;
                case ToolType.ENGRAVE2:
                    this.Instance = new Engrave2();
                    break;
                case ToolType.SPHERICAL:
                    this.Instance = new Spherical();
                    break;
                case ToolType.TAPER:
                    this.Instance = new Taper();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(toolType), toolType, null);
            }
        }

        protected ToolBuilder Name(string name) {
            this.Instance.Name = name;
            this.Instance.Description = name;
            return this;
        }

        protected ToolBuilder Type(ToolType type) {
            this.Instance.Type = type;
            return this;
        }

        protected ToolBuilder Width1(double width1) {
            this.Instance.Width1 = width1;
            return this;
        }

        protected ToolBuilder Units(Unit units) {
            this.Instance.Units = units;
            return this;
        }

        protected TCasted As<TCasted>() where TCasted : Tool {
            return (TCasted) this.Instance;
        }

        public virtual Tool Build() {
            return this.Instance;
        }
    }
}