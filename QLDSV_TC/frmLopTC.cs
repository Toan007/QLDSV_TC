using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDSV_TC
{
    public partial class frmLopTC : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private DataRowView da;
        private int vt;

        public frmLopTC()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOPTINCHI.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLopTC_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            
            cmbChiNhanh.DataSource = Program.bds_dspm1;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "KHOA")
            {
                cmbChiNhanh.Enabled = false;
            }
            labelMa.Visible = false;
            loadCmb(sender, e);
            btnThem.Enabled = true;
            btnHuy.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;

        }
        private void lOPTINCHIGridControl_Click_2(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnHuy.Enabled = btnGhi.Enabled  = false;
        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = false;
            btnThem.Enabled = btnGhi.Enabled = btnHuy.Enabled = true;
            MAMH.Enabled = MAGV.Enabled = NIENKHOA.Enabled = HOCKY.Enabled = NHOM.Enabled = SOSVTOITHIEU.Enabled = checkHuyLop.Enabled = true;
            labelMa.Visible = true;
            bdsLOPTINCHI.AddNew();
            bdsMAKHOA.Text = ((DataRowView)bdsLOPTINCHI[0])["MAKHOA"].ToString();
            checkHuyLop.Checked = false;
            lOPTINCHIGridControl.Enabled = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maloptc = "";
            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maloptc = ((DataRowView)bdsLOPTINCHI[bdsLOPTINCHI.Position])["MALTC"].ToString();
                    vt = bdsLOPTINCHI.Position;
                    da = (DataRowView)bdsLOPTINCHI[bdsLOPTINCHI.Position];
                    bdsLOPTINCHI.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp : " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                    bdsLOPTINCHI.Position = bdsLOPTINCHI.Find("MALTC", maloptc);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            labelMa.Visible = true;
            NIENKHOA.Enabled = HOCKY.Enabled = NHOM.Enabled
              = MAMH.Enabled = MAGV.Enabled = SOSVTOITHIEU.Enabled = checkHuyLop.Enabled = true;
            btnHuy.Enabled = false;
            btnXoa.Enabled = btnGhi.Enabled = btnSua.Enabled = btnGhi.Enabled = btnHuy.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HOCKY.Value == 0)
            {
                MessageBox.Show("Học kì không được thiếu!", "", MessageBoxButtons.OK);
                HOCKY.Focus();
                return;
            }
            if (SOSVTOITHIEU.Value == 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK);
                SOSVTOITHIEU.Focus();
                return;
            }
            if (NHOM.Value == 0)
            {
                MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK);
                NHOM.Focus();
                return;
            }
            if (MAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                MAMH.Focus();
                return;
            }
            if (MAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được thiếu!", "", MessageBoxButtons.OK);
                MAGV.Focus();
                return;
            }
            if (NIENKHOA.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK);
                NIENKHOA.Focus();
                return;
            }
            labelMa.Visible = false;
            NIENKHOA.Enabled = HOCKY.Enabled = NHOM.Enabled
               = MAMH.Enabled = MAGV.Enabled = SOSVTOITHIEU.Enabled = checkHuyLop.Enabled = false;
            bdsLOPTINCHI.EndEdit();
            bdsLOPTINCHI.ResetCurrentItem();
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled  = true;
            btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bdsLOPTINCHI.AddNew();
            //  MALTC.text = ((DataRowView)da)["MALTC"].ToString();
            //  btnHuy.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //  bdsLOPTINCHI.RemoveCurrent();
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            lOPTINCHIGridControl.Enabled = true;
            btnHuy.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = true;
            labelMa.Visible = false;
            NIENKHOA.Enabled = HOCKY.Enabled = NHOM.Enabled
              = MAMH.Enabled = MAGV.Enabled = SOSVTOITHIEU.Enabled = checkHuyLop.Enabled = false;
        }

        private void lOPTINCHIGridControl_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnHuy.Enabled  = true;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);

            }


        }
        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LayDSGV";
            dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cmbGV.DataSource = bdsgv;
            cmbGV.DisplayMember = "HOTEN";
            cmbGV.ValueMember = "MAGV";
            cmbGV.SelectedIndex = 0;
        }

        private void loadCmb(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);


            cmbMH.DataSource = bdsMonHoc;
            cmbMH.ValueMember = "MAMH";
            cmbMH.DisplayMember = "TENMH";

            loadGVcombobox();
            //    cmbMH.Enabled = cmbGV.Enabled = NIENKHOA.Enabled = HOCKY.Enabled = NHOM.Enabled = SOSVTOITHIEU.Enabled = checkHuyLop.Enabled = true;
        }
        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {

           tedMH.Text = cmbMH.SelectedValue.ToString();

        }

        private void cmbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cmbGV.SelectedValue.ToString();
          //  MessageBox.Show("x " + x);
            if (x == "System.Data.DataRowView" || x == null)
                tedGV.Text = " ";
            else
                tedGV.Text = cmbGV.SelectedValue.ToString();

        }

        private void labelMa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}