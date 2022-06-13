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
    public partial class frmIn_HocPhi : Form
    {
        public frmIn_HocPhi()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string nienkhoa = cmbNienKhoa.SelectedValue.ToString();
            int hocky = Int32.Parse(cmbHocKy.SelectedValue.ToString());
            string malop = cmbMaLop.Text;
            
            string tienchu = "";
            string strLenh = "EXEC [dbo].[SP_TongTienHocPhiChu] '" + malop + "', '" + nienkhoa + "', " + hocky;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            tienchu = Program.myReader.GetString(0);
            Program.myReader.Close();
            rpHOCPHI rpt = new rpHOCPHI(malop,nienkhoa, hocky);
            rpt.xrMaLop.Text = malop;
            rpt.xrKhoa.Text = cmbMaLop.SelectedValue.ToString();
            rpt.xrTienChu.Text = tienchu;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void frmIn_HocPhi_Load(object sender, EventArgs e)
        {
            dS_HP.EnforceConstraints = false;
            this.cmbMaLopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cmbMaLopTableAdapter.Fill(this.dS_HP.CmbMaLop);
            this.cmbHKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cmbHKTableAdapter.Fill(this.dS_HP.CmbHK);
            this.cmbNKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cmbNKTableAdapter.Fill(this.dS_HP.CmbNK);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
