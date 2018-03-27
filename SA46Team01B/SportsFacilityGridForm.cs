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
    public partial class SportsFacilityGridForm : Form
    {
        List<SportFacility> sportList;
        public string sportNo;
        public string sportName;
        public string sportPrice;
        public static int index;
        Main myParent; //inserted
        public SportsFacilityGridForm(Main Parent)
        {
            InitializeComponent();
            myParent = Parent;
        }

        private void SportsFacilityGridForm_Load(object sender, EventArgs e)
        {
            SA46Team01BEntities7 context = new SA46Team01BEntities7();
            sportList = context.SportFacilities.ToList();
            dataGridViewSportFac.DataSource = sportList;
        }

        private void dataGridViewSportFac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sportNo = dataGridViewSportFac.SelectedRows[0].Cells["SportFacilityNo"].Value.ToString();
            sportName = dataGridViewSportFac.SelectedRows[0].Cells["SportFacilityName"].Value.ToString();
            sportPrice = dataGridViewSportFac.SelectedRows[0].Cells["PricePerHour"].Value.ToString();
            index=dataGridViewSportFac.CurrentCell.RowIndex;

            SportsFacility sf = new SportsFacility(myParent);

            sf.MdiParent = myParent; //inserted
            sf.Dock = DockStyle.Fill; //inserted

            sf.lblSportNo.Text = sportNo;
            sf.txtSportFacName.Text = sportName;
            sf.txtPricePerHr.Text = sportPrice;

            sf.Show(); //inserted

            



        }

    }
}
