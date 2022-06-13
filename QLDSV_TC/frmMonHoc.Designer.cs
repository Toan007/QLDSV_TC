namespace QLDSV_TC
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLDSV_TC.DS();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.DSTableAdapters.LOPTINCHITableAdapter();
            this.dANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.mONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.numbTietLT = new System.Windows.Forms.NumericUpDown();
            this.numbTietTH = new System.Windows.Forms.NumericUpDown();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(304, 411);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 17);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(304, 452);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(95, 17);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(304, 506);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(73, 17);
            sOTIET_LTLabel.TabIndex = 9;
            sOTIET_LTLabel.Text = "Số tiết LT:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(304, 561);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(75, 17);
            sOTIET_THLabel.TabIndex = 11;
            sOTIET_THLabel.Text = "Số tiết TH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar7,
            this.bar8,
            this.bar9});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnHieuChinh,
            this.barBtnGhi,
            this.barBtnXoa,
            this.barBtnPhucHoi,
            this.barBtnLamLai,
            this.barBtnThoat});
            this.barManager1.MainMenu = this.bar8;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar9;
            // 
            // bar7
            // 
            this.bar7.BarName = "Tools";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 1;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLamLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar7.Text = "Tools";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnThem.Glyph")));
            this.barBtnThem.Id = 0;
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnHieuChinh
            // 
            this.barBtnHieuChinh.Caption = "Hiệu chỉnh";
            this.barBtnHieuChinh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnHieuChinh.Glyph")));
            this.barBtnHieuChinh.Id = 1;
            this.barBtnHieuChinh.Name = "barBtnHieuChinh";
            this.barBtnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHieuChinh_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.Glyph")));
            this.barBtnGhi.Id = 2;
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.Glyph")));
            this.barBtnXoa.Id = 3;
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnPhucHoi
            // 
            this.barBtnPhucHoi.Caption = "Phục hồi";
            this.barBtnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPhucHoi.Glyph")));
            this.barBtnPhucHoi.Id = 4;
            this.barBtnPhucHoi.Name = "barBtnPhucHoi";
            this.barBtnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhucHoi_ItemClick);
            // 
            // barBtnLamLai
            // 
            this.barBtnLamLai.Caption = "Làm lại";
            this.barBtnLamLai.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLamLai.Glyph")));
            this.barBtnLamLai.Id = 5;
            this.barBtnLamLai.Name = "barBtnLamLai";
            this.barBtnLamLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLamLai_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.Glyph")));
            this.barBtnThoat.Id = 6;
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Main menu";
            // 
            // bar9
            // 
            this.bar9.BarName = "Status bar";
            this.bar9.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar9.OptionsBar.AllowQuickCustomization = false;
            this.bar9.OptionsBar.DrawDragBorder = false;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Size = new System.Drawing.Size(1528, 79);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 659);
            this.barDockControlBottom.Size = new System.Drawing.Size(1528, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 79);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 580);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1528, 79);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 580);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.ds_Lop_KhoaHocTableAdapter = null;
            this.tableAdapterManager.DS_LopTableAdapter = null;
            this.tableAdapterManager.ds_MonHocTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "FK_LOPTINCHI_MONHOC";
            this.lOPTINCHIBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYBindingSource
            // 
            this.dANGKYBindingSource.DataMember = "DANGKY";
            this.dANGKYBindingSource.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 148);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(1528, 220);
            this.mONHOCGridControl.TabIndex = 20;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.OptionsColumn.AllowEdit = false;
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.OptionsColumn.AllowEdit = false;
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(435, 406);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(182, 22);
            this.txtMaMH.TabIndex = 21;
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(435, 447);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(182, 22);
            this.txtTenMH.TabIndex = 22;
            // 
            // numbTietLT
            // 
            this.numbTietLT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mONHOCBindingSource, "SOTIET_LT", true));
            this.numbTietLT.Enabled = false;
            this.numbTietLT.Location = new System.Drawing.Point(435, 504);
            this.numbTietLT.Name = "numbTietLT";
            this.numbTietLT.Size = new System.Drawing.Size(182, 22);
            this.numbTietLT.TabIndex = 23;
            // 
            // numbTietTH
            // 
            this.numbTietTH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mONHOCBindingSource, "SOTIET_TH", true));
            this.numbTietTH.Enabled = false;
            this.numbTietTH.Location = new System.Drawing.Point(435, 556);
            this.numbTietTH.Name = "numbTietTH";
            this.numbTietTH.Size = new System.Drawing.Size(182, 22);
            this.numbTietTH.TabIndex = 24;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.mONHOCGridControl;
            this.searchControl1.Location = new System.Drawing.Point(1034, 31);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.mONHOCGridControl;
            this.searchControl1.Size = new System.Drawing.Size(257, 22);
            this.searchControl1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(904, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "DANH SÁCH MÔN HỌC";
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.numbTietTH);
            this.Controls.Add(this.numbTietLT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(sOTIET_THLabel);
            this.Controls.Add(sOTIET_LTLabel);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barBtnLamLai;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource dANGKYBindingSource;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.NumericUpDown numbTietTH;
        private System.Windows.Forms.NumericUpDown numbTietLT;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Label label2;
    }
}