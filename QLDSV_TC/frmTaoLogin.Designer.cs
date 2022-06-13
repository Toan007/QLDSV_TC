namespace QLDSV_TC
{
    partial class frmTaoLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.gIANGVIEN1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.rdoPGV = new System.Windows.Forms.RadioButton();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoPKT = new System.Windows.Forms.RadioButton();
            this.gIANGVIEN1TableAdapter = new QLDSV_TC.DSTableAdapters.GIANGVIEN1TableAdapter();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLDSV_TC.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHITableAdapter = new QLDSV_TC.DSTableAdapters.LOPTINCHITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangKy.Location = new System.Drawing.Point(644, 447);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(89, 37);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(911, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(615, 95);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(406, 22);
            this.txtLogin.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(615, 237);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(406, 22);
            this.txtPass.TabIndex = 10;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(615, 316);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(406, 22);
            this.txtRePass.TabIndex = 11;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.gIANGVIEN1BindingSource;
            this.cmbMaGV.DisplayMember = "MAGV";
            this.cmbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(615, 159);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(406, 24);
            this.cmbMaGV.TabIndex = 12;
            this.cmbMaGV.ValueMember = "MAGV";
            // 
            // gIANGVIEN1BindingSource
            // 
            this.gIANGVIEN1BindingSource.DataMember = "GIANGVIEN1";
            this.gIANGVIEN1BindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdoPGV
            // 
            this.rdoPGV.AutoSize = true;
            this.rdoPGV.Location = new System.Drawing.Point(615, 386);
            this.rdoPGV.Name = "rdoPGV";
            this.rdoPGV.Size = new System.Drawing.Size(58, 21);
            this.rdoPGV.TabIndex = 13;
            this.rdoPGV.TabStop = true;
            this.rdoPGV.Text = "PGV";
            this.rdoPGV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(757, 386);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(68, 21);
            this.rdoKhoa.TabIndex = 14;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "KHOA";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoPKT
            // 
            this.rdoPKT.AutoSize = true;
            this.rdoPKT.Location = new System.Drawing.Point(911, 386);
            this.rdoPKT.Name = "rdoPKT";
            this.rdoPKT.Size = new System.Drawing.Size(56, 21);
            this.rdoPKT.TabIndex = 15;
            this.rdoPKT.TabStop = true;
            this.rdoPKT.Text = "PKT";
            this.rdoPKT.UseVisualStyleBackColor = true;
            // 
            // gIANGVIEN1TableAdapter
            // 
            this.gIANGVIEN1TableAdapter.ClearBeforeFill = true;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "GIANGVIEN";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.ds_Lop_KhoaHocTableAdapter = null;
            this.tableAdapterManager.DS_LopTableAdapter = null;
            this.tableAdapterManager.ds_MonHocTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 588);
            this.Controls.Add(this.rdoPKT);
            this.Controls.Add(this.rdoKhoa);
            this.Controls.Add(this.rdoPGV);
            this.Controls.Add(this.cmbMaGV);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIEN1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.RadioButton rdoPGV;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoPKT;
        private DS dS;
        private System.Windows.Forms.BindingSource gIANGVIEN1BindingSource;
        private DSTableAdapters.GIANGVIEN1TableAdapter gIANGVIEN1TableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
    }
}