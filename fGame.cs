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
    public partial class fGame : Form
    {
        Random random = new Random();
        
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            int i = random.Next(0, Quiz.list.Count);
            wmp.URL = Quiz.list[i];
            //wmp.Ctlcontrols.play();
            Quiz.list.RemoveAt(i);
            lblMelodyCount.Text = Quiz.list.Count.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Quiz.list.Count.ToString();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Quiz.gameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value == progressBar.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }
    }
}
