namespace MusicQuiz
{
    partial class fParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParams));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListSelect = new System.Windows.Forms.Button();
            this.btnListClear = new System.Windows.Forms.Button();
            this.cbAllDirectory = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFirstPlayer = new System.Windows.Forms.ComboBox();
            this.cbSecondPlayer = new System.Windows.Forms.ComboBox();
            this.cbThirdPlayer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnListSelect
            // 
            this.btnListSelect.Location = new System.Drawing.Point(13, 216);
            this.btnListSelect.Name = "btnListSelect";
            this.btnListSelect.Size = new System.Drawing.Size(103, 23);
            this.btnListSelect.TabIndex = 1;
            this.btnListSelect.Text = "Выбрать папку";
            this.btnListSelect.UseVisualStyleBackColor = true;
            this.btnListSelect.Click += new System.EventHandler(this.btnListSelect_Click);
            // 
            // btnListClear
            // 
            this.btnListClear.Location = new System.Drawing.Point(122, 216);
            this.btnListClear.Name = "btnListClear";
            this.btnListClear.Size = new System.Drawing.Size(103, 23);
            this.btnListClear.TabIndex = 2;
            this.btnListClear.Text = "Очистить список";
            this.btnListClear.UseVisualStyleBackColor = true;
            // 
            // cbAllDirectory
            // 
            this.cbAllDirectory.AutoSize = true;
            this.cbAllDirectory.Location = new System.Drawing.Point(235, 220);
            this.cbAllDirectory.Name = "cbAllDirectory";
            this.cbAllDirectory.Size = new System.Drawing.Size(117, 17);
            this.cbAllDirectory.TabIndex = 3;
            this.cbAllDirectory.Text = "вложенные папки";
            this.cbAllDirectory.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(277, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbThirdPlayer);
            this.groupBox1.Controls.Add(this.cbSecondPlayer);
            this.groupBox1.Controls.Add(this.cbFirstPlayer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(9, 90);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(112, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "случайное место";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbMusicDuration.Location = new System.Drawing.Point(73, 55);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(37, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "10";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120",
            "180",
            "240",
            "300"});
            this.cbGameDuration.Location = new System.Drawing.Point(73, 21);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(37, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ответ, сек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Раунд, сек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Игрок 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Игрок 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Игрок 3";
            // 
            // cbFirstPlayer
            // 
            this.cbFirstPlayer.FormattingEnabled = true;
            this.cbFirstPlayer.Items.AddRange(new object[] {
            "Q",
            "q",
            "A",
            "a",
            "Z",
            "z",
            "W",
            "w",
            "S",
            "s",
            "X",
            "x",
            "E",
            "e",
            "D",
            "d"});
            this.cbFirstPlayer.Location = new System.Drawing.Point(193, 21);
            this.cbFirstPlayer.Name = "cbFirstPlayer";
            this.cbFirstPlayer.Size = new System.Drawing.Size(37, 21);
            this.cbFirstPlayer.TabIndex = 8;
            this.cbFirstPlayer.Text = "A";
            // 
            // cbSecondPlayer
            // 
            this.cbSecondPlayer.FormattingEnabled = true;
            this.cbSecondPlayer.Items.AddRange(new object[] {
            "V",
            "v",
            "B",
            "b",
            "F",
            "f",
            "G",
            "g",
            "H",
            "h",
            "T",
            "t",
            "Y",
            "y",
            "U",
            "u"});
            this.cbSecondPlayer.Location = new System.Drawing.Point(193, 55);
            this.cbSecondPlayer.Name = "cbSecondPlayer";
            this.cbSecondPlayer.Size = new System.Drawing.Size(37, 21);
            this.cbSecondPlayer.TabIndex = 9;
            this.cbSecondPlayer.Text = "B";
            // 
            // cbThirdPlayer
            // 
            this.cbThirdPlayer.FormattingEnabled = true;
            this.cbThirdPlayer.Items.AddRange(new object[] {
            "P",
            "p",
            "O",
            "o",
            "I",
            "i",
            "U",
            "u",
            "L",
            "l",
            "K",
            "k",
            "J",
            "j",
            "M",
            "m",
            "N",
            "n"});
            this.cbThirdPlayer.Location = new System.Drawing.Point(193, 88);
            this.cbThirdPlayer.Name = "cbThirdPlayer";
            this.cbThirdPlayer.Size = new System.Drawing.Size(37, 21);
            this.cbThirdPlayer.TabIndex = 10;
            this.cbThirdPlayer.Text = "P";
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbAllDirectory);
            this.Controls.Add(this.btnListClear);
            this.Controls.Add(this.btnListSelect);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 420);
            this.MinimumSize = new System.Drawing.Size(380, 420);
            this.Name = "fParams";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListSelect;
        private System.Windows.Forms.Button btnListClear;
        private System.Windows.Forms.CheckBox cbAllDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThirdPlayer;
        private System.Windows.Forms.ComboBox cbSecondPlayer;
        private System.Windows.Forms.ComboBox cbFirstPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}