namespace SamarPro.Views
{
    partial class frmSplash
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
            this.txtActivationID = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1.Properties)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActivationID
            // 
            this.txtActivationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivationID.Location = new System.Drawing.Point(961, 364);
            this.txtActivationID.Name = "txtActivationID";
            this.txtActivationID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtActivationID.Size = new System.Drawing.Size(10, 22);
            this.txtActivationID.TabIndex = 14;
            this.txtActivationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtActivationID.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.ProgressBar1);
            this.panel2.Controls.Add(this.Panel1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1373, 770);
            this.panel2.TabIndex = 18;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.EditValue = 0;
            this.ProgressBar1.Location = new System.Drawing.Point(-23, 753);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProgressBar1.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProgressBar1.Properties.LookAndFeel.SkinName = "Metropolis";
            this.ProgressBar1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.ProgressBar1.Properties.ReadOnly = true;
            this.ProgressBar1.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar1.Size = new System.Drawing.Size(1421, 17);
            this.ProgressBar1.TabIndex = 19;
            this.ProgressBar1.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(394, 210);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(518, 201);
            this.Panel1.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(19, 80);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(492, 45);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Beauty Center Management v.01";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(205, 162);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(116, 25);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Loading...";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtActivationID);
            this.Name = "frmSplash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1.Properties)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtActivationID;
        public System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel2;
        public DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBar1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
    }
}