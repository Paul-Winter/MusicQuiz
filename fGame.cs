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
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }
    }
}
