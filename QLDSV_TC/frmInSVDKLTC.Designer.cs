namespace QLDSV_TC
{
    partial class frmInSVDKLTC
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.dsHKLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.dsNKLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.dsNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.dsMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNK_LTCTableAdapter = new QLDSV_TC.DSTableAdapters.dsNK_LTCTableAdapter();
            this.ds_HK_LTCTableAdapter = new QLDSV_TC.DSTableAdapters.ds_HK_LTCTableAdapter();
            this.ds_NhomTableAdapter = new QLDSV_TC.DSTableAdapters.ds_NhomTableAdapter();
            this.ds_MonHocTableAdapter = new QLDSV_TC.DSTableAdapters.ds_MonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsHKLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNKLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(835, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 33);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIn.Location = new System.Drawing.Point(664, 391);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(87, 33);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataSource = this.dsHKLTCBindingSource;
            this.cmbHocKy.DisplayMember = "HOCKY";
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(664, 245);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(258, 24);
            this.cmbHocKy.TabIndex = 13;
            this.cmbHocKy.ValueMember = "HOCKY";
            // 
            // dsHKLTCBindingSource
            // 
            this.dsHKLTCBindingSource.DataMember = "ds_HK_LTC";
            this.dsHKLTCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.dsNKLTCBindingSource;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(664, 199);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(258, 24);
            this.cmbNienKhoa.TabIndex = 12;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // dsNKLTCBindingSource
            // 
            this.dsNKLTCBindingSource.DataMember = "dsNK_LTC";
            this.dsNKLTCBindingSource.DataSource = this.dS;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(664, 154);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(258, 24);
            this.cmbKhoa.TabIndex = 11;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "HỌC KỲ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIÊN KHÓA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "KHOA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "NHÓM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "MÔN HỌC";
            // 
            // cmbNhom
            // 
            this.cmbNhom.DataSource = this.dsNhomBindingSource;
            this.cmbNhom.DisplayMember = "NHOM";
            this.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(664, 283);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(258, 24);
            this.cmbNhom.TabIndex = 18;
            this.cmbNhom.ValueMember = "NHOM";
            // 
            // dsNhomBindingSource
            // 
            this.dsNhomBindingSource.DataMember = "ds_Nhom";
            this.dsNhomBindingSource.DataSource = this.dS;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.dsMonHocBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(664, 327);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(258, 24);
            this.cmbMonHoc.TabIndex = 19;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // dsMonHocBindingSource
            // 
            this.dsMonHocBindingSource.DataMember = "ds_MonHoc";
            this.dsMonHocBindingSource.DataSource = this.dS;
            // 
            // dsNK_LTCTableAdapter
            // 
            this.dsNK_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // ds_HK_LTCTableAdapter
            // 
            this.ds_HK_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // ds_NhomTableAdapter
            // 
            this.ds_NhomTableAdapter.ClearBeforeFill = true;
            // 
            // ds_MonHocTableAdapter
            // 
            this.ds_MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmInSVDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 545);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInSVDKLTC";
            this.Text = "Danh sách sinh viên LTC";
            this.Load += new System.EventHandler(this.frmInSVDKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHKLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNKLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private DS dS;
        private System.Windows.Forms.BindingSource dsNKLTCBindingSource;
        private DSTableAdapters.dsNK_LTCTableAdapter dsNK_LTCTableAdapter;
        private System.Windows.Forms.BindingSource dsHKLTCBindingSource;
        private DSTableAdapters.ds_HK_LTCTableAdapter ds_HK_LTCTableAdapter;
        private System.Windows.Forms.BindingSource dsNhomBindingSource;
        private DSTableAdapters.ds_NhomTableAdapter ds_NhomTableAdapter;
        private System.Windows.Forms.BindingSource dsMonHocBindingSource;
        private DSTableAdapters.ds_MonHocTableAdapter ds_MonHocTableAdapter;
    }
}