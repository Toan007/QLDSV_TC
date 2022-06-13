namespace QLDSV_TC
{
    partial class frmIN_BDTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.dsLopKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.ds_Lop_KhoaHocTableAdapter = new QLDSV_TC.DSTableAdapters.ds_Lop_KhoaHocTableAdapter();
            this.KHOA = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopKhoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ LỚP";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIn.Location = new System.Drawing.Point(530, 313);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 34);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(726, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.dsLopKhoaHocBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(530, 151);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(279, 24);
            this.cmbMaLop.TabIndex = 3;
            this.cmbMaLop.ValueMember = "KHOAHOC";
            // 
            // dsLopKhoaHocBindingSource
            // 
            this.dsLopKhoaHocBindingSource.DataMember = "ds_Lop_KhoaHoc";
            this.dsLopKhoaHocBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_Lop_KhoaHocTableAdapter
            // 
            this.ds_Lop_KhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(447, 80);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(47, 17);
            this.KHOA.TabIndex = 4;
            this.KHOA.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(530, 71);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(271, 24);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmIN_BDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 590);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.KHOA);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Name = "frmIN_BDTK";
            this.Text = "Bảng điểm tổng kết";
            this.Load += new System.EventHandler(this.frmIN_BDTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLopKhoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private DS dS;
        private System.Windows.Forms.BindingSource dsLopKhoaHocBindingSource;
        private DSTableAdapters.ds_Lop_KhoaHocTableAdapter ds_Lop_KhoaHocTableAdapter;
        private System.Windows.Forms.Label KHOA;
        private System.Windows.Forms.ComboBox cmbKhoa;
    }
}