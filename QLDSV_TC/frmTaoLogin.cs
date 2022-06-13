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
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
               txtLogin.Focus();
                return;
            }

            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            if (txtRePass.Text.Trim() == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txtRePass.Focus();
                return;
            }
            if (txtRePass.Text != txtPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txtRePass.Focus();
                return;
            }
            if (rdoKhoa.Checked == false && rdoPGV.Checked == false && rdoPKT.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản!", "", MessageBoxButtons.OK);
                rdoKhoa.Focus();
                return;
            }
            string role = "";
            if (rdoKhoa.Checked) role = "KHOA";
            if (rdoPGV.Checked) role = "PGV";
            if (rdoPKT.Checked) role = "PKT";

            

            string strlenh = "EXEC [dbo].[SP_Kt_Loginname] '" + txtLogin.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.\nBạn xem lại tên đăng nhập.\n ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;               
            }
            Program.myReader.Close();
            string strlenh1 = "EXEC [dbo].[SP_Kt_Username] '" + cmbMaGV.SelectedValue + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh1);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show("Mã giáo viên đã tạo login.\nBạn xem lại mã giáo viên.\n ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;                
            }
            Program.myReader.Close();
            Program.ExecSqlNonQuery("EXEC [dbo].[SP_TAOLOGIN] '" + txtLogin.Text + "','" + txtPass.Text + "','" + cmbMaGV.SelectedValue + "','" + role + "'");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
          
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            
            this.gIANGVIEN1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIEN1TableAdapter.Fill(this.dS.GIANGVIEN1);

            if (Program.mGroup.Equals("KHOA"))
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoPKT.Enabled = false;
            }
            if (Program.mGroup.Equals("PGV"))
            {
                rdoPKT.Enabled = false;
                rdoKhoa.Enabled = rdoPGV.Enabled = true;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                rdoPKT.Checked = true;
                rdoKhoa.Enabled = rdoPGV.Enabled = false;
            }

        }
    }
}
