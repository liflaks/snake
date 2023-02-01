
namespace SNAKE.forms
{
    partial class Snake_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake_main));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.GameOverPic = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.HighScore = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.GameOverPic);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.HighScore);
            this.panel1.Controls.Add(this.CurrentScore);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(680, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 714);
            this.panel1.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile.BackgroundImage")));
            this.profile.Location = new System.Drawing.Point(29, 4);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(40, 40);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 10;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(208, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 49);
            this.exit.TabIndex = 9;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GameOverPic
            // 
            this.GameOverPic.Image = ((System.Drawing.Image)(resources.GetObject("GameOverPic.Image")));
            this.GameOverPic.Location = new System.Drawing.Point(29, 85);
            this.GameOverPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameOverPic.Name = "GameOverPic";
            this.GameOverPic.Size = new System.Drawing.Size(188, 54);
            this.GameOverPic.TabIndex = 6;
            this.GameOverPic.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 310);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 66);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 55);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(41, 450);
            this.startButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 86);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.BeginButtonClicked);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Black;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.ForeColor = System.Drawing.Color.Lime;
            this.comboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Insane"});
            this.comboBox.Location = new System.Drawing.Point(39, 401);
            this.comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(196, 28);
            this.comboBox.TabIndex = 2;
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HighScore.Location = new System.Drawing.Point(196, 245);
            this.HighScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HighScore.Name = "HighScore";
            this.HighScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HighScore.Size = new System.Drawing.Size(26, 30);
            this.HighScore.TabIndex = 1;
            this.HighScore.Text = "0";
            this.HighScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CurrentScore.Location = new System.Drawing.Point(196, 166);
            this.CurrentScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(26, 30);
            this.CurrentScore.TabIndex = 1;
            this.CurrentScore.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(254)))), ((int)(((byte)(14)))));
            this.pictureBox3.Location = new System.Drawing.Point(680, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 709);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Snake_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(954, 600);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Snake_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Snake_main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_main_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox GameOverPic;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox profile;
    }
}