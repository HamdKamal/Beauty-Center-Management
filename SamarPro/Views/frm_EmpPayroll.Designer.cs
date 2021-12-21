namespace SamarPro.Views
{
    partial class frm_EmpPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmpPayroll));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grid_Payroll = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lbl_Net_Salary1 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Net_Salary = new DevExpress.XtraEditors.LabelControl();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_SumOver = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_overMoney = new System.Windows.Forms.TextBox();
            this.txt_overHours = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesPersent = new System.Windows.Forms.TextBox();
            this.TXT_NETBonus = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_SumBonus = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotalBonus = new System.Windows.Forms.Label();
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_AdvMoney = new System.Windows.Forms.TextBox();
            this.txt_AdvHours = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_TotalAdv = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_SumAdv = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_SumDieon = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Paydate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.com_Emp = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Payroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bunifuGradientPanel6.SuspendLayout();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Net_Salary1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grp_1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_text);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-18, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1242, 52);
            this.bunifuGradientPanel1.TabIndex = 57;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(22, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.Color.White;
            this.lbl_text.Location = new System.Drawing.Point(1041, 12);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(180, 31);
            this.lbl_text.TabIndex = 3;
            this.lbl_text.Text = "حســــابـات الرواتب";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.bunifuGradientPanel5);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuGradientPanel6);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuGradientPanel4);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(9, 55);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1183, 599);
            this.bunifuGradientPanel3.TabIndex = 60;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel5.Controls.Add(this.grid_Payroll);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(158, 289);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1015, 302);
            this.bunifuGradientPanel5.TabIndex = 67;
            // 
            // grid_Payroll
            // 
            this.grid_Payroll.DataMember = "TBL_EmpPayRoll";
            this.grid_Payroll.DataSource = this.sqlDataSource1;
            this.grid_Payroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grid_Payroll.Location = new System.Drawing.Point(3, 5);
            this.grid_Payroll.MainView = this.gridView1;
            this.grid_Payroll.Name = "grid_Payroll";
            this.grid_Payroll.Size = new System.Drawing.Size(1005, 292);
            this.grid_Payroll.TabIndex = 68;
            this.grid_Payroll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "TBLempoyees";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "TBLempoyees";
            selectQuery1.Tables.Add(table1);
            column3.Alias = "المعرف";
            columnExpression3.ColumnName = "Id";
            table2.Name = "TBL_EmpPayRoll";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            column4.Alias = "إسم الموظف";
            columnExpression4.ColumnName = "Name";
            table3.Name = "TBLempoyees";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            column5.Alias = "الراتب الأساسي";
            columnExpression5.ColumnName = "Salary";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            column6.Alias = "إجمالي الخصومات";
            columnExpression6.ColumnName = "Set_Total";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            column7.Alias = "إجمالي ع / الأوفر";
            columnExpression7.ColumnName = "Get_Total";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            column8.Alias = "صافي الراتب";
            columnExpression8.ColumnName = "Net_Salary";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            column9.Alias = "تاريخ الدفع";
            columnExpression9.ColumnName = "Date_Pay";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.FilterString = "";
            selectQuery2.GroupFilterString = "";
            selectQuery2.Name = "TBL_EmpPayRoll";
            relationColumnInfo1.NestedKeyColumn = "ID";
            relationColumnInfo1.ParentKeyColumn = "EMP_Id";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table3;
            join1.Parent = table2;
            selectQuery2.Relations.Add(join1);
            selectQuery2.Tables.Add(table2);
            selectQuery2.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
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
            this.gridView1.GridControl = this.grid_Payroll;
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
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel6.Controls.Add(this.grp1);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(5, 3);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(1168, 280);
            this.bunifuGradientPanel6.TabIndex = 66;
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.Color.LightCyan;
            this.grp1.Controls.Add(this.lbl_Net_Salary1);
            this.grp1.Controls.Add(this.lbl_Net_Salary);
            this.grp1.Controls.Add(this.btn_Calculate);
            this.grp1.Controls.Add(this.label11);
            this.grp1.Controls.Add(this.label10);
            this.grp1.Controls.Add(this.label9);
            this.grp1.Controls.Add(this.label8);
            this.grp1.Controls.Add(this.label7);
            this.grp1.Controls.Add(this.label6);
            this.grp1.Controls.Add(this.label5);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.groupBox1);
            this.grp1.Controls.Add(this.grp_1);
            this.grp1.Controls.Add(this.panel3);
            this.grp1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grp1.Location = new System.Drawing.Point(7, 3);
            this.grp1.Name = "grp1";
            this.grp1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp1.Size = new System.Drawing.Size(1154, 267);
            this.grp1.TabIndex = 63;
            this.grp1.TabStop = false;
            this.grp1.Text = "تفاصيل الراتب ... ";
            // 
            // lbl_Net_Salary1
            // 
            this.lbl_Net_Salary1.EditValue = "12.250";
            this.lbl_Net_Salary1.Location = new System.Drawing.Point(14, 232);
            this.lbl_Net_Salary1.Name = "lbl_Net_Salary1";
            this.lbl_Net_Salary1.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Net_Salary1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Net_Salary1.Properties.Appearance.Options.UseBackColor = true;
            this.lbl_Net_Salary1.Properties.Appearance.Options.UseFont = true;
            this.lbl_Net_Salary1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lbl_Net_Salary1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lbl_Net_Salary1.Properties.Mask.BeepOnError = true;
            this.lbl_Net_Salary1.Properties.Mask.EditMask = "c2";
            this.lbl_Net_Salary1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.lbl_Net_Salary1.Properties.ReadOnly = true;
            this.lbl_Net_Salary1.Size = new System.Drawing.Size(125, 26);
            this.lbl_Net_Salary1.TabIndex = 0;
            // 
            // lbl_Net_Salary
            // 
            this.lbl_Net_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Net_Salary.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Net_Salary.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Net_Salary.Appearance.Options.UseBackColor = true;
            this.lbl_Net_Salary.Appearance.Options.UseFont = true;
            this.lbl_Net_Salary.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Net_Salary.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_Net_Salary.Location = new System.Drawing.Point(12, 207);
            this.lbl_Net_Salary.Name = "lbl_Net_Salary";
            this.lbl_Net_Salary.Size = new System.Drawing.Size(111, 0);
            this.lbl_Net_Salary.TabIndex = 136;
            this.lbl_Net_Salary.Text = "10000";
            this.lbl_Net_Salary.Click += new System.EventHandler(this.lbl_Net_Salary_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Calculate.Enabled = false;
            this.btn_Calculate.FlatAppearance.BorderSize = 0;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.btn_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calculate.Image")));
            this.btn_Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Calculate.Location = new System.Drawing.Point(10, 199);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(173, 27);
            this.btn_Calculate.TabIndex = 66;
            this.btn_Calculate.Text = "حساب صافي الراتب";
            this.btn_Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(451, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 23);
            this.label11.TabIndex = 135;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(139, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 134;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(264, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 23);
            this.label9.TabIndex = 133;
            this.label9.Text = "+";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(381, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 132;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(163, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 131;
            this.label7.Text = "إجمالي ع / أوفر";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(296, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = "إجمالي الخصم";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(403, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "الراتب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(478, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "صافي الراتب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 30);
            this.label3.TabIndex = 127;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(564, 179);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  حساب العلاوات و  Over Time ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.bunifuFlatButton2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lbl_TotalBonus);
            this.panel7.Location = new System.Drawing.Point(6, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(549, 152);
            this.panel7.TabIndex = 124;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "حساب العلاوات و الأوفر";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Times New Roman", 5F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(300, 112);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(239, 31);
            this.bunifuFlatButton2.TabIndex = 129;
            this.bunifuFlatButton2.Text = "حساب العلاوات و الأوفر";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txt_SumOver);
            this.panel8.Controls.Add(this.bunifuCustomLabel14);
            this.panel8.Controls.Add(this.txt_overMoney);
            this.panel8.Controls.Add(this.txt_overHours);
            this.panel8.Controls.Add(this.bunifuCustomLabel8);
            this.panel8.Controls.Add(this.bunifuCustomLabel10);
            this.panel8.Location = new System.Drawing.Point(9, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(243, 96);
            this.panel8.TabIndex = 127;
            // 
            // txt_SumOver
            // 
            this.txt_SumOver.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_SumOver.Location = new System.Drawing.Point(5, 63);
            this.txt_SumOver.Multiline = true;
            this.txt_SumOver.Name = "txt_SumOver";
            this.txt_SumOver.ReadOnly = true;
            this.txt_SumOver.Size = new System.Drawing.Size(113, 23);
            this.txt_SumOver.TabIndex = 130;
            this.txt_SumOver.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SumOver_KeyUp);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(121, 65);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(100, 17);
            this.bunifuCustomLabel14.TabIndex = 129;
            this.bunifuCustomLabel14.Text = ": مجموع الأوفر تايم";
            // 
            // txt_overMoney
            // 
            this.txt_overMoney.Enabled = false;
            this.txt_overMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_overMoney.Location = new System.Drawing.Point(6, 6);
            this.txt_overMoney.Multiline = true;
            this.txt_overMoney.Name = "txt_overMoney";
            this.txt_overMoney.Size = new System.Drawing.Size(112, 23);
            this.txt_overMoney.TabIndex = 123;
            this.txt_overMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_overMoney_KeyPress);
            this.txt_overMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_overMoney_KeyUp_1);
            // 
            // txt_overHours
            // 
            this.txt_overHours.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_overHours.Location = new System.Drawing.Point(5, 34);
            this.txt_overHours.Multiline = true;
            this.txt_overHours.Name = "txt_overHours";
            this.txt_overHours.ReadOnly = true;
            this.txt_overHours.Size = new System.Drawing.Size(113, 23);
            this.txt_overHours.TabIndex = 122;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(116, 35);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(90, 19);
            this.bunifuCustomLabel8.TabIndex = 121;
            this.bunifuCustomLabel8.Text = " : عدد الساعات";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(119, 6);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel10.TabIndex = 117;
            this.bunifuCustomLabel10.Text = ": أوفر تايم";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.SalesPersent);
            this.panel9.Controls.Add(this.TXT_NETBonus);
            this.panel9.Controls.Add(this.bunifuCustomLabel13);
            this.panel9.Controls.Add(this.txt_SumBonus);
            this.panel9.Controls.Add(this.bunifuCustomLabel11);
            this.panel9.Controls.Add(this.bunifuCustomLabel12);
            this.panel9.Location = new System.Drawing.Point(300, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(239, 96);
            this.panel9.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesPersent
            // 
            this.SalesPersent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.SalesPersent.Location = new System.Drawing.Point(45, 35);
            this.SalesPersent.Multiline = true;
            this.SalesPersent.Name = "SalesPersent";
            this.SalesPersent.ReadOnly = true;
            this.SalesPersent.Size = new System.Drawing.Size(75, 23);
            this.SalesPersent.TabIndex = 124;
            // 
            // TXT_NETBonus
            // 
            this.TXT_NETBonus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.TXT_NETBonus.Location = new System.Drawing.Point(5, 64);
            this.TXT_NETBonus.Multiline = true;
            this.TXT_NETBonus.Name = "TXT_NETBonus";
            this.TXT_NETBonus.ReadOnly = true;
            this.TXT_NETBonus.Size = new System.Drawing.Size(115, 23);
            this.TXT_NETBonus.TabIndex = 122;
            this.TXT_NETBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(118, 66);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel13.TabIndex = 121;
            this.bunifuCustomLabel13.Text = " : صافي الدخل ";
            // 
            // txt_SumBonus
            // 
            this.txt_SumBonus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_SumBonus.Location = new System.Drawing.Point(5, 6);
            this.txt_SumBonus.Multiline = true;
            this.txt_SumBonus.Name = "txt_SumBonus";
            this.txt_SumBonus.ReadOnly = true;
            this.txt_SumBonus.Size = new System.Drawing.Size(115, 23);
            this.txt_SumBonus.TabIndex = 118;
            this.txt_SumBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(118, 8);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(83, 17);
            this.bunifuCustomLabel11.TabIndex = 114;
            this.bunifuCustomLabel11.Text = " : دخل الموظف ";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(117, 35);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel12.TabIndex = 116;
            this.bunifuCustomLabel12.Text = " : نسبة البيع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 128;
            this.label1.Text = "الإجمالي ع / أوفر :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalBonus
            // 
            this.lbl_TotalBonus.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_TotalBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TotalBonus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalBonus.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalBonus.Location = new System.Drawing.Point(9, 116);
            this.lbl_TotalBonus.Name = "lbl_TotalBonus";
            this.lbl_TotalBonus.Size = new System.Drawing.Size(118, 23);
            this.lbl_TotalBonus.TabIndex = 127;
            this.lbl_TotalBonus.Text = "0";
            this.lbl_TotalBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_1
            // 
            this.grp_1.BackColor = System.Drawing.Color.White;
            this.grp_1.Controls.Add(this.panel4);
            this.grp_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grp_1.Location = new System.Drawing.Point(586, 114);
            this.grp_1.Name = "grp_1";
            this.grp_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_1.Size = new System.Drawing.Size(564, 146);
            this.grp_1.TabIndex = 125;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "حساب الخصومات";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bunifuFlatButton1);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbl_TotalAdv);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(7, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 114);
            this.panel4.TabIndex = 124;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "حساب الخصومات";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(300, 76);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(239, 32);
            this.bunifuFlatButton1.TabIndex = 127;
            this.bunifuFlatButton1.Text = "حساب الخصومات";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(130, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 19);
            this.label22.TabIndex = 126;
            this.label22.Text = " إجمالي الخصم :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_AdvMoney);
            this.panel5.Controls.Add(this.txt_AdvHours);
            this.panel5.Controls.Add(this.bunifuCustomLabel4);
            this.panel5.Controls.Add(this.bunifuCustomLabel5);
            this.panel5.Location = new System.Drawing.Point(9, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 68);
            this.panel5.TabIndex = 124;
            // 
            // txt_AdvMoney
            // 
            this.txt_AdvMoney.Enabled = false;
            this.txt_AdvMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_AdvMoney.Location = new System.Drawing.Point(7, 6);
            this.txt_AdvMoney.Multiline = true;
            this.txt_AdvMoney.Name = "txt_AdvMoney";
            this.txt_AdvMoney.Size = new System.Drawing.Size(112, 23);
            this.txt_AdvMoney.TabIndex = 123;
            this.txt_AdvMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AdvMoney_KeyDown);
            this.txt_AdvMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AdvMoney_KeyPress);
            this.txt_AdvMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_AdvMoney_KeyUp);
            // 
            // txt_AdvHours
            // 
            this.txt_AdvHours.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_AdvHours.Location = new System.Drawing.Point(7, 34);
            this.txt_AdvHours.Multiline = true;
            this.txt_AdvHours.Name = "txt_AdvHours";
            this.txt_AdvHours.ReadOnly = true;
            this.txt_AdvHours.Size = new System.Drawing.Size(112, 23);
            this.txt_AdvHours.TabIndex = 122;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(116, 35);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(98, 19);
            this.bunifuCustomLabel4.TabIndex = 121;
            this.bunifuCustomLabel4.Text = " : ساعات التأخير";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(120, 7);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(79, 19);
            this.bunifuCustomLabel5.TabIndex = 117;
            this.bunifuCustomLabel5.Text = ": مبلغ الخصم";
            // 
            // lbl_TotalAdv
            // 
            this.lbl_TotalAdv.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_TotalAdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TotalAdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalAdv.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalAdv.Location = new System.Drawing.Point(9, 81);
            this.lbl_TotalAdv.Name = "lbl_TotalAdv";
            this.lbl_TotalAdv.Size = new System.Drawing.Size(120, 23);
            this.lbl_TotalAdv.TabIndex = 125;
            this.lbl_TotalAdv.Text = "0";
            this.lbl_TotalAdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txt_SumAdv);
            this.panel6.Controls.Add(this.bunifuCustomLabel6);
            this.panel6.Controls.Add(this.txt_SumDieon);
            this.panel6.Controls.Add(this.bunifuCustomLabel7);
            this.panel6.Location = new System.Drawing.Point(300, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 67);
            this.panel6.TabIndex = 124;
            // 
            // txt_SumAdv
            // 
            this.txt_SumAdv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_SumAdv.Location = new System.Drawing.Point(7, 6);
            this.txt_SumAdv.Multiline = true;
            this.txt_SumAdv.Name = "txt_SumAdv";
            this.txt_SumAdv.ReadOnly = true;
            this.txt_SumAdv.Size = new System.Drawing.Size(113, 23);
            this.txt_SumAdv.TabIndex = 118;
            this.txt_SumAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(119, 8);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(106, 17);
            this.bunifuCustomLabel6.TabIndex = 114;
            this.bunifuCustomLabel6.Text = " : مجموع الخصومات";
            // 
            // txt_SumDieon
            // 
            this.txt_SumDieon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_SumDieon.Location = new System.Drawing.Point(7, 34);
            this.txt_SumDieon.Multiline = true;
            this.txt_SumDieon.Name = "txt_SumDieon";
            this.txt_SumDieon.ReadOnly = true;
            this.txt_SumDieon.Size = new System.Drawing.Size(113, 23);
            this.txt_SumDieon.TabIndex = 117;
            this.txt_SumDieon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(119, 35);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(97, 17);
            this.bunifuCustomLabel7.TabIndex = 116;
            this.bunifuCustomLabel7.Text = " : مجموع السلفيات";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(586, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 83);
            this.panel3.TabIndex = 123;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuDatepicker1);
            this.panel2.Controls.Add(this.Paydate);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Location = new System.Drawing.Point(5, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 65);
            this.panel2.TabIndex = 124;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = "";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(9, 7);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(163, 22);
            this.bunifuDatepicker1.TabIndex = 126;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // Paydate
            // 
            this.Paydate.BackColor = System.Drawing.Color.DodgerBlue;
            this.Paydate.BorderRadius = 0;
            this.Paydate.ForeColor = System.Drawing.Color.White;
            this.Paydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Paydate.FormatCustom = "";
            this.Paydate.Location = new System.Drawing.Point(8, 36);
            this.Paydate.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Paydate.Name = "Paydate";
            this.Paydate.Size = new System.Drawing.Size(163, 23);
            this.Paydate.TabIndex = 125;
            this.Paydate.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            this.Paydate.onValueChanged += new System.EventHandler(this.Paydate_onValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(168, 37);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 19);
            this.bunifuCustomLabel2.TabIndex = 121;
            this.bunifuCustomLabel2.Text = " : إلى";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(174, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(42, 19);
            this.bunifuCustomLabel3.TabIndex = 117;
            this.bunifuCustomLabel3.Text = ": من  ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.com_Emp);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.txt_Salary);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(306, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 65);
            this.panel1.TabIndex = 124;
            // 
            // com_Emp
            // 
            this.com_Emp.DataSource = this.sqlDataSource1;
            this.com_Emp.DisplayMember = "TBLempoyees.Name";
            this.com_Emp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.com_Emp.FormattingEnabled = true;
            this.com_Emp.Location = new System.Drawing.Point(7, 6);
            this.com_Emp.Name = "com_Emp";
            this.com_Emp.Size = new System.Drawing.Size(155, 23);
            this.com_Emp.TabIndex = 115;
            this.com_Emp.ValueMember = "TBLempoyees.ID";
            this.com_Emp.SelectedIndexChanged += new System.EventHandler(this.com_Emp_SelectedIndexChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(158, 7);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(78, 17);
            this.bunifuCustomLabel9.TabIndex = 114;
            this.bunifuCustomLabel9.Text = " : إسم الموظف";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Salary.Location = new System.Drawing.Point(7, 35);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.ReadOnly = true;
            this.txt_Salary.Size = new System.Drawing.Size(155, 23);
            this.txt_Salary.TabIndex = 117;
            this.txt_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(159, 35);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(73, 17);
            this.bunifuCustomLabel1.TabIndex = 116;
            this.bunifuCustomLabel1.Text = " : قيمة الراتب";
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel4.Controls.Add(this.btn_Print);
            this.bunifuGradientPanel4.Controls.Add(this.btn_save);
            this.bunifuGradientPanel4.Controls.Add(this.btn_new);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(5, 289);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(145, 302);
            this.bunifuGradientPanel4.TabIndex = 64;
            // 
            // btn_Print
            // 
            this.btn_Print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.BorderRadius = 5;
            this.btn_Print.ButtonText = "طباعة";
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Print.Enabled = false;
            this.btn_Print.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_Print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Print.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Print.Iconimage")));
            this.btn_Print.Iconimage_right = null;
            this.btn_Print.Iconimage_right_Selected = null;
            this.btn_Print.Iconimage_Selected = null;
            this.btn_Print.IconMarginLeft = 0;
            this.btn_Print.IconMarginRight = 0;
            this.btn_Print.IconRightVisible = true;
            this.btn_Print.IconRightZoom = 0D;
            this.btn_Print.IconVisible = true;
            this.btn_Print.IconZoom = 60D;
            this.btn_Print.IsTab = false;
            this.btn_Print.Location = new System.Drawing.Point(13, 199);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Print.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Print.selected = false;
            this.btn_Print.Size = new System.Drawing.Size(115, 35);
            this.btn_Print.TabIndex = 68;
            this.btn_Print.Text = "طباعة";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.Textcolor = System.Drawing.Color.Black;
            this.btn_Print.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Peru;
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(13, 133);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 38);
            this.btn_save.TabIndex = 67;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.Location = new System.Drawing.Point(13, 67);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(115, 38);
            this.btn_new.TabIndex = 65;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-32, 660);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1256, 18);
            this.bunifuGradientPanel2.TabIndex = 61;
            // 
            // frm_EmpPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 675);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EmpPayroll";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EmpPayroll";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Payroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Net_Salary1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.grp_1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_text;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private System.Windows.Forms.GroupBox grp1;
        public System.Windows.Forms.ComboBox com_Emp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox txt_Salary;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_AdvMoney;
        private System.Windows.Forms.TextBox txt_AdvHours;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_SumAdv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox txt_SumDieon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.GroupBox grp_1;
        public System.Windows.Forms.Label lbl_TotalAdv;
        public System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_SumBonus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.LabelControl lbl_Net_Salary;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_Calculate;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_overMoney;
        private System.Windows.Forms.TextBox txt_overHours;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.TextBox TXT_NETBonus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_TotalBonus;
        private System.Windows.Forms.TextBox txt_SumOver;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        public Bunifu.Framework.UI.BunifuDatepicker Paydate;
        private System.Windows.Forms.TextBox SalesPersent;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private DevExpress.XtraEditors.TextEdit lbl_Net_Salary1;
        public DevExpress.XtraGrid.GridControl grid_Payroll;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Print;
    }
}