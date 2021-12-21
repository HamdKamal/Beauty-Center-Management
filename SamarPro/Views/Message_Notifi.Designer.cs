namespace SamarPro.Views
{
    partial class Message_Notifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message_Notifi));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_notification = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label_Res = new Bunifu.Framework.UI.BunifuImageButton();
            this.animatetimer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lbl_Name
            // 
            resources.ApplyResources(this.lbl_Name, "lbl_Name");
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.UseWaitCursor = true;
            // 
            // lbl_notification
            // 
            resources.ApplyResources(this.lbl_notification, "lbl_notification");
            this.lbl_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lbl_notification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_notification.ForeColor = System.Drawing.Color.Black;
            this.lbl_notification.Name = "lbl_notification";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("simpleButton1.Appearance.BackColor")));
            this.simpleButton1.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("simpleButton1.Appearance.BackColor2")));
            this.simpleButton1.Appearance.BorderColor = ((System.Drawing.Color)(resources.GetObject("simpleButton1.Appearance.BorderColor")));
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("simpleButton1.Appearance.ForeColor")));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.BackColor = ((System.Drawing.Color)(resources.GetObject("simpleButton1.AppearanceDisabled.BackColor")));
            this.simpleButton1.AppearanceDisabled.ForeColor = ((System.Drawing.Color)(resources.GetObject("simpleButton1.AppearanceDisabled.ForeColor")));
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseForeColor = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label_Res
            // 
            this.label_Res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            resources.ApplyResources(this.label_Res, "label_Res");
            this.label_Res.ImageActive = null;
            this.label_Res.Name = "label_Res";
            this.label_Res.TabStop = false;
            this.label_Res.Zoom = 10;
            // 
            // animatetimer
            // 
            this.animatetimer.Interval = 10;
            // 
            // Message_Notifi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.ControlBox = false;
            this.Controls.Add(this.lbl_notification);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label_Res);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbl_Name);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Message_Notifi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Message_Notifi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Label lbl_notification;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Bunifu.Framework.UI.BunifuImageButton label_Res;
        private System.Windows.Forms.Timer animatetimer;
    }
}