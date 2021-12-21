namespace SamarPro.Views
{
    partial class frmformView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmformView));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvShow = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالباركود = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالإسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالكمية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمراتالإستخدام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالإدخال = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالشراء = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالصلاحية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعرالبيع = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعرالشراء = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمورد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعرالجملة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتخفيض = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالعلاوة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالحالة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel5.Controls.Add(this.dgvShow);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(6, 50);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1081, 543);
            this.bunifuGradientPanel5.TabIndex = 76;
            // 
            // dgvShow
            // 
            this.dgvShow.DataMember = "Products";
            this.dgvShow.DataSource = this.sqlDataSource1;
            this.dgvShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvShow.Location = new System.Drawing.Point(3, 3);
            this.dgvShow.MainView = this.gridView1;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(1071, 535);
            this.dgvShow.TabIndex = 66;
            this.dgvShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvShow.Click += new System.EventHandler(this.dgvShow_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Products";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
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
            this.colرقمالمنتج,
            this.colالباركود,
            this.colالإسم,
            this.colالكمية,
            this.colمراتالإستخدام,
            this.colتاريخالإدخال,
            this.colتاريخالشراء,
            this.colتاريخالصلاحية,
            this.colسعرالبيع,
            this.colسعرالشراء,
            this.colإسمالمورد,
            this.colنوعالمنتج,
            this.colسعرالجملة,
            this.colالتخفيض,
            this.colالعلاوة,
            this.colالحالة});
            this.gridView1.GridControl = this.dgvShow;
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
            // colرقمالمنتج
            // 
            this.colرقمالمنتج.FieldName = "رقم المنتج";
            this.colرقمالمنتج.Name = "colرقمالمنتج";
            // 
            // colالباركود
            // 
            this.colالباركود.FieldName = "الباركود";
            this.colالباركود.Name = "colالباركود";
            this.colالباركود.Visible = true;
            this.colالباركود.VisibleIndex = 0;
            // 
            // colالإسم
            // 
            this.colالإسم.FieldName = "الإسم";
            this.colالإسم.Name = "colالإسم";
            this.colالإسم.Visible = true;
            this.colالإسم.VisibleIndex = 1;
            // 
            // colالكمية
            // 
            this.colالكمية.FieldName = "الكمية";
            this.colالكمية.Name = "colالكمية";
            this.colالكمية.Visible = true;
            this.colالكمية.VisibleIndex = 3;
            // 
            // colمراتالإستخدام
            // 
            this.colمراتالإستخدام.FieldName = "مرات الإستخدام";
            this.colمراتالإستخدام.Name = "colمراتالإستخدام";
            this.colمراتالإستخدام.Visible = true;
            this.colمراتالإستخدام.VisibleIndex = 6;
            // 
            // colتاريخالإدخال
            // 
            this.colتاريخالإدخال.FieldName = "تاريخ الإدخال";
            this.colتاريخالإدخال.Name = "colتاريخالإدخال";
            // 
            // colتاريخالشراء
            // 
            this.colتاريخالشراء.FieldName = "تاريخ الشراء";
            this.colتاريخالشراء.Name = "colتاريخالشراء";
            this.colتاريخالشراء.Visible = true;
            this.colتاريخالشراء.VisibleIndex = 8;
            // 
            // colتاريخالصلاحية
            // 
            this.colتاريخالصلاحية.FieldName = "تاريخ الصلاحية";
            this.colتاريخالصلاحية.Name = "colتاريخالصلاحية";
            this.colتاريخالصلاحية.Visible = true;
            this.colتاريخالصلاحية.VisibleIndex = 9;
            // 
            // colسعرالبيع
            // 
            this.colسعرالبيع.FieldName = "سعر البيع";
            this.colسعرالبيع.Name = "colسعرالبيع";
            this.colسعرالبيع.Visible = true;
            this.colسعرالبيع.VisibleIndex = 5;
            // 
            // colسعرالشراء
            // 
            this.colسعرالشراء.FieldName = "سعر الشراء";
            this.colسعرالشراء.Name = "colسعرالشراء";
            this.colسعرالشراء.Visible = true;
            this.colسعرالشراء.VisibleIndex = 4;
            // 
            // colإسمالمورد
            // 
            this.colإسمالمورد.FieldName = "إسم المسوق";
            this.colإسمالمورد.Name = "colإسمالمورد";
            this.colإسمالمورد.Visible = true;
            this.colإسمالمورد.VisibleIndex = 7;
            // 
            // colنوعالمنتج
            // 
            this.colنوعالمنتج.FieldName = "نوع المنتج";
            this.colنوعالمنتج.Name = "colنوعالمنتج";
            this.colنوعالمنتج.Visible = true;
            this.colنوعالمنتج.VisibleIndex = 2;
            // 
            // colسعرالجملة
            // 
            this.colسعرالجملة.FieldName = "سعر الجملة";
            this.colسعرالجملة.Name = "colسعرالجملة";
            this.colسعرالجملة.Visible = true;
            this.colسعرالجملة.VisibleIndex = 10;
            // 
            // colالتخفيض
            // 
            this.colالتخفيض.FieldName = "التخفيض";
            this.colالتخفيض.Name = "colالتخفيض";
            this.colالتخفيض.Visible = true;
            this.colالتخفيض.VisibleIndex = 11;
            // 
            // colالعلاوة
            // 
            this.colالعلاوة.FieldName = "العلاوة";
            this.colالعلاوة.Name = "colالعلاوة";
            this.colالعلاوة.Visible = true;
            this.colالعلاوة.VisibleIndex = 12;
            // 
            // colالحالة
            // 
            this.colالحالة.FieldName = "الحالة";
            this.colالحالة.Name = "colالحالة";
            this.colالحالة.Visible = true;
            this.colالحالة.VisibleIndex = 13;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "db_model";
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel2.Controls.Add(this.lbl_name);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-19, -30);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1120, 74);
            this.bunifuGradientPanel2.TabIndex = 77;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(74, 32);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(75, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(847, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(139, 31);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "قائمة المنتجات";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(10, 32);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-9, 600);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1110, 52);
            this.bunifuGradientPanel1.TabIndex = 78;
            // 
            // frmformView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 614);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmformView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmformView";
            this.Load += new System.EventHandler(this.frmformView_Load);
            this.bunifuGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        public DevExpress.XtraGrid.GridControl dgvShow;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colالباركود;
        private DevExpress.XtraGrid.Columns.GridColumn colالإسم;
        private DevExpress.XtraGrid.Columns.GridColumn colالكمية;
        private DevExpress.XtraGrid.Columns.GridColumn colمراتالإستخدام;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالإدخال;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالشراء;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالصلاحية;
        private DevExpress.XtraGrid.Columns.GridColumn colسعرالبيع;
        private DevExpress.XtraGrid.Columns.GridColumn colسعرالشراء;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمورد;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالمنتج;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colسعرالجملة;
        private DevExpress.XtraGrid.Columns.GridColumn colالتخفيض;
        private DevExpress.XtraGrid.Columns.GridColumn colالعلاوة;
        private DevExpress.XtraGrid.Columns.GridColumn colالحالة;
    }
}