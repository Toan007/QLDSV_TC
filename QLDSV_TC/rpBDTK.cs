using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class rpBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBDTK()
        {
            InitializeComponent();
        }
        public rpBDTK(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
        }

    }
}
