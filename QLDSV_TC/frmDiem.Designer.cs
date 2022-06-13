namespace QLDSV_TC
{
    partial class frmDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbNhom = new DevExpress.XtraEditors.SpinEdit();
            this.cmbHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaMH = new DevExpress.XtraEditors.TextEdit();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV_TC.DS();
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.DiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(114, 125);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 17);
            mAMHLabel.TabIndex = 21;
            mAMHLabel.Text = "Tên Môn Học";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbNhom);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.MaMH);
            this.panelControl1.Controls.Add(this.cbMonHoc);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1413, 248);
            this.panelControl1.TabIndex = 2;
            // 
            // cmbNhom
            // 
            this.cmbNhom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cmbNhom.Location = new System.Drawing.Point(775, 64);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhom.Size = new System.Drawing.Size(100, 22);
            this.cmbNhom.TabIndex = 29;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cmbHocKy.Location = new System.Drawing.Point(538, 64);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHocKy.Size = new System.Drawing.Size(100, 22);
            this.cmbHocKy.TabIndex = 28;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(216, 64);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(174, 24);
            this.cmbNienKhoa.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã Môn Học :";
            // 
            // MaMH
            // 
            this.MaMH.Location = new System.Drawing.Point(529, 121);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(100, 22);
            this.MaMH.TabIndex = 23;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(216, 118);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(174, 24);
            this.cbMonHoc.TabIndex = 22;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Niên Khoá";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ghi Điểm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khoa";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(458, 20);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(300, 24);
            this.cmbChiNhanh.TabIndex = 6;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "DANGKY";
            this.bdsDiem.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.dANGKYTableAdapter;
            this.tableAdapterManager.ds_Lop_KhoaHocTableAdapter = null;
            this.tableAdapterManager.DS_LopTableAdapter = null;
            this.tableAdapterManager.ds_MonHocTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // DiemGridControl
            // 
            this.DiemGridControl.DataSource = this.bdsMonHoc;
            this.DiemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiemGridControl.Location = new System.Drawing.Point(0, 248);
            this.DiemGridControl.MainView = this.gridView1;
            this.DiemGridControl.Name = "DiemGridControl";
            this.DiemGridControl.Size = new System.Drawing.Size(1413, 366);
            this.DiemGridControl.TabIndex = 3;
            this.DiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMASV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.DiemGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DIEM_TK";
            this.gridColumn1.FieldName = "DIEM_TK";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "HOTEN";
            this.gridColumn2.Caption = "HO TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 614);
            this.Controls.Add(this.DiemGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit cmbNhom;
        private DevExpress.XtraEditors.SpinEdit cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit MaMH;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDiem;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl DiemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}