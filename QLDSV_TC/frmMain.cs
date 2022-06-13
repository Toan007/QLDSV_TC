using QLdSV_TC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            rbbBaoCao.Visible = rbbQuanTri.Visible = false;
            btnDangXuat.Enabled = btnTaoTK.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void PhanQuyen()
        {
            if (Program.mGroup.Equals("Sinh Viên"))
            {
                btnDangKi.Enabled = true;
                btnDiem.Enabled = btnHocPhi.Enabled = btnLopHoc.Enabled = btnLopTC.Enabled = btnMonHoc.Enabled = btnSinhvien.Enabled = btnTaoTK.Enabled = false;
                rbbBaoCao.Visible = false;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                btnHocPhi.Enabled = true;
                btnDiem.Enabled = btnLopHoc.Enabled = btnLopTC.Enabled = btnMonHoc.Enabled = btnSinhvien.Enabled = btnDangKi.Enabled = false;
                btnRP_DiemTongKet.Enabled = btnRP_BDMH.Enabled = btnRP_DSLTC.Enabled = btnRP_DSSV.Enabled = btnRP_PhieuDiem.Enabled = false;
                btnRP_HocPhi.Enabled = true;
                rbbBaoCao.Visible = true;
                
            }
            else if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                btnDangKi.Enabled = btnHocPhi.Enabled = false;
                btnRP_HocPhi.Enabled = false;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();  
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            Ma.Text = "Mã: " + Program.username;
            Ten.Text = "Họ tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
            rbbQuanTri.Visible = rbbBaoCao.Visible = btnDangXuat.Enabled = btnTaoTK.Enabled = true;
            btnDangNhap.Enabled = false;
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất khỏi tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
                // Clear user info in status bar
                Program.frmChinh.Ma.Text = "Mã : trống";
                Program.frmChinh.Ten.Text = "Họ tên: trống";
                Program.frmChinh.Nhom.Text = "Nhóm: trống";
                rbbQuanTri.Visible = rbbBaoCao.Visible = btnTaoTK.Enabled = btnDangXuat.Enabled = false;
                rbbHeThong.Visible = btnDangNhap.Enabled = true;
            }
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmLopHoc f = new frmLopHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDSLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmInDSLTC f = new frmInDSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInSVDKLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmInSVDKLTC f = new frmInSVDKLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInBDMH));
            if (frm != null) frm.Activate();
            else
            {
                frmInBDMH f = new frmInBDMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmIn_Diem));
            if (frm != null) frm.Activate();
            else
            {
                frmIn_Diem f = new frmIn_Diem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmIn_HocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmIn_HocPhi f = new frmIn_HocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnRP_DiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(frmIN_BDTK));
            if (frm != null) frm.Activate();
            else
            {
                frmIN_BDTK f = new frmIN_BDTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmHP));
            if (frm != null) frm.Activate();
            else
            {
                frmHP f = new frmHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTC));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTC f = new frmLopTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangky));
            if (frm != null) frm.Activate();
            else
            {
                frmDangky f = new frmDangky();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}

 