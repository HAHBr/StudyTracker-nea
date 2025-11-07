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
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }

        private void inventoryOpen_Click(object sender, EventArgs e)
        {
            //open inventory form
            inventory inventory = new inventory();
            inventory.Show();
        }
    }
}
