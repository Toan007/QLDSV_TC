namespace QLdSV_TC
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dS = new QLDSV_TC.DS();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV_TC.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV_TC.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.sINHVIENGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXLamLai = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXChuyenLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.lopKhoafrmSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.pHAICheckBox = new System.Windows.Forms.CheckBox();
            this.dANGHIHOCCheckBox = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lop_Khoa_frmSVTableAdapter = new QLDSV_TC.DSTableAdapters.Lop_Khoa_frmSVTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopKhoafrmSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(49, 397);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(91, 17);
            mASVLabel.TabIndex = 15;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(390, 402);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(54, 17);
            hOLabel.TabIndex = 16;
            hOLabel.Text = "Họ tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(49, 442);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(75, 17);
            nGAYSINHLabel.TabIndex = 18;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(51, 501);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(73, 17);
            pASSWORDLabel.TabIndex = 19;
            pASSWORDLabel.Text = "Password:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(51, 551);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(55, 17);
            dIACHILabel.TabIndex = 31;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(1023, 24);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(52, 17);
            mALOPLabel.TabIndex = 36;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 411);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1374, 246);
            this.panelControl2.TabIndex = 7;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.sINHVIENBindingSource.DataSource = this.lOPBindingSource;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.ds_Lop_KhoaHocTableAdapter = null;
            this.tableAdapterManager.DS_LopTableAdapter = null;
            this.tableAdapterManager.ds_MonHocTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(0, 191);
            this.sINHVIENGridControl.MainView = this.gridView1;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(735, 220);
            this.sINHVIENGridControl.TabIndex = 25;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridView1.GridControl = this.sINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Location = new System.Drawing.Point(736, 191);
            this.lOPGridControl.MainView = this.gridView2;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(638, 220);
            this.lOPGridControl.TabIndex = 25;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.lOPGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(262, 21);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(351, 24);
            this.cmbKhoa.TabIndex = 10;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.searchControl1);
            this.panelControl3.Controls.Add(this.cmbMaLop);
            this.panelControl3.Controls.Add(mALOPLabel);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.cmbKhoa);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1289, 67);
            this.panelControl3.TabIndex = 11;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.sINHVIENGridControl1;
            this.searchControl1.Location = new System.Drawing.Point(785, 21);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.sINHVIENGridControl1;
            this.searchControl1.Properties.FindDelay = 100;
            this.searchControl1.Size = new System.Drawing.Size(186, 22);
            this.searchControl1.TabIndex = 14;
            // 
            // sINHVIENGridControl1
            // 
            this.sINHVIENGridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.sINHVIENGridControl1.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENGridControl1.Location = new System.Drawing.Point(526, 165);
            this.sINHVIENGridControl1.MainView = this.gridView4;
            this.sINHVIENGridControl1.Name = "sINHVIENGridControl1";
            this.sINHVIENGridControl1.Size = new System.Drawing.Size(743, 206);
            this.sINHVIENGridControl1.TabIndex = 5;
            this.sINHVIENGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXThem,
            this.btnXSua,
            this.btnXGhi,
            this.btnXXoa,
            this.btnXPhucHoi,
            this.btnXLamLai,
            this.btnXChuyenLop,
            this.btnXThoat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 196);
            // 
            // btnXThem
            // 
            this.btnXThem.Name = "btnXThem";
            this.btnXThem.Size = new System.Drawing.Size(152, 24);
            this.btnXThem.Text = "Thêm";
            this.btnXThem.Click += new System.EventHandler(this.btnXThem_Click);
            // 
            // btnXSua
            // 
            this.btnXSua.Name = "btnXSua";
            this.btnXSua.Size = new System.Drawing.Size(152, 24);
            this.btnXSua.Text = "Sửa";
            this.btnXSua.Click += new System.EventHandler(this.btnXSua_Click);
            // 
            // btnXGhi
            // 
            this.btnXGhi.Name = "btnXGhi";
            this.btnXGhi.Size = new System.Drawing.Size(152, 24);
            this.btnXGhi.Text = "Ghi";
            this.btnXGhi.Click += new System.EventHandler(this.btnXGhi_Click);
            // 
            // btnXXoa
            // 
            this.btnXXoa.Name = "btnXXoa";
            this.btnXXoa.Size = new System.Drawing.Size(152, 24);
            this.btnXXoa.Text = "Xóa";
            this.btnXXoa.Click += new System.EventHandler(this.btnXXoa_Click);
            // 
            // btnXPhucHoi
            // 
            this.btnXPhucHoi.Name = "btnXPhucHoi";
            this.btnXPhucHoi.Size = new System.Drawing.Size(152, 24);
            this.btnXPhucHoi.Text = "Phục Hồi";
            this.btnXPhucHoi.Click += new System.EventHandler(this.btnXPhucHoi_Click);
            // 
            // btnXLamLai
            // 
            this.btnXLamLai.Name = "btnXLamLai";
            this.btnXLamLai.Size = new System.Drawing.Size(152, 24);
            this.btnXLamLai.Text = "Làm lại";
            this.btnXLamLai.Click += new System.EventHandler(this.btnXLamLai_Click);
            // 
            // btnXChuyenLop
            // 
            this.btnXChuyenLop.Name = "btnXChuyenLop";
            this.btnXChuyenLop.Size = new System.Drawing.Size(152, 24);
            this.btnXChuyenLop.Text = "Chuyển lớp";
            this.btnXChuyenLop.Click += new System.EventHandler(this.btnXChuyenLop_Click);
            // 
            // btnXThoat
            // 
            this.btnXThoat.Name = "btnXThoat";
            this.btnXThoat.Size = new System.Drawing.Size(152, 24);
            this.btnXThoat.Text = "Thoát";
            this.btnXThoat.Click += new System.EventHandler(this.btnXThoat_Click);
            // 
            // gridView4
            // 
            this.gridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV1,
            this.colHO1,
            this.colTEN1,
            this.colPHAI1,
            this.colDIACHI1,
            this.colNGAYSINH1,
            this.colMALOP1,
            this.colDANGHIHOC1,
            this.colPASSWORD1});
            this.gridView4.GridControl = this.sINHVIENGridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMASV1
            // 
            this.colMASV1.FieldName = "MASV";
            this.colMASV1.Name = "colMASV1";
            this.colMASV1.OptionsColumn.AllowEdit = false;
            this.colMASV1.Visible = true;
            this.colMASV1.VisibleIndex = 0;
            // 
            // colHO1
            // 
            this.colHO1.FieldName = "HO";
            this.colHO1.Name = "colHO1";
            this.colHO1.OptionsColumn.AllowEdit = false;
            this.colHO1.Visible = true;
            this.colHO1.VisibleIndex = 1;
            // 
            // colTEN1
            // 
            this.colTEN1.FieldName = "TEN";
            this.colTEN1.Name = "colTEN1";
            this.colTEN1.OptionsColumn.AllowEdit = false;
            this.colTEN1.Visible = true;
            this.colTEN1.VisibleIndex = 2;
            // 
            // colPHAI1
            // 
            this.colPHAI1.FieldName = "PHAI";
            this.colPHAI1.Name = "colPHAI1";
            this.colPHAI1.OptionsColumn.AllowEdit = false;
            this.colPHAI1.Visible = true;
            this.colPHAI1.VisibleIndex = 3;
            // 
            // colDIACHI1
            // 
            this.colDIACHI1.FieldName = "DIACHI";
            this.colDIACHI1.Name = "colDIACHI1";
            this.colDIACHI1.OptionsColumn.AllowEdit = false;
            this.colDIACHI1.Visible = true;
            this.colDIACHI1.VisibleIndex = 4;
            // 
            // colNGAYSINH1
            // 
            this.colNGAYSINH1.FieldName = "NGAYSINH";
            this.colNGAYSINH1.Name = "colNGAYSINH1";
            this.colNGAYSINH1.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH1.Visible = true;
            this.colNGAYSINH1.VisibleIndex = 5;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.OptionsColumn.AllowEdit = false;
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            // 
            // colDANGHIHOC1
            // 
            this.colDANGHIHOC1.FieldName = "DANGHIHOC";
            this.colDANGHIHOC1.Name = "colDANGHIHOC1";
            this.colDANGHIHOC1.OptionsColumn.AllowEdit = false;
            this.colDANGHIHOC1.Visible = true;
            this.colDANGHIHOC1.VisibleIndex = 7;
            // 
            // colPASSWORD1
            // 
            this.colPASSWORD1.FieldName = "PASSWORD";
            this.colPASSWORD1.Name = "colPASSWORD1";
            this.colPASSWORD1.OptionsColumn.AllowEdit = false;
            this.colPASSWORD1.Visible = true;
            this.colPASSWORD1.VisibleIndex = 8;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MALOP", true));
            this.cmbMaLop.DataSource = this.lopKhoafrmSVBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.Enabled = false;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(1098, 19);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(121, 24);
            this.cmbMaLop.TabIndex = 37;
            this.cmbMaLop.ValueMember = "MALOP";
            this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaLop_SelectedIndexChanged);
            // 
            // lopKhoafrmSVBindingSource
            // 
            this.lopKhoafrmSVBindingSource.DataMember = "Lop_Khoa_frmSV";
            this.lopKhoafrmSVBindingSource.DataSource = this.dS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "KHOA";
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(156, 397);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(149, 22);
            this.txtMaSV.TabIndex = 16;
            // 
            // txtHoSV
            // 
            this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HO", true));
            this.txtHoSV.Enabled = false;
            this.txtHoSV.Location = new System.Drawing.Point(464, 399);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(219, 22);
            this.txtHoSV.TabIndex = 17;
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "TEN", true));
            this.txtTenSV.Enabled = false;
            this.txtTenSV.Location = new System.Drawing.Point(681, 399);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 22);
            this.txtTenSV.TabIndex = 18;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Enabled = false;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(156, 439);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(149, 22);
            this.nGAYSINHDateEdit.TabIndex = 19;
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "PASSWORD", true));
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(156, 496);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(149, 22);
            this.txtPass.TabIndex = 20;
            // 
            // dANGKYBindingSource
            // 
            this.dANGKYBindingSource.DataMember = "FK_CTLTC_SINHVIEN";
            this.dANGKYBindingSource.DataSource = this.sINHVIENBindingSource;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // pHAICheckBox
            // 
            this.pHAICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sINHVIENBindingSource, "PHAI", true));
            this.pHAICheckBox.Enabled = false;
            this.pHAICheckBox.Location = new System.Drawing.Point(464, 435);
            this.pHAICheckBox.Name = "pHAICheckBox";
            this.pHAICheckBox.Size = new System.Drawing.Size(104, 24);
            this.pHAICheckBox.TabIndex = 30;
            this.pHAICheckBox.Text = "Phái";
            this.pHAICheckBox.UseVisualStyleBackColor = true;
            // 
            // dANGHIHOCCheckBox
            // 
            this.dANGHIHOCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sINHVIENBindingSource, "DANGHIHOC", true));
            this.dANGHIHOCCheckBox.Enabled = false;
            this.dANGHIHOCCheckBox.Location = new System.Drawing.Point(464, 494);
            this.dANGHIHOCCheckBox.Name = "dANGHIHOCCheckBox";
            this.dANGHIHOCCheckBox.Size = new System.Drawing.Size(143, 24);
            this.dANGHIHOCCheckBox.TabIndex = 31;
            this.dANGHIHOCCheckBox.Text = "Đã nghỉ học";
            this.dANGHIHOCCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "DIACHI", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(156, 551);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(649, 22);
            this.txtDiaChi.TabIndex = 32;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP2,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView3.GridControl = this.lOPGridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMALOP2
            // 
            this.colMALOP2.FieldName = "MALOP";
            this.colMALOP2.Name = "colMALOP2";
            this.colMALOP2.OptionsColumn.AllowEdit = false;
            this.colMALOP2.Visible = true;
            this.colMALOP2.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.OptionsColumn.AllowEdit = false;
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            // 
            // lOPGridControl1
            // 
            this.lOPGridControl1.DataSource = this.lOPBindingSource;
            this.lOPGridControl1.Location = new System.Drawing.Point(21, 165);
            this.lOPGridControl1.MainView = this.gridView3;
            this.lOPGridControl1.Name = "lOPGridControl1";
            this.lOPGridControl1.Size = new System.Drawing.Size(499, 206);
            this.lOPGridControl1.TabIndex = 4;
            this.lOPGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // lop_Khoa_frmSVTableAdapter
            // 
            this.lop_Khoa_frmSVTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "DANH SÁCH LỚP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(780, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 29);
            this.label5.TabIndex = 89;
            this.label5.Text = "THÔNG TIN SINH VIÊN";
            // 
            // frmSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(1289, 789);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dANGHIHOCCheckBox);
            this.Controls.Add(this.pHAICheckBox);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.nGAYSINHDateEdit);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(mASVLabel);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.sINHVIENGridControl1);
            this.Controls.Add(this.lOPGridControl1);
            this.Name = "frmSinhVien";
            this.Text = "Sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopKhoafrmSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSV_TC.DS dS;
        private QLDSV_TC.DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSV_TC.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private QLDSV_TC.DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.BindingSource dANGKYBindingSource;
        private QLDSV_TC.DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox dANGHIHOCCheckBox;
        private System.Windows.Forms.CheckBox pHAICheckBox;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchControl searchControl1;
     
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl lOPGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnXThem;
        private System.Windows.Forms.ToolStripMenuItem btnXSua;
        private System.Windows.Forms.ToolStripMenuItem btnXGhi;
        private System.Windows.Forms.ToolStripMenuItem btnXXoa;
        private System.Windows.Forms.ToolStripMenuItem btnXPhucHoi;
        private System.Windows.Forms.ToolStripMenuItem btnXLamLai;
        private System.Windows.Forms.ToolStripMenuItem btnXChuyenLop;
        private System.Windows.Forms.ToolStripMenuItem btnXThoat;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI1;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC1;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP2;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.BindingSource lopKhoafrmSVBindingSource;
        private QLDSV_TC.DSTableAdapters.Lop_Khoa_frmSVTableAdapter lop_Khoa_frmSVTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}