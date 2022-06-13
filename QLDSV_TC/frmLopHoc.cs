using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmLopHoc : Form
    {
        int vitri = 0;
        bool checksua = false;
        string macn = "";
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            
            this.dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;                     
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            
            cmbKhoa.DataSource = Program.bds_dspm1;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "PGV") cmbKhoa.Enabled = true;
            else if (Program.mGroup == "KHOA") cmbKhoa.Enabled = false;
            barBtnPhucHoi.Enabled = barBtnGhi.Enabled = false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
              
            }
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPBindingSource.Position;
            lOPBindingSource.AddNew();
            txtMaLop.Enabled = txtTenLop.Enabled = txtKhoaHoc.Enabled =  true;
            cmbMakhoa.Enabled = false;

             lOPGridControl.Enabled = false;

            cmbMakhoa.Text = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MAKHOA"].ToString();
            

            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = false;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = true;
           
        }


        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barBtnLamLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(dS.LOP);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải lại", "", MessageBoxButtons.OK);
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if (sINHVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì lớp có sinh viên đăng ký lớp", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                {
                    try
                    {
                        malop = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString();
                        lOPBindingSource.RemoveCurrent();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        lOPBindingSource.Position = lOPBindingSource.Find("MALOP", malop);
                        return;
                    }
                }
                if (lOPBindingSource.Count == 0) barBtnXoa.Enabled = false;
            }

        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPBindingSource.Position;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = true;
            lOPGridControl.Enabled = false;
            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = false;                    
            checksua = true;
            txtMaLop.Enabled = cmbMakhoa.Enabled = false;
            txtKhoaHoc.Enabled = txtTenLop.Enabled = true;
        }
        private void ghi_lop()
        {
            try
            {
                lOPBindingSource.EndEdit();
                lOPBindingSource.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = true;

            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = true;          
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = false;
            txtMaLop.Enabled = cmbMakhoa.Enabled = false;
            txtKhoaHoc.Enabled = txtTenLop.Enabled = false;
        }
        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return;
            }
            if(checksua == true)
            {
                this.ghi_lop();
            }
            else
            {
                string strlenh = "EXEC KT_MALOP_TRUNG '" + txtMaLop.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                if (Program.myReader.HasRows == true)
                {
                    MessageBox.Show("Mã lớp trùng.\nBạn xem lại mã lớp học.\n ", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                    
                }

                this.ghi_lop();
            }
           
        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPBindingSource.CancelEdit();
            if (barBtnThem.Enabled == false) lOPBindingSource.Position = vitri;
            lOPGridControl.Enabled = true;
            
            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = true;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = false;
            this.lOPTableAdapter.Fill(dS.LOP);
            txtMaLop.Enabled = cmbMakhoa.Enabled = txtKhoaHoc.Enabled = txtTenLop.Enabled = false;
            
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
