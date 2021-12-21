using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Threading;

namespace SamarPro.Views
{
    public partial class Message_Notifi : Form
    {
        public Message_Notifi()
        {
            InitializeComponent();
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Message_Notifi_Load(object sender, EventArgs e)
        {           
            
                Sound();               
        }       
        public void Sound()
        {
            SoundPlayer notif = new SoundPlayer(Properties.Resources.notification);
            notif.Play();
        }       
    }
}
