using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class rpSVDKLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpSVDKLTC(string nienkhoa, int hocky, string monhoc, int nhom)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_In_SVDKLTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_In_SVDKLTCTableAdapter.Fill(ds1.SP_In_SVDKLTC, nienkhoa,hocky,monhoc,nhom);
        }

    }
}
