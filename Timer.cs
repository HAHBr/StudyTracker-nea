using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //import database


namespace StudyTracker
{
    public partial class Timer : Form
    {
        bool isPaused = false;
        int timeElapsed = 0;
        int points = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void studyTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            int minutes = timeElapsed / 60;
            int seconds = timeElapsed % 60;
            lblTime.Text = $"{minutes} minutes {seconds:D2} seconds studied";

            if (timeElapsed % 1800 == 0) //reward every 30 minutes
            {
                points += 10;
                pointsDisplay.Text = $"Points: {points}";
                lblStatus.Text = $"You've earned {points} points";

            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                studyTimer.Start();
                isPaused = false;
            }
            else
            {
                studyTimer.Stop();
                pauseBtn.Text = "resume";
                isPaused = true;
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            studyTimer.Start();
            //start the timer
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void pointsDisplay_Click(object sender, EventArgs e)
        {
          
        }


    }
}
