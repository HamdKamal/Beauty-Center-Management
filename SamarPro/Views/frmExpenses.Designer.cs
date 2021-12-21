namespace SamarPro.Views
{
    partial class frmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpenses));
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_del = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_new = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtprice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNote = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_1 = new System.Windows.Forms.GroupBox();
            this.Com_Emp = new System.Windows.Forms.ComboBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lbl_Emp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.Paydate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvShow = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالصرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالصرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالصرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.pnl_1.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-10, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(884, 52);
            this.bunifuGradientPanel1.TabIndex = 60;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(10, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 51);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(682, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(173, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "فواتير المصروفات";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.btn_del);
            this.bunifuGradientPanel3.Controls.Add(this.btn_edit);
            this.bunifuGradientPanel3.Controls.Add(this.btn_save);
            this.bunifuGradientPanel3.Controls.Add(this.btn_new);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(10, 67);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(138, 267);
            this.bunifuGradientPanel3.TabIndex = 1;
            // 
            // btn_del
            // 
            this.btn_del.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.BorderRadius = 5;
            this.btn_del.ButtonText = "حذف";
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.DisabledColor = System.Drawing.Color.Gray;
            this.btn_del.Enabled = false;
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btn_del.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_del.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_del.Iconimage")));
            this.btn_del.Iconimage_right = null;
            this.btn_del.Iconimage_right_Selected = null;
            this.btn_del.Iconimage_Selected = null;
            this.btn_del.IconMarginLeft = 0;
            this.btn_del.IconMarginRight = 0;
            this.btn_del.IconRightVisible = true;
            this.btn_del.IconRightZoom = 0D;
            this.btn_del.IconVisible = true;
            this.btn_del.IconZoom = 60D;
            this.btn_del.IsTab = false;
            this.btn_del.Location = new System.Drawing.Point(18, 220);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_del.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_del.selected = false;
            this.btn_del.Size = new System.Drawing.Size(101, 35);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "حذف";
            this.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del.Textcolor = System.Drawing.Color.Black;
            this.btn_del.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_edit.BackColor = System.Drawing.Color.Teal;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 5;
            this.btn_edit.ButtonText = "تعديل";
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
            this.btn_edit.Location = new System.Drawing.Point(18, 154);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.Teal;
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(101, 35);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.Black;
            this.btn_edit.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_save.Location = new System.Drawing.Point(18, 87);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(101, 35);
            this.btn_save.TabIndex = 1;
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
            this.btn_new.Location = new System.Drawing.Point(18, 18);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(101, 35);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Textcolor = System.Drawing.Color.Black;
            this.btn_new.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-11, 694);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(896, 25);
            this.bunifuGradientPanel2.TabIndex = 61;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(579, 47);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 19);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = ": نوع المنصرف";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(579, 101);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 19);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = ": المبلغ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(579, 205);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(57, 19);
            this.bunifuCustomLabel5.TabIndex = 3;
            this.bunifuCustomLabel5.Text = ": ملاحظة";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderColor = System.Drawing.Color.Black;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(341, 100);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(232, 26);
            this.txtprice.TabIndex = 2;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderColor = System.Drawing.Color.Black;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(33, 208);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(540, 53);
            this.txtNote.TabIndex = 4;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(578, 154);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(89, 19);
            this.bunifuCustomLabel8.TabIndex = 11;
            this.bunifuCustomLabel8.Text = ": تاريخ الصرف";
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.White;
            this.pnl_1.Controls.Add(this.Com_Emp);
            this.pnl_1.Controls.Add(this.lbl_Emp);
            this.pnl_1.Controls.Add(this.txtType);
            this.pnl_1.Controls.Add(this.Paydate);
            this.pnl_1.Controls.Add(this.bunifuCustomLabel8);
            this.pnl_1.Controls.Add(this.txtNote);
            this.pnl_1.Controls.Add(this.txtprice);
            this.pnl_1.Controls.Add(this.bunifuCustomLabel5);
            this.pnl_1.Controls.Add(this.bunifuCustomLabel3);
            this.pnl_1.Controls.Add(this.bunifuCustomLabel2);
            this.pnl_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.pnl_1.Location = new System.Drawing.Point(154, 58);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnl_1.Size = new System.Drawing.Size(701, 277);
            this.pnl_1.TabIndex = 0;
            this.pnl_1.TabStop = false;
            this.pnl_1.Text = "بيانات الفاتورة";
            // 
            // Com_Emp
            // 
            this.Com_Emp.DataSource = this.sqlDataSource1;
            this.Com_Emp.DisplayMember = "TBLempoyees.Name";
            this.Com_Emp.FormattingEnabled = true;
            this.Com_Emp.Location = new System.Drawing.Point(33, 47);
            this.Com_Emp.Name = "Com_Emp";
            this.Com_Emp.Size = new System.Drawing.Size(198, 27);
            this.Com_Emp.TabIndex = 1;
            this.Com_Emp.ValueMember = "TBLempoyees.ID";
            this.Com_Emp.Visible = false;
            this.Com_Emp.SelectedIndexChanged += new System.EventHandler(this.Com_Emp_SelectedIndexChanged);
            this.Com_Emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Com_Emp_KeyPress);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف الصرف";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Expenses";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "نوع الصرف";
            columnExpression2.ColumnName = "Type";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "المبلغ";
            columnExpression3.ColumnName = "Money";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "تاريخ الصرف";
            columnExpression4.ColumnName = "E_date";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "ملاحظة";
            columnExpression5.ColumnName = "Note";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "Expenses";
            selectQuery1.Tables.Add(table1);
            columnExpression6.ColumnName = "ID";
            table2.Name = "TBLempoyees";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Name";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Name = "TBLempoyees";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // lbl_Emp
            // 
            this.lbl_Emp.AutoSize = true;
            this.lbl_Emp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Emp.Location = new System.Drawing.Point(238, 50);
            this.lbl_Emp.Name = "lbl_Emp";
            this.lbl_Emp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Emp.Size = new System.Drawing.Size(84, 19);
            this.lbl_Emp.TabIndex = 121;
            this.lbl_Emp.Text = ": إسم الموظف";
            this.lbl_Emp.Visible = false;
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "شراء بضاعة (فاتورة شرائية)",
            "مصروفات محل",
            "سلفية موظف",
            "إيجار",
            "فاتورة كهرباء",
            "صيانة معدات",
            "دفعات رواتب"});
            this.txtType.Location = new System.Drawing.Point(341, 47);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(232, 27);
            this.txtType.TabIndex = 0;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtType_KeyDown);
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // Paydate
            // 
            this.Paydate.BackColor = System.Drawing.Color.DodgerBlue;
            this.Paydate.BorderRadius = 0;
            this.Paydate.ForeColor = System.Drawing.Color.White;
            this.Paydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Paydate.FormatCustom = "";
            this.Paydate.Location = new System.Drawing.Point(341, 154);
            this.Paydate.Margin = new System.Windows.Forms.Padding(6);
            this.Paydate.Name = "Paydate";
            this.Paydate.Size = new System.Drawing.Size(232, 26);
            this.Paydate.TabIndex = 3;
            this.Paydate.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
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
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(10, 341);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(845, 347);
            this.bunifuGradientPanel5.TabIndex = 76;
            // 
            // dgvShow
            // 
            this.dgvShow.DataMember = "Expenses";
            this.dgvShow.DataSource = this.sqlDataSource1;
            this.dgvShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgvShow.Location = new System.Drawing.Point(4, 3);
            this.dgvShow.MainView = this.gridView2;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(836, 339);
            this.dgvShow.TabIndex = 66;
            this.dgvShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgvShow.Click += new System.EventHandler(this.dgvShow_Click);
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
            this.colمعرفالصرف,
            this.colنوعالصرف,
            this.colالمبلغ,
            this.colتاريخالصرف,
            this.colملاحظة});
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
            // colمعرفالصرف
            // 
            this.colمعرفالصرف.FieldName = "معرف الصرف";
            this.colمعرفالصرف.Name = "colمعرفالصرف";
            this.colمعرفالصرف.Visible = true;
            this.colمعرفالصرف.VisibleIndex = 0;
            // 
            // colنوعالصرف
            // 
            this.colنوعالصرف.FieldName = "نوع الصرف";
            this.colنوعالصرف.Name = "colنوعالصرف";
            this.colنوعالصرف.Visible = true;
            this.colنوعالصرف.VisibleIndex = 1;
            // 
            // colالمبلغ
            // 
            this.colالمبلغ.FieldName = "المبلغ";
            this.colالمبلغ.Name = "colالمبلغ";
            this.colالمبلغ.Visible = true;
            this.colالمبلغ.VisibleIndex = 2;
            // 
            // colتاريخالصرف
            // 
            this.colتاريخالصرف.FieldName = "تاريخ الصرف";
            this.colتاريخالصرف.Name = "colتاريخالصرف";
            this.colتاريخالصرف.Visible = true;
            this.colتاريخالصرف.VisibleIndex = 3;
            // 
            // colملاحظة
            // 
            this.colملاحظة.FieldName = "ملاحظة";
            this.colملاحظة.Name = "colملاحظة";
            this.colملاحظة.Visible = true;
            this.colملاحظة.VisibleIndex = 4;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 710);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExpenses";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.bunifuGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtprice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNote;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.GroupBox pnl_1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_del;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        public DevExpress.XtraGrid.GridControl dgvShow;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالصرف;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالصرف;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغ;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالصرف;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة;
        public Bunifu.Framework.UI.BunifuDatepicker Paydate;
        public System.Windows.Forms.ComboBox txtType;
        public System.Windows.Forms.ComboBox Com_Emp;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Emp;
    }
}