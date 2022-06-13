namespace QLDSV_TC
{
    partial class frmIn_HocPhi
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
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.cmbMaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_HP = new QLDSV_TC.DS_HP();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaLopTableAdapter = new QLDSV_TC.DS_HPTableAdapters.CmbMaLopTableAdapter();
            this.cmbNKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNKTableAdapter = new QLDSV_TC.DS_HPTableAdapters.CmbNKTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_HPTableAdapters.TableAdapterManager();
            this.cmbHKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHKTableAdapter = new QLDSV_TC.DS_HPTableAdapters.CmbHKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIÊN KHÓA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌC KỲ";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.cmbMaLopBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(567, 69);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(286, 24);
            this.cmbMaLop.TabIndex = 3;
            this.cmbMaLop.ValueMember = "TENKHOA";
            // 
            // cmbMaLopBindingSource
            // 
            this.cmbMaLopBindingSource.DataMember = "CmbMaLop";
            this.cmbMaLopBindingSource.DataSource = this.dS_HP;
            // 
            // dS_HP
            // 
            this.dS_HP.DataSetName = "DS_HP";
            this.dS_HP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.cmbNKBindingSource;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(567, 130);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(286, 24);
            this.cmbNienKhoa.TabIndex = 4;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataSource = this.cmbHKBindingSource;
            this.cmbHocKy.DisplayMember = "HOCKY";
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(567, 208);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(286, 24);
            this.cmbHocKy.TabIndex = 5;
            this.cmbHocKy.ValueMember = "HOCKY";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIn.Location = new System.Drawing.Point(567, 290);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 29);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(778, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaLopTableAdapter
            // 
            this.cmbMaLopTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNKBindingSource
            // 
            this.cmbNKBindingSource.DataMember = "CmbNK";
            this.cmbNKBindingSource.DataSource = this.dS_HP;
            // 
            // cmbNKTableAdapter
            // 
            this.cmbNKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_HPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbHKBindingSource
            // 
            this.cmbHKBindingSource.DataMember = "CmbHK";
            this.cmbHKBindingSource.DataSource = this.dS_HP;
            // 
            // cmbHKTableAdapter
            // 
            this.cmbHKTableAdapter.ClearBeforeFill = true;
            // 
            // frmIn_HocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 654);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIn_HocPhi";
            this.Text = "Báo cáo học phí";
            this.Load += new System.EventHandler(this.frmIn_HocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private DS_HP dS_HP;
        private System.Windows.Forms.BindingSource cmbMaLopBindingSource;
        private DS_HPTableAdapters.CmbMaLopTableAdapter cmbMaLopTableAdapter;
        private System.Windows.Forms.BindingSource cmbNKBindingSource;
        private DS_HPTableAdapters.CmbNKTableAdapter cmbNKTableAdapter;
        private DS_HPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cmbHKBindingSource;
        private DS_HPTableAdapters.CmbHKTableAdapter cmbHKTableAdapter;
    }
}