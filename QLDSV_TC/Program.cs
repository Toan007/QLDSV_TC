using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace QLDSV_TC
{
    static class Program
    {
        public static string constr = ConfigurationManager.ConnectionStrings["QLDSV_TC.Properties.Settings.QLDSV_TCConnectionString"].ToString();
        public static SqlConnection conn = new SqlConnection(constr);
        public static string constr2 = ConfigurationManager.ConnectionStrings["QLDSV_TC.Properties.Settings.QLDSV_TCConnectionString4"].ToString();
        public static SqlConnection conn2 = new SqlConnection(constr2);
        public static String connstr;
        public static String connstr_publisher = "Data Source= DESKTOP-00M9PPR;Initial Catalog=QLDSV_TC;integrated security=true";
        public static SqlDataReader myReader;   
        public static String servername = "";
        public static int mChiNhanh;
        public static String username;
        public static String password;
        public static String database = "QLDSV_TC";
        public static String mlogin;

        public static String mGroup;
        public static String mHoten;

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static frmMain frmChinh;
        public static BindingSource bds_dspm = new BindingSource(); // giu bdsPM khi dang nhap
        public static BindingSource bds_dspm1 = new BindingSource();
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static SqlDataReader ExecSqlDataReader(String cmd) //, String connectionstring
        {          
            //con.Open();
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReader2(String cmd) //, String connectionstring
        {
            //con.Open();
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn2);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn2.State == ConnectionState.Closed) Program.conn2.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;  
        }


        public static void ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery(); //conn.Close()
                MessageBox.Show("Thao tác thành công!!", "", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Program.conn.Close();
            }
        }
        

        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
