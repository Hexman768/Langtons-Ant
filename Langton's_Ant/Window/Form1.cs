using Langton_s_Ant.Core;
using System;
using System.Windows.Forms;

namespace Langton_s_Ant.Window
{
    public partial class mainForm : Form
    {
        private int rows;
        private int cols;
        private int size;
        private int steps = 0;

        /// <summary>
        /// This method fixes the screen flickering caused by the constant repainting of the form.
        /// <see cref="https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms"/>.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        Game game;

        /// <summary>
        /// Constructs the <see cref="mainForm"/>.
        /// </summary>
        public mainForm()
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
            game.Step();
            steps++;
            stepsLbl.Text = $"Steps: {steps}";
            Invalidate();
        }
    }
}
