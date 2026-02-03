namespace StudyTracker
{
    partial class Timer
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
            this.pauseBtn = new System.Windows.Forms.Button();
            this.studyTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBarToReward = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pointsDisplay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.pauseBtn.Location = new System.Drawing.Point(692, 27);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(120, 44);
            this.pauseBtn.TabIndex = 0;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // studyTimer
            // 
            this.studyTimer.Interval = 1000;
            this.studyTimer.Tick += new System.EventHandler(this.studyTimer_Tick);
            // 
            // progressBarToReward
            // 
            this.progressBarToReward.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.progressBarToReward.ForeColor = System.Drawing.Color.LightSalmon;
            this.progressBarToReward.Location = new System.Drawing.Point(270, 330);
            this.progressBarToReward.Name = "progressBarToReward";
            this.progressBarToReward.Size = new System.Drawing.Size(309, 28);
            this.progressBarToReward.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(266, 372);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "  ";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(574, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 18);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = " ";
            // 
            // pointsDisplay
            // 
            this.pointsDisplay.AutoSize = true;
            this.pointsDisplay.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.pointsDisplay.Location = new System.Drawing.Point(36, 92);
            this.pointsDisplay.Name = "pointsDisplay";
            this.pointsDisplay.Size = new System.Drawing.Size(156, 25);
            this.pointsDisplay.TabIndex = 5;
            this.pointsDisplay.Text = "Keep studying!!";
            this.pointsDisplay.Click += new System.EventHandler(this.pointsDisplay_Click);
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProgressTitle.Location = new System.Drawing.Point(266, 304);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(150, 20);
            this.lblProgressTitle.TabIndex = 6;
            this.lblProgressTitle.Text = "Progress to reward";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(34, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 41);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Study Timer";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblProgressTitle);
            this.Controls.Add(this.pointsDisplay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.progressBarToReward);
            this.Controls.Add(this.pauseBtn);
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pauseBtn;
        public System.Windows.Forms.Timer studyTimer;
        private System.Windows.Forms.ProgressBar progressBarToReward;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label pointsDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Label lblHeader;
    }
}
