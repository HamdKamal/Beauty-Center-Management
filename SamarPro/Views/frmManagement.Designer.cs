namespace SamarPro.Views
{
    partial class frmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagement));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnedit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPhone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtMoney = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TXTID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Withdrow = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtService = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Paid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvRes = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالحجز = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالعميل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالمدفوع = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالمتبقي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالكلي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالخدمة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالهاتف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-9, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1007, 52);
            this.bunifuGradientPanel1.TabIndex = 61;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(7, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(826, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(160, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "دفعات الحجوزات";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-5, 597);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1007, 39);
            this.bunifuGradientPanel2.TabIndex = 62;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel6.Controls.Add(this.panel1);
            this.bunifuGradientPanel6.Controls.Add(this.txtPhone);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel6.Controls.Add(this.txtMoney);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel6.Controls.Add(this.total);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel6.Controls.Add(this.TXTID);
            this.bunifuGradientPanel6.Controls.Add(this.Withdrow);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel6.Controls.Add(this.txtService);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel15);
            this.bunifuGradientPanel6.Controls.Add(this.txtName);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel14);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel13);
            this.bunifuGradientPanel6.Controls.Add(this.Paid);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel19);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuGradientPanel8);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(4, 57);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(987, 531);
            this.bunifuGradientPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Location = new System.Drawing.Point(696, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 120);
            this.panel1.TabIndex = 124;
            // 
            // btn_print
            // 
            this.btn_print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.BorderRadius = 5;
            this.btn_print.ButtonText = "طباعة";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print.Enabled = false;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_print.Iconimage")));
            this.btn_print.Iconimage_right = null;
            this.btn_print.Iconimage_right_Selected = null;
            this.btn_print.Iconimage_Selected = null;
            this.btn_print.IconMarginLeft = 0;
            this.btn_print.IconMarginRight = 0;
            this.btn_print.IconRightVisible = true;
            this.btn_print.IconRightZoom = 0D;
            this.btn_print.IconVisible = true;
            this.btn_print.IconZoom = 60D;
            this.btn_print.IsTab = false;
            this.btn_print.Location = new System.Drawing.Point(14, 71);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_print.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_print.selected = false;
            this.btn_print.Size = new System.Drawing.Size(254, 35);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "طباعة";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.Textcolor = System.Drawing.Color.Black;
            this.btn_print.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnedit
            // 
            this.btnedit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnedit.BackColor = System.Drawing.Color.Teal;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.BorderRadius = 5;
            this.btnedit.ButtonText = "سداد دفعة جديدة من المبلغ ";
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.DisabledColor = System.Drawing.Color.Gray;
            this.btnedit.Enabled = false;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btnedit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnedit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnedit.Iconimage")));
            this.btnedit.Iconimage_right = null;
            this.btnedit.Iconimage_right_Selected = null;
            this.btnedit.Iconimage_Selected = null;
            this.btnedit.IconMarginLeft = 0;
            this.btnedit.IconMarginRight = 0;
            this.btnedit.IconRightVisible = true;
            this.btnedit.IconRightZoom = 0D;
            this.btnedit.IconVisible = true;
            this.btnedit.IconZoom = 60D;
            this.btnedit.IsTab = false;
            this.btnedit.Location = new System.Drawing.Point(14, 17);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Normalcolor = System.Drawing.Color.Teal;
            this.btnedit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnedit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnedit.selected = false;
            this.btnedit.Size = new System.Drawing.Size(254, 35);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "سداد دفعة جديدة من المبلغ ";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.Textcolor = System.Drawing.Color.Black;
            this.btnedit.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(711, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(870, 102);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel2.TabIndex = 121;
            this.bunifuCustomLabel2.Text = "رقم الهاتف :";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(690, 174);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(294, 35);
            this.bunifuSeparator1.TabIndex = 120;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.White;
            this.txtMoney.BorderColor = System.Drawing.Color.Black;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(711, 346);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(157, 20);
            this.txtMoney.TabIndex = 7;
            this.txtMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoney_KeyDown);
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            this.txtMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMoney_KeyUp);
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(870, 346);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(49, 19);
            this.bunifuCustomLabel6.TabIndex = 118;
            this.bunifuCustomLabel6.Text = "المبلغ :";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.BorderColor = System.Drawing.Color.Black;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Location = new System.Drawing.Point(711, 226);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(157, 20);
            this.total.TabIndex = 4;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(870, 226);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(80, 19);
            this.bunifuCustomLabel5.TabIndex = 116;
            this.bunifuCustomLabel5.Text = "المبلغ الكلي :";
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.Color.White;
            this.TXTID.BorderColor = System.Drawing.Color.Black;
            this.TXTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTID.Location = new System.Drawing.Point(799, 32);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(69, 20);
            this.TXTID.TabIndex = 0;
            // 
            // Withdrow
            // 
            this.Withdrow.BackColor = System.Drawing.Color.White;
            this.Withdrow.BorderColor = System.Drawing.Color.Black;
            this.Withdrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Withdrow.Location = new System.Drawing.Point(711, 306);
            this.Withdrow.Name = "Withdrow";
            this.Withdrow.ReadOnly = true;
            this.Withdrow.Size = new System.Drawing.Size(157, 20);
            this.Withdrow.TabIndex = 6;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(870, 306);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(90, 19);
            this.bunifuCustomLabel4.TabIndex = 114;
            this.bunifuCustomLabel4.Text = "المبلغ المتبقي :";
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.Color.White;
            this.txtService.BorderColor = System.Drawing.Color.Black;
            this.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtService.Location = new System.Drawing.Point(711, 140);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(157, 20);
            this.txtService.TabIndex = 3;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(870, 138);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel15.TabIndex = 112;
            this.bunifuCustomLabel15.Text = "نوع الخدمة :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(711, 67);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 1;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(870, 65);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel14.TabIndex = 110;
            this.bunifuCustomLabel14.Text = "إسم العميل :";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(870, 32);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(71, 19);
            this.bunifuCustomLabel13.TabIndex = 108;
            this.bunifuCustomLabel13.Text = "رقم الحجز :";
            // 
            // Paid
            // 
            this.Paid.BackColor = System.Drawing.Color.White;
            this.Paid.BorderColor = System.Drawing.Color.Black;
            this.Paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paid.Location = new System.Drawing.Point(711, 265);
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            this.Paid.Size = new System.Drawing.Size(157, 20);
            this.Paid.TabIndex = 5;
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(870, 264);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel19.TabIndex = 106;
            this.bunifuCustomLabel19.Text = "الميلغ المدفوع :";
            // 
            // bunifuGradientPanel8
            // 
            this.bunifuGradientPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel8.BackgroundImage")));
            this.bunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel8.Controls.Add(this.dgvRes);
            this.bunifuGradientPanel8.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel8.Name = "bunifuGradientPanel8";
            this.bunifuGradientPanel8.Quality = 10;
            this.bunifuGradientPanel8.Size = new System.Drawing.Size(687, 523);
            this.bunifuGradientPanel8.TabIndex = 66;
            // 
            // dgvRes
            // 
            this.dgvRes.DataMember = "Reservations";
            this.dgvRes.DataSource = this.sqlDataSource1;
            this.dgvRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvRes.Location = new System.Drawing.Point(4, 3);
            this.dgvRes.MainView = this.gridView1;
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.Size = new System.Drawing.Size(678, 515);
            this.dgvRes.TabIndex = 67;
            this.dgvRes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvRes.Click += new System.EventHandler(this.dgvRes_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "رقم الحجز";
            columnExpression1.ColumnName = "Code";
            table1.Name = "Reservations";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم العميل";
            columnExpression2.ColumnName = "CUSname";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "المبلغ المدفوع";
            columnExpression3.ColumnName = "Paid";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "المبلغ المتبقي";
            columnExpression4.ColumnName = "withdrow";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "المبلغ الكلي";
            columnExpression5.ColumnName = "Money";
            table2.Name = "Services";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            column6.Alias = "نوع الخدمة";
            columnExpression6.ColumnName = "Name";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            column7.Alias = "رقم الهاتف";
            columnExpression7.ColumnName = "Phone";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.FilterString = "";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "Reservations";
            relationColumnInfo1.NestedKeyColumn = "ID";
            relationColumnInfo1.ParentKeyColumn = "SERTYPE";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView1.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالحجز,
            this.colإسمالعميل,
            this.colالمبلغالمدفوع,
            this.colالمبلغالمتبقي,
            this.colالمبلغالكلي,
            this.colنوعالخدمة,
            this.colرقمالهاتف});
            this.gridView1.GridControl = this.dgvRes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "بــحــــث";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colرقمالحجز
            // 
            this.colرقمالحجز.FieldName = "رقم الحجز";
            this.colرقمالحجز.Name = "colرقمالحجز";
            this.colرقمالحجز.Visible = true;
            this.colرقمالحجز.VisibleIndex = 0;
            // 
            // colإسمالعميل
            // 
            this.colإسمالعميل.FieldName = "إسم العميل";
            this.colإسمالعميل.Name = "colإسمالعميل";
            this.colإسمالعميل.Visible = true;
            this.colإسمالعميل.VisibleIndex = 2;
            // 
            // colالمبلغالمدفوع
            // 
            this.colالمبلغالمدفوع.FieldName = "المبلغ المدفوع";
            this.colالمبلغالمدفوع.Name = "colالمبلغالمدفوع";
            this.colالمبلغالمدفوع.Visible = true;
            this.colالمبلغالمدفوع.VisibleIndex = 5;
            // 
            // colالمبلغالمتبقي
            // 
            this.colالمبلغالمتبقي.FieldName = "المبلغ المتبقي";
            this.colالمبلغالمتبقي.Name = "colالمبلغالمتبقي";
            this.colالمبلغالمتبقي.Visible = true;
            this.colالمبلغالمتبقي.VisibleIndex = 6;
            // 
            // colالمبلغالكلي
            // 
            this.colالمبلغالكلي.FieldName = "المبلغ الكلي";
            this.colالمبلغالكلي.Name = "colالمبلغالكلي";
            this.colالمبلغالكلي.Visible = true;
            this.colالمبلغالكلي.VisibleIndex = 4;
            // 
            // colنوعالخدمة
            // 
            this.colنوعالخدمة.FieldName = "نوع الخدمة";
            this.colنوعالخدمة.Name = "colنوعالخدمة";
            this.colنوعالخدمة.Visible = true;
            this.colنوعالخدمة.VisibleIndex = 1;
            // 
            // colرقمالهاتف
            // 
            this.colرقمالهاتف.FieldName = "رقم الهاتف";
            this.colرقمالهاتف.Name = "colرقمالهاتف";
            this.colرقمالهاتف.Visible = true;
            this.colرقمالهاتف.VisibleIndex = 3;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 611);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagement";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMoney;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox total;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXTID;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Withdrow;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtService;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Paid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public Bunifu.Framework.UI.BunifuFlatButton btnedit;
        public DevExpress.XtraGrid.GridControl dgvRes;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالحجز;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالعميل;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالمدفوع;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالمتبقي;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالكلي;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالخدمة;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالهاتف;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_print;
    }
}