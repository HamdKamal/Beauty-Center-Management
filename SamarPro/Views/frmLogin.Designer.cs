namespace SamarPro.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BT_OK = new System.Windows.Forms.Button();
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.BT_OK);
            this.bunifuGradientPanel1.Controls.Add(this.txt_type);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.txt_name);
            this.bunifuGradientPanel1.Controls.Add(this.txt_pass);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(13, 257);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(407, 327);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // BT_OK
            // 
            this.BT_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_OK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_OK.FlatAppearance.BorderSize = 0;
            this.BT_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BT_OK.ForeColor = System.Drawing.Color.Black;
            this.BT_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_OK.Location = new System.Drawing.Point(3, 288);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BT_OK.Size = new System.Drawing.Size(399, 33);
            this.BT_OK.TabIndex = 60;
            this.BT_OK.Text = "تسجيل الدخول ";
            this.BT_OK.UseVisualStyleBackColor = false;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // txt_type
            // 
            this.txt_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_type.BackColor = System.Drawing.Color.White;
            this.txt_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txt_type.Location = new System.Drawing.Point(25, 75);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(351, 21);
            this.txt_type.TabIndex = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(139, 8);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(115, 25);
            this.bunifuCustomLabel4.TabIndex = 59;
            this.bunifuCustomLabel4.Text = "تسجيل الدخول";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(299, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(81, 19);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "نوع المستخدم";
            // 
            // txt_name
            // 
            this.txt_name.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.txt_name.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txt_name.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txt_name.BorderThickness = 2;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.isPassword = false;
            this.txt_name.Location = new System.Drawing.Point(25, 138);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(351, 26);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox2_OnValueChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.txt_pass.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txt_pass.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txt_pass.BorderThickness = 2;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.isPassword = true;
            this.txt_pass.Location = new System.Drawing.Point(25, 210);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(351, 27);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(303, 187);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(73, 19);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "كلمة المرور";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(298, 115);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 19);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "إسم المستخدم";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(192, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "&Copyrights © 2020. All rights Reserved By Aim Tech";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = " Emp_Name";
            columnExpression1.ColumnName = "Name";
            table1.Name = "TBLempoyees";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.FilterString = "[TBLusers.Name] = ?U_Name";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "TBLempoyees";
            queryParameter1.Name = "U_Name";
            queryParameter1.Type = typeof(string);
            selectQuery1.Parameters.Add(queryParameter1);
            relationColumnInfo1.NestedKeyColumn = "Em_ID";
            relationColumnInfo1.ParentKeyColumn = "ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            table2.Name = "TBLusers";
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlRCTGVtcG95ZWVzIj48Rmllb" +
    "GQgTmFtZT0iIEVtcF9OYW1lIiBUeXBlPSJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-23, -2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(742, 205);
            this.bunifuGradientPanel2.TabIndex = 63;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton2.Enabled = false;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(420, 34);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(157, 139);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 62;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = global::SamarPro.Properties.Resources.pictureBox2_Image;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = global::SamarPro.Properties.Resources.pictureBox2_Image;
            this.bunifuImageButton1.Location = new System.Drawing.Point(292, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 61;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.label7);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(-156, 594);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(742, 63);
            this.bunifuGradientPanel3.TabIndex = 64;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 617);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public System.Windows.Forms.ComboBox txt_type;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Button BT_OK;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
    }
}