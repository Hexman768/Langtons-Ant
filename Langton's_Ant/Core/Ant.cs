namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This class represents the Ant object model.
    /// </summary>
    public class Ant
    {
        /// <summary>
        /// Stores the ant's current position on the board.
        /// </summary>
        public Point position { get; set; }

        /// <summary>
        /// Direction the <see cref="Ant"/> is facing.
        /// </summary>
        public Direction direction { get; set; }

        /// <summary>
        /// Constructs the <see cref="Ant"/>.
        /// </summary>
        /// <param name="x">Location X</param>
        /// <param name="y">Location Y</param>
        /// <param name="dir">Direction ant is facing</param>
        public Ant(int x, int y, Direction dir)
        {
            position = new Point(x, y);
            direction = dir;
        }
    }
}
