namespace SamarPro.Views
{
    partial class FRM_BOX
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
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BOX));
            this.dgvRes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNote = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_new = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DayDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.combo_Res = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colالمعرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمورد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالشكوى = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bunifuGradientPanel8.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRes
            // 
            this.dgvRes.DataMember = "THE_BOX";
            this.dgvRes.DataSource = this.sqlDataSource1;
            this.dgvRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvRes.Location = new System.Drawing.Point(4, 3);
            this.dgvRes.MainView = this.gridView1;
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.Size = new System.Drawing.Size(678, 515);
            this.dgvRes.TabIndex = 67;
            this.dgvRes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colإسمالمنتج,
            this.colإسمالمورد,
            this.colالتاريخ,
            this.colالشكوى});
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
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(708, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(908, 75);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel2.TabIndex = 121;
            this.bunifuCustomLabel2.Text = "إسم المنتج :";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderColor = System.Drawing.Color.Black;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(708, 154);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(196, 242);
            this.txtNote.TabIndex = 4;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(909, 155);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 19);
            this.bunifuCustomLabel5.TabIndex = 116;
            this.bunifuCustomLabel5.Text = "الشكوى :";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(908, 39);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel14.TabIndex = 110;
            this.bunifuCustomLabel14.Text = "إسم المورد :";
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
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel6.Controls.Add(this.panel1);
            this.bunifuGradientPanel6.Controls.Add(this.DayDate);
            this.bunifuGradientPanel6.Controls.Add(this.combo_Res);
            this.bunifuGradientPanel6.Controls.Add(this.txtName);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel6.Controls.Add(this.txtNote);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel15);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel14);
            this.bunifuGradientPanel6.Controls.Add(this.bunifuGradientPanel8);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(5, 60);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(987, 531);
            this.bunifuGradientPanel6.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(710, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 58);
            this.panel1.TabIndex = 124;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 5;
            this.btn_save.ButtonText = "حفظ";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
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
            this.btn_save.Location = new System.Drawing.Point(22, 15);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(101, 25);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.Black;
            this.btn_save.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.BorderRadius = 5;
            this.btn_new.ButtonText = "جديد";
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_new.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_new.Iconimage")));
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
            this.btn_new.Location = new System.Drawing.Point(134, 15);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(101, 25);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Textcolor = System.Drawing.Color.Black;
            this.btn_new.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // DayDate
            // 
            this.DayDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.DayDate.BorderRadius = 0;
            this.DayDate.ForeColor = System.Drawing.Color.White;
            this.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DayDate.FormatCustom = "";
            this.DayDate.Location = new System.Drawing.Point(708, 113);
            this.DayDate.Margin = new System.Windows.Forms.Padding(6);
            this.DayDate.Name = "DayDate";
            this.DayDate.Size = new System.Drawing.Size(196, 23);
            this.DayDate.TabIndex = 123;
            this.DayDate.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // combo_Res
            // 
            this.combo_Res.DataSource = this.sqlDataSource1;
            this.combo_Res.DisplayMember = "Resources.Name";
            this.combo_Res.FormattingEnabled = true;
            this.combo_Res.Location = new System.Drawing.Point(708, 40);
            this.combo_Res.Name = "combo_Res";
            this.combo_Res.Size = new System.Drawing.Size(196, 21);
            this.combo_Res.TabIndex = 122;
            this.combo_Res.ValueMember = "Resources.ID";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(908, 113);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(54, 19);
            this.bunifuCustomLabel15.TabIndex = 112;
            this.bunifuCustomLabel15.Text = "التاريخ :";
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-4, 600);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1007, 24);
            this.bunifuGradientPanel2.TabIndex = 65;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(7, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 46);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(802, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(195, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "الشكاوي والمقترحات";
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-8, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1007, 52);
            this.bunifuGradientPanel1.TabIndex = 64;
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
            column3.Alias = "المعرف";
            columnExpression3.ColumnName = "ID";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"153\" />";
            table2.Name = "THE_BOX";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            column4.Alias = "إسم المورد";
            columnExpression4.ColumnName = "RES_NAME";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            column5.Alias = "إسم المنتج";
            columnExpression5.ColumnName = "PRD_NAME";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            column6.Alias = "الشكوى";
            columnExpression6.ColumnName = "NOTE";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            column7.Alias = "التاريخ";
            columnExpression7.ColumnName = "N_DATE";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Name = "THE_BOX";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colالمعرف
            // 
            this.colالمعرف.FieldName = "المعرف";
            this.colالمعرف.Name = "colالمعرف";
            this.colالمعرف.Visible = true;
            this.colالمعرف.VisibleIndex = 0;
            this.colالمعرف.Width = 65;
            // 
            // colإسمالمنتج
            // 
            this.colإسمالمنتج.FieldName = "إسم المنتج";
            this.colإسمالمنتج.Name = "colإسمالمنتج";
            this.colإسمالمنتج.Visible = true;
            this.colإسمالمنتج.VisibleIndex = 1;
            this.colإسمالمنتج.Width = 122;
            // 
            // colإسمالمورد
            // 
            this.colإسمالمورد.FieldName = "إسم المورد";
            this.colإسمالمورد.Name = "colإسمالمورد";
            this.colإسمالمورد.Visible = true;
            this.colإسمالمورد.VisibleIndex = 2;
            this.colإسمالمورد.Width = 133;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            this.colالتاريخ.Visible = true;
            this.colالتاريخ.VisibleIndex = 4;
            this.colالتاريخ.Width = 72;
            // 
            // colالشكوى
            // 
            this.colالشكوى.FieldName = "الشكوى";
            this.colالشكوى.Name = "colالشكوى";
            this.colالشكوى.Visible = true;
            this.colالشكوى.VisibleIndex = 3;
            this.colالشكوى.Width = 268;
            // 
            // FRM_BOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 611);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BOX";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_BOX";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bunifuGradientPanel8.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl dgvRes;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNote;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public System.Windows.Forms.ComboBox combo_Res;
        public Bunifu.Framework.UI.BunifuDatepicker DayDate;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_save;
        public Bunifu.Framework.UI.BunifuFlatButton btn_new;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colالمعرف;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمورد;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
        private DevExpress.XtraGrid.Columns.GridColumn colالشكوى;
    }
}