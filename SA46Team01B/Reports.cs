using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team01B
{
    public partial class Reports : Form
    {
        Main myParent;
        public Reports(Main Parent)
        {
            InitializeComponent();
            myParent = Parent;
            myParent.CreateMemory();

        }

        private void MemberReportbutton_Click(object sender, EventArgs e)
        {
            MemberReport newMemberReport = new MemberReport();
            myParent.InstantiatedForms.Add(newMemberReport);
            newMemberReport.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Today.ToShortDateString().ToString();
        }
    }
}
