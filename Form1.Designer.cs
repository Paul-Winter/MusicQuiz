namespace MusicQuiz
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(82, 49);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(208, 55);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "ИГРА";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnParams
            // 
            this.btnParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParams.Location = new System.Drawing.Point(82, 167);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(208, 55);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "НАСТРОЙКИ";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(82, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 382);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 420);
            this.MinimumSize = new System.Drawing.Size(380, 420);
            this.Name = "MainForm";
            this.Text = " Угадай мелодию!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnExit;
    }
}

