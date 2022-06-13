using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection(); 
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        private void LayDSPM1(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm1.DataSource = dt;
            
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("\nLỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại Tên Server và tên của Publisher, và tên CSDL trong chuỗi kết nối.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
      

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            LayDSPM1("SELECT * FROM Get_Subscribes1");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (rdbSV.Checked == false && rdbGV.Checked == false)
            {
                MessageBox.Show("Chưa chọn nhóm đăng nhập!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
                if (txtUserName.Text.Trim() == "" || txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (rdbSV.Checked){
                string strlenh = "EXEC CHECK_EXISTS_SV_PASS '" + txtUserName.Text + "','" + txtPassWord.Text + "'";
                if (cmbChiNhanh.SelectedIndex == 0)
                {
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                }
                else
                {
                    Program.myReader = Program.ExecSqlDataReader2(strlenh);
                }
                MessageBox.Show(strlenh, "", MessageBoxButtons.OK);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                
                if (Program.myReader.HasRows == false)
                {
                    MessageBox.Show("Mã sinh viên hoặc mật khẩu không tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                Program.mlogin = "TKSV"; Program.password = "123456";   
                if (Program.KetNoi() == 0) return;

                Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
                string strlenh1 = "EXEC SP_ThongTinSV '"+ txtUserName.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                //if (Program.myReader.HasRows == false)
                //{
                //    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại user name và password.\n ", "", MessageBoxButtons.OK);
                //    return;
                //}
            }
            if (rdbGV.Checked)
            {
                Program.mlogin = txtUserName.Text; Program.password = txtPassWord.Text;
                   
                if (Program.KetNoi() == 0) return;

                Program.mChiNhanh = cmbChiNhanh.SelectedIndex;

                string strlenh = "EXEC SP_ThongTinGV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
            }
            Program.username = Program.myReader.GetString(0);         
            // Lay user name
            if (Convert.IsDBNull(Program.username))
           {
               MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại user name và password.\n ", "", MessageBoxButtons.OK);
                return;
            }
           Program.mHoten = Program.myReader.GetString(1);
           Program.mGroup = Program.myReader.GetString(2);
            
            MessageBox.Show("Đăng nhập thành công tài khoản \n- Mã: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "", MessageBoxButtons.OK);
           
           Program.myReader.Close();
           Program.conn.Close();   
           Program.frmChinh.HienThiMenu();Program.frmChinh.PhanQuyen();

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
        }


        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }
    }
}
