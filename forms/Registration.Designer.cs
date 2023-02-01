
namespace SNAKE.forms
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password_re = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.done = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.s_check = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(223, 209);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(159, 27);
            this.login.TabIndex = 1;
            // 
            // password_re
            // 
            this.password_re.Location = new System.Drawing.Point(299, 408);
            this.password_re.Name = "password_re";
            this.password_re.Size = new System.Drawing.Size(161, 27);
            this.password_re.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Image = ((System.Drawing.Image)(resources.GetObject("done.Image")));
            this.done.Location = new System.Drawing.Point(538, 340);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(279, 139);
            this.done.TabIndex = 6;
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(854, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 39);
            this.exit.TabIndex = 7;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(299, 335);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(161, 27);
            this.password.TabIndex = 8;
            // 
            // s_check
            // 
            this.s_check.AutoSize = true;
            this.s_check.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.s_check.ForeColor = System.Drawing.Color.Lime;
            this.s_check.Location = new System.Drawing.Point(223, 260);
            this.s_check.Name = "s_check";
            this.s_check.Size = new System.Drawing.Size(196, 24);
            this.s_check.TabIndex = 9;
            this.s_check.Text = "Запомнить устройство?";
            this.s_check.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(899, 15);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(29, 30);
            this.back.TabIndex = 12;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 553);
            this.Controls.Add(this.back);
            this.Controls.Add(this.s_check);
            this.Controls.Add(this.password);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.done);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.password_re);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password_re;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox s_check;
        private System.Windows.Forms.PictureBox back;
    }
}