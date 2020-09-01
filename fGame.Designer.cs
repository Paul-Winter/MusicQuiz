namespace MusicQuiz
{
    partial class fGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblFirstPlayer = new System.Windows.Forms.Label();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.lblThirdPlayer = new System.Windows.Forms.Label();
            this.lblMelodyCount = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(2, 363);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(211, 45);
            this.wmp.TabIndex = 0;
            this.wmp.Visible = false;
            this.wmp.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.wmp_OpenStateChange);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(12, 305);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 65);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(143, 305);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 65);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(230, 305);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(122, 65);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer1.Location = new System.Drawing.Point(13, 13);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(85, 24);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Игрок 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer2.Location = new System.Drawing.Point(139, 13);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(85, 24);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Игрок 2";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer3.Location = new System.Drawing.Point(267, 13);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(85, 24);
            this.lblPlayer3.TabIndex = 6;
            this.lblPlayer3.Text = "Игрок 3";
            // 
            // lblFirstPlayer
            // 
            this.lblFirstPlayer.AutoSize = true;
            this.lblFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstPlayer.Location = new System.Drawing.Point(29, 60);
            this.lblFirstPlayer.Name = "lblFirstPlayer";
            this.lblFirstPlayer.Size = new System.Drawing.Size(21, 24);
            this.lblFirstPlayer.TabIndex = 7;
            this.lblFirstPlayer.Text = "0";
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondPlayer.Location = new System.Drawing.Point(158, 60);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(21, 24);
            this.lblSecondPlayer.TabIndex = 8;
            this.lblSecondPlayer.Text = "0";
            // 
            // lblThirdPlayer
            // 
            this.lblThirdPlayer.AutoSize = true;
            this.lblThirdPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThirdPlayer.Location = new System.Drawing.Point(285, 60);
            this.lblThirdPlayer.Name = "lblThirdPlayer";
            this.lblThirdPlayer.Size = new System.Drawing.Size(21, 24);
            this.lblThirdPlayer.TabIndex = 9;
            this.lblThirdPlayer.Text = "0";
            // 
            // lblMelodyCount
            // 
            this.lblMelodyCount.AutoSize = true;
            this.lblMelodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMelodyCount.Location = new System.Drawing.Point(241, 111);
            this.lblMelodyCount.Name = "lblMelodyCount";
            this.lblMelodyCount.Size = new System.Drawing.Size(27, 29);
            this.lblMelodyCount.TabIndex = 10;
            this.lblMelodyCount.Text = "0";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.Location = new System.Drawing.Point(15, 115);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(203, 24);
            this.lblCounter.TabIndex = 11;
            this.lblCounter.Text = "Осталось мелодий:";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(17, 220);
            this.progressBar.MarqueeAnimationSpeed = 200;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 28);
            this.progressBar.TabIndex = 12;
            this.progressBar.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Осталось времени:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(241, 151);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(27, 29);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 382);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblMelodyCount);
            this.Controls.Add(this.lblThirdPlayer);
            this.Controls.Add(this.lblSecondPlayer);
            this.Controls.Add(this.lblFirstPlayer);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.wmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(380, 420);
            this.MinimumSize = new System.Drawing.Size(380, 420);
            this.Name = "fGame";
            this.Text = "Угадай мелодию!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblFirstPlayer;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.Label lblThirdPlayer;
        private System.Windows.Forms.Label lblMelodyCount;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        public System.Windows.Forms.Label lblPlayer1;
        public System.Windows.Forms.Label lblPlayer2;
        public System.Windows.Forms.Label lblPlayer3;
    }
}