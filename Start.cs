using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTracker
{
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            //open timer form
            Timer Timer = new Timer();
            Timer.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            //open shop form
            shop shop = new shop();
            shop.Show();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void petName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
