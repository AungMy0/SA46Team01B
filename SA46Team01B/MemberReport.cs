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

namespace SA46Team01B
{
    public partial class MemberReport : Form
    {
        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            string Cons = "data source = (local); integrated security = SSPI; database = SA46Team01B";
            SqlConnection cn = new SqlConnection(Cons);
            cn.Open();

            string command = "SELECT * FROM Member";
            SqlCommand cmd = new SqlCommand(command, cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            MemberDataSet myMemberDataSet = new MemberDataSet();
            da.Fill(myMemberDataSet, "Member");
            cn.Close();

            MemberCR myMemberCR = new MemberCR();
            myMemberCR.SetDataSource(myMemberDataSet);
            MemberCRV.ReportSource = myMemberCR;
        }
    }
}
