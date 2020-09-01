﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicQuiz
{
    public partial class fGame : Form
    {
        Random random = new Random();
        int musicDuration;
        SoundPlayer sp;
        bool[] players = new bool[3];
        
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
            Quiz.answer = Path.GetFileNameWithoutExtension(wmp.URL);
            //wmp.Ctlcontrols.play();
            Quiz.list.RemoveAt(i);
            lblMelodyCount.Text = Quiz.list.Count.ToString();
            for (int j = 0; j < players.Length; j++)
                players[j] = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            musicDuration = Quiz.musicDuration;
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
            progressBar.Maximum = Quiz.musicDuration;
            //SoundPlayer sp = new SoundPlayer(Properties.Resources.MusixQuiz);
            //sp.PlaySync();
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
            if (!timer1.Enabled)
                return;
            switch (e.KeyData)
            {
                case Keys.A:
                case Keys.Q:
                case Keys.Z:
                    {
                        if (!players[0])
                        {
                            GamePause();
                            sp = new SoundPlayer(Properties.Resources.ButtonPress);
                            sp.PlaySync();
                            players[0] = true;
                            fMessage fm = new fMessage();
                            fm.lblMessagePlayer.Text = lblPlayer1.Text;
                            if (fm.ShowDialog() == DialogResult.Yes)
                                lblFirstPlayer.Text = (Convert.ToInt32(lblFirstPlayer.Text) + 1).ToString();
                            GamePlay();
                        }
                    } break;
                case Keys.B:
                case Keys.V:
                case Keys.N:
                    {
                        if (!players[1])
                        {
                            GamePause();
                            sp = new SoundPlayer(Properties.Resources.ButtonPress);
                            sp.PlaySync();
                            players[1] = true;
                            fMessage fm = new fMessage();
                            fm.lblMessagePlayer.Text = lblPlayer2.Text;
                            if (fm.ShowDialog() == DialogResult.Yes)
                                lblSecondPlayer.Text = (Convert.ToInt32(lblSecondPlayer.Text) + 1).ToString();
                            GamePlay();
                        }
                    } break;
                case Keys.P:
                case Keys.L:
                case Keys.O:
                    {
                        if (!players[2])
                        {
                            GamePause();
                            sp = new SoundPlayer(Properties.Resources.ButtonPress);
                            sp.PlaySync();
                            players[2] = true;
                            fMessage fm = new fMessage();
                            fm.lblMessagePlayer.Text = lblPlayer3.Text;
                            if (fm.ShowDialog() == DialogResult.Yes)
                                lblThirdPlayer.Text = (Convert.ToInt32(lblThirdPlayer.Text) + 1).ToString();
                            GamePlay();
                        }
                    } break;
            }
        }

        private void wmp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.randomStart)
                if (wmp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    wmp.Ctlcontrols.currentPosition = random.Next(0, (int)(wmp.currentMedia.duration) / 2);
        }

        private void lblFirstPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblFirstPlayer.Text = (Convert.ToInt32(lblFirstPlayer.Text) + 1).ToString();
            if (e.Button == MouseButtons.Right)
                lblFirstPlayer.Text = (Convert.ToInt32(lblFirstPlayer.Text) - 1).ToString();
        }

        private void lblSecondPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblSecondPlayer.Text = (Convert.ToInt32(lblSecondPlayer.Text) + 1).ToString();
            if (e.Button == MouseButtons.Right)
                lblSecondPlayer.Text = (Convert.ToInt32(lblSecondPlayer.Text) - 1).ToString();
        }

        private void lblThirdPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblThirdPlayer.Text = (Convert.ToInt32(lblThirdPlayer.Text) + 1).ToString();
            if (e.Button == MouseButtons.Right)
                lblThirdPlayer.Text = (Convert.ToInt32(lblThirdPlayer.Text) - 1).ToString();
        }
    }
}
