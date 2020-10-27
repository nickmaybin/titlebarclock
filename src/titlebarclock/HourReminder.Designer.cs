namespace TitleBarClock
{
    partial class HourReminder
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
            this.blinkLabel1 = new TitleBarClock.BlinkLabel();
            this.SuspendLayout();
            // 
            // blinkLabel1
            // 
            this.blinkLabel1.AutoSize = true;
            this.blinkLabel1.ForeColor = System.Drawing.Color.Purple;
            this.blinkLabel1.Location = new System.Drawing.Point(24, 28);
            this.blinkLabel1.Name = "blinkLabel1";
            this.blinkLabel1.Size = new System.Drawing.Size(61, 13);
            this.blinkLabel1.TabIndex = 0;
            this.blinkLabel1.Text = "blinkLabel1";
            // 
            // HourReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(120, 53);
            this.Controls.Add(this.blinkLabel1);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 40);
            this.Name = "HourReminder";
            this.Text = "HourReminder";
            this.Load += new System.EventHandler(this.HourReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlinkLabel blinkLabel1;
    }
}