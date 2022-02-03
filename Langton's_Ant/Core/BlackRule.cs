namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This is the default rule for the <see cref="Ant"/> landing on a black cell.
    /// </summary>
    public class BlackRule : Rule
    {
        private readonly int[] move_x = new[] { -1, 1, 0, 0 };
        private readonly int[] move_y = new[] { 0, 0, -1, 1 };
        private readonly Direction[] directions = new[] { Direction.WEST, Direction.EAST, Direction.NORTH, Direction.SOUTH };

        /// <summary>
        /// Constructs the <see cref="BlackRule"/>.
        /// </summary>
        /// <param name="state">The state for the rule</param>
        public BlackRule(int state) : base(state)
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
            return 0;
        }
    }
}
