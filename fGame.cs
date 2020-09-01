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
        int musicDuration = Quiz.musicDuration;
        
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Quiz.list.Count == 0)
                GameEnd();
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
            lblTimer.Text = musicDuration.ToString();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Quiz.gameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            musicDuration--;
            lblTimer.Text = musicDuration.ToString();
            if (progressBar.Value == progressBar.Maximum)
            {
                GameEnd();
                return;
            }
            if (musicDuration == 0)
                GameEnd();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void GamePause()
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }
        private void GamePlay()
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }
        private void GameEnd()
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.A)
            //{
            //    GamePause();
            //    if (MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        lblFirstPlayer.Text = (Convert.ToInt32(lblFirstPlayer.Text) + 1).ToString();
            //        //MakeMusic();
            //    }
            //    GamePlay();
            //}
            switch (e.KeyData)
            {
                case Keys.A:
                case Keys.Q:
                case Keys.Z:
                    {
                        GamePause();
                        if (MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            lblFirstPlayer.Text = (Convert.ToInt32(lblFirstPlayer.Text) + 1).ToString();
                        GamePlay();
                    } break;
                case Keys.B:
                case Keys.V:
                case Keys.N:
                    {
                        GamePause();
                        if (MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            lblSecondPlayer.Text = (Convert.ToInt32(lblSecondPlayer.Text) + 1).ToString();
                        GamePlay();
                    } break;
                case Keys.P:
                case Keys.L:
                case Keys.O:
                    {
                        GamePause();
                        if (MessageBox.Show("Правильный ответ?", "Игрок 3", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            lblThirdPlayer.Text = (Convert.ToInt32(lblThirdPlayer.Text) + 1).ToString();
                        GamePlay();
                    } break;
            }
        }
    }
}
