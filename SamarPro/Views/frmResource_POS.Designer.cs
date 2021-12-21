namespace SamarPro.Views
{
    partial class frmResource_POS
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResource_POS));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_BarCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRouc_pos = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Enterydate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Comb_Name = new System.Windows.Forms.ComboBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.txt_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Money = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_QunInStoke = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Note = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Price = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Employee = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BT_PAY = new System.Windows.Forms.Button();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.BT_PRINT = new System.Windows.Forms.Button();
            this.LBL_BILL_NO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_BILL_PRICE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LBL_TOTAL_PRICE = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouc_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_BarCode);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.Enterydate);
            this.tabPage2.Controls.Add(this.bunifuSeparator1);
            this.tabPage2.Controls.Add(this.Comb_Name);
            this.tabPage2.Controls.Add(this.txt_Name);
            this.tabPage2.Controls.Add(this.txt_Money);
            this.tabPage2.Controls.Add(this.txt_Quantity);
            this.tabPage2.Controls.Add(this.txt_QunInStoke);
            this.tabPage2.Controls.Add(this.txt_Note);
            this.tabPage2.Controls.Add(this.txt_Price);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel11);
            this.tabPage2.Controls.Add(this.txt_Employee);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel10);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel9);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel7);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel8);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage2.Controls.Add(this.bunifuDatepicker2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بيع منتج";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_BarCode
            // 
            this.txt_BarCode.BackColor = System.Drawing.Color.White;
            this.txt_BarCode.BorderColor = System.Drawing.Color.Black;
            this.txt_BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BarCode.Location = new System.Drawing.Point(493, 298);
            this.txt_BarCode.Name = "txt_BarCode";
            this.txt_BarCode.Size = new System.Drawing.Size(78, 24);
            this.txt_BarCode.TabIndex = 132;
            this.txt_BarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BarCode_KeyDown);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(572, 300);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel3.TabIndex = 133;
            this.bunifuCustomLabel3.Text = ": باركود المنتج";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvRouc_pos);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 240);
            this.panel1.TabIndex = 131;
            // 
            // dgvRouc_pos
            // 
            this.dgvRouc_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvRouc_pos.Location = new System.Drawing.Point(4, 4);
            this.dgvRouc_pos.MainView = this.gridView2;
            this.dgvRouc_pos.Name = "dgvRouc_pos";
            this.dgvRouc_pos.Size = new System.Drawing.Size(644, 230);
            this.dgvRouc_pos.TabIndex = 67;
            this.dgvRouc_pos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgvRouc_pos.Click += new System.EventHandler(this.dgvRouc_pos_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridView2.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Blue;
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.RowSeparator.Options.UseForeColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView2.GridControl = this.dgvRouc_pos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsCustomization.AllowColumnMoving = false;
            this.gridView2.OptionsCustomization.AllowColumnResizing = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsCustomization.AllowRowSizing = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.ClearFindOnClose = false;
            this.gridView2.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView2.OptionsFind.FindNullPrompt = "بــحــــث";
            this.gridView2.OptionsFind.ShowCloseButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Enterydate
            // 
            this.Enterydate.BackColor = System.Drawing.Color.DodgerBlue;
            this.Enterydate.BorderRadius = 0;
            this.Enterydate.ForeColor = System.Drawing.Color.White;
            this.Enterydate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Enterydate.FormatCustom = "";
            this.Enterydate.Location = new System.Drawing.Point(23, 429);
            this.Enterydate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Enterydate.Name = "Enterydate";
            this.Enterydate.Size = new System.Drawing.Size(160, 24);
            this.Enterydate.TabIndex = 9;
            this.Enterydate.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-40, 412);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(807, 10);
            this.bunifuSeparator1.TabIndex = 130;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Comb_Name
            // 
            this.Comb_Name.DataSource = this.sqlDataSource1;
            this.Comb_Name.DisplayMember = "Resources.Name";
            this.Comb_Name.FormattingEnabled = true;
            this.Comb_Name.Location = new System.Drawing.Point(155, 6);
            this.Comb_Name.Name = "Comb_Name";
            this.Comb_Name.Size = new System.Drawing.Size(317, 25);
            this.Comb_Name.TabIndex = 0;
            this.Comb_Name.ValueMember = "Resources.ID";
            this.Comb_Name.SelectedIndexChanged += new System.EventHandler(this.comb_Product_SelectedIndexChanged);
            this.Comb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Comb_Name_KeyPress);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression5.ColumnName = "ID";
            table3.Name = "Resources";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Name";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.Name = "Resources";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlJlc291cmNlcyI+PEZpZWxkI" +
    "E5hbWU9IklEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iTmFtZSIgVHlwZT0iU3RyaW5nIiAvP" +
    "jwvVmlldz48L0RhdGFTZXQ+";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderColor = System.Drawing.Color.Black;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Location = new System.Drawing.Point(418, 334);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(153, 24);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Money
            // 
            this.txt_Money.BackColor = System.Drawing.Color.White;
            this.txt_Money.BorderColor = System.Drawing.Color.Black;
            this.txt_Money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Money.Location = new System.Drawing.Point(23, 335);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.ReadOnly = true;
            this.txt_Money.Size = new System.Drawing.Size(97, 24);
            this.txt_Money.TabIndex = 6;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.White;
            this.txt_Quantity.BorderColor = System.Drawing.Color.Black;
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Location = new System.Drawing.Point(192, 335);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(97, 24);
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
            this.txt_QunInStoke.Location = new System.Drawing.Point(192, 298);
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
            this.txt_Note.Location = new System.Drawing.Point(493, 376);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ReadOnly = true;
            this.txt_Note.Size = new System.Drawing.Size(78, 24);
            this.txt_Note.TabIndex = 7;
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.White;
            this.txt_Price.BorderColor = System.Drawing.Color.Black;
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Location = new System.Drawing.Point(23, 298);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.Size = new System.Drawing.Size(97, 24);
            this.txt_Price.TabIndex = 4;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(474, 9);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel11.TabIndex = 92;
            this.bunifuCustomLabel11.Text = ": إسم المورد";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Employee
            // 
            this.txt_Employee.BackColor = System.Drawing.Color.White;
            this.txt_Employee.BorderColor = System.Drawing.Color.Black;
            this.txt_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Employee.Location = new System.Drawing.Point(388, 429);
            this.txt_Employee.Name = "txt_Employee";
            this.txt_Employee.ReadOnly = true;
            this.txt_Employee.Size = new System.Drawing.Size(183, 24);
            this.txt_Employee.TabIndex = 8;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(571, 335);
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
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(121, 338);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(62, 19);
            this.bunifuCustomLabel9.TabIndex = 88;
            this.bunifuCustomLabel9.Text = ": الإجمالي";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(292, 300);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(85, 19);
            this.bunifuCustomLabel7.TabIndex = 84;
            this.bunifuCustomLabel7.Text = ": كمية المخزن";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(188, 432);
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
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(291, 335);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(99, 19);
            this.bunifuCustomLabel6.TabIndex = 82;
            this.bunifuCustomLabel6.Text = ": الكمية المطلوبة";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(571, 376);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(80, 19);
            this.bunifuCustomLabel5.TabIndex = 77;
            this.bunifuCustomLabel5.Text = ": رقم التخزين";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(121, 300);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel4.TabIndex = 76;
            this.bunifuCustomLabel4.Text = ": سعر البيع";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(574, 430);
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
            this.bunifuDatepicker2.Location = new System.Drawing.Point(38, 540);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(14, 9, 14, 9);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(318, 31);
            this.bunifuDatepicker2.TabIndex = 73;
            this.bunifuDatepicker2.Value = new System.DateTime(2020, 4, 18, 15, 11, 5, 287);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(8, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 492);
            this.tabControl1.TabIndex = 71;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel5.Controls.Add(this.button1);
            this.bunifuGradientPanel5.Controls.Add(this.BT_EXIT);
            this.bunifuGradientPanel5.Controls.Add(this.BT_CANCEL);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(8, 547);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(674, 50);
            this.bunifuGradientPanel5.TabIndex = 72;
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
            this.button1.Location = new System.Drawing.Point(444, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "بيع جديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BT_EXIT.Location = new System.Drawing.Point(112, 9);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(129, 32);
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
            this.BT_CANCEL.Location = new System.Drawing.Point(278, 9);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(126, 32);
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
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(688, 409);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(397, 188);
            this.bunifuGradientPanel4.TabIndex = 76;
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
            this.BT_PAY.Location = new System.Drawing.Point(263, 13);
            this.BT_PAY.Name = "BT_PAY";
            this.BT_PAY.Size = new System.Drawing.Size(119, 31);
            this.BT_PAY.TabIndex = 0;
            this.BT_PAY.Text = "شراء";
            this.BT_PAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_PAY.UseVisualStyleBackColor = false;
            this.BT_PAY.Click += new System.EventHandler(this.BT_PAY_Click);
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_DATE.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LBL_DATE.ForeColor = System.Drawing.Color.Black;
            this.LBL_DATE.Location = new System.Drawing.Point(-23, 161);
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
            this.BT_PRINT.Location = new System.Drawing.Point(133, 13);
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
            this.LBL_BILL_NO.Location = new System.Drawing.Point(133, 69);
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
            this.label1.Location = new System.Drawing.Point(94, 163);
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
            this.BT_DEL.Location = new System.Drawing.Point(7, 13);
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
            this.label2.Location = new System.Drawing.Point(257, 70);
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
            this.LBL_BILL_PRICE.Location = new System.Drawing.Point(133, 97);
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
            this.label6.Location = new System.Drawing.Point(257, 97);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = ": قيمة الفاتورة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-5, -6);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1097, 52);
            this.bunifuGradientPanel1.TabIndex = 73;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(4, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 41);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(840, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(244, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "نقطة بيع منتجات الموردين";
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-13, 606);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1109, 21);
            this.bunifuGradientPanel2.TabIndex = 74;
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
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(688, 49);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(397, 356);
            this.bunifuGradientPanel3.TabIndex = 75;
            // 
            // LBL_TOTAL_PRICE
            // 
            this.LBL_TOTAL_PRICE.BackColor = System.Drawing.Color.DarkKhaki;
            this.LBL_TOTAL_PRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TOTAL_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_TOTAL_PRICE.ForeColor = System.Drawing.Color.Black;
            this.LBL_TOTAL_PRICE.Location = new System.Drawing.Point(0, 330);
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
            this.label22.Location = new System.Drawing.Point(319, 333);
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
            this.ListView1.Location = new System.Drawing.Point(0, 3);
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
            // frmResource_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResource_POS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResource_POS";
            this.Load += new System.EventHandler(this.frmResource_POS_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouc_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BT_PAY;
        public System.Windows.Forms.Button BT_DEL;
        public System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_EXIT;
        private System.Windows.Forms.Button BT_CANCEL;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        public System.Windows.Forms.Label LBL_DATE;
        private System.Windows.Forms.Button BT_PRINT;
        public System.Windows.Forms.Label LBL_BILL_NO;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LBL_BILL_PRICE;
        private System.Windows.Forms.TabPage tabPage2;
        public Bunifu.Framework.UI.BunifuDatepicker Enterydate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.ComboBox Comb_Name;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Name;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Money;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Quantity;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_QunInStoke;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Note;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Price;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Employee;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private System.Windows.Forms.TabControl tabControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        public System.Windows.Forms.Label LBL_TOTAL_PRICE;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader20;
        internal System.Windows.Forms.ColumnHeader ColumnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader18;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_BarCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public DevExpress.XtraGrid.GridControl dgvRouc_pos;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}