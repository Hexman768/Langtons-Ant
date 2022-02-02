using System.Drawing;

namespace Langton_s_Ant.Core
{
    public class Game
    {
        private Board board;
        private int cellSize;
        private Ant ant;
        private int rows;
        private int cols;

        /// <summary>
        /// Constructs the <see cref="Game"/>.
        /// </summary>
        /// <param name="rows">Rows</param>
        /// <param name="cols">Columns</param>
        /// <param name="cellSize">Size of cell</param>
        public Game(int rows, int cols, int cellSize)
        {
            this.cellSize = cellSize;
            board = CreateBoard(rows, cols);
            this.rows = rows; this.cols = cols;
            ant = new Ant(25, 25, Direction.NORTH);
        }

        /// <summary>
        /// Creates the game board.
        /// </summary>
        /// <param name="rows">Rows</param>
        /// <param name="cols">Columns</param>
        /// <returns></returns>
        public Board CreateBoard(int rows, int cols)
        {
            Board board = new Board();
            for (int i = 0; i < rows; i++)
            {
                board.AddRow();
            }

            foreach (Row row in board.rows)
            {
                for (int i = 0; i < cols; i++)
                {
                    row.AddBlock();
                }
            }

            return board;
        }

        /// <summary>
        /// Draws the game board. 
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void Draw(Graphics g)
        {
            Point startPoint = new Point(5, 5);
            Point currentPoint = startPoint;
            int i = 0; int j = 0;

            foreach (Row row in board.rows)
            {
                i++;
                foreach (Block block in row.blocks)
                {
                    j++;
                    Rectangle cellRect = new Rectangle(currentPoint.X, currentPoint.Y, cellSize, cellSize);
                    if (j == ant.X && i == ant.Y)
                        g.FillRectangle(Brushes.Green, cellRect);
                    else if (block.state == 1)
                        g.FillRectangle(Brushes.Black, cellRect);
                    else
                        g.FillRectangle(Brushes.White, cellRect);

                    currentPoint = new Point((currentPoint.X + cellSize + 1), currentPoint.Y);
                }
                j = 0;
                currentPoint = new Point(startPoint.X, (currentPoint.Y + cellSize + 1));
            }
        }

        /// <summary>
        /// Executes the logic for one step (frame).
        /// </summary>
        public void Step()
        {
            int i = 0;
            int j = 0;
            foreach (Row row in board.rows)
            {
                i++;
                foreach(Block block in row.blocks)
                {
                    j++;
                    if (i == ant.Y && j == ant.X)
                    {
                        if (block.state == 0)
                        {
                            ant.TurnRight();
                            block.state = 1;
                        }
                        else if (block.state == 1)
                        {
                            ant.TurnLeft();
                            block.state = 0;
                        }
                    }
                }
                j = 0;
            }
        }
    }
}
