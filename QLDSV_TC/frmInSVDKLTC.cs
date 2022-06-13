using DevExpress.XtraReports.UI;
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
    public partial class frmInSVDKLTC : Form
    {
        public frmInSVDKLTC()
        {
            InitializeComponent();
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
                this.ds_HK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_HK_LTCTableAdapter.Fill(this.dS.ds_HK_LTC);
                this.dsNK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dsNK_LTCTableAdapter.Fill(this.dS.dsNK_LTC);
                this.ds_MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_MonHocTableAdapter.Fill(this.dS.ds_MonHoc);
                this.ds_NhomTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_NhomTableAdapter.Fill(this.dS.ds_Nhom);
            }
        }

        private void frmInSVDKLTC_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.ds_HK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_HK_LTCTableAdapter.Fill(this.dS.ds_HK_LTC);
            this.dsNK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsNK_LTCTableAdapter.Fill(this.dS.dsNK_LTC);
            this.ds_MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_MonHocTableAdapter.Fill(this.dS.ds_MonHoc);
            this.ds_NhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_NhomTableAdapter.Fill(this.dS.ds_Nhom);
            cmbKhoa.DataSource = Program.bds_dspm1;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string nienkhoa = cmbNienKhoa.SelectedValue.ToString();
            int hocky = Int32.Parse(cmbHocKy.SelectedValue.ToString());
            string khoa = cmbKhoa.Text;
            string monhoc = cmbMonHoc.SelectedValue.ToString(); ;
            int nhom = Int32.Parse(cmbNhom.SelectedValue.ToString());
            rpSVDKLTC rpt = new rpSVDKLTC(nienkhoa, hocky,monhoc,nhom);
            rpt.xrKhoa.Text = khoa;
            rpt.xrHocKy.Text = hocky.ToString();
            rpt.xrNienKhoa.Text = nienkhoa;
            rpt.xrMonHoc.Text = cmbMonHoc.Text;
            rpt.xrNhom.Text = nhom.ToString();
           
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
