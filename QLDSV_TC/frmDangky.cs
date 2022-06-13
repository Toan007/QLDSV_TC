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
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
        }

      

        private void frmDangky_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.thongtin_sv_DKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thongtin_sv_DKYTableAdapter.Fill(this.dS.thongtin_sv_DKY, Program.username);
            this.dS_LOP_LTC_SVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_LOP_LTC_SVTableAdapter.Fill(this.dS.DS_LOP_LTC_SV, Program.username);
            this.ds_HK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ds_HK_LTCTableAdapter.Fill(this.dS.ds_HK_LTC);
            this.dsNK_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsNK_LTCTableAdapter.Fill(this.dS.dsNK_LTC);
        }

       

        private void btnTimKiemLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.dS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dS_LTCTableAdapter.Fill(this.dS.DS_LTC, cmbNienKhoa.Text, Convert.ToInt16(cmbHocKy.Text));
            }
             catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtMaLTC.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLTC.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txtMaSV.Text + "' , '" + txtMaLTC.Text + "', " + 1;
                Program.ExecSqlNonQuery(cmd);
                //string cmd1 = "EXEC [dbo].[DS_LOP_LTC_SV] '" + txtMaSV.Text + "'";
                //Program.ExecSqlDataTable(cmd1);
                this.dS_LOP_LTC_SVTableAdapter.Fill(dS.DS_LOP_LTC_SV, txtMaSV.Text);
                this.dS_LTCTableAdapter.Fill(dS.DS_LTC, cmbNienKhoa.Text, Convert.ToInt16(cmbHocKy.Text));
            }
            else
            {
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (dS_LTCBindingSource.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp tín chỉ để hủy");
                dS_LTCGridControl.Focus();
                return;
            }
            string maltc = "";
            if (((DataRowView)dS_LOP_LTC_SVBindingSource[dS_LOP_LTC_SVBindingSource.Position])["MALTC"] != null)
            {
                maltc = ((DataRowView)dS_LOP_LTC_SVBindingSource[dS_LOP_LTC_SVBindingSource.Position])["MALTC"].ToString();
            }
            string strlenh = "EXEC SV_CO_DIEM '" + txtMaSV.Text + "'" +", '"+ maltc + "'";
           // MessageBox.Show("EXEC SV_CO_DIEM '" + txtMaSV.Text + "'" +", '" + maltc + "'");
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show(" Sinh viên đã có điểm.\n Không thể hủy đăng ký lớp tín chỉ. ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;

            }
            Program.myReader.Close();
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txtMaSV.Text + "' , '" + maltc + "', " + 2;
                Program.ExecSqlNonQuery(cmd);
                //string cmd1 = "EXEC [dbo].[DS_LOP_LTC_SV] '" + txtMaSV.Text + "'";
                //Program.ExecSqlDataTable(cmd1);
                this.dS_LOP_LTC_SVTableAdapter.Fill(dS.DS_LOP_LTC_SV, txtMaSV.Text);
                this.dS_LTCTableAdapter.Fill(dS.DS_LTC, cmbNienKhoa.Text, Convert.ToInt16(cmbHocKy.Text));
            }
            else
            {
                return;
            }
        }
    }
    
}
