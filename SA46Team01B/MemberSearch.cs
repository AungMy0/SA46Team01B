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
    public partial class MemberSearch : Form
    {
        Main myParent;
        MemberForm sender;
        List<Member> memberList;
        public MemberSearch(Main parent, MemberForm sender)
        {
            InitializeComponent();

            myParent = parent;

            this.sender = sender;

            memberList = myParent.memberList;

            ResultCountlabel.Hide();
            
        }

        //---------------------------------------------------------Button Event---------------------------------------------------
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string Name = NametextBox.Text;
            string Address = AddresstextBox.Text;
            string PhoneNo = PhoneNotextBox.Text;
            string Age = AgetextBox.Text;
            string Category = CategorytextBox.Text;

            string MemberID = MemberIDtextBox.Text;

            if(MemberID != "") memberList = memberList.Where(x => x.MemberID.ToString().ToLower() == MemberID.ToLower()).ToList();
            if(Category != "") memberList = memberList.Where(x => x.Category.ToLower() == Category.ToLower()).ToList();

            dataGridView1.DataSource = memberList.Where(x => correctNull(x.MemberName).ToLower().Contains(Name.ToLower()) && correctNull(x.Address).ToLower().Contains(Address.ToLower()) && correctNull(x.PhoneNo).Contains(PhoneNo) && correctNull(Convert.ToString(x.Age)).Contains(Age)).Select(x => new { x.MemberID, x.MemberName, x.Address, x.Age, x.PhoneNo, x.Category, x.AmountSpend }).ToList();
            dataGridView1.AutoResizeColumns();

            ResultCountlabel.Text = String.Format("Results: {0}",dataGridView1.RowCount);
            ResultCountlabel.Show();

            memberList = myParent.memberList;
        }

        private string correctNull(string myString) //support method for search button click event
        {
            string correctString = "";
            if (myString != null) correctString = myString;
            return correctString;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------Datagridview event---------------------------------------------------------------
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;

            string MemberID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            this.sender.ReceiveMemberDetails(MemberID);

            this.Close();
        }


    }
}
