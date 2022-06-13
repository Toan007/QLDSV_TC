using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class rpDSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDSLTC(string nienkhoa,int hocky)
        {
            InitializeComponent();
            this.sP_IN_DSLTCTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_IN_DSLTCTableAdapter1.Fill(ds1.SP_IN_DSLTC,nienkhoa,hocky);
        }

    }
}
