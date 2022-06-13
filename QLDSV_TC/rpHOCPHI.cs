using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class rpHOCPHI : DevExpress.XtraReports.UI.XtraReport
    {
        public rpHOCPHI(string malop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sP_In_HocPhiTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_In_HocPhiTableAdapter1.Fill(ds2.SP_In_HocPhi,malop, nienkhoa, hocky);
        }

    }
}
