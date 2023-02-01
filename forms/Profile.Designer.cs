
namespace SNAKE.forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.delete = new System.Windows.Forms.Button();
            this.session = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.session);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.record);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 251);
            this.panel1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.Lime;
            this.id.Location = new System.Drawing.Point(61, 68);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 17);
            this.id.TabIndex = 11;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox.ForeColor = System.Drawing.Color.Lime;
            this.checkBox.Location = new System.Drawing.Point(176, 207);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(111, 21);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "You sure?";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Visible = false;
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.Lime;
            this.delete.Location = new System.Drawing.Point(10, 203);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(170, 29);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete session";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // session
            // 
            this.session.AutoSize = true;
            this.session.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.session.ForeColor = System.Drawing.Color.Lime;
            this.session.Location = new System.Drawing.Point(90, 163);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(53, 17);
            this.session.TabIndex = 8;
            this.session.Text = "False";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(10, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "session:";
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.record.ForeColor = System.Drawing.Color.Lime;
            this.record.Location = new System.Drawing.Point(90, 103);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(0, 17);
            this.record.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "record:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(13, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "id:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.Lime;
            this.login.Location = new System.Drawing.Point(81, 21);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(0, 17);
            this.login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "login:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(481, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(29, 30);
            this.back.TabIndex = 13;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 415);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label session;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id;
    }
}