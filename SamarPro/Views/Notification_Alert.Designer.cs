namespace SamarPro.Views
{
    partial class Notification_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_Alert));
            this.animatetimer = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_notification = new System.Windows.Forms.Label();
            this.lbl__Notifidate = new System.Windows.Forms.Label();
            this.label_Res = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // animatetimer
            // 
            this.animatetimer.Interval = 10;
            this.animatetimer.Tick += new System.EventHandler(this.animatetimer_Tick_1);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(35, 3);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(109, 22);
            this.label12.TabIndex = 90;
            this.label12.Text = "...  إشعار جديد ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.UseWaitCursor = true;
            // 
            // lbl_notification
            // 
            this.lbl_notification.AutoSize = true;
            this.lbl_notification.BackColor = System.Drawing.Color.White;
            this.lbl_notification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_notification.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline);
            this.lbl_notification.ForeColor = System.Drawing.Color.Black;
            this.lbl_notification.Location = new System.Drawing.Point(26, 33);
            this.lbl_notification.Name = "lbl_notification";
            this.lbl_notification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_notification.Size = new System.Drawing.Size(92, 21);
            this.lbl_notification.TabIndex = 91;
            this.lbl_notification.Text = "! إشعار جديد ";
            this.lbl_notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_notification.Click += new System.EventHandler(this.lbl_notification_Click);
            // 
            // lbl__Notifidate
            // 
            this.lbl__Notifidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl__Notifidate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbl__Notifidate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl__Notifidate.Location = new System.Drawing.Point(390, 1);
            this.lbl__Notifidate.Name = "lbl__Notifidate";
            this.lbl__Notifidate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl__Notifidate.Size = new System.Drawing.Size(108, 23);
            this.lbl__Notifidate.TabIndex = 92;
            this.lbl__Notifidate.Text = "HH:MM:SS";
            this.lbl__Notifidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Res
            // 
            this.label_Res.BackColor = System.Drawing.Color.White;
            this.label_Res.Image = ((System.Drawing.Image)(resources.GetObject("label_Res.Image")));
            this.label_Res.ImageActive = null;
            this.label_Res.Location = new System.Drawing.Point(0, 1);
            this.label_Res.Name = "label_Res";
            this.label_Res.Size = new System.Drawing.Size(40, 24);
            this.label_Res.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label_Res.TabIndex = 21;
            this.label_Res.TabStop = false;
            this.label_Res.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(100)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(454, 31);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 92;
            this.label1.Text = "! إشعار جديد ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "! إشعار جديد ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 96;
            this.label3.Text = "! إشعار جديد ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Notification_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_notification);
            this.Controls.Add(this.lbl__Notifidate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_Res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification_Alert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification_Alert";
            this.Load += new System.EventHandler(this.Notification_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton label_Res;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl__Notifidate;
        public System.Windows.Forms.Label lbl_notification;
        private System.Windows.Forms.Timer animatetimer;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}