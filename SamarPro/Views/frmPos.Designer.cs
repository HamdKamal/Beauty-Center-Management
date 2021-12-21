namespace SamarPro.Views
{
    partial class frmPos
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPos));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_supplayer = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_discount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_comm = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.com_PayType = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Enterydate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.comb_Product = new System.Windows.Forms.ComboBox();
            this.txt_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Money = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_QunInStoke = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Note = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Price = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_BarCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Employee = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.productsBindingSource = new System.Windows.Forms.BindingSource();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_REPORT = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BT_PAY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.BT_PRINT = new System.Windows.Forms.Button();
            this.LBL_BILL_NO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_BILL_PRICE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LBL_TOTAL_PRICE = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sEARCHPRODUCTBindingSource = new System.Windows.Forms.BindingSource();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHPRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_supplayer);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel15);
            this.tabPage2.Controls.Add(this.txt_discount);
            this.tabPage2.Controls.Add(this.txt_comm);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel13);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel14);
            this.tabPage2.Controls.Add(this.com_PayType);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel12);
            this.tabPage2.Controls.Add(this.Enterydate);
            this.tabPage2.Controls.Add(this.bunifuSeparator1);
            this.tabPage2.Controls.Add(this.comb_Product);
            this.tabPage2.Controls.Add(this.txt_Name);
            this.tabPage2.Controls.Add(this.txt_Money);
            this.tabPage2.Controls.Add(this.txt_Quantity);
            this.tabPage2.Controls.Add(this.txt_QunInStoke);
            this.tabPage2.Controls.Add(this.txt_Note);
            this.tabPage2.Controls.Add(this.txt_Price);
            this.tabPage2.Controls.Add(this.txt_BarCode);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel11);
            this.tabPage2.Controls.Add(this.txt_Employee);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel10);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel9);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel7);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel8);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage2.Controls.Add(this.bunifuDatepicker2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بيع منتج";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_supplayer
            // 
            this.txt_supplayer.BackColor = System.Drawing.Color.White;
            this.txt_supplayer.BorderColor = System.Drawing.Color.Black;
            this.txt_supplayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_supplayer.Location = new System.Drawing.Point(376, 193);
            this.txt_supplayer.Name = "txt_supplayer";
            this.txt_supplayer.ReadOnly = true;
            this.txt_supplayer.Size = new System.Drawing.Size(184, 24);
            this.txt_supplayer.TabIndex = 143;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(561, 194);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(84, 19);
            this.bunifuCustomLabel15.TabIndex = 144;
            this.bunifuCustomLabel15.Text = ": إسم المسوق";
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.White;
            this.txt_discount.BorderColor = System.Drawing.Color.Black;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_discount.Location = new System.Drawing.Point(196, 236);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(105, 24);
            this.txt_discount.TabIndex = 134;
            this.txt_discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_discount_KeyUp);
            // 
            // txt_comm
            // 
            this.txt_comm.BackColor = System.Drawing.Color.White;
            this.txt_comm.BorderColor = System.Drawing.Color.Black;
            this.txt_comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comm.Location = new System.Drawing.Point(196, 193);
            this.txt_comm.Name = "txt_comm";
            this.txt_comm.ReadOnly = true;
            this.txt_comm.Size = new System.Drawing.Size(105, 24);
            this.txt_comm.TabIndex = 133;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(301, 238);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel13.TabIndex = 136;
            this.bunifuCustomLabel13.Text = ": التخفيض";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(301, 195);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(57, 19);
            this.bunifuCustomLabel14.TabIndex = 135;
            this.bunifuCustomLabel14.Text = ": العمولة";
            // 
            // com_PayType
            // 
            this.com_PayType.FormattingEnabled = true;
            this.com_PayType.Items.AddRange(new object[] {
            "جملة",
            "تجزئة"});
            this.com_PayType.Location = new System.Drawing.Point(24, 193);
            this.com_PayType.Name = "com_PayType";
            this.com_PayType.Size = new System.Drawing.Size(102, 25);
            this.com_PayType.TabIndex = 132;
            this.com_PayType.SelectedIndexChanged += new System.EventHandler(this.com_PayType_SelectedIndexChanged);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(126, 196);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(66, 19);
            this.bunifuCustomLabel12.TabIndex = 131;
            this.bunifuCustomLabel12.Text = ": نوع البيع";
            // 
            // Enterydate
            // 
            this.Enterydate.BackColor = System.Drawing.Color.DodgerBlue;
            this.Enterydate.BorderRadius = 0;
            this.Enterydate.ForeColor = System.Drawing.Color.White;
            this.Enterydate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Enterydate.FormatCustom = "";
            this.Enterydate.Location = new System.Drawing.Point(24, 417);
            this.Enterydate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Enterydate.Name = "Enterydate";
            this.Enterydate.Size = new System.Drawing.Size(187, 24);
            this.Enterydate.TabIndex = 9;
            this.Enterydate.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-4, 159);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(807, 14);
            this.bunifuSeparator1.TabIndex = 130;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // comb_Product
            // 
            this.comb_Product.FormattingEnabled = true;
            this.comb_Product.Location = new System.Drawing.Point(139, 14);
            this.comb_Product.Name = "comb_Product";
            this.comb_Product.Size = new System.Drawing.Size(317, 25);
            this.comb_Product.TabIndex = 0;
            this.comb_Product.SelectedIndexChanged += new System.EventHandler(this.comb_Product_SelectedIndexChanged);
            this.comb_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comb_Product_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderColor = System.Drawing.Color.Black;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Location = new System.Drawing.Point(376, 116);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(183, 24);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Money
            // 
            this.txt_Money.BackColor = System.Drawing.Color.White;
            this.txt_Money.BorderColor = System.Drawing.Color.Black;
            this.txt_Money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Money.Location = new System.Drawing.Point(24, 278);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.ReadOnly = true;
            this.txt_Money.Size = new System.Drawing.Size(102, 24);
            this.txt_Money.TabIndex = 6;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.White;
            this.txt_Quantity.BorderColor = System.Drawing.Color.Black;
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Location = new System.Drawing.Point(196, 279);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(105, 24);
            this.txt_Quantity.TabIndex = 5;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            this.txt_Quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Quantity_KeyUp);
            this.txt_Quantity.Leave += new System.EventHandler(this.txt_Quantity_Leave);
            // 
            // txt_QunInStoke
            // 
            this.txt_QunInStoke.BackColor = System.Drawing.Color.White;
            this.txt_QunInStoke.BorderColor = System.Drawing.Color.Black;
            this.txt_QunInStoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QunInStoke.Location = new System.Drawing.Point(462, 236);
            this.txt_QunInStoke.Name = "txt_QunInStoke";
            this.txt_QunInStoke.ReadOnly = true;
            this.txt_QunInStoke.Size = new System.Drawing.Size(97, 24);
            this.txt_QunInStoke.TabIndex = 3;
            // 
            // txt_Note
            // 
            this.txt_Note.BackColor = System.Drawing.Color.White;
            this.txt_Note.BorderColor = System.Drawing.Color.Black;
            this.txt_Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Note.Location = new System.Drawing.Point(24, 332);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(536, 52);
            this.txt_Note.TabIndex = 7;
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.White;
            this.txt_Price.BorderColor = System.Drawing.Color.Black;
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Location = new System.Drawing.Point(24, 236);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.Size = new System.Drawing.Size(102, 24);
            this.txt_Price.TabIndex = 4;
            // 
            // txt_BarCode
            // 
            this.txt_BarCode.BackColor = System.Drawing.Color.White;
            this.txt_BarCode.BorderColor = System.Drawing.Color.Black;
            this.txt_BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BarCode.Location = new System.Drawing.Point(462, 74);
            this.txt_BarCode.Name = "txt_BarCode";
            this.txt_BarCode.Size = new System.Drawing.Size(97, 24);
            this.txt_BarCode.TabIndex = 1;
            this.txt_BarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BarCode_KeyDown);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(458, 17);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(90, 19);
            this.bunifuCustomLabel11.TabIndex = 92;
            this.bunifuCustomLabel11.Text = ": بحث عن منتج";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Employee
            // 
            this.txt_Employee.BackColor = System.Drawing.Color.White;
            this.txt_Employee.BorderColor = System.Drawing.Color.Black;
            this.txt_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Employee.Location = new System.Drawing.Point(376, 417);
            this.txt_Employee.Name = "txt_Employee";
            this.txt_Employee.Size = new System.Drawing.Size(183, 24);
            this.txt_Employee.TabIndex = 8;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(562, 118);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel10.TabIndex = 90;
            this.bunifuCustomLabel10.Text = ": إسم المنتج";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(126, 281);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(49, 19);
            this.bunifuCustomLabel9.TabIndex = 88;
            this.bunifuCustomLabel9.Text = ": المبلغ";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(560, 237);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel7.TabIndex = 84;
            this.bunifuCustomLabel7.Text = ": المخزون";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(211, 418);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(90, 19);
            this.bunifuCustomLabel8.TabIndex = 83;
            this.bunifuCustomLabel8.Text = ": تاريخ الفاتورة";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(302, 282);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(50, 19);
            this.bunifuCustomLabel6.TabIndex = 82;
            this.bunifuCustomLabel6.Text = ": الكمية";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(562, 333);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(57, 19);
            this.bunifuCustomLabel5.TabIndex = 77;
            this.bunifuCustomLabel5.Text = ": ملاحظة";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(126, 237);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel4.TabIndex = 76;
            this.bunifuCustomLabel4.Text = ": سعر البيع";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(563, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel3.TabIndex = 75;
            this.bunifuCustomLabel3.Text = ": باركود المنتج";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(562, 418);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 19);
            this.bunifuCustomLabel2.TabIndex = 74;
            this.bunifuCustomLabel2.Text = ": إسم الموظف";
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(41, 540);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(14, 9, 14, 9);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(318, 31);
            this.bunifuDatepicker2.TabIndex = 73;
            this.bunifuDatepicker2.Value = new System.DateTime(2020, 4, 18, 15, 11, 5, 287);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(7, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "TBL_PRODUCTS";
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression3.ColumnName = "Name";
            columnExpression3.Table = table1;
            sorting1.Expression = columnExpression3;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlRCTF9QUk9EVUNUUyI+PEZpZ" +
    "WxkIE5hbWU9IklEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iTmFtZSIgVHlwZT0iU3RyaW5nI" +
    "iAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "db_model";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression4.ColumnName = "ID";
            table2.Name = "Products";
            columnExpression4.Table = table2;
            column3.Expression = columnExpression4;
            columnExpression5.ColumnName = "Name";
            columnExpression5.Table = table2;
            column4.Expression = columnExpression5;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "Products";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlByb2R1Y3RzIj48RmllbGQgT" +
    "mFtZT0iSUQiIFR5cGU9IkludDMyIiAvPjxGaWVsZCBOYW1lPSJOYW1lIiBUeXBlPSJTdHJpbmciIC8+P" +
    "C9WaWV3PjwvRGF0YVNldD4=";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.sqlDataSource2;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel5.Controls.Add(this.button1);
            this.bunifuGradientPanel5.Controls.Add(this.BT_REPORT);
            this.bunifuGradientPanel5.Controls.Add(this.BT_EXIT);
            this.bunifuGradientPanel5.Controls.Add(this.BT_CANCEL);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(7, 546);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(674, 55);
            this.bunifuGradientPanel5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(495, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "بيع جديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_REPORT
            // 
            this.BT_REPORT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_REPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_REPORT.Enabled = false;
            this.BT_REPORT.FlatAppearance.BorderSize = 0;
            this.BT_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_REPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_REPORT.ForeColor = System.Drawing.Color.White;
            this.BT_REPORT.Image = ((System.Drawing.Image)(resources.GetObject("BT_REPORT.Image")));
            this.BT_REPORT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_REPORT.Location = new System.Drawing.Point(199, 8);
            this.BT_REPORT.Name = "BT_REPORT";
            this.BT_REPORT.Size = new System.Drawing.Size(128, 38);
            this.BT_REPORT.TabIndex = 2;
            this.BT_REPORT.Text = "فاتورة كبيرة";
            this.BT_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_REPORT.UseVisualStyleBackColor = false;
            this.BT_REPORT.Click += new System.EventHandler(this.BT_REPORT_Click);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EXIT.BackColor = System.Drawing.Color.Red;
            this.BT_EXIT.FlatAppearance.BorderSize = 0;
            this.BT_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_EXIT.ForeColor = System.Drawing.Color.White;
            this.BT_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.Image")));
            this.BT_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EXIT.Location = new System.Drawing.Point(49, 9);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(129, 37);
            this.BT_EXIT.TabIndex = 3;
            this.BT_EXIT.Text = "خروج";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_CANCEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_CANCEL.Enabled = false;
            this.BT_CANCEL.FlatAppearance.BorderSize = 0;
            this.BT_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_CANCEL.Image")));
            this.BT_CANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_CANCEL.Location = new System.Drawing.Point(348, 8);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(126, 37);
            this.BT_CANCEL.TabIndex = 1;
            this.BT_CANCEL.Text = "الغاء الفاتورة";
            this.BT_CANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel4.Controls.Add(this.BT_PAY);
            this.bunifuGradientPanel4.Controls.Add(this.label3);
            this.bunifuGradientPanel4.Controls.Add(this.LBL_DATE);
            this.bunifuGradientPanel4.Controls.Add(this.BT_PRINT);
            this.bunifuGradientPanel4.Controls.Add(this.LBL_BILL_NO);
            this.bunifuGradientPanel4.Controls.Add(this.label1);
            this.bunifuGradientPanel4.Controls.Add(this.BT_DEL);
            this.bunifuGradientPanel4.Controls.Add(this.label2);
            this.bunifuGradientPanel4.Controls.Add(this.LBL_BILL_PRICE);
            this.bunifuGradientPanel4.Controls.Add(this.label6);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(687, 413);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(397, 188);
            this.bunifuGradientPanel4.TabIndex = 70;
            // 
            // BT_PAY
            // 
            this.BT_PAY.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_PAY.Enabled = false;
            this.BT_PAY.FlatAppearance.BorderSize = 0;
            this.BT_PAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_PAY.ForeColor = System.Drawing.Color.White;
            this.BT_PAY.Image = ((System.Drawing.Image)(resources.GetObject("BT_PAY.Image")));
            this.BT_PAY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_PAY.Location = new System.Drawing.Point(266, 13);
            this.BT_PAY.Name = "BT_PAY";
            this.BT_PAY.Size = new System.Drawing.Size(119, 31);
            this.BT_PAY.TabIndex = 0;
            this.BT_PAY.Text = "شراء";
            this.BT_PAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_PAY.UseVisualStyleBackColor = false;
            this.BT_PAY.Click += new System.EventHandler(this.BT_PAY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "جنيه سوداني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_DATE.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LBL_DATE.ForeColor = System.Drawing.Color.Black;
            this.LBL_DATE.Location = new System.Drawing.Point(-20, 161);
            this.LBL_DATE.Name = "LBL_DATE";
            this.LBL_DATE.Size = new System.Drawing.Size(120, 25);
            this.LBL_DATE.TabIndex = 69;
            this.LBL_DATE.Text = "01-01-2020";
            this.LBL_DATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BT_PRINT
            // 
            this.BT_PRINT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_PRINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_PRINT.Enabled = false;
            this.BT_PRINT.FlatAppearance.BorderSize = 0;
            this.BT_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_PRINT.ForeColor = System.Drawing.Color.White;
            this.BT_PRINT.Image = ((System.Drawing.Image)(resources.GetObject("BT_PRINT.Image")));
            this.BT_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_PRINT.Location = new System.Drawing.Point(136, 13);
            this.BT_PRINT.Name = "BT_PRINT";
            this.BT_PRINT.Size = new System.Drawing.Size(124, 31);
            this.BT_PRINT.TabIndex = 1;
            this.BT_PRINT.Text = " طباعة الفاتورة";
            this.BT_PRINT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_PRINT.UseVisualStyleBackColor = false;
            this.BT_PRINT.Click += new System.EventHandler(this.BT_PRINT_Click);
            // 
            // LBL_BILL_NO
            // 
            this.LBL_BILL_NO.BackColor = System.Drawing.Color.DarkGray;
            this.LBL_BILL_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_BILL_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_BILL_NO.ForeColor = System.Drawing.Color.Black;
            this.LBL_BILL_NO.Location = new System.Drawing.Point(136, 69);
            this.LBL_BILL_NO.Name = "LBL_BILL_NO";
            this.LBL_BILL_NO.Size = new System.Drawing.Size(124, 25);
            this.LBL_BILL_NO.TabIndex = 68;
            this.LBL_BILL_NO.Text = "0";
            this.LBL_BILL_NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 65;
            this.label1.Text = "التاريخ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_DEL
            // 
            this.BT_DEL.BackColor = System.Drawing.Color.OrangeRed;
            this.BT_DEL.Enabled = false;
            this.BT_DEL.FlatAppearance.BorderSize = 0;
            this.BT_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_DEL.ForeColor = System.Drawing.Color.White;
            this.BT_DEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.Image")));
            this.BT_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_DEL.Location = new System.Drawing.Point(10, 13);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(120, 31);
            this.BT_DEL.TabIndex = 2;
            this.BT_DEL.Text = " حذف المنتج";
            this.BT_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_DEL.UseVisualStyleBackColor = false;
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(260, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = ": رقم الفاتورة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_BILL_PRICE
            // 
            this.LBL_BILL_PRICE.BackColor = System.Drawing.Color.Yellow;
            this.LBL_BILL_PRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_BILL_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_BILL_PRICE.ForeColor = System.Drawing.Color.Black;
            this.LBL_BILL_PRICE.Location = new System.Drawing.Point(136, 97);
            this.LBL_BILL_PRICE.Name = "LBL_BILL_PRICE";
            this.LBL_BILL_PRICE.Size = new System.Drawing.Size(124, 25);
            this.LBL_BILL_PRICE.TabIndex = 66;
            this.LBL_BILL_PRICE.Text = "0.00";
            this.LBL_BILL_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(260, 97);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = ": قيمة الفاتورة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.LBL_TOTAL_PRICE);
            this.bunifuGradientPanel3.Controls.Add(this.label22);
            this.bunifuGradientPanel3.Controls.Add(this.ListView1);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(687, 53);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(397, 356);
            this.bunifuGradientPanel3.TabIndex = 59;
            // 
            // LBL_TOTAL_PRICE
            // 
            this.LBL_TOTAL_PRICE.BackColor = System.Drawing.Color.DarkKhaki;
            this.LBL_TOTAL_PRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TOTAL_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_TOTAL_PRICE.ForeColor = System.Drawing.Color.Black;
            this.LBL_TOTAL_PRICE.Location = new System.Drawing.Point(3, 330);
            this.LBL_TOTAL_PRICE.Name = "LBL_TOTAL_PRICE";
            this.LBL_TOTAL_PRICE.Size = new System.Drawing.Size(90, 25);
            this.LBL_TOTAL_PRICE.TabIndex = 61;
            this.LBL_TOTAL_PRICE.Text = "0.00";
            this.LBL_TOTAL_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(322, 333);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(70, 22);
            this.label22.TabIndex = 62;
            this.label22.Text = ": الإجمالي";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader20,
            this.ColumnHeader15,
            this.columnHeader1,
            this.ColumnHeader18,
            this.columnHeader2});
            this.ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(3, 3);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.Size = new System.Drawing.Size(388, 327);
            this.ListView1.TabIndex = 60;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader20
            // 
            this.ColumnHeader20.Text = "إسم المنتج";
            this.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader20.Width = 135;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "الكمية";
            this.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader15.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "السعر";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // ColumnHeader18
            // 
            this.ColumnHeader18.Text = "الإجمالي";
            this.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader18.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "باركود المنتج";
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-14, 610);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1109, 21);
            this.bunifuGradientPanel2.TabIndex = 58;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-6, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1097, 52);
            this.bunifuGradientPanel1.TabIndex = 57;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(986, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "نافذة البيع";
            // 
            // sEARCHPRODUCTBindingSource
            // 
            this.sEARCHPRODUCTBindingSource.DataMember = "SEARCH_PRODUCT";
            // 
            // frmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPos";
            this.Load += new System.EventHandler(this.frmPos_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHPRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        public System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader20;
        internal System.Windows.Forms.ColumnHeader ColumnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader18;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.Label LBL_TOTAL_PRICE;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label LBL_DATE;
        public System.Windows.Forms.Label LBL_BILL_NO;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LBL_BILL_PRICE;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_PRINT;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BT_DEL;
        public System.Windows.Forms.Button BT_PAY;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private System.Windows.Forms.Button BT_REPORT;
        private System.Windows.Forms.Button BT_EXIT;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.TabPage tabPage2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Name;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Money;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Quantity;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_QunInStoke;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Note;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Price;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_BarCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Employee;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private System.Windows.Forms.TabControl tabControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource sEARCHPRODUCTBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        public System.Windows.Forms.ComboBox comb_Product;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuDatepicker Enterydate;
        public System.Windows.Forms.ComboBox com_PayType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_discount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_comm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_supplayer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
    }
}