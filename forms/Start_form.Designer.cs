
namespace SNAKE
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Sign_In = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_In.Image = ((System.Drawing.Image)(resources.GetObject("Sign_In.Image")));
            this.Sign_In.Location = new System.Drawing.Point(14, 395);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(210, 85);
            this.Sign_In.TabIndex = 0;
            this.Sign_In.UseVisualStyleBackColor = false;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Image = ((System.Drawing.Image)(resources.GetObject("Register.Image")));
            this.Register.Location = new System.Drawing.Point(14, 315);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(210, 75);
            this.Register.TabIndex = 1;
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Control;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(-2, -117);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(600, 400);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.title.TabIndex = 2;
            this.title.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 239);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 333);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(901, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 39);
            this.exit.TabIndex = 8;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 553);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Sign_In);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
    }
}

