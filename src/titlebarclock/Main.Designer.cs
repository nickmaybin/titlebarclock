namespace TitleBarClock
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMeetingPlanner = new System.Windows.Forms.Label();
            this.pbFour = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblOne.Location = new System.Drawing.Point(19, 2);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(34, 13);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "00:36";
            this.toolTip.SetToolTip(this.lblOne, "Hong Kong");
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTwo.Location = new System.Drawing.Point(102, 2);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(34, 13);
            this.lblTwo.TabIndex = 1;
            this.lblTwo.Text = "22:06";
            this.toolTip.SetToolTip(this.lblTwo, "Delhi");
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblThree.Location = new System.Drawing.Point(187, 2);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(57, 13);
            this.lblThree.TabIndex = 2;
            this.lblThree.Text = "16:36:23";
            this.toolTip.SetToolTip(this.lblThree, "London");
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblFour.Location = new System.Drawing.Point(302, 2);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(34, 13);
            this.lblFour.TabIndex = 3;
            this.lblFour.Text = "16:36";
            this.toolTip.SetToolTip(this.lblFour, "New York");
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(363, -3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(12, 13);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMeetingPlanner
            // 
            this.lblMeetingPlanner.AutoSize = true;
            this.lblMeetingPlanner.Location = new System.Drawing.Point(351, -2);
            this.lblMeetingPlanner.Name = "lblMeetingPlanner";
            this.lblMeetingPlanner.Size = new System.Drawing.Size(13, 13);
            this.lblMeetingPlanner.TabIndex = 5;
            this.lblMeetingPlanner.Text = "=";
            this.lblMeetingPlanner.Click += new System.EventHandler(this.lblMeetingPlanner_Click);
            // 
            // pbFour
            // 
            this.pbFour.Image = ((System.Drawing.Image)(resources.GetObject("pbFour.Image")));
            this.pbFour.Location = new System.Drawing.Point(285, 0);
            this.pbFour.Name = "pbFour";
            this.pbFour.Size = new System.Drawing.Size(16, 16);
            this.pbFour.TabIndex = 6;
            this.pbFour.TabStop = false;
            this.toolTip.SetToolTip(this.pbFour, "New York");
            // 
            // pbThree
            // 
            this.pbThree.Image = ((System.Drawing.Image)(resources.GetObject("pbThree.Image")));
            this.pbThree.Location = new System.Drawing.Point(172, 0);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(16, 16);
            this.pbThree.TabIndex = 7;
            this.pbThree.TabStop = false;
            this.toolTip.SetToolTip(this.pbThree, "London");
            // 
            // pbTwo
            // 
            this.pbTwo.Image = ((System.Drawing.Image)(resources.GetObject("pbTwo.Image")));
            this.pbTwo.Location = new System.Drawing.Point(85, 0);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(16, 16);
            this.pbTwo.TabIndex = 8;
            this.pbTwo.TabStop = false;
            this.toolTip.SetToolTip(this.pbTwo, "Delhi");
            // 
            // pbOne
            // 
            this.pbOne.Image = ((System.Drawing.Image)(resources.GetObject("pbOne.Image")));
            this.pbOne.Location = new System.Drawing.Point(4, 0);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(16, 16);
            this.pbOne.TabIndex = 9;
            this.pbOne.TabStop = false;
            this.toolTip.SetToolTip(this.pbOne, "Hong Kong");
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(372, 16);
            this.Controls.Add(this.pbOne);
            this.Controls.Add(this.pbTwo);
            this.Controls.Add(this.pbThree);
            this.Controls.Add(this.pbFour);
            this.Controls.Add(this.lblMeetingPlanner);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "TitleBarClock";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMeetingPlanner;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pbFour;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.Timer tmrTick;
    }
}

