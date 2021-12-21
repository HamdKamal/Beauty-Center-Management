namespace SamarPro.Views
{
    partial class ResourceNotify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceNotify));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShow = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colإسمالمورد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colكودالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالكميةالمتبقية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالصلاحية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.com_Name = new System.Windows.Forms.ComboBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lbl_name);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-15, -5);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(845, 56);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(458, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(368, 31);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "تاريخ صلاحية و كمية المنتجات للموردين";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(16, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvShow);
            this.panel1.Location = new System.Drawing.Point(8, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 382);
            this.panel1.TabIndex = 2;
            // 
            // dgvShow
            // 
            this.dgvShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvShow.Location = new System.Drawing.Point(3, 3);
            this.dgvShow.MainView = this.gridView2;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(795, 374);
            this.dgvShow.TabIndex = 68;
            this.dgvShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colإسمالمورد,
            this.colكودالمنتج,
            this.colإسمالمنتج,
            this.colالكميةالمتبقية,
            this.colتاريخالصلاحية});
            this.gridView2.GridControl = this.dgvShow;
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
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colإسمالمورد
            // 
            this.colإسمالمورد.FieldName = "إسم المورد";
            this.colإسمالمورد.Name = "colإسمالمورد";
            this.colإسمالمورد.Visible = true;
            this.colإسمالمورد.VisibleIndex = 0;
            // 
            // colكودالمنتج
            // 
            this.colكودالمنتج.FieldName = "كود المنتج";
            this.colكودالمنتج.Name = "colكودالمنتج";
            this.colكودالمنتج.Visible = true;
            this.colكودالمنتج.VisibleIndex = 1;
            // 
            // colإسمالمنتج
            // 
            this.colإسمالمنتج.FieldName = "إسم المنتج";
            this.colإسمالمنتج.Name = "colإسمالمنتج";
            this.colإسمالمنتج.Visible = true;
            this.colإسمالمنتج.VisibleIndex = 2;
            // 
            // colالكميةالمتبقية
            // 
            this.colالكميةالمتبقية.FieldName = "الكمية المتبقية";
            this.colالكميةالمتبقية.Name = "colالكميةالمتبقية";
            this.colالكميةالمتبقية.Visible = true;
            this.colالكميةالمتبقية.VisibleIndex = 3;
            // 
            // colتاريخالصلاحية
            // 
            this.colتاريخالصلاحية.FieldName = "تاريخ الصلاحية";
            this.colتاريخالصلاحية.Name = "colتاريخالصلاحية";
            this.colتاريخالصلاحية.Visible = true;
            this.colتاريخالصلاحية.VisibleIndex = 4;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-14, 497);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(845, 19);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.com_Name);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Location = new System.Drawing.Point(8, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 43);
            this.panel2.TabIndex = 8;
            // 
            // com_Name
            // 
            this.com_Name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sqlDataSource1, "Resources.Name", true));
            this.com_Name.DataSource = this.sqlDataSource1;
            this.com_Name.DisplayMember = "Resources.Name";
            this.com_Name.FormattingEnabled = true;
            this.com_Name.Location = new System.Drawing.Point(243, 12);
            this.com_Name.Name = "com_Name";
            this.com_Name.Size = new System.Drawing.Size(215, 21);
            this.com_Name.TabIndex = 9;
            this.com_Name.ValueMember = "Resources.ID";
            this.com_Name.SelectedIndexChanged += new System.EventHandler(this.com_Name_SelectedIndexChanged);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Resources";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "Resources";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlJlc291cmNlcyI+PEZpZWxkI" +
    "E5hbWU9IklEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iTmFtZSIgVHlwZT0iU3RyaW5nIiAvP" +
    "jwvVmlldz48L0RhdGFTZXQ+";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(464, 11);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 19);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = ": إسم المورد ";
            // 
            // ResourceNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResourceNotify";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResourceNotify";
            this.Load += new System.EventHandler(this.ResourceNotify_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraGrid.GridControl dgvShow;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox com_Name;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمورد;
        private DevExpress.XtraGrid.Columns.GridColumn colكودالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colالكميةالمتبقية;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالصلاحية;
    }
}