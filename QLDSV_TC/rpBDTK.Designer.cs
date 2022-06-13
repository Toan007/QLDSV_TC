namespace QLDSV_TC
{
    partial class rpBDTK
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpBDTK));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fieldMASV1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldHOTEN = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDIEM1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrKhoaHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLop = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.fieldTENMH1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 104.1667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "SP_IN_BANGDIEMTONGKET";
            this.xrPivotGrid1.DataSource = this.sqlDataSource1;
            this.xrPivotGrid1.Dpi = 100F;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldMASV1,
            this.fieldHOTEN,
            this.xrPivotGridField1,
            this.fieldDIEM1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(80.83334F, 10.00005F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(497.5F, 84.16666F);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV_TC.Properties.Settings.QLDSV_TCConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_IN_BANGDIEMTONGKET";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D15CQCP01";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_IN_BANGDIEMTONGKET";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // fieldMASV1
            // 
            this.fieldMASV1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMASV1.AreaIndex = 0;
            this.fieldMASV1.Caption = "Mã SV";
            this.fieldMASV1.FieldName = "MASV";
            this.fieldMASV1.Name = "fieldMASV1";
            // 
            // fieldHOTEN
            // 
            this.fieldHOTEN.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHOTEN.AreaIndex = 1;
            this.fieldHOTEN.Caption = "Họ tên";
            this.fieldHOTEN.FieldName = "HOTEN";
            this.fieldHOTEN.Name = "fieldHOTEN";
            // 
            // xrPivotGridField1
            // 
            this.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xrPivotGridField1.AreaIndex = 0;
            this.xrPivotGridField1.FieldName = "TENMH";
            this.xrPivotGridField1.Name = "xrPivotGridField1";
            this.xrPivotGridField1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.xrPivotGridField1.Width = 200;
            // 
            // fieldDIEM1
            // 
            this.fieldDIEM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDIEM1.AreaIndex = 0;
            this.fieldDIEM1.FieldName = "DIEM";
            this.fieldDIEM1.Name = "fieldDIEM1";
            this.fieldDIEM1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 152F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrKhoa
            // 
            this.xrKhoa.Dpi = 100F;
            this.xrKhoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrKhoa.ForeColor = System.Drawing.Color.Maroon;
            this.xrKhoa.LocationFloat = new DevExpress.Utils.PointFloat(232.3333F, 90.16663F);
            this.xrKhoa.Name = "xrKhoa";
            this.xrKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrKhoa.SizeF = new System.Drawing.SizeF(300F, 23.00001F);
            this.xrKhoa.StylePriority.UseFont = false;
            this.xrKhoa.StylePriority.UseForeColor = false;
            this.xrKhoa.Text = "xrKhoa";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 100F;
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(132.3333F, 90.16663F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(99.99998F, 23.00001F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "KHOA";
            // 
            // xrKhoaHoc
            // 
            this.xrKhoaHoc.BorderColor = System.Drawing.Color.Transparent;
            this.xrKhoaHoc.Dpi = 100F;
            this.xrKhoaHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrKhoaHoc.ForeColor = System.Drawing.Color.Maroon;
            this.xrKhoaHoc.LocationFloat = new DevExpress.Utils.PointFloat(432.3333F, 50.16668F);
            this.xrKhoaHoc.Name = "xrKhoaHoc";
            this.xrKhoaHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrKhoaHoc.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrKhoaHoc.StylePriority.UseBorderColor = false;
            this.xrKhoaHoc.StylePriority.UseFont = false;
            this.xrKhoaHoc.StylePriority.UseForeColor = false;
            this.xrKhoaHoc.Text = "xrKhoaHoc";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel4.Dpi = 100F;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(332.3333F, 50.16668F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "KHÓA HỌC:";
            // 
            // xrLop
            // 
            this.xrLop.BorderColor = System.Drawing.Color.Transparent;
            this.xrLop.Dpi = 100F;
            this.xrLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLop.ForeColor = System.Drawing.Color.Maroon;
            this.xrLop.LocationFloat = new DevExpress.Utils.PointFloat(181.5001F, 50.16668F);
            this.xrLop.Name = "xrLop";
            this.xrLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLop.SizeF = new System.Drawing.SizeF(150.8333F, 23F);
            this.xrLop.StylePriority.UseBorderColor = false;
            this.xrLop.StylePriority.UseFont = false;
            this.xrLop.StylePriority.UseForeColor = false;
            this.xrLop.Text = "xrLop";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Dpi = 100F;
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(132.3333F, 50.16668F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(49.16667F, 23F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "LỚP:";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(220.8333F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(357.5F, 23F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLop,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel4,
            this.xrKhoaHoc,
            this.xrLabel3,
            this.xrKhoa});
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 132.3333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // fieldTENMH1
            // 
            this.fieldTENMH1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTENMH1.AreaIndex = 0;
            this.fieldTENMH1.FieldName = "TENMH";
            this.fieldTENMH1.Name = "fieldTENMH1";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.PageFooter.Dpi = 100F;
            this.PageFooter.HeightF = 55.83333F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Dpi = 100F;
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(424.3333F, 10F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 100F;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(99.33332F, 10F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(315F, 23F);
            // 
            // rpBDTK
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Margins = new System.Drawing.Printing.Margins(1, 0, 152, 100);
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMASV1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHOTEN;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDIEM1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel xrLop;
        public DevExpress.XtraReports.UI.XRLabel xrKhoaHoc;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldTENMH1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
        public DevExpress.XtraReports.UI.XRLabel xrKhoa;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    }
}
