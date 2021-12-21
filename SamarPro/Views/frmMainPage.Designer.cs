namespace SamarPro.Views
{
    partial class frmMainPage
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery20 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column58 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression77 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table39 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column59 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression78 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column60 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression79 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table40 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Group group20 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression80 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join20 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo20 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl__date = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_watch = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.L_PRD = new System.Windows.Forms.Label();
            this.L_RES = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_SHOW = new Bunifu.Framework.UI.BunifuImageButton();
            this.L_SHOW = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Product = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_Res = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_Mtype = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_Pos = new DevExpress.XtraNavBar.NavBarItem();
            this.Nav_RentPos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_Reservation = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_PaymentRes = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_EmpAdd = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_EmpManage = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_EmpPayRoll = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_AddBank = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Expenses = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup7 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_Products = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Supplaier = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup8 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem15 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem16 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem17 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup9 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_Rent = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Service = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Gategory = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Show = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Logs = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup10 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_UserManage = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Permistion = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup11 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_DataBase = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Project = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_Devlopers = new DevExpress.XtraNavBar.NavBarItem();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer2 = new System.Windows.Forms.Timer();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.posProductsBindingSource = new System.Windows.Forms.BindingSource();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.timer3 = new System.Windows.Forms.Timer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem18 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem19 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem20 = new DevExpress.XtraNavBar.NavBarItem();
            label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label_SHOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posProductsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(36, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 17);
            label3.TabIndex = 43;
            label3.Text = "الخرطوم - كبري المنشية ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel4.Controls.Add(this.lbl__date);
            this.panel4.Controls.Add(this.lbl_type);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(182, 738);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1204, 54);
            this.panel4.TabIndex = 38;
            // 
            // lbl__date
            // 
            this.lbl__date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl__date.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbl__date.ForeColor = System.Drawing.Color.Black;
            this.lbl__date.Location = new System.Drawing.Point(551, 3);
            this.lbl__date.Name = "lbl__date";
            this.lbl__date.Size = new System.Drawing.Size(251, 26);
            this.lbl__date.TabIndex = 8;
            this.lbl__date.Text = "HH:MM:SS";
            this.lbl__date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_type
            // 
            this.lbl_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_type.Location = new System.Drawing.Point(23, 7);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(82, 22);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "مدير النظام ";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(97, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "نوع المستخدم : ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(142, 745);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "مرحباً :";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(-127, 745);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(265, 22);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "***";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel3.Controls.Add(this.label_watch);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(182, -2);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(1225, 75);
            this.panel3.TabIndex = 39;
            // 
            // label_watch
            // 
            this.label_watch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_watch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_watch.ForeColor = System.Drawing.Color.Black;
            this.label_watch.Location = new System.Drawing.Point(17, 48);
            this.label_watch.Name = "label_watch";
            this.label_watch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_watch.Size = new System.Drawing.Size(108, 19);
            this.label_watch.TabIndex = 9;
            this.label_watch.Text = "HH:MM:SS";
            this.label_watch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.L_PRD);
            this.panel5.Controls.Add(this.L_RES);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label_SHOW);
            this.panel5.Controls.Add(this.L_SHOW);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label_Product);
            this.panel5.Controls.Add(this.label_Res);
            this.panel5.Controls.Add(this.bunifuImageButton3);
            this.panel5.Controls.Add(this.bunifuImageButton1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(-6, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1264, 40);
            this.panel5.TabIndex = 44;
            // 
            // L_PRD
            // 
            this.L_PRD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_PRD.AutoSize = true;
            this.L_PRD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.L_PRD.ForeColor = System.Drawing.Color.White;
            this.L_PRD.Location = new System.Drawing.Point(131, 2);
            this.L_PRD.Name = "L_PRD";
            this.L_PRD.Size = new System.Drawing.Size(13, 13);
            this.L_PRD.TabIndex = 58;
            this.L_PRD.Text = "0";
            // 
            // L_RES
            // 
            this.L_RES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_RES.AutoSize = true;
            this.L_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.L_RES.ForeColor = System.Drawing.Color.White;
            this.L_RES.Location = new System.Drawing.Point(163, 2);
            this.L_RES.Name = "L_RES";
            this.L_RES.Size = new System.Drawing.Size(13, 13);
            this.L_RES.TabIndex = 57;
            this.L_RES.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(755, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "0";
            // 
            // label_SHOW
            // 
            this.label_SHOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.label_SHOW.Image = global::SamarPro.Properties.Resources.toolStripMenuItem15_Image;
            this.label_SHOW.ImageActive = null;
            this.label_SHOW.Location = new System.Drawing.Point(174, 10);
            this.label_SHOW.Name = "label_SHOW";
            this.label_SHOW.Size = new System.Drawing.Size(36, 26);
            this.label_SHOW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label_SHOW.TabIndex = 22;
            this.label_SHOW.TabStop = false;
            this.label_SHOW.Zoom = 10;
            this.label_SHOW.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // L_SHOW
            // 
            this.L_SHOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_SHOW.AutoSize = true;
            this.L_SHOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.L_SHOW.ForeColor = System.Drawing.Color.White;
            this.L_SHOW.Location = new System.Drawing.Point(208, 3);
            this.L_SHOW.Name = "L_SHOW";
            this.L_SHOW.Size = new System.Drawing.Size(13, 13);
            this.L_SHOW.TabIndex = 54;
            this.L_SHOW.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(685, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "0";
            // 
            // label_Product
            // 
            this.label_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.label_Product.Image = global::SamarPro.Properties.Resources.btnSale_Image;
            this.label_Product.ImageActive = null;
            this.label_Product.Location = new System.Drawing.Point(111, 10);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(29, 26);
            this.label_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label_Product.TabIndex = 21;
            this.label_Product.TabStop = false;
            this.label_Product.Zoom = 10;
            this.label_Product.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // label_Res
            // 
            this.label_Res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.label_Res.Image = ((System.Drawing.Image)(resources.GetObject("label_Res.Image")));
            this.label_Res.ImageActive = null;
            this.label_Res.Location = new System.Drawing.Point(144, 10);
            this.label_Res.Name = "label_Res";
            this.label_Res.Size = new System.Drawing.Size(29, 26);
            this.label_Res.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label_Res.TabIndex = 20;
            this.label_Res.TabStop = false;
            this.label_Res.Zoom = 10;
            this.label_Res.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(77, 6);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(29, 31);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Tag = "حضور الموظفين";
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(42, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beauty Center Management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bnt_Mtype);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(-18, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(224, 795);
            this.panel1.TabIndex = 40;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(127, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 61;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // bnt_Mtype
            // 
            this.bnt_Mtype.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bnt_Mtype.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bnt_Mtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bnt_Mtype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_Mtype.BorderRadius = 7;
            this.bnt_Mtype.ButtonText = "Admin";
            this.bnt_Mtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Mtype.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bnt_Mtype.Enabled = false;
            this.bnt_Mtype.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.bnt_Mtype.ForeColor = System.Drawing.Color.White;
            this.bnt_Mtype.Iconcolor = System.Drawing.Color.Transparent;
            this.bnt_Mtype.Iconimage = null;
            this.bnt_Mtype.Iconimage_right = null;
            this.bnt_Mtype.Iconimage_right_Selected = null;
            this.bnt_Mtype.Iconimage_Selected = null;
            this.bnt_Mtype.IconMarginLeft = 0;
            this.bnt_Mtype.IconMarginRight = 0;
            this.bnt_Mtype.IconRightVisible = true;
            this.bnt_Mtype.IconRightZoom = 0D;
            this.bnt_Mtype.IconVisible = true;
            this.bnt_Mtype.IconZoom = 70D;
            this.bnt_Mtype.IsTab = false;
            this.bnt_Mtype.Location = new System.Drawing.Point(65, 190);
            this.bnt_Mtype.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bnt_Mtype.Name = "bnt_Mtype";
            this.bnt_Mtype.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bnt_Mtype.OnHovercolor = System.Drawing.Color.Cornsilk;
            this.bnt_Mtype.OnHoverTextColor = System.Drawing.Color.BlanchedAlmond;
            this.bnt_Mtype.selected = false;
            this.bnt_Mtype.Size = new System.Drawing.Size(75, 26);
            this.bnt_Mtype.TabIndex = 60;
            this.bnt_Mtype.Text = "Admin";
            this.bnt_Mtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnt_Mtype.Textcolor = System.Drawing.Color.White;
            this.bnt_Mtype.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "لمسة حنين بيوتي سنتر";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton4.Enabled = false;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(43, 43);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(112, 97);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 42;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(162, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 38);
            this.button8.TabIndex = 41;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Background.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Background.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Background.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.Background.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Appearance.Background.Options.UseBorderColor = true;
            this.navBarControl1.Appearance.Background.Options.UseFont = true;
            this.navBarControl1.Appearance.Background.Options.UseForeColor = true;
            this.navBarControl1.Appearance.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Button.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.Button.BorderColor = System.Drawing.Color.White;
            this.navBarControl1.Appearance.Button.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.Button.Options.UseBackColor = true;
            this.navBarControl1.Appearance.Button.Options.UseBorderColor = true;
            this.navBarControl1.Appearance.Button.Options.UseFont = true;
            this.navBarControl1.Appearance.ButtonPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.ButtonPressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.ButtonPressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.ButtonPressed.Options.UseBackColor = true;
            this.navBarControl1.Appearance.ButtonPressed.Options.UseBorderColor = true;
            this.navBarControl1.Appearance.GroupBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupBackground.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupBackground.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupBackground.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupBackground.Options.UseBorderColor = true;
            this.navBarControl1.Appearance.GroupBackground.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupHeader.Options.UseBorderColor = true;
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.ItemPressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.ItemPressed.Options.UseBackColor = true;
            this.navBarControl1.Appearance.NavigationPaneHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.NavigationPaneHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.NavigationPaneHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseBackColor = true;
            this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseBorderColor = true;
            this.navBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup5,
            this.navBarGroup6,
            this.navBarGroup7,
            this.navBarGroup8,
            this.navBarGroup9,
            this.navBarGroup10,
            this.navBarGroup11});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nav_Pos,
            this.Nav_RentPos,
            this.nav_Products,
            this.nav_Supplaier,
            this.nav_EmpAdd,
            this.nav_EmpManage,
            this.nav_EmpPayRoll,
            this.nav_UserManage,
            this.nav_Permistion,
            this.nav_Reservation,
            this.nav_PaymentRes,
            this.navBarItem13,
            this.navBarItem14,
            this.navBarItem15,
            this.navBarItem16,
            this.navBarItem17,
            this.nav_DataBase,
            this.nav_Project,
            this.nav_Devlopers,
            this.nav_Rent,
            this.nav_Service,
            this.nav_Gategory,
            this.nav_Show,
            this.nav_Logs,
            this.nav_AddBank,
            this.nav_Expenses,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem18,
            this.navBarItem19,
            this.navBarItem20});
            this.navBarControl1.Location = new System.Drawing.Point(2, 229);
            this.navBarControl1.LookAndFeel.SkinName = "Blueprint";
            this.navBarControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl1.Size = new System.Drawing.Size(204, 509);
            this.navBarControl1.TabIndex = 53;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Sharp Plus");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.Appearance.Options.UseBackColor = true;
            this.navBarGroup1.Appearance.Options.UseBorderColor = true;
            this.navBarGroup1.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearanceBackground.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearanceBackground.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearanceBackground.Options.UseBackColor = true;
            this.navBarGroup1.AppearanceBackground.Options.UseBorderColor = true;
            this.navBarGroup1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup1.AppearancePressed.Options.UseBackColor = true;
            this.navBarGroup1.AppearancePressed.Options.UseBorderColor = true;
            this.navBarGroup1.Caption = "الرئيسية";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.ItemChanged += new System.EventHandler(this.btnDashboard_Click);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup2.Appearance.Options.UseBackColor = true;
            this.navBarGroup2.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup2.AppearanceBackground.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.navBarGroup2.AppearanceBackground.Options.UseBackColor = true;
            this.navBarGroup2.Caption = "المبيعات";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Pos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Nav_RentPos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // nav_Pos
            // 
            this.nav_Pos.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Pos.Appearance.Options.UseFont = true;
            this.nav_Pos.Caption = "نافذة البيع";
            this.nav_Pos.Name = "nav_Pos";
            this.nav_Pos.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Pos.SmallImage")));
            this.nav_Pos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Pos_LinkClicked);
            // 
            // Nav_RentPos
            // 
            this.Nav_RentPos.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Nav_RentPos.Appearance.Options.UseFont = true;
            this.Nav_RentPos.Caption = "فواتير الإيجار";
            this.Nav_RentPos.Name = "Nav_RentPos";
            this.Nav_RentPos.SmallImage = ((System.Drawing.Image)(resources.GetObject("Nav_RentPos.SmallImage")));
            this.Nav_RentPos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Nav_RentPos_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem1.Appearance.Options.UseFont = true;
            this.navBarItem1.Caption = "فواتير العروض";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "الحجوزات";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Reservation),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_PaymentRes)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.SmallImage")));
            // 
            // nav_Reservation
            // 
            this.nav_Reservation.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Reservation.Appearance.Options.UseFont = true;
            this.nav_Reservation.Caption = "إضافة حجز";
            this.nav_Reservation.Name = "nav_Reservation";
            this.nav_Reservation.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Reservation.SmallImage")));
            this.nav_Reservation.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Reservation_LinkClicked);
            // 
            // nav_PaymentRes
            // 
            this.nav_PaymentRes.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_PaymentRes.Appearance.Options.UseFont = true;
            this.nav_PaymentRes.Caption = "دفعات الحجوزات";
            this.nav_PaymentRes.Name = "nav_PaymentRes";
            this.nav_PaymentRes.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_PaymentRes.SmallImage")));
            this.nav_PaymentRes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_PaymentRes_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "شؤون الموظفين";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_EmpAdd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_EmpManage),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_EmpPayRoll),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.SmallImage")));
            // 
            // nav_EmpAdd
            // 
            this.nav_EmpAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_EmpAdd.Appearance.Options.UseFont = true;
            this.nav_EmpAdd.Caption = "إضافة موظف";
            this.nav_EmpAdd.Name = "nav_EmpAdd";
            this.nav_EmpAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_EmpAdd.SmallImage")));
            this.nav_EmpAdd.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_EmpAdd_LinkClicked);
            // 
            // nav_EmpManage
            // 
            this.nav_EmpManage.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_EmpManage.Appearance.Options.UseFont = true;
            this.nav_EmpManage.Caption = "إدارة الموظفين";
            this.nav_EmpManage.Name = "nav_EmpManage";
            this.nav_EmpManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_EmpManage.SmallImage")));
            this.nav_EmpManage.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_EmpManage_LinkClicked);
            // 
            // nav_EmpPayRoll
            // 
            this.nav_EmpPayRoll.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_EmpPayRoll.Appearance.Options.UseFont = true;
            this.nav_EmpPayRoll.Caption = "رواتب الموظفين";
            this.nav_EmpPayRoll.Name = "nav_EmpPayRoll";
            this.nav_EmpPayRoll.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_EmpPayRoll.SmallImage")));
            this.nav_EmpPayRoll.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_EmpPayRoll_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem5.Appearance.Options.UseFont = true;
            this.navBarItem5.Caption = "التعهدات";
            this.navBarItem5.LargeImage = global::SamarPro.Properties.Resources.button2_Image;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = global::SamarPro.Properties.Resources.button2_Image;
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Caption = "الكورسات";
            this.navBarGroup6.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_AddBank),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Expenses)});
            this.navBarGroup6.Name = "navBarGroup6";
            this.navBarGroup6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup6.SmallImage")));
            // 
            // nav_AddBank
            // 
            this.nav_AddBank.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_AddBank.Appearance.Options.UseFont = true;
            this.nav_AddBank.Caption = "إضافة كورس ";
            this.nav_AddBank.Name = "nav_AddBank";
            this.nav_AddBank.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_AddBank.SmallImage")));
            this.nav_AddBank.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_AddBank_LinkClicked);
            // 
            // nav_Expenses
            // 
            this.nav_Expenses.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Expenses.Appearance.Options.UseFont = true;
            this.nav_Expenses.Caption = "تسجيل للكورس";
            this.nav_Expenses.Name = "nav_Expenses";
            this.nav_Expenses.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Expenses.SmallImage")));
            this.nav_Expenses.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Expenses_LinkClicked);
            // 
            // navBarGroup7
            // 
            this.navBarGroup7.Caption = "المخزن";
            this.navBarGroup7.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Products),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Supplaier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup7.Name = "navBarGroup7";
            this.navBarGroup7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup7.SmallImage")));
            // 
            // nav_Products
            // 
            this.nav_Products.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Products.Appearance.Options.UseFont = true;
            this.nav_Products.Caption = "إدارة المحزن";
            this.nav_Products.Name = "nav_Products";
            this.nav_Products.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Products.SmallImage")));
            this.nav_Products.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Products_LinkClicked);
            // 
            // nav_Supplaier
            // 
            this.nav_Supplaier.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Supplaier.Appearance.Options.UseFont = true;
            this.nav_Supplaier.Caption = "إضافة مسوقين";
            this.nav_Supplaier.Name = "nav_Supplaier";
            this.nav_Supplaier.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Supplaier.SmallImage")));
            this.nav_Supplaier.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Supplaier_LinkClicked);
            // 
            // navBarGroup8
            // 
            this.navBarGroup8.Caption = "التقارير";
            this.navBarGroup8.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem15),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem16),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem17),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem18),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem19),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem20)});
            this.navBarGroup8.Name = "navBarGroup8";
            this.navBarGroup8.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup8.SmallImage")));
            // 
            // navBarItem13
            // 
            this.navBarItem13.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem13.Appearance.Options.UseFont = true;
            this.navBarItem13.Caption = "تقرير المبيعات";
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem13.SmallImage")));
            this.navBarItem13.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem13_LinkClicked);
            // 
            // navBarItem14
            // 
            this.navBarItem14.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem14.Appearance.Options.UseFont = true;
            this.navBarItem14.Caption = "التقرير العام";
            this.navBarItem14.Name = "navBarItem14";
            this.navBarItem14.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem14.SmallImage")));
            this.navBarItem14.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem14_LinkClicked);
            // 
            // navBarItem15
            // 
            this.navBarItem15.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem15.Appearance.Options.UseFont = true;
            this.navBarItem15.Caption = "التقرير اليومي";
            this.navBarItem15.Name = "navBarItem15";
            this.navBarItem15.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem15.SmallImage")));
            this.navBarItem15.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem15_LinkClicked);
            // 
            // navBarItem16
            // 
            this.navBarItem16.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem16.Appearance.Options.UseFont = true;
            this.navBarItem16.Caption = "تقرير المصروفات";
            this.navBarItem16.Name = "navBarItem16";
            this.navBarItem16.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem16.SmallImage")));
            this.navBarItem16.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem16_LinkClicked);
            // 
            // navBarItem17
            // 
            this.navBarItem17.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem17.Appearance.Options.UseFont = true;
            this.navBarItem17.Caption = "تقرير المخزن";
            this.navBarItem17.Name = "navBarItem17";
            this.navBarItem17.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem17.SmallImage")));
            this.navBarItem17.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem17_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem2.Appearance.Options.UseFont = true;
            this.navBarItem2.Caption = "تقرير الصلاحية";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.SmallImage")));
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem3.Appearance.Options.UseFont = true;
            this.navBarItem3.Caption = "تقرير دفعات الحجز";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.SmallImage")));
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem4.Appearance.Options.UseFont = true;
            this.navBarItem4.Caption = "تقرير الرواتب ";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup9
            // 
            this.navBarGroup9.Caption = "إدارة النظام";
            this.navBarGroup9.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Rent),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Service),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Gategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Show),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Logs)});
            this.navBarGroup9.Name = "navBarGroup9";
            this.navBarGroup9.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup9.SmallImage")));
            // 
            // nav_Rent
            // 
            this.nav_Rent.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Rent.Appearance.Options.UseFont = true;
            this.nav_Rent.Caption = "إضافة إيجار";
            this.nav_Rent.Name = "nav_Rent";
            this.nav_Rent.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Rent.SmallImage")));
            this.nav_Rent.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Rent_LinkClicked);
            // 
            // nav_Service
            // 
            this.nav_Service.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Service.Appearance.Options.UseFont = true;
            this.nav_Service.Caption = "إضافة خدمة";
            this.nav_Service.Name = "nav_Service";
            this.nav_Service.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Service.SmallImage")));
            this.nav_Service.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Service_LinkClicked);
            // 
            // nav_Gategory
            // 
            this.nav_Gategory.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Gategory.Appearance.Options.UseFont = true;
            this.nav_Gategory.Caption = "إضافة فئات";
            this.nav_Gategory.Name = "nav_Gategory";
            this.nav_Gategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Gategory.SmallImage")));
            this.nav_Gategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Gategory_LinkClicked);
            // 
            // nav_Show
            // 
            this.nav_Show.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Show.Appearance.Options.UseFont = true;
            this.nav_Show.Caption = "إضافة عرض";
            this.nav_Show.Name = "nav_Show";
            this.nav_Show.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Show.SmallImage")));
            this.nav_Show.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Show_LinkClicked);
            // 
            // nav_Logs
            // 
            this.nav_Logs.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Logs.Appearance.Options.UseFont = true;
            this.nav_Logs.Caption = "سجلات النظام";
            this.nav_Logs.Name = "nav_Logs";
            this.nav_Logs.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Logs.SmallImage")));
            this.nav_Logs.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Logs_LinkClicked);
            // 
            // navBarGroup10
            // 
            this.navBarGroup10.Caption = "إدارة المستخدمين";
            this.navBarGroup10.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_UserManage),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Permistion)});
            this.navBarGroup10.Name = "navBarGroup10";
            this.navBarGroup10.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup10.SmallImage")));
            // 
            // nav_UserManage
            // 
            this.nav_UserManage.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_UserManage.Appearance.Options.UseFont = true;
            this.nav_UserManage.Caption = "إدارة  االمستخدمين";
            this.nav_UserManage.Name = "nav_UserManage";
            this.nav_UserManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_UserManage.SmallImage")));
            this.nav_UserManage.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_UserManage_LinkClicked);
            // 
            // nav_Permistion
            // 
            this.nav_Permistion.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Permistion.Appearance.Options.UseFont = true;
            this.nav_Permistion.Caption = "إدارة الصلاحيات";
            this.nav_Permistion.Name = "nav_Permistion";
            this.nav_Permistion.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Permistion.SmallImage")));
            this.nav_Permistion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Permistion_LinkClicked);
            // 
            // navBarGroup11
            // 
            this.navBarGroup11.Caption = "الإعدادات";
            this.navBarGroup11.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_DataBase),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Project),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_Devlopers)});
            this.navBarGroup11.Name = "navBarGroup11";
            this.navBarGroup11.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup11.SmallImage")));
            // 
            // nav_DataBase
            // 
            this.nav_DataBase.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_DataBase.Appearance.Options.UseFont = true;
            this.nav_DataBase.Caption = "إدارة قاعدة البيانات";
            this.nav_DataBase.Name = "nav_DataBase";
            this.nav_DataBase.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_DataBase.SmallImage")));
            this.nav_DataBase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_DataBase_LinkClicked);
            // 
            // nav_Project
            // 
            this.nav_Project.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Project.Appearance.Options.UseFont = true;
            this.nav_Project.Caption = "عن البرنامج";
            this.nav_Project.Name = "nav_Project";
            this.nav_Project.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Project.SmallImage")));
            this.nav_Project.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Project_LinkClicked);
            // 
            // nav_Devlopers
            // 
            this.nav_Devlopers.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.nav_Devlopers.Appearance.Options.UseFont = true;
            this.nav_Devlopers.Caption = "حول المبرمج";
            this.nav_Devlopers.Name = "nav_Devlopers";
            this.nav_Devlopers.SmallImage = ((System.Drawing.Image)(resources.GetObject("nav_Devlopers.SmallImage")));
            this.nav_Devlopers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_Devlopers_LinkClicked);
            // 
            // lbl_sales
            // 
            this.lbl_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sales.BackColor = System.Drawing.Color.Teal;
            this.lbl_sales.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_sales.ForeColor = System.Drawing.Color.Black;
            this.lbl_sales.Location = new System.Drawing.Point(1140, 138);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(63, 22);
            this.lbl_sales.TabIndex = 90;
            this.lbl_sales.Text = "25.000";
            this.lbl_sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1077, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 88;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1006, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "تقرير المشتريات";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(782, 127);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(290, 128);
            this.bunifuFlatButton2.TabIndex = 86;
            this.bunifuFlatButton2.Text = "تقرير المشتريات";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(432, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Peru;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1284, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "تقرير المبيعات";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1067, 127);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(291, 128);
            this.bunifuFlatButton1.TabIndex = 82;
            this.bunifuFlatButton1.Text = "تقرير المبيعات";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.Crimson;
            this.btn_edit.BackColor = System.Drawing.Color.Crimson;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 5;
            this.btn_edit.ButtonText = "التقرير اليومي";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.Crimson;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = null;
            this.btn_edit.Iconimage_right = null;
            this.btn_edit.Iconimage_right_Selected = null;
            this.btn_edit.Iconimage_Selected = null;
            this.btn_edit.IconMarginLeft = 0;
            this.btn_edit.IconMarginRight = 0;
            this.btn_edit.IconRightVisible = true;
            this.btn_edit.IconRightZoom = 0D;
            this.btn_edit.IconVisible = true;
            this.btn_edit.IconZoom = 60D;
            this.btn_edit.IsTab = false;
            this.btn_edit.Location = new System.Drawing.Point(224, 127);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.Crimson;
            this.btn_edit.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(283, 128);
            this.btn_edit.TabIndex = 81;
            this.btn_edit.Text = "التقرير اليومي";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.Black;
            this.btn_edit.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.Peru;
            this.btn_save.BackColor = System.Drawing.Color.Peru;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 5;
            this.btn_save.ButtonText = "التقرير العام";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Peru;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = null;
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 60D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(500, 127);
            this.btn_save.Margin = new System.Windows.Forms.Padding(9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.Peru;
            this.btn_save.OnHovercolor = System.Drawing.Color.Peru;
            this.btn_save.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(287, 128);
            this.btn_save.TabIndex = 80;
            this.btn_save.Text = "التقرير العام";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.Textcolor = System.Drawing.Color.Black;
            this.btn_save.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1198, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 91;
            this.label6.Text = "ج.س";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column58.Alias = "Sum_Quantity";
            columnExpression77.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression77.ColumnName = "Quantity";
            table39.Name = "PosProducts";
            columnExpression77.Table = table39;
            column58.Expression = columnExpression77;
            column59.Alias = "Sum_Money";
            columnExpression78.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression78.ColumnName = "Money";
            columnExpression78.Table = table39;
            column59.Expression = columnExpression78;
            columnExpression79.ColumnName = "Name";
            table40.Name = "Products";
            columnExpression79.Table = table40;
            column60.Expression = columnExpression79;
            selectQuery20.Columns.Add(column58);
            selectQuery20.Columns.Add(column59);
            selectQuery20.Columns.Add(column60);
            columnExpression80.ColumnName = "Name";
            columnExpression80.Table = table40;
            group20.Expression = columnExpression80;
            selectQuery20.Groups.Add(group20);
            selectQuery20.Name = "PosProducts";
            relationColumnInfo20.NestedKeyColumn = "BarCode";
            relationColumnInfo20.ParentKeyColumn = "Barcode";
            join20.KeyColumns.Add(relationColumnInfo20);
            join20.Nested = table40;
            join20.Parent = table39;
            selectQuery20.Relations.Add(join20);
            selectQuery20.Tables.Add(table39);
            selectQuery20.Tables.Add(table40);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery20});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // posProductsBindingSource
            // 
            this.posProductsBindingSource.DataMember = "PosProducts";
            this.posProductsBindingSource.DataSource = this.sqlDataSource1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1023, 28);
            this.label5.TabIndex = 92;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.AppearanceDisabled.BackColor2 = System.Drawing.Color.LightGreen;
            this.simpleButton1.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.AppearanceDisabled.ForeColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(1267, 79);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 36);
            this.simpleButton1.TabIndex = 99;
            this.simpleButton1.Text = "نافذة البيع";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(224, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 36);
            this.panel2.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 93;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem6.Appearance.Options.UseFont = true;
            this.navBarItem6.Caption = "العقودات";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.SmallImage")));
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem7.Appearance.Options.UseFont = true;
            this.navBarItem7.Caption = "إضافة موردين";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.SmallImage")));
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // navBarItem8
            // 
            this.navBarItem8.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem8.Appearance.Options.UseFont = true;
            this.navBarItem8.Caption = "منتجات الموردين";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem8.SmallImage")));
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // navBarItem9
            // 
            this.navBarItem9.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem9.Appearance.Options.UseFont = true;
            this.navBarItem9.Caption = "صلاحية منتجات المورد";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem9.SmallImage")));
            this.navBarItem9.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem9_LinkClicked);
            // 
            // navBarItem10
            // 
            this.navBarItem10.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem10.Appearance.Options.UseFont = true;
            this.navBarItem10.Caption = "الشكاوي والملاحظات ";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem10.SmallImage")));
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem10_LinkClicked);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem11.Appearance.Options.UseFont = true;
            this.navBarItem11.Caption = "مبيعات الموردين";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem11.SmallImage")));
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // navBarItem12
            // 
            this.navBarItem12.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem12.Appearance.Options.UseFont = true;
            this.navBarItem12.Caption = "نافذة المصروفات";
            this.navBarItem12.Name = "navBarItem12";
            this.navBarItem12.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem12.SmallImage")));
            this.navBarItem12.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem12_LinkClicked);
            // 
            // navBarItem18
            // 
            this.navBarItem18.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem18.Appearance.Options.UseFont = true;
            this.navBarItem18.Caption = "تقرير الكورسات";
            this.navBarItem18.Name = "navBarItem18";
            this.navBarItem18.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem18.SmallImage")));
            this.navBarItem18.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem18_LinkClicked);
            // 
            // navBarItem19
            // 
            this.navBarItem19.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem19.Appearance.Options.UseFont = true;
            this.navBarItem19.Caption = "تقرير مبيعات المورد";
            this.navBarItem19.Name = "navBarItem19";
            this.navBarItem19.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem19.SmallImage")));
            this.navBarItem19.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem19_LinkClicked);
            // 
            // navBarItem20
            // 
            this.navBarItem20.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.navBarItem20.Appearance.Options.UseFont = true;
            this.navBarItem20.Caption = "تقرير أعلى المبيعات للمورد";
            this.navBarItem20.Name = "navBarItem20";
            this.navBarItem20.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem20.SmallImage")));
            this.navBarItem20.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem20_LinkClicked);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainPage";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label_SHOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label_Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posProductsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl__date;
        public System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_watch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        public Bunifu.Framework.UI.BunifuFlatButton bnt_Mtype;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem15;
        private DevExpress.XtraNavBar.NavBarItem nav_Project;
        private DevExpress.XtraNavBar.NavBarItem nav_Devlopers;
        public DevExpress.XtraNavBar.NavBarItem Nav_RentPos;
        public DevExpress.XtraNavBar.NavBarControl navBarControl1;
        public DevExpress.XtraNavBar.NavBarItem nav_Pos;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        public DevExpress.XtraNavBar.NavBarItem nav_Reservation;
        public DevExpress.XtraNavBar.NavBarItem nav_PaymentRes;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        public DevExpress.XtraNavBar.NavBarItem nav_EmpAdd;
        public DevExpress.XtraNavBar.NavBarItem nav_EmpManage;
        public DevExpress.XtraNavBar.NavBarItem nav_EmpPayRoll;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        public DevExpress.XtraNavBar.NavBarItem nav_AddBank;
        public DevExpress.XtraNavBar.NavBarItem nav_Expenses;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup7;
        public DevExpress.XtraNavBar.NavBarItem nav_Products;
        public DevExpress.XtraNavBar.NavBarItem nav_Supplaier;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup8;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup9;
        public DevExpress.XtraNavBar.NavBarItem nav_Rent;
        public DevExpress.XtraNavBar.NavBarItem nav_Service;
        public DevExpress.XtraNavBar.NavBarItem nav_Gategory;
        public DevExpress.XtraNavBar.NavBarItem nav_Show;
        public DevExpress.XtraNavBar.NavBarItem nav_Logs;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup10;
        public DevExpress.XtraNavBar.NavBarItem nav_UserManage;
        public DevExpress.XtraNavBar.NavBarItem nav_Permistion;
        public DevExpress.XtraNavBar.NavBarGroup navBarGroup11;
        public DevExpress.XtraNavBar.NavBarItem nav_DataBase;
        private Bunifu.Framework.UI.BunifuImageButton label_SHOW;
        private Bunifu.Framework.UI.BunifuImageButton label_Product;
        private Bunifu.Framework.UI.BunifuImageButton label_Res;
        private System.Windows.Forms.Label L_PRD;
        private System.Windows.Forms.Label L_RES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L_SHOW;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        public Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        internal System.Windows.Forms.Timer timer2;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        public DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource posProductsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem18;
        private DevExpress.XtraNavBar.NavBarItem navBarItem20;
        public DevExpress.XtraNavBar.NavBarItem navBarItem12;
        public DevExpress.XtraNavBar.NavBarItem navBarItem5;
        public DevExpress.XtraNavBar.NavBarItem navBarItem6;
        public DevExpress.XtraNavBar.NavBarItem navBarItem7;
        public DevExpress.XtraNavBar.NavBarItem navBarItem8;
        public DevExpress.XtraNavBar.NavBarItem navBarItem9;
        public DevExpress.XtraNavBar.NavBarItem navBarItem10;
        public DevExpress.XtraNavBar.NavBarItem navBarItem11;
        public DevExpress.XtraNavBar.NavBarItem navBarItem13;
        public DevExpress.XtraNavBar.NavBarItem navBarItem14;
        public DevExpress.XtraNavBar.NavBarItem navBarItem16;
        public DevExpress.XtraNavBar.NavBarItem navBarItem17;
        public DevExpress.XtraNavBar.NavBarItem navBarItem4;
        public DevExpress.XtraNavBar.NavBarItem navBarItem19;
    }
}