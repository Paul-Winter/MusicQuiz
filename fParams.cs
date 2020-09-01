using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicQuiz
{
    public partial class fParams : Form
    {
        public fParams()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Quiz.randomStart = cbRandomStart.Checked;
            Quiz.allDirectories = cbAllDirectory.Checked;
            Quiz.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Quiz.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Quiz.WriteParam();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetParams();
            this.Hide();
        }

        private void btnListSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Quiz.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musicList);
                Quiz.list.Clear();
                Quiz.list.AddRange(musicList);
            }
        }

        private void fParams_Load(object sender, EventArgs e)
        {
            SetParams();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Quiz.list.ToArray());
        }

        void SetParams()
        {
            cbRandomStart.Checked = Quiz.randomStart;
            cbAllDirectory.Checked = Quiz.allDirectories;
            cbGameDuration.Text = Quiz.gameDuration.ToString();
            cbMusicDuration.Text = Quiz.musicDuration.ToString();
        }
    }
}
