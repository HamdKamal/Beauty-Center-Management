namespace SamarPro.Views
{
    partial class frmReservationLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationLoad));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvResservation = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colكودالحجز = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالعميل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالحجز = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالهاتف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمدفوع = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمتبقي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالخدمة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالسعر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالحجز = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.colإلى = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-7, -29);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1050, 74);
            this.bunifuGradientPanel2.TabIndex = 78;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(448, 34);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(152, 31);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "قائمة الحجوزات";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(10, 30);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel5.Controls.Add(this.dgvResservation);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(5, 51);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1028, 551);
            this.bunifuGradientPanel5.TabIndex = 79;
            // 
            // dgvResservation
            // 
            this.dgvResservation.DataMember = "Query";
            this.dgvResservation.DataSource = this.sqlDataSource1;
            this.dgvResservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvResservation.Location = new System.Drawing.Point(6, 3);
            this.dgvResservation.MainView = this.gridView1;
            this.dgvResservation.Name = "dgvResservation";
            this.dgvResservation.Size = new System.Drawing.Size(1013, 543);
            this.dgvResservation.TabIndex = 66;
            this.dgvResservation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvResservation.Click += new System.EventHandler(this.dgvResservation_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
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
            this.colكودالحجز,
            this.colإسمالعميل,
            this.colتاريخالحجز,
            this.colرقمالهاتف,
            this.colملاحظة,
            this.colالتاريخ,
            this.colالمدفوع,
            this.colالمتبقي,
            this.colإسمالموظف,
            this.colإسمالخدمة,
            this.colالسعر,
            this.colنوعالحجز,
            this.colإلى,
            this.colمن});
            this.gridView1.GridControl = this.dgvResservation;
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
            // colكودالحجز
            // 
            this.colكودالحجز.FieldName = "كود الحجز";
            this.colكودالحجز.Name = "colكودالحجز";
            this.colكودالحجز.Visible = true;
            this.colكودالحجز.VisibleIndex = 0;
            this.colكودالحجز.Width = 76;
            // 
            // colإسمالعميل
            // 
            this.colإسمالعميل.FieldName = "إسم العميل";
            this.colإسمالعميل.Name = "colإسمالعميل";
            this.colإسمالعميل.Visible = true;
            this.colإسمالعميل.VisibleIndex = 6;
            this.colإسمالعميل.Width = 76;
            // 
            // colتاريخالحجز
            // 
            this.colتاريخالحجز.FieldName = "تاريخ الحجز";
            this.colتاريخالحجز.Name = "colتاريخالحجز";
            this.colتاريخالحجز.Visible = true;
            this.colتاريخالحجز.VisibleIndex = 9;
            this.colتاريخالحجز.Width = 76;
            // 
            // colرقمالهاتف
            // 
            this.colرقمالهاتف.FieldName = "رقم الهاتف";
            this.colرقمالهاتف.Name = "colرقمالهاتف";
            this.colرقمالهاتف.Visible = true;
            this.colرقمالهاتف.VisibleIndex = 7;
            this.colرقمالهاتف.Width = 76;
            // 
            // colملاحظة
            // 
            this.colملاحظة.FieldName = "ملاحظة";
            this.colملاحظة.Name = "colملاحظة";
            this.colملاحظة.Visible = true;
            this.colملاحظة.VisibleIndex = 10;
            this.colملاحظة.Width = 125;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            // 
            // colالمدفوع
            // 
            this.colالمدفوع.FieldName = "المدفوع";
            this.colالمدفوع.Name = "colالمدفوع";
            this.colالمدفوع.Visible = true;
            this.colالمدفوع.VisibleIndex = 4;
            this.colالمدفوع.Width = 76;
            // 
            // colالمتبقي
            // 
            this.colالمتبقي.FieldName = "المتبقي";
            this.colالمتبقي.Name = "colالمتبقي";
            this.colالمتبقي.Visible = true;
            this.colالمتبقي.VisibleIndex = 5;
            this.colالمتبقي.Width = 76;
            // 
            // colإسمالموظف
            // 
            this.colإسمالموظف.FieldName = "إسم الموظف";
            this.colإسمالموظف.Name = "colإسمالموظف";
            this.colإسمالموظف.Visible = true;
            this.colإسمالموظف.VisibleIndex = 8;
            this.colإسمالموظف.Width = 76;
            // 
            // colإسمالخدمة
            // 
            this.colإسمالخدمة.FieldName = "إسم الخدمة";
            this.colإسمالخدمة.Name = "colإسمالخدمة";
            this.colإسمالخدمة.Visible = true;
            this.colإسمالخدمة.VisibleIndex = 2;
            this.colإسمالخدمة.Width = 76;
            // 
            // colالسعر
            // 
            this.colالسعر.FieldName = "السعر";
            this.colالسعر.Name = "colالسعر";
            this.colالسعر.Visible = true;
            this.colالسعر.VisibleIndex = 3;
            this.colالسعر.Width = 76;
            // 
            // colنوعالحجز
            // 
            this.colنوعالحجز.FieldName = "نوع الحجز";
            this.colنوعالحجز.Name = "colنوعالحجز";
            this.colنوعالحجز.Visible = true;
            this.colنوعالحجز.VisibleIndex = 1;
            this.colنوعالحجز.Width = 76;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-5, 611);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1087, 29);
            this.bunifuGradientPanel1.TabIndex = 79;
            // 
            // colإلى
            // 
            this.colإلى.FieldName = "إلى";
            this.colإلى.Name = "colإلى";
            this.colإلى.Visible = true;
            this.colإلى.VisibleIndex = 12;
            this.colإلى.Width = 52;
            // 
            // colمن
            // 
            this.colمن.FieldName = "من";
            this.colمن.Name = "colمن";
            this.colمن.Visible = true;
            this.colمن.VisibleIndex = 11;
            this.colمن.Width = 58;
            // 
            // frmReservationLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 623);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservationLoad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservationLoad";
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        public DevExpress.XtraGrid.GridControl dgvResservation;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colكودالحجز;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالعميل;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالحجز;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالهاتف;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
        private DevExpress.XtraGrid.Columns.GridColumn colالمدفوع;
        private DevExpress.XtraGrid.Columns.GridColumn colالمتبقي;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالموظف;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالخدمة;
        private DevExpress.XtraGrid.Columns.GridColumn colالسعر;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالحجز;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colإلى;
        private DevExpress.XtraGrid.Columns.GridColumn colمن;
    }
}