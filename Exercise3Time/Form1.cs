using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3Time
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Date.ToString("dddd, MMMM, yyyy");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;

            if (hours == 15 && minutes == 30 && seconds == 00)
            {
                MessageBox.Show("It's exactly home time!", "Exact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (hours > 15 && minutes > 30)
            {
                MessageBox.Show("It's time to go home.", "Late", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(hours < 15)
            {
                MessageBox.Show("It's not home time yet.", "Early", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time: " + DateTime.Now.ToString("h:mm:ss tt");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Author: Stefan Reesberg \n Created: 19 October 2022", "Application Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
