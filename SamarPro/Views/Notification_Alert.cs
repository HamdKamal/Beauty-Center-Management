using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;

namespace SamarPro.Views
{
    public partial class Notification_Alert : Form
    {
        public Notification_Alert()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        string[] ScreenResolution = { Screen.PrimaryScreen.WorkingArea.Width.ToString(), Screen.PrimaryScreen.Bounds.Height.ToString() };

        private void Notification_Alert_Load(object sender, EventArgs e)
        {
         
            try
            {

                lbl__Notifidate.Text = DateTime.Now.ToShortTimeString().ToString();
                // Set location of notification
                this.SetDesktopLocation(Convert.ToInt32(ScreenResolution[0]) - this.Width, Convert.ToInt32(ScreenResolution[1]));

                animatetimer.Start();

                Sound();

                var StopThread = new Thread(Stop);
                StopThread.Start();
            }
            catch
            {
                return;
            }
        }

        public void Stop()
        {
            Thread.Sleep(6000);
            //Dispose();
        }

        public void Sound()
        {
            SoundPlayer notif = new SoundPlayer(Properties.Resources.notification);
            notif.Play();

        }

        public int go = 0;
        private void animatetimer_Tick_1(object sender, EventArgs e)
        {
          
            if (go < this.Height + 5)
            {
                this.SetDesktopLocation(Convert.ToInt32(ScreenResolution[0]) - this.Width, Convert.ToInt32(ScreenResolution[1]) - go);
            }

            go = go + 5;
            //animatetimer.Stop();
        }

        private void lbl_notification_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
