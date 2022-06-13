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
    public partial class frmMonHoc : Form
    {
        int vitri = 0;
        bool checksua = false;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;            
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            

            barBtnPhucHoi.Enabled = barBtnGhi.Enabled = false;
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            mONHOCBindingSource.AddNew();
            txtMaMH.Enabled = txtTenMH.Enabled = numbTietLT.Enabled = numbTietTH.Enabled = true;
            numbTietLT.Value = numbTietTH.Value = 0;
            mONHOCGridControl.Enabled = false;
            
            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = false;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = true;
        }

        private void barBtnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = true;
            mONHOCGridControl.Enabled = false;
            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = false;
            checksua = true;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = numbTietLT.Enabled = numbTietTH.Enabled = true;
        }
        private void ghi_mon()
        {
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCBindingSource.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            mONHOCGridControl.Enabled = true;

            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = true;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = false;
            txtMaMH.Enabled = txtTenMH.Enabled = numbTietLT.Enabled = numbTietTH.Enabled = false;
        }
        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            if (numbTietLT.Value == 0 )
            {
                MessageBox.Show("Số tiết LT Không được thiếu!", "", MessageBoxButtons.OK);
                numbTietLT.Focus();
                return;
            }
            if (numbTietTH.Value == 0)
            {
                MessageBox.Show("Số tiết TH Không được thiếu!", "", MessageBoxButtons.OK);
                numbTietTH.Focus();
                return;
            }
            if (checksua == true)
            {
                this.ghi_mon();
            }
            else
            {
                string strlenh = "EXEC KT_MAMON_TRUNG '" + txtMaMH.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                
                if (Program.myReader.HasRows == true)
                {
                    MessageBox.Show("Mã môn học trùng.\nBạn xem lại mã môn học.\n ", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                }
               
                this.ghi_mon();
            }
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamon = "";
            if (lOPTINCHIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn này vì đã có trong lớp học", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                {
                    try
                    {
                        mamon = ((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["MAMH"].ToString();
                        mONHOCBindingSource.RemoveCurrent();
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                        mONHOCBindingSource.Position = mONHOCBindingSource.Find("MAMH", mamon);
                        return;
                    }
                }
                if (mONHOCBindingSource.Count == 0) barBtnXoa.Enabled = false;
            }
        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            if (barBtnThem.Enabled == false) mONHOCBindingSource.Position = vitri;
            mONHOCGridControl.Enabled = true;

            barBtnThem.Enabled = barBtnHieuChinh.Enabled = barBtnXoa.Enabled = barBtnLamLai.Enabled = barBtnThoat.Enabled = true;
            barBtnGhi.Enabled = barBtnPhucHoi.Enabled = false;
            this.mONHOCTableAdapter.Fill(dS.MONHOC);
            txtMaMH.Enabled = txtTenMH.Enabled = numbTietLT.Enabled = numbTietTH.Enabled = false;
        }

        private void barBtnLamLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(dS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại", "", MessageBoxButtons.OK);
            }
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
