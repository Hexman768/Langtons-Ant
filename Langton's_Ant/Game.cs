using System.Drawing;

namespace Langton_s_Ant
{
    class Game
    {
        private Board board;
        private int cellSize;

        public Game(int rows, int cols, int cellSize)
        {
            this.cellSize = cellSize;
            board = CreateBoard(rows, cols);
        }

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

        public void Draw(Graphics g)
        {
            Point startPoint = new Point(5, 5);
            Point currentPoint = startPoint;

            foreach (Row row in board.rows)
            {
                foreach (Block block in row.blocks)
                {
                    Rectangle cellRect = new Rectangle(currentPoint.X, currentPoint.Y, cellSize, cellSize);
                    if (block.state == 1)
                        g.FillRectangle(Brushes.Black, cellRect);
                    else
                        g.FillRectangle(Brushes.White, cellRect);

                    currentPoint = new Point((currentPoint.X + cellSize + 1), currentPoint.Y);
                }
                currentPoint = new Point(startPoint.X, (currentPoint.Y + cellSize + 1));
            }
        }
    }
}
