namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This is the default rule for the <see cref="Ant"/> landing on a white cell.
    /// </summary>
    public class WhiteRule : Rule
    {

        private readonly int[] move_x = new[] { 1, -1, 0, 0 };
        private readonly int[] move_y = new[] { 0, 0, 1, -1 };
        private readonly Direction[] directions = new[] { Direction.EAST, Direction.WEST, Direction.SOUTH, Direction.NORTH };

        /// <summary>
        /// Constructs the <see cref="WhiteRule"/>.
        /// </summary>
        /// <param name="state">The state for the rule</param>
        public WhiteRule(int state) : base(state)
        {
        }

        public override Point Turn(Point position, Direction dir)
        {
            position.X += move_x[(int)dir];
            position.Y += move_y[(int)dir];

            direction = directions[(int)dir];

            return position;
        }

        public override int GetNewState()
        {
            return 1;
        }
    }
}
