
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
            this.body_sk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.body_sk)).BeginInit();
            this.SuspendLayout();
            // 
            // body_sk
            // 
            this.body_sk.BackColor = System.Drawing.Color.LawnGreen;
            this.body_sk.Location = new System.Drawing.Point(407, 139);
            this.body_sk.Name = "body_sk";
            this.body_sk.Size = new System.Drawing.Size(25, 25);
            this.body_sk.TabIndex = 0;
            this.body_sk.TabStop = false;
            // 
            // Snake_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.body_sk);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Snake_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake_main";
            ((System.ComponentModel.ISupportInitialize)(this.body_sk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox body_sk;
    }
}