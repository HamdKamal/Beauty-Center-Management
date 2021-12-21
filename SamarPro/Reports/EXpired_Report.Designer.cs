namespace SamarPro.Reports
{
    partial class EXpired_Report
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

        #region Designer generated code

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
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXpired_Report));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.XrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.XrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.XrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.XrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TOTAL = new DevExpress.XtraReports.UI.CalculatedField();
            this.SUM_MONEY = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.Barcode = new DevExpress.XtraReports.Parameters.Parameter();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableHeader = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableBody = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableBody2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.XrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db_model";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "BarCode";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ExperidDate";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "SupCategories_Name";
            columnExpression4.ColumnName = "Name";
            table2.Name = "SupCategories";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.FilterString = "[Products.BarCode] In (?Barcode)";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "custom";
            queryParameter1.Name = "Reservation_Code";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.Barcode]", typeof(int));
            queryParameter2.Name = "Barcode";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.Barcode]", typeof(int));
            selectQuery1.Parameters.Add(queryParameter1);
            selectQuery1.Parameters.Add(queryParameter2);
            relationColumnInfo1.NestedKeyColumn = "PAR_id";
            relationColumnInfo1.ParentKeyColumn = "ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            columnExpression5.ColumnName = "BarCode";
            table3.Name = "Products";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Name";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Name = "Products";
            selectQuery2.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel58,
            this.XrPageInfo2,
            this.xrLabel11});
            this.BottomMargin.HeightF = 121F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrLabel58
            // 
            this.XrLabel58.BorderColor = System.Drawing.Color.White;
            this.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.XrLabel58.Font = new System.Drawing.Font("Times New Roman", 8.8F, System.Drawing.FontStyle.Bold);
            this.XrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.95833F);
            this.XrLabel58.Name = "XrLabel58";
            this.XrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel58.SizeF = new System.Drawing.SizeF(693.4167F, 23.00013F);
            this.XrLabel58.StylePriority.UseBorderColor = false;
            this.XrLabel58.StylePriority.UseBorders = false;
            this.XrLabel58.StylePriority.UseFont = false;
            this.XrLabel58.StylePriority.UseTextAlignment = false;
            this.XrLabel58.Text = "الخرطوم - شرق النيل - كبري المنشية , جوار  ملحمة الغالي , رقم التلفون 00249090006" +
    "1804 ";
            this.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrPageInfo2
            // 
            this.XrPageInfo2.BorderColor = System.Drawing.Color.White;
            this.XrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.XrPageInfo2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.XrPageInfo2.Format = "{0:dddd، d MMMM yyyy}";
            this.XrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(218.6386F, 69.9585F);
            this.XrPageInfo2.Name = "XrPageInfo2";
            this.XrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.XrPageInfo2.SizeF = new System.Drawing.SizeF(185.1065F, 17.79162F);
            this.XrPageInfo2.StylePriority.UseBorderColor = false;
            this.XrPageInfo2.StylePriority.UseBorders = false;
            this.XrPageInfo2.StylePriority.UseFont = false;
            this.XrPageInfo2.StylePriority.UseTextAlignment = false;
            this.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BorderColor = System.Drawing.Color.White;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 8.8F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(83.89416F, 46.95842F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(505.8557F, 23.00012F);
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Khartoum , East Nile Localty , Near El Manshia Bireade , Tel : 002490900061804 - " +
    "00249121230140";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel3,
            this.XrPictureBox2,
            this.xrLabel26,
            this.xrLabel4,
            this.xrLabel39,
            this.xrLabel38,
            this.XrLine4,
            this.XrLabel21});
            this.ReportHeader.HeightF = 272.9168F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XrLine4
            // 
            this.XrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 216.4584F);
            this.XrLine4.Name = "XrLine4";
            this.XrLine4.SizeF = new System.Drawing.SizeF(660.8729F, 10.00006F);
            // 
            // XrLabel21
            // 
            this.XrLabel21.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(186.6887F, 176.0417F);
            this.XrLabel21.Name = "XrLabel21";
            this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel21.SizeF = new System.Drawing.SizeF(292.8448F, 40.41672F);
            this.XrLabel21.StylePriority.UseFont = false;
            this.XrLabel21.StylePriority.UseTextAlignment = false;
            this.XrLabel21.Text = "تقرير صلاحية المنتجات";
            this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel25,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel17,
            this.xrLabel7,
            this.xrLabel2,
            this.XrLabel8,
            this.xrLabel20});
            this.GroupHeader2.HeightF = 43.08332F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(81.54317F, 23.62499F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(100.8839F, 17.37499F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Expiert Date";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(385.1441F, 23.62499F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(114.9775F, 17.37499F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Product Name";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(182.4272F, 23.62499F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(117.4486F, 17.37499F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Days";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(300.3751F, 23.62499F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(84.51944F, 17.37499F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Services";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(500.1215F, 23.62499F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(80.34918F, 17.37499F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "BarCode";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(500.3713F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(80.06219F, 23.62499F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "الباركود";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(300.3751F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(84.51938F, 23.62499F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "نوع الخدمة";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(182.4272F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(117.948F, 23.62499F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "الأيام المتبقية";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrLabel8
            // 
            this.XrLabel8.BackColor = System.Drawing.Color.LightGray;
            this.XrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(81.29359F, 0F);
            this.XrLabel8.Name = "XrLabel8";
            this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel8.SizeF = new System.Drawing.SizeF(101.1336F, 23.62499F);
            this.XrLabel8.StylePriority.UseBackColor = false;
            this.XrLabel8.StylePriority.UseBorders = false;
            this.XrLabel8.StylePriority.UseFont = false;
            this.XrLabel8.StylePriority.UseTextAlignment = false;
            this.XrLabel8.Text = "تاريخ الصلاحية";
            this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(385.1441F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(115.2271F, 23.62499F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "إسم المنتج";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Expanded = false;
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrTable1});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // XrTable1
            // 
            this.XrTable1.BackColor = System.Drawing.Color.OldLace;
            this.XrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.XrTable1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.XrTable1.LocationFloat = new DevExpress.Utils.PointFloat(81.29358F, 0F);
            this.XrTable1.Name = "XrTable1";
            this.XrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.XrTableRow1});
            this.XrTable1.SizeF = new System.Drawing.SizeF(498.8902F, 25F);
            this.XrTable1.StylePriority.UseBackColor = false;
            this.XrTable1.StylePriority.UseBorders = false;
            this.XrTable1.StylePriority.UseFont = false;
            this.XrTable1.StylePriority.UseTextAlignment = false;
            this.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrTableRow1
            // 
            this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.XrTableCell1,
            this.XrTableCell2,
            this.XrTableCell3,
            this.xrTableCell5});
            this.XrTableRow1.Name = "XrTableRow1";
            this.XrTableRow1.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "custom.ExperidDate", "{0:dd/MM/yyyy}")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell9.Weight = 0.789748378080089D;
            // 
            // XrTableCell1
            // 
            this.XrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "custom.TOTAL", "{0}")});
            this.XrTableCell1.Name = "XrTableCell1";
            this.XrTableCell1.StylePriority.UseTextAlignment = false;
            this.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.XrTableCell1.Weight = 0.92333041439484587D;
            // 
            // XrTableCell2
            // 
            this.XrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "custom.SupCategories_Name", "{0}")});
            this.XrTableCell2.Name = "XrTableCell2";
            this.XrTableCell2.StylePriority.UseTextAlignment = false;
            this.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.XrTableCell2.Weight = 0.66359600320822909D;
            // 
            // XrTableCell3
            // 
            this.XrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "custom.Name", "{0}")});
            this.XrTableCell3.Name = "XrTableCell3";
            this.XrTableCell3.StylePriority.UseTextAlignment = false;
            this.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.XrTableCell3.Weight = 0.90007611313571934D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "custom.BarCode")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.62870426815139857D;
            // 
            // TOTAL
            // 
            this.TOTAL.DataMember = "custom";
            this.TOTAL.Expression = "DateDiffDay(GetDate(LocalDateTimeTomorrow()),GetDate([ExperidDate]))";
            this.TOTAL.Name = "TOTAL";
            // 
            // SUM_MONEY
            // 
            this.SUM_MONEY.DataMember = "custom";
            this.SUM_MONEY.Expression = "Iif(IsNull([].Sum([withdrow])),0  ,[].Sum([withdrow]))";
            this.SUM_MONEY.Name = "SUM_MONEY";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "custom";
            this.calculatedField1.Expression = "[CUS_Firstname] + \' \'+ [CUS_lastname]";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // Barcode
            // 
            this.Barcode.Description = " باركود المنتج :";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "Products";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "Name";
            dynamicListLookUpSettings1.ValueMember = "BarCode";
            this.Barcode.LookUpSettings = dynamicListLookUpSettings1;
            this.Barcode.MultiValue = true;
            this.Barcode.Name = "Barcode";
            this.Barcode.Type = typeof(int);
            this.Barcode.ValueInfo = "0";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Simplified Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // TableHeader
            // 
            this.TableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TableHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TableBody
            // 
            this.TableBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TableBody.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableBody.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableBody.Name = "TableBody";
            this.TableBody.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableBody.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TableBody2
            // 
            this.TableBody2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableBody2.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableBody2.Name = "TableBody2";
            this.TableBody2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanPublish = false;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(494.6731F, 9F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(166.3269F, 23.75005F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "لمسة حنين بيوتي سنتر";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanPublish = false;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(207.0703F, 23F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Lamsa Hanien Beautey Center";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // XrPictureBox2
            // 
            this.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.XrPictureBox2.BorderWidth = 1F;
            this.XrPictureBox2.CanPublish = false;
            this.XrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("XrPictureBox2.Image")));
            this.XrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.XrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(276.9167F, 0F);
            this.XrPictureBox2.Name = "XrPictureBox2";
            this.XrPictureBox2.SizeF = new System.Drawing.SizeF(126.8284F, 123.2412F);
            this.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.XrPictureBox2.StylePriority.UseBorders = false;
            this.XrPictureBox2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.BorderWidth = 1F;
            this.xrLabel26.CanPublish = false;
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(485.5726F, 31.99999F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(175.4272F, 26.125F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseBorderWidth = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "الخرطوم , شرق النيل ";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanPublish = false;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(529.8752F, 58.12497F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(131.1249F, 23F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "  +249  0900061804";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel39.BorderWidth = 1F;
            this.xrLabel39.CanPublish = false;
            this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30.99999F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(175.4272F, 26.125F);
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseBorderWidth = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.Text = "Khartoum, East Nile";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel38.BorderWidth = 1F;
            this.xrLabel38.CanPublish = false;
            this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.125F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(139.7336F, 23F);
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseBorderWidth = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "  +249  0900061804";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // EXpired_Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader2,
            this.ReportFooter,
            this.DetailReport});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TOTAL,
            this.SUM_MONEY,
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "custom";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(90, 99, 23, 121);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Barcode});
            this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.TableHeader,
            this.TableBody,
            this.TableBody2});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.XrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel XrLabel58;
        private DevExpress.XtraReports.UI.XRPageInfo XrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLine XrLine4;
        private DevExpress.XtraReports.UI.XRLabel XrLabel21;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel XrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable XrTable1;
        private DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell XrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell XrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell XrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.CalculatedField TOTAL;
        private DevExpress.XtraReports.UI.CalculatedField SUM_MONEY;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.Parameters.Parameter Barcode;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle TableHeader;
        private DevExpress.XtraReports.UI.XRControlStyle TableBody;
        private DevExpress.XtraReports.UI.XRControlStyle TableBody2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPictureBox XrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
    }
}
