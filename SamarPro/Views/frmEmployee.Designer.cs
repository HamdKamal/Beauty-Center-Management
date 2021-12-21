namespace SamarPro.Views
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.date_time = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtsalary = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtnote = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtphone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtadress = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtname = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpEmployee.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.BackColor = System.Drawing.Color.White;
            this.grpEmployee.Controls.Add(this.txt_type);
            this.grpEmployee.Controls.Add(this.date_time);
            this.grpEmployee.Controls.Add(this.txtsalary);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel7);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel8);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel6);
            this.grpEmployee.Controls.Add(this.txtnote);
            this.grpEmployee.Controls.Add(this.txtphone);
            this.grpEmployee.Controls.Add(this.txtadress);
            this.grpEmployee.Controls.Add(this.txtname);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel5);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel4);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel3);
            this.grpEmployee.Controls.Add(this.bunifuCustomLabel2);
            this.grpEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpEmployee.Location = new System.Drawing.Point(12, 56);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpEmployee.Size = new System.Drawing.Size(635, 362);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "بيانات الموظفين";
            this.grpEmployee.Enter += new System.EventHandler(this.grpEmployee_Enter);
            this.grpEmployee.MouseHover += new System.EventHandler(this.grpEmployee_MouseHover);
            // 
            // txt_type
            // 
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Items.AddRange(new object[] {
            "مدير",
            "فني",
            "موظف إستقبال"});
            this.txt_type.Location = new System.Drawing.Point(17, 150);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(172, 27);
            this.txt_type.TabIndex = 3;
            // 
            // date_time
            // 
            this.date_time.BackColor = System.Drawing.Color.DodgerBlue;
            this.date_time.BorderRadius = 0;
            this.date_time.ForeColor = System.Drawing.Color.White;
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time.FormatCustom = "";
            this.date_time.Location = new System.Drawing.Point(283, 203);
            this.date_time.Margin = new System.Windows.Forms.Padding(4);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(231, 26);
            this.date_time.TabIndex = 4;
            this.date_time.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.Color.White;
            this.txtsalary.BorderColor = System.Drawing.Color.Black;
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalary.Location = new System.Drawing.Point(17, 203);
            this.txtsalary.MaxLength = 10;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(172, 26);
            this.txtsalary.TabIndex = 5;
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(194, 205);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "الراتب :";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(520, 202);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(85, 19);
            this.bunifuCustomLabel8.TabIndex = 11;
            this.bunifuCustomLabel8.Text = "تاريخ التعيين :";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(195, 150);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(81, 19);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "نوع الوظيفة :";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtnote
            // 
            this.txtnote.BackColor = System.Drawing.Color.White;
            this.txtnote.BorderColor = System.Drawing.Color.Black;
            this.txtnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnote.Location = new System.Drawing.Point(17, 258);
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(498, 82);
            this.txtnote.TabIndex = 6;
            this.txtnote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnote_KeyPress);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.BorderColor = System.Drawing.Color.Black;
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Location = new System.Drawing.Point(282, 148);
            this.txtphone.MaxLength = 10;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(232, 26);
            this.txtphone.TabIndex = 2;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtadress
            // 
            this.txtadress.BackColor = System.Drawing.Color.White;
            this.txtadress.BorderColor = System.Drawing.Color.Black;
            this.txtadress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadress.Location = new System.Drawing.Point(282, 95);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(232, 26);
            this.txtadress.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.Black;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(282, 42);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(232, 26);
            this.txtname.TabIndex = 0;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(521, 259);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(57, 19);
            this.bunifuCustomLabel5.TabIndex = 3;
            this.bunifuCustomLabel5.Text = "ملاحظة :";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(520, 149);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "رقم الهاتف :";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(520, 96);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(56, 19);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "العنوان :";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(520, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 19);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "إسم الموظف :";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.btn_edit);
            this.bunifuGradientPanel3.Controls.Add(this.btn_save);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(653, 249);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(138, 169);
            this.bunifuGradientPanel3.TabIndex = 1;
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
            this.btn_edit.Location = new System.Drawing.Point(18, 57);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.Teal;
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(101, 35);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.Black;
            this.btn_edit.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 5;
            this.btn_save.ButtonText = "حفظ";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
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
            this.btn_save.Location = new System.Drawing.Point(18, 111);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.DarkKhaki;
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
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-7, 424);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(840, 25);
            this.bunifuGradientPanel2.TabIndex = 57;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-8, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(829, 52);
            this.bunifuGradientPanel1.TabIndex = 56;
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
            this.lbl_text.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.Color.White;
            this.lbl_text.Location = new System.Drawing.Point(369, 14);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(119, 25);
            this.lbl_text.TabIndex = 3;
            this.lbl_text.Text = "إضافة الموظف";
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel4.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(653, 67);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(138, 180);
            this.bunifuGradientPanel4.TabIndex = 60;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton2.Enabled = false;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(130, 172);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 437);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_text;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtnote;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtphone;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtadress;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtname;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtsalary;
        public Bunifu.Framework.UI.BunifuDatepicker date_time;
        public Bunifu.Framework.UI.BunifuFlatButton btn_save;
        public System.Windows.Forms.GroupBox grpEmployee;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.ComboBox txt_type;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
    }
}