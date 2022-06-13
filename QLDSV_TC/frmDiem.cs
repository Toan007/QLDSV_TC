using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDSV_TC
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            cmbChiNhanh.DataSource = Program.bds_dspm1;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            //   cmbChiNhanh.Items.RemoveAt(0);

            if (Program.mGroup == "KHOA")
            {
                cmbChiNhanh.Enabled = false;
            }
            cbMonHoc.DataSource = bdsMonHoc;
            cbMonHoc.DisplayMember = "TENMH";
            cbMonHoc.ValueMember = "MAMH";
            MaMH.Enabled = false;
            MaMH.Text = cbMonHoc.SelectedValue.ToString();
            loadcbNienkhoa();
            loadBDMH();

        }
        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cmbNienKhoa.DataSource = bdsNienKhoa;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }

        void loadBDMH()
        {
            string cmd = "EXEC [dbo].[SP_BDMH] '" + cmbNienKhoa.Text + "', " + cmbHocKy.Text + ", " + cmbNhom.Text + ", N'" + cbMonHoc.SelectedValue.ToString() + "'";
            //  MessageBox.Show(cmd);
            DataTable diemTable = Program.ExecSqlDataTable(cmd);
            this.bdsDiem.DataSource = diemTable;
            this.DiemGridControl.DataSource = this.bdsDiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadBDMH();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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

                loadBDMH();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bdsTemp = (BindingSource)this.DiemGridControl.DataSource;
            if (bdsTemp == null)
            {
                MessageBox.Show("Chưa có thông tin để ghi điểm!", "", MessageBoxButtons.OK);
                return;
            }

            bdsTemp.EndEdit();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {


                for (int i = 0; i < bdsTemp.Count; i++)
                {

                    SqlCommand cmd1 = new SqlCommand("SP_XULY_DIEM", conn);
                    cmd1.Connection = conn;
                    cmd1.Transaction = tran;



                    cmd1.CommandType = CommandType.StoredProcedure;
                    string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                    cmd1.Parameters.Add(new SqlParameter("@MSSV", masv));
                    cmd1.Parameters.Add(new SqlParameter("@MALTC", ((DataRowView)bdsTemp[i])["MALC"].ToString()));
                    float diemcc = 0;
                    float diemgk = 0;
                    float diemck = 0;
                    if (((DataRowView)bdsTemp[i])["DIEM_CC"].ToString() != "")
                    {
                        diemcc = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CC"].ToString());
                    }
                    if (((DataRowView)bdsTemp[i])["DIEM_GK"].ToString() != "")
                    {
                        diemgk = float.Parse(((DataRowView)bdsTemp[i])["DIEM_GK"].ToString());
                    }
                    if (((DataRowView)bdsTemp[i])["DIEM_CK"].ToString() != "")
                    {
                        diemck = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CK"].ToString());
                    }
                    if (diemcc < 0 || diemcc > 10 || diemck < 0 || diemck > 10 || diemgk < 0 || diemgk > 10)
                    {
                        tran.Rollback();
                        XtraMessageBox.Show("Điểm số chỉ được nhập từ 0 đến 10! Xin vui lòng nhập lại");
                        conn.Close();
                        loadBDMH();
                        return;
                    }
                    cmd1.Parameters.Add(new SqlParameter("@DIEMCC", diemcc));
                    cmd1.Parameters.Add(new SqlParameter("@DIEMGK", diemgk));
                    cmd1.Parameters.Add(new SqlParameter("@DIEMCK", diemck));
                    cmd1.ExecuteNonQuery();


                }


                tran.Commit();
            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);
                    loadBDMH();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
            XtraMessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
            string cmd2 = "EXEC [dbo].[SP_BDMH] '" + cmbNienKhoa.Text + "', " + cmbHocKy.Text + ", " + cmbNhom.Text + ", N'" + cbMonHoc.SelectedValue.ToString() + "'";
            DataTable diemTable = Program.ExecSqlDataTable(cmd2);
            this.bdsDiem.DataSource = diemTable;
            this.DiemGridControl.DataSource = this.bdsDiem;
            return;
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string x = cbMonHoc.SelectedValue.ToString();
            if (cbMonHoc.SelectedValue.ToString() == null)
                MaMH.Text = "";
            else
                MaMH.Text = cbMonHoc.SelectedValue.ToString();
        }

    }
}