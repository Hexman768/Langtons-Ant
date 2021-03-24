using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Langton_s_Ant
{
    public partial class mainForm : Form
    {
        private int rows;
        private int cols;
        private int size;

        Game game;

        public mainForm()
        {
            InitializeComponent();

            rows = 50;
            cols = 50;
            size = 10;

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
    }
}
