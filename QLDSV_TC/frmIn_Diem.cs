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
    public partial class frmIn_Diem : Form
    {
        public frmIn_Diem()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            string masv = cmbMaSV.Text;
            
            rpDiemSV rpt = new rpDiemSV(masv);
            rpt.xrMaSV.Text = cmbMaSV.SelectedValue.ToString();
            
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
                this.ds_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_SVTableAdapter.Fill(this.dS.ds_SV);
            }
        }

        private void frmIn_Diem_Load(object sender, EventArgs e)
        {
            this.ds_SVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_SVTableAdapter.Fill(this.dS.ds_SV);
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
    }
}
