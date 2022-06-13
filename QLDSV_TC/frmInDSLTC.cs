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
    public partial class frmInDSLTC : Form
    {
        public frmInDSLTC()
        {
            InitializeComponent();
        }

 

        private void frmInDSLTC_Load(object sender, EventArgs e)
        {
            
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }
            dS.EnforceConstraints = false;
            this.ds_HK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_HK_LTCTableAdapter.Fill(this.dS.ds_HK_LTC);
            this.dsNK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsNK_LTCTableAdapter.Fill(this.dS.dsNK_LTC);
            cmbKhoa.DataSource = Program.bds_dspm1;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChiNhanh;

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
                this.ds_HK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_HK_LTCTableAdapter.Fill(this.dS.ds_HK_LTC);
                this.dsNK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dsNK_LTCTableAdapter.Fill(this.dS.dsNK_LTC);
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
            rpDSLTC rpt = new rpDSLTC(nienkhoa, hocky);
            rpt.xrKhoa.Text = khoa;
            rpt.xrHocKy.Text = hocky.ToString();
            rpt.xrNienKhoa.Text = nienkhoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
