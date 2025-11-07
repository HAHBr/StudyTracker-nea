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
            this.SuspendLayout();
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(368, 35);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(102, 96);
            this.pauseBtn.TabIndex = 0;
            this.pauseBtn.Text = "pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
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
            this.progressBarToReward.Location = new System.Drawing.Point(322, 366);
            this.progressBarToReward.Name = "progressBarToReward";
            this.progressBarToReward.Size = new System.Drawing.Size(193, 41);
            this.progressBarToReward.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(329, 410);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 20);
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
            this.pointsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsDisplay.Location = new System.Drawing.Point(88, 52);
            this.pointsDisplay.Name = "pointsDisplay";
            this.pointsDisplay.Size = new System.Drawing.Size(155, 24);
            this.pointsDisplay.TabIndex = 5;
            this.pointsDisplay.Text = "Keep studying!!";
            this.pointsDisplay.Click += new System.EventHandler(this.pointsDisplay_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(849, 501);
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
    }
}