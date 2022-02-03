namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This class represents the base class for rules.
    /// </summary>
    public abstract class Rule
    {
        private int state;
        internal Direction direction;

        /// <summary>
        /// Constructs the <see cref="Ant"/>.
        /// </summary>
        /// <param name="state">Cell state</param>
        public Rule(int state)
        {
            this.state = state;
        }

        /// <summary>
        /// Gets the state that activates this rule.
        /// </summary>
        /// <returns>Cell state</returns>
        public int GetState()
        {
            return state;
        }

        /// <summary>
        /// Gets the direction the ant is currently facing.
        /// </summary>
        /// <returns>Ant direction</returns>
        public Direction getDirection()
        {
            return direction;
        }

        /// <summary>
        /// Abstract method for turning the <see cref="Ant"/> based on a rule.
        /// </summary>
        /// <param name="dir">Current direction</param>
        public abstract Point Turn(Point position, Direction dir);

        /// <summary>
        /// Abstract method that sets and returns the new state of the current block.
        /// </summary>
        /// <returns>Integer state of the current block</returns>
        public abstract int GetNewState();
    }
}
