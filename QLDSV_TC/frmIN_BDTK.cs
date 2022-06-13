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
    public partial class frmIN_BDTK : Form
    {
        public frmIN_BDTK()
        {
            InitializeComponent();
        }

        private void frmIN_BDTK_Load(object sender, EventArgs e)
        {
            this.ds_Lop_KhoaHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_Lop_KhoaHocTableAdapter.Fill(this.dS.ds_Lop_KhoaHoc);
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            string malop = cmbMaLop.Text;
            string khoa = cmbKhoa.Text;
         
           
            rpBDTK rpt = new rpBDTK(malop);
            rpt.xrLop.Text = malop;
            rpt.xrKhoaHoc.Text = cmbMaLop.SelectedValue.ToString();
            rpt.xrKhoa.Text = khoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                this.ds_Lop_KhoaHocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_Lop_KhoaHocTableAdapter.Fill(this.dS.ds_Lop_KhoaHoc);
            }
        }
    }
}
