using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bryce_Locker
{
    public partial class Form1 : Form
        {
        int timeLeft = 7200;
        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }
        private void BryceLockTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
                {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                }
            else
                {
                // If the user ran out of time, stop the timer, show
                // a MessageBox.
                BryceLockTimer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time, your files will be deleted shortly, sorry!");
                }
        }

        private void timeLabel_Click(object sender, EventArgs e)
            {

            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Q5m5rpNDNCA");
            }
            }
        }

