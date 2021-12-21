namespace SamarPro
{
    partial class frmAttendance
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
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Attend = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colالمعرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colبدايةالدوام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمنالحضور = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنهايةالدوام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمنالإنصراف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالحالة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.C_YEAR = new System.Windows.Forms.ComboBox();
            this.C_DAY = new System.Windows.Forms.ComboBox();
            this.C_MONTH = new System.Windows.Forms.ComboBox();
            this.lbl_Start = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.com_Emp = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.S_work = new DevExpress.XtraEditors.TimeEdit();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_new = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grp_1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_work.Properties)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-6, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(635, 39);
            this.bunifuGradientPanel1.TabIndex = 67;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(496, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 26);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "نافذة الحضور";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(6, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 36);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(782, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(196, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "الحضور و الإنصراف";
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-18, 686);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1012, 25);
            this.bunifuGradientPanel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_Attend);
            this.panel1.Location = new System.Drawing.Point(7, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 393);
            this.panel1.TabIndex = 69;
            // 
            // dgv_Attend
            // 
            this.dgv_Attend.DataMember = "TBL_Attendance";
            this.dgv_Attend.DataSource = this.sqlDataSource1;
            this.dgv_Attend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgv_Attend.Location = new System.Drawing.Point(4, 5);
            this.dgv_Attend.MainView = this.gridView1;
            this.dgv_Attend.Name = "dgv_Attend";
            this.dgv_Attend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Attend.Size = new System.Drawing.Size(589, 381);
            this.dgv_Attend.TabIndex = 67;
            this.dgv_Attend.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_Attend.Click += new System.EventHandler(this.dgv_Attend_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "المعرف";
            columnExpression1.ColumnName = "Id";
            table1.Name = "TBL_Attendance";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم الموظف";
            columnExpression2.ColumnName = "Name";
            table2.Name = "TBLempoyees";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            column3.Alias = "بداية الدوام";
            columnExpression3.ColumnName = "Entery_Date";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "زمن الحضور";
            columnExpression4.ColumnName = "Attend_Time";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "نهاية الدوام";
            columnExpression5.ColumnName = "Lave_Date";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            column6.Alias = "زمن الإنصراف";
            columnExpression6.ColumnName = "Lave_Time";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            column7.Alias = "الحالة";
            columnExpression7.ColumnName = "Status";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            column8.Alias = "EMP_ID";
            columnExpression8.ColumnName = "EmpID";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.FilterString = "";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "TBL_Attendance";
            relationColumnInfo1.NestedKeyColumn = "ID";
            relationColumnInfo1.ParentKeyColumn = "EmpID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            columnExpression9.ColumnName = "ID";
            table3.Name = "TBLempoyees";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Name";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Name = "TBLempoyees";
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colالمعرف,
            this.colإسمالموظف,
            this.colبدايةالدوام,
            this.colزمنالحضور,
            this.colنهايةالدوام,
            this.colزمنالإنصراف,
            this.colالحالة,
            this.colEMP_ID});
            this.gridView1.GridControl = this.dgv_Attend;
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
            // colالمعرف
            // 
            this.colالمعرف.FieldName = "المعرف";
            this.colالمعرف.Name = "colالمعرف";
            this.colالمعرف.Visible = true;
            this.colالمعرف.VisibleIndex = 0;
            this.colالمعرف.Width = 52;
            // 
            // colإسمالموظف
            // 
            this.colإسمالموظف.FieldName = "إسم الموظف";
            this.colإسمالموظف.Name = "colإسمالموظف";
            this.colإسمالموظف.Visible = true;
            this.colإسمالموظف.VisibleIndex = 1;
            this.colإسمالموظف.Width = 105;
            // 
            // colبدايةالدوام
            // 
            this.colبدايةالدوام.DisplayFormat.FormatString = "d";
            this.colبدايةالدوام.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colبدايةالدوام.FieldName = "بداية الدوام";
            this.colبدايةالدوام.Name = "colبدايةالدوام";
            this.colبدايةالدوام.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colبدايةالدوام.Visible = true;
            this.colبدايةالدوام.VisibleIndex = 2;
            this.colبدايةالدوام.Width = 91;
            // 
            // colزمنالحضور
            // 
            this.colزمنالحضور.DisplayFormat.FormatString = "d";
            this.colزمنالحضور.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colزمنالحضور.FieldName = "زمن الحضور";
            this.colزمنالحضور.Name = "colزمنالحضور";
            this.colزمنالحضور.Visible = true;
            this.colزمنالحضور.VisibleIndex = 3;
            this.colزمنالحضور.Width = 93;
            // 
            // colنهايةالدوام
            // 
            this.colنهايةالدوام.DisplayFormat.FormatString = "d";
            this.colنهايةالدوام.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colنهايةالدوام.FieldName = "نهاية الدوام";
            this.colنهايةالدوام.Name = "colنهايةالدوام";
            this.colنهايةالدوام.Visible = true;
            this.colنهايةالدوام.VisibleIndex = 4;
            this.colنهايةالدوام.Width = 94;
            // 
            // colزمنالإنصراف
            // 
            this.colزمنالإنصراف.DisplayFormat.FormatString = "d";
            this.colزمنالإنصراف.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colزمنالإنصراف.FieldName = "زمن الإنصراف";
            this.colزمنالإنصراف.Name = "colزمنالإنصراف";
            this.colزمنالإنصراف.Visible = true;
            this.colزمنالإنصراف.VisibleIndex = 5;
            this.colزمنالإنصراف.Width = 86;
            // 
            // colالحالة
            // 
            this.colالحالة.FieldName = "الحالة";
            this.colالحالة.Name = "colالحالة";
            this.colالحالة.Visible = true;
            this.colالحالة.VisibleIndex = 6;
            this.colالحالة.Width = 50;
            // 
            // colEMP_ID
            // 
            this.colEMP_ID.FieldName = "EMP_ID";
            this.colEMP_ID.Name = "colEMP_ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grp_1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel2.Location = new System.Drawing.Point(7, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 140);
            this.panel2.TabIndex = 70;
            // 
            // grp_1
            // 
            this.grp_1.BackColor = System.Drawing.Color.White;
            this.grp_1.Controls.Add(this.panel3);
            this.grp_1.Controls.Add(this.lbl_Start);
            this.grp_1.Controls.Add(this.com_Emp);
            this.grp_1.Controls.Add(this.bunifuCustomLabel9);
            this.grp_1.Controls.Add(this.S_work);
            this.grp_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grp_1.Location = new System.Drawing.Point(4, 6);
            this.grp_1.Name = "grp_1";
            this.grp_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_1.Size = new System.Drawing.Size(589, 130);
            this.grp_1.TabIndex = 0;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "تسجيل الحضور و الإنصراف ...";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.C_YEAR);
            this.panel3.Controls.Add(this.C_DAY);
            this.panel3.Controls.Add(this.C_MONTH);
            this.panel3.Location = new System.Drawing.Point(18, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 61);
            this.panel3.TabIndex = 122;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "الأحد",
            "الإثنين",
            "الثلاثاء",
            "الأربعاء",
            "الخميس",
            "الجمعة",
            "السبت"});
            this.comboBox1.Location = new System.Drawing.Point(12, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 23);
            this.comboBox1.TabIndex = 121;
            this.comboBox1.Text = "...";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(87, 7);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(79, 19);
            this.bunifuCustomLabel3.TabIndex = 117;
            this.bunifuCustomLabel3.Text = " : تاريخ اليوم";
            // 
            // C_YEAR
            // 
            this.C_YEAR.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.C_YEAR.FormattingEnabled = true;
            this.C_YEAR.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.C_YEAR.Location = new System.Drawing.Point(120, 32);
            this.C_YEAR.Name = "C_YEAR";
            this.C_YEAR.Size = new System.Drawing.Size(47, 23);
            this.C_YEAR.TabIndex = 120;
            this.C_YEAR.Text = "Year";
            // 
            // C_DAY
            // 
            this.C_DAY.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.C_DAY.FormattingEnabled = true;
            this.C_DAY.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.C_DAY.Location = new System.Drawing.Point(12, 32);
            this.C_DAY.Name = "C_DAY";
            this.C_DAY.Size = new System.Drawing.Size(47, 23);
            this.C_DAY.TabIndex = 118;
            this.C_DAY.Text = "Day";
            // 
            // C_MONTH
            // 
            this.C_MONTH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.C_MONTH.FormattingEnabled = true;
            this.C_MONTH.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.C_MONTH.Location = new System.Drawing.Point(60, 32);
            this.C_MONTH.Name = "C_MONTH";
            this.C_MONTH.Size = new System.Drawing.Size(59, 23);
            this.C_MONTH.TabIndex = 119;
            this.C_MONTH.Text = "Month";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Start.Location = new System.Drawing.Point(468, 82);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Start.Size = new System.Drawing.Size(80, 19);
            this.lbl_Start.TabIndex = 114;
            this.lbl_Start.Text = ": بداية الدوام ";
            // 
            // com_Emp
            // 
            this.com_Emp.DataSource = this.sqlDataSource1;
            this.com_Emp.DisplayMember = "TBLempoyees.Name";
            this.com_Emp.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.com_Emp.FormattingEnabled = true;
            this.com_Emp.Location = new System.Drawing.Point(286, 44);
            this.com_Emp.Name = "com_Emp";
            this.com_Emp.Size = new System.Drawing.Size(179, 23);
            this.com_Emp.TabIndex = 113;
            this.com_Emp.ValueMember = "TBLempoyees.ID";
            this.com_Emp.SelectedIndexChanged += new System.EventHandler(this.com_Emp_SelectedIndexChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(464, 44);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(88, 19);
            this.bunifuCustomLabel9.TabIndex = 112;
            this.bunifuCustomLabel9.Text = " : إسم الموظف";
            // 
            // S_work
            // 
            this.S_work.EditValue = new System.DateTime(2020, 6, 7, 0, 0, 0, 0);
            this.S_work.Location = new System.Drawing.Point(286, 85);
            this.S_work.Name = "S_work";
            this.S_work.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.S_work.Properties.Mask.BeepOnError = true;
            this.S_work.Properties.Mask.EditMask = "g";
            this.S_work.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.S_work.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.S_work.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.S_work.Size = new System.Drawing.Size(179, 20);
            this.S_work.TabIndex = 116;
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_edit.BackColor = System.Drawing.Color.Teal;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 5;
            this.btn_edit.ButtonText = "حـــــــــــــفظ";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_edit.Iconimage")));
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
            this.btn_edit.Location = new System.Drawing.Point(22, 4);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.Teal;
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(242, 35);
            this.btn_edit.TabIndex = 119;
            this.btn_edit.Text = "حـــــــــــــفظ";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.Black;
            this.btn_edit.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.BorderRadius = 5;
            this.btn_new.ButtonText = "جديد";
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.DisabledColor = System.Drawing.Color.Gray;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_new.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new.Iconimage = global::SamarPro.Properties.Resources.إضافةالأصنافToolStripMenuItem_Image;
            this.btn_new.Iconimage_right = null;
            this.btn_new.Iconimage_right_Selected = null;
            this.btn_new.Iconimage_Selected = null;
            this.btn_new.IconMarginLeft = 0;
            this.btn_new.IconMarginRight = 0;
            this.btn_new.IconRightVisible = true;
            this.btn_new.IconRightZoom = 0D;
            this.btn_new.IconVisible = true;
            this.btn_new.IconZoom = 60D;
            this.btn_new.IsTab = false;
            this.btn_new.Location = new System.Drawing.Point(419, 5);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.DarkCyan;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(80, 35);
            this.btn_new.TabIndex = 118;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Textcolor = System.Drawing.Color.Black;
            this.btn_new.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.btn_edit);
            this.bunifuGradientPanel3.Controls.Add(this.btn_new);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(7, 234);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(598, 46);
            this.bunifuGradientPanel3.TabIndex = 73;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel4.Controls.Add(this.radioButton2);
            this.bunifuGradientPanel4.Controls.Add(this.radioButton1);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(7, 43);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(598, 39);
            this.bunifuGradientPanel4.TabIndex = 74;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(159, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 23);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "الإنصراف";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(380, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 23);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "الحضور";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 702);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "         ";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_work.Properties)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public DevExpress.XtraGrid.GridControl dgv_Attend;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox grp_1;
        public System.Windows.Forms.ComboBox com_Emp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Start;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colالمعرف;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالموظف;
        private DevExpress.XtraGrid.Columns.GridColumn colبدايةالدوام;
        private DevExpress.XtraGrid.Columns.GridColumn colزمنالحضور;
        private DevExpress.XtraGrid.Columns.GridColumn colزمنالإنصراف;
        private DevExpress.XtraGrid.Columns.GridColumn colالحالة;
        private DevExpress.XtraEditors.TimeEdit S_work;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox C_DAY;
        private System.Windows.Forms.ComboBox C_YEAR;
        private System.Windows.Forms.ComboBox C_MONTH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        public DevExpress.XtraGrid.Columns.GridColumn colنهايةالدوام;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID;
    }
}