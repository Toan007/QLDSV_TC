using QLDSV_TC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLdSV_TC
{
    public partial class frmSinhVien : Form
    {
        int vitri = 0;
        string SV_Chuyen = "";
        string malop = "";
        bool checksua = false;
        bool checkchuyenlop = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {          
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(dS.SINHVIEN);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            this.lop_Khoa_frmSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lop_Khoa_frmSVTableAdapter.Fill(this.dS.Lop_Khoa_frmSV);

            cmbKhoa.DataSource = Program.bds_dspm1;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "PGV") cmbKhoa.Enabled = true;
            else if (Program.mGroup == "KHOA") cmbKhoa.Enabled = false;
            lOPGridControl1.ShowOnlyPredefinedDetails = true;
            btnXPhucHoi.Enabled = btnXGhi.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {

                dS.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(dS.SINHVIEN);
                //this.lop_Khoa_frmSVTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.lop_Khoa_frmSVTableAdapter.Fill(this.dS.Lop_Khoa_frmSV);

            }
        }
        private void btnXThem_Click(object sender, EventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            sINHVIENBindingSource.AddNew();
            txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtPass.Enabled = txtDiaChi.Enabled =
            nGAYSINHDateEdit.Enabled =   pHAICheckBox.Enabled = dANGHIHOCCheckBox.Enabled = true;
            cmbMaLop.Enabled = false;
            lOPGridControl1.Enabled = false;

            cmbMaLop.Text = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MALOP"].ToString();
            nGAYSINHDateEdit.EditValue = "";

            btnXChuyenLop.Enabled = btnXThem.Enabled = btnXSua.Enabled = btnXXoa.Enabled = btnXLamLai.Enabled = btnXThoat.Enabled = false;
            btnXGhi.Enabled = btnXPhucHoi.Enabled = true;
            sINHVIENGridControl1.Enabled = true;
        }

        private void btnXThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXLamLai_Click(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXSua_Click(object sender, EventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            txtHoSV.Enabled = txtTenSV.Enabled = txtPass.Enabled = txtDiaChi.Enabled =
            nGAYSINHDateEdit.Enabled = pHAICheckBox.Enabled = dANGHIHOCCheckBox.Enabled = true;
            lOPGridControl1.Enabled = false;

            btnXChuyenLop.Enabled = btnXThem.Enabled = btnXSua.Enabled = btnXXoa.Enabled = btnXLamLai.Enabled = btnXThoat.Enabled = btnXChuyenLop.Enabled= false;
            btnXGhi.Enabled = btnXPhucHoi.Enabled = true;
            sINHVIENGridControl1.Enabled = true;
            checksua = true;
        }
        private void ghi_sv()
        {
            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENBindingSource.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            sINHVIENGridControl1.Enabled = true;
            lOPGridControl1.Enabled = true;
            txtHoSV.Enabled = txtTenSV.Enabled = txtPass.Enabled = txtDiaChi.Enabled = txtMaSV.Enabled = cmbMaLop.Enabled =
            nGAYSINHDateEdit.Enabled = pHAICheckBox.Enabled = dANGHIHOCCheckBox.Enabled = false;

            btnXChuyenLop.Enabled = btnXThem.Enabled = btnXSua.Enabled = btnXXoa.Enabled = btnXLamLai.Enabled = btnXThoat.Enabled = true;
            btnXGhi.Enabled = btnXPhucHoi.Enabled = false;
        }
        private void btnXGhi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHoSV.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return;
            }
            if (txtTenSV.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            
            DateTime today = DateTime.Now;
            if (DateTime.Compare(nGAYSINHDateEdit.DateTime, today) == 1)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.", "", MessageBoxButtons.OK);
                nGAYSINHDateEdit.EditValue = "";
                nGAYSINHDateEdit.Focus();
                return;
            }

            if (checksua == true)
            {
                this.ghi_sv();
            }
            else if (checkchuyenlop == true)
            {
                if (cmbMaLop.SelectedValue.ToString() == malop)
                {
                    MessageBox.Show("Lớp chuyển đi phải khác lớp ban đầu của sinh viên ", "", MessageBoxButtons.OK);
                    return;
                }
                string strLenh1 = "EXEC SP_Chuyen_Lop_SV '" + SV_Chuyen + "',"+ "'" + cmbMaLop.Text + "'";
                Program.ExecSqlNonQuery(strLenh1);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.ghi_sv();
            }
            else if (checksua == false && checkchuyenlop == false)
            {
                string strlenh = "EXEC KT_MASV_TRUNG '" + txtMaSV.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                if (Program.myReader.HasRows == true)
                {
                    MessageBox.Show("Mã sinh viên trùng.\nBạn xem lại mã sinh viên.\n ", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                    
                }
                this.ghi_sv();
            }
        }

        private void btnXXoa_Click(object sender, EventArgs e)
        {
            //Int32 masv = 0;
            string masv = "";
            if (dANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                {
                    try
                    {
                        masv = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MASV"].ToString();
                        sINHVIENBindingSource.RemoveCurrent();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                        sINHVIENBindingSource.Position = lOPBindingSource.Find("MASV", masv);
                        return;
                    }
                }
                if (sINHVIENBindingSource.Count == 0) btnXXoa.Enabled = false;
            }
        }

        private void btnXPhucHoi_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            if (btnXThem.Enabled == false) lOPBindingSource.Position = vitri;
            sINHVIENGridControl1.Enabled = true;
            lOPGridControl1.Enabled = true;
            txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtPass.Enabled = txtDiaChi.Enabled =
            nGAYSINHDateEdit.Enabled = cmbMaLop.Enabled = pHAICheckBox.Enabled = dANGHIHOCCheckBox.Enabled = false;

            btnXChuyenLop.Enabled=btnXThem.Enabled = btnXSua.Enabled = btnXXoa.Enabled = btnXLamLai.Enabled = btnXThoat.Enabled = true;
            btnXGhi.Enabled = btnXPhucHoi.Enabled = false;

            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(dS.SINHVIEN);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
        }

        private void btnXChuyenLop_Click(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            //this.lOPTableAdapter.Fill(dS.LOP);
            malop = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString();
            SV_Chuyen = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MASV"].ToString();
       
            btnXGhi.Enabled = btnXPhucHoi.Enabled = true;
            btnXChuyenLop.Enabled = btnXThem.Enabled = btnXSua.Enabled = btnXXoa.Enabled =btnXLamLai.Enabled = btnXThoat.Enabled = false;
            txtHoSV.Enabled = txtTenSV.Enabled = txtPass.Enabled = txtDiaChi.Enabled = txtMaSV.Enabled =
            nGAYSINHDateEdit.Enabled = pHAICheckBox.Enabled = dANGHIHOCCheckBox.Enabled = false;
            sINHVIENGridControl1.Enabled = lOPGridControl1.Enabled = false;
            cmbMaLop.Enabled = true;
            checkchuyenlop = true;
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}