using System.Collections.Generic;
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

        private List<Rule> rules = new List<Rule>();

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
            rules.Add(new WhiteRule(0));
            rules.Add(new BlackRule(1));
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
            System.Drawing.Point startPoint = new System.Drawing.Point(5, 5);
            System.Drawing.Point currentPoint = startPoint;
            int i = 0; int j = 0;

            foreach (Row row in board.rows)
            {
                i++;
                foreach (Block block in row.blocks)
                {
                    j++;
                    Rectangle cellRect = new Rectangle(currentPoint.X, currentPoint.Y, cellSize, cellSize);
                    if (j == ant.position.X && i == ant.position.Y)
                        g.FillRectangle(Brushes.Green, cellRect);
                    else if (block.state == 1)
                        g.FillRectangle(Brushes.Black, cellRect);
                    else
                        g.FillRectangle(Brushes.White, cellRect);

                    currentPoint = new System.Drawing.Point((currentPoint.X + cellSize + 1), currentPoint.Y);
                }
                j = 0;
                currentPoint = new System.Drawing.Point(startPoint.X, (currentPoint.Y + cellSize + 1));
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
                    if (i == ant.position.Y && j == ant.position.X)
                    {
                        foreach(Rule rule in rules)
                        {
                            if (block.state.Equals(rule.GetState()))
                            {
                                ant.position = rule.Turn(ant.position, ant.direction);
                                ant.direction = rule.getDirection();
                                block.state = rule.GetNewState();
                                break;
                            }
                        }
                    }
                }
                j = 0;
            }
        }
    }
}
