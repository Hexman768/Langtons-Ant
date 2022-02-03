using Langton_s_Ant.Core;
using System;
using System.Windows.Forms;

namespace Langton_s_Ant.Window
{
    public partial class MainForm : Form
    {
        private int rows;
        private int cols;
        private int size;
        private int steps = 0;

        Game game;

        /// <summary>
        /// Constructs the <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            rows = 100;
            cols = 100;
            size = 5;

            game = new Game(rows, cols, size);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            frameTmr.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            frameTmr.Stop();
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void FrameTmr_Tick(object sender, EventArgs e)
        {
            game.Step(); game.Step(); game.Step();
            steps += 3;
            stepsLbl.Text = $"Steps: {steps}";
            Invalidate();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            game = new Game(rows, cols, size);
            stepsLbl.Text = $"Steps: 0";
            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Extension.DoubleBuffered(this, true);
        }
    }
}
