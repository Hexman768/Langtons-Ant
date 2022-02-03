namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This is a helper class to represent a Vector.
    /// </summary>
    public class Point
    {
        public int X;
        public int Y;

        /// <summary>
        /// Constructs the <see cref="Point"/>.
        /// </summary>
        /// <param name="x">X position</param>
        /// <param name="y">Y position</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
