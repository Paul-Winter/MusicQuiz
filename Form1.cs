using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicQuiz
{
    public partial class MainForm : Form
    {
        fParams fParams = new fParams();
        fGame fGame = new fGame();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            fParams.ShowDialog();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            fGame.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadParam();
            Quiz.ReadMusic();
        }
    }
}
