using DevExpress.XtraEditors;
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
    public partial class frmHP : Form
    {
        private DataTable tableHocPhi;
        public frmHP()
        {
            InitializeComponent();
        }

        private void frmHP_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            barButtonItem3.Enabled = barButtonItem2.Enabled = false;

            dS_HP.EnforceConstraints = false;
        //    this.nK_HPTableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.nK_HPTableAdapter.Fill(this.dS_HP.NK_HP);
 
        //    this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.hOCPHITableAdapter.Fill(this.dS_HP.HOCPHI);
         //   loadcbNienkhoa();
            //   this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            //   this.cT_DONGHOCPHITableAdapter.Fill(this.dS_HP.CT_DONGHOCPHI);


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

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_HP);

        }
        void loadHP()
        {
            string cmd1 = "EXEC [dbo].[SP_GetInfoSV_HP] '" + tedMaSV.Text + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd1);
            if (reader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                reader.Close();
                return;
            }
            reader.Read();
            tedHoTen.Text = reader.GetString(0);
            tedLop.Text = reader.GetString(1);
            reader.Close();
            Program.conn.Close();


            string cmd2 = "EXEC [dbo].[SP_GetDSHP_SV] '" + tedMaSV.Text + "'";

            tableHocPhi = Program.ExecSqlDataTable(cmd2);
            this.bdsHocPhi.DataSource = tableHocPhi;
            this.hOCPHIGridControl.DataSource = this.bdsHocPhi.DataSource;
        }
        private void Tim_Click(object sender, EventArgs e)
        {
            if (tedMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không thể trống");
                frmHP_Load(sender, e);
                tedMaSV.Focus();
                return;
            }
            loadHP();
            barButtonItem4.Enabled = barButtonItem6.Enabled = barButtonItem3.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel3.Enabled = true;
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = barButtonItem3.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel3.Enabled = false;
            barButtonItem2.Enabled = barButtonItem3.Enabled = false;
            barButtonItem1.Enabled  = true;
            string msv = tedMaSV.Text;
            string nienkhoa = tedNienKhoa.Text;
            string hocki = tedHK.Text;
            string hocphi = tedHP.Text;
            try
            {
                if (msv == "")
                {
                    MessageBox.Show("Mã sinh viên không thể trống");
                    return;
                }
                if (float.Parse(hocphi) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }
                if (nienkhoa == "")
                {
                    MessageBox.Show("Niên khóa chưa nhập!");
                    return;
                }
                if (hocki == "")
                {
                    MessageBox.Show("Học kỳ chưa nhập!");
                    return;
                }
                if (hocphi == "")
                {
                    MessageBox.Show("Học phí chưa nhập!");
                    return;
                }
                if (float.Parse(hocki) <= 0)
                {
                    MessageBox.Show("Học kì không được nhỏ hơn 1");
                    return;
                }
            }
            catch (Exception ex) { 

                MessageBox.Show(ex.Message);
                return;
            }


            bdsHocPhi.EndEdit();
            bdsHocPhi.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("TAO_THONGTINHOCPHI", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@HocPhi", hocphi));
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Thêm học phí thành công!");
                loadHP();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

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
        }
      

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTHP.AddNew();
             barButtonItem4.Enabled = true;
            barButtonItem3.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            {
                try
                {
                    if (((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString() == "")
                    {
                        MessageBox.Show("Số tiền không được bỏ trống");
                        return;
                    }
                    if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) <= 0)
                    {
                        MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                        return;
                    }

                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               // string nienkhoa = "";
               // string hocki = "";
               // string msv ="";

                string nienkhoa = cmbNienKhoa.Text;
                string hocki = tedHocky.Text;
                string msv = tedMaSV.Text;



                string sotiendong = ((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString();
                string ngay = ((DataRowView)bdsCTHP[bdsCTHP.Position])["NGAYDONG"].ToString();
                bdsCTHP.EndEdit();
                bdsCTHP.ResetCurrentItem();
                foreach (DataRow x in tableHocPhi.Rows)
                {
                    if(x["NIENKHOA"].ToString() == nienkhoa  &&  x["HOCKY"].ToString() == hocki){
                        float c = float.Parse(x["SOTIENCANDONG"].ToString());
                        if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) > c)
                        {
                            MessageBox.Show("Số tiền đóng không được lớn hơn số tiền cần đóng!");
                            return;
                        }
                    }
                 }
                SqlConnection conn = new SqlConnection(Program.connstr);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();
                tran = conn.BeginTransaction();
                try
                {
                   // MessageBox.Show(sotiendong);
                    SqlCommand cmd = new SqlCommand("SV_DONGTIEN", conn);
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                    cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                    cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                    cmd.Parameters.Add(new SqlParameter("@SoTienDong", sotiendong));
                    cmd.Parameters.Add(new SqlParameter("@Ngay", ngay));
                    cmd.ExecuteNonQuery();





                    tran.Commit();
                    MessageBox.Show("Thêm chi tiết học phí thành công!");
                    loadHP();


                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        XtraMessageBox.Show("Lỗi ghi chit tiết học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

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
            }
            barButtonItem4.Enabled = false;
            barButtonItem3.Enabled = true;
        }

        private void cT_DONGHOCPHIGridControl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
             
                string nienkhoa = cmbNienKhoa.Text;
                string hocki = tedHocky.Text;
                string msv = tedMaSV.Text;
                if (msv == "")
                {
                    MessageBox.Show("Mã sinh viên không thể rỗng!");
                }
                if (nienkhoa =="")          {
                    MessageBox.Show("Niên khóa không thể rỗng!");
                }
                if (nienkhoa == "")
                {
                    MessageBox.Show("Học kỳ không thể rỗng!");
                }

            string cmd = "EXEC dbo.SP_GetCTHP_SV '" + msv + "', '" + nienkhoa + "', '" + hocki + "'";

                DataTable tableCTHP = Program.ExecSqlDataTable(cmd);
                this.bdsCTHP.DataSource = tableCTHP;
                this.cT_DONGHOCPHIGridControl.DataSource = this.bdsCTHP.DataSource;
            barButtonItem3.Enabled= barButtonItem6.Enabled = true;
              barButtonItem4.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dS_HP.EnforceConstraints = false;
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.dS_HP.HOCPHI);
            this.hOCPHIGridControl.DataSource = this.bdsHocPhi;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel3.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = barButtonItem3.Enabled = false;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
