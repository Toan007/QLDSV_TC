using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class rpDiemSV : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDiemSV(string masv)
        {
            InitializeComponent();
            this.sP_In_DiemSvTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_In_DiemSvTableAdapter.Fill(ds1.SP_In_DiemSv, masv);
        }

    }
}
