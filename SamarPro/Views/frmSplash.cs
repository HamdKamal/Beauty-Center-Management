using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace SamarPro.Views
{
    public partial class frmSplash : SplashScreen
    {   
        void ring()
        {
            Label3.Visible = true;
            if (ProgressBar1.Visible == false)
            {
                frmLogin frm = new frmLogin();
                Timer1.Stop();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                tr.Show_Message("Activaition Project Is Faild... !");
            }
        }
        public frmSplash()
        {
            InitializeComponent();
            //Timer1.Start();
        }
        #region Overrides
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        SamarPro.TransationModule tr = new SamarPro.TransationModule();

        private void frmSplash_Load(object sender, EventArgs e)
        {
            ProgressBar1.BackColor = Color.DarkGreen;
            Panel1.Location = new Point(this.ClientSize.Width / 2 - Panel1.Size.Width / 2, this.ClientSize.Height / 2 - Panel1.Size.Height / 2);
            Panel1.Anchor = AnchorStyles.None;
            this.BackColor = Color.DodgerBlue;
        }
       
        private void Timer1_Tick(object sender, EventArgs e)
        {
           ring();
        }

    }
}

