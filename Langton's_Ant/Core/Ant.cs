namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This class represents the Ant object model.
    /// </summary>
    public class Ant
    {
        /// <summary>
        /// Location of <see cref="Ant"/> on the X axis.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Location of <see cref="Ant"/> on the Y axis.
        /// </summary>
        public int Y { get; set; }

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
            X = x;
            Y = y;
            direction = dir;
        }

        /// <summary>
        /// Turns the <see cref="Ant"/> clockwise.
        /// </summary>
        public void TurnRight()
        {
            switch (direction)
            {
                case Direction.NORTH:
                    X += 1;
                    direction = Direction.EAST;
                    break;
                case Direction.SOUTH:
                    X -= 1;
                    direction = Direction.WEST;
                    break;
                case Direction.EAST:
                    Y += 1;
                    direction = Direction.SOUTH;
                    break;
                case Direction.WEST:
                    Y -= 1;
                    direction = Direction.NORTH;
                    break;
            }
        }

        /// <summary>
        /// Turns the <see cref="Ant"/> counter-clockwise.
        /// </summary>
        public void TurnLeft()
        {
            switch (direction)
            {
                case Direction.NORTH:
                    X -= 1;
                    direction = Direction.WEST;
                    break;
                case Direction.SOUTH:
                    X += 1;
                    direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    Y -= 1;
                    direction = Direction.NORTH;
                    break;
                case Direction.WEST:
                    Y += 1;
                    direction = Direction.SOUTH;
                    break;
            }
        }
    }
}
