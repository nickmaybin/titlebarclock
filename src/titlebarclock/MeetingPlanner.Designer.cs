namespace TitleBarClock
{
    partial class MeetingPlanner
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvTimes = new System.Windows.Forms.DataGridView();
            this.hKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(455, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClose.Location = new System.Drawing.Point(363, -3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(12, 13);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvTimes
            // 
            this.dgvTimes.AllowUserToAddRows = false;
            this.dgvTimes.AllowUserToDeleteRows = false;
            this.dgvTimes.AllowUserToResizeColumns = false;
            this.dgvTimes.AllowUserToResizeRows = false;
            this.dgvTimes.AutoGenerateColumns = false;
            this.dgvTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hKDataGridViewTextBoxColumn,
            this.iNDataGridViewTextBoxColumn,
            this.lNDataGridViewTextBoxColumn,
            this.nYDataGridViewTextBoxColumn});
            this.dgvTimes.DataSource = this.meetingTimeBindingSource;
            this.dgvTimes.Location = new System.Drawing.Point(2, 13);
            this.dgvTimes.Name = "dgvTimes";
            this.dgvTimes.ReadOnly = true;
            this.dgvTimes.RowHeadersVisible = false;
            this.dgvTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimes.Size = new System.Drawing.Size(370, 213);
            this.dgvTimes.TabIndex = 6;
            // 
            // hKDataGridViewTextBoxColumn
            // 
            this.hKDataGridViewTextBoxColumn.DataPropertyName = "HK";
            this.hKDataGridViewTextBoxColumn.HeaderText = "HK";
            this.hKDataGridViewTextBoxColumn.Name = "hKDataGridViewTextBoxColumn";
            this.hKDataGridViewTextBoxColumn.ReadOnly = true;
            this.hKDataGridViewTextBoxColumn.Width = 90;
            // 
            // iNDataGridViewTextBoxColumn
            // 
            this.iNDataGridViewTextBoxColumn.DataPropertyName = "IN";
            this.iNDataGridViewTextBoxColumn.HeaderText = "IN";
            this.iNDataGridViewTextBoxColumn.Name = "iNDataGridViewTextBoxColumn";
            this.iNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNDataGridViewTextBoxColumn.Width = 90;
            // 
            // lNDataGridViewTextBoxColumn
            // 
            this.lNDataGridViewTextBoxColumn.DataPropertyName = "LN";
            this.lNDataGridViewTextBoxColumn.HeaderText = "LN";
            this.lNDataGridViewTextBoxColumn.Name = "lNDataGridViewTextBoxColumn";
            this.lNDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNDataGridViewTextBoxColumn.Width = 90;
            // 
            // nYDataGridViewTextBoxColumn
            // 
            this.nYDataGridViewTextBoxColumn.DataPropertyName = "NY";
            this.nYDataGridViewTextBoxColumn.HeaderText = "NY";
            this.nYDataGridViewTextBoxColumn.Name = "nYDataGridViewTextBoxColumn";
            this.nYDataGridViewTextBoxColumn.ReadOnly = true;
            this.nYDataGridViewTextBoxColumn.Width = 90;
            // 
            // meetingTimeBindingSource
            // 
            this.meetingTimeBindingSource.DataSource = typeof(TitleBarClock.MeetingTime);
            // 
            // MeetingPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(372, 227);
            this.Controls.Add(this.dgvTimes);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingPlanner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MeetingPlanner";
            this.Load += new System.EventHandler(this.MeetingPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgvTimes;
        private System.Windows.Forms.BindingSource meetingTimeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nYDataGridViewTextBoxColumn;
    }
}