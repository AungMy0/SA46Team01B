using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SA46Team01B
{
    public partial class SportsFacility : Form
    {
        SA46Team01BEntities7 context = new SA46Team01BEntities7();
        List<SportFacility> sportList;
        List<SportFacilityDetail> sportDetailList;
        int largest;
        Main myParent;

        public string sportPrice;
        public SportsFacility(Main Parent)
        {
            InitializeComponent();
            myParent = Parent; //inserted
        }

        private void SportsFacility_Load(object sender, EventArgs e)
        {
            SportsFacilityGridForm sfg = new SportsFacilityGridForm(myParent);

            List<SportFacilityDetail> sportDetail = context.SportFacilityDetails.Where(x => x.SportFacilityNo == lblSportNo.Text).ToList();
            dataGridViewChild.DataSource = sportDetail;
            sportList = context.SportFacilities.ToList();
            sportDetailList = context.SportFacilityDetails.ToList();
            btnParentSave.Enabled = false;
            btnChildSave.Enabled = false;
        }

        private void btnParentNew_Click(object sender, EventArgs e)
        {
            btnParentSave.Enabled = true;
            btnParentUpdate.Enabled = false;
            txtSportFacName.Enabled = true;
            txtPricePerHr.Enabled = true;
            
            sportList = context.SportFacilities.ToList();

            largest = Convert.ToInt16(sportList[0].SportFacilityNo);
            for (int i = 0; i < sportList.Count; i++)
            {
                if (largest < Convert.ToInt16(sportList[i].SportFacilityNo))
                    largest = Convert.ToInt16(sportList[i].SportFacilityNo);
            }
            lblSportNo.Text = (largest + 1).ToString();
            txtSportFacName.Text = "";
            txtPricePerHr.Text = "";      
            groupBox1.Enabled = false;
        }

        private void btnParentSave_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtSportFacName.Text, out value))
            {
                MessageBox.Show("Name must be string");
            }
            else
            {
                decimal d;
                if (decimal.TryParse(txtPricePerHr.Text, out d))
                {
                    SportFacility newSportFacility = new SportFacility();
                    newSportFacility.SportFacilityNo = lblSportNo.Text;
                    newSportFacility.SportFacilityName = txtSportFacName.Text;
                    newSportFacility.PricePerHour = Convert.ToDecimal(txtPricePerHr.Text);
                    context.SportFacilities.Add(newSportFacility);
                    context.SaveChanges();
                    groupBox1.Enabled = true;
                    MessageBox.Show("New Sport has been added successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Price must be integer or decimal");
                }
                SportsFacilityGridForm sgf = new SportsFacilityGridForm(myParent);
                
                btnParentUpdate.Enabled = true;
            }
        }
        

        private void btnParentUpdate_Click(object sender, EventArgs e)
        {

            int value;
            if (int.TryParse(txtSportFacName.Text, out value))
            {
                MessageBox.Show("Name must be string");
            }
            else
            {
                decimal d;
                if (decimal.TryParse(txtPricePerHr.Text, out d))
                {
                    int c = SportsFacilityGridForm.index;
                    sportList[c].SportFacilityName = txtSportFacName.Text;
                    sportList[c].PricePerHour = Convert.ToDecimal(txtPricePerHr.Text);
                    context.SaveChanges();
                    MessageBox.Show("Updated Sucessfully");
                    
                }
                else
                {
                    MessageBox.Show("Price must be integer or decimal");
                }
            }
            
        }

        private void dataGridViewChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {             
            string sportID = dataGridViewChild.SelectedRows[0].Cells["SportFacilityID"].Value.ToString();
            string sportQuota = dataGridViewChild.SelectedRows[0].Cells["Quota"].Value.ToString();
            string sportLocation = dataGridViewChild.SelectedRows[0].Cells["Location"].Value.ToString();
            string sportDescription = dataGridViewChild.SelectedRows[0].Cells["Description"].Value.ToString();
            lblSP_ID.Text = sportID;
            txtDescription.Text = sportDescription;
            txtQuota.Text = sportQuota;
            txtLocation.Text = sportLocation;  
        }

        private void btnChildNew_Click(object sender, EventArgs e)
        {
            btnChildSave.Enabled = true;
            btnChildUpdate.Enabled = false;
            btnParentNew.Enabled = false;
            btnParentSave.Enabled = false;
            btnParentUpdate.Enabled = false;
            txtSportFacName.Enabled = false;
            txtPricePerHr.Enabled = false;
            sportDetailList = context.SportFacilityDetails.ToList();   
            for (int i = 0; i < sportDetailList.Count(); i++)
            {
                if (lblSportNo.Text == sportDetailList[i].SportFacilityNo.Substring(0, 1))
                {
                    largest = Convert.ToInt16(sportDetailList[0].SportFacilityID.Substring(2, 2));
                    for (int j = 0; j<sportList.Count; j++)
                         {
                           if (largest < Convert.ToInt16(sportDetailList[i].SportFacilityID.Substring(2, 2)))
                              largest = Convert.ToInt16(sportDetailList[i].SportFacilityID.Substring(2, 2));
                         }
                }
            }

            int threeNum = Convert.ToInt16(largest) + 1;
            if (threeNum.ToString().Length == 1)
            { lblSP_ID.Text = lblSportNo.Text + "-0" + threeNum.ToString(); }
            else
            {
                lblSP_ID.Text = lblSportNo.Text + "-" + threeNum.ToString();
            }

            txtQuota.Text = "";
            txtLocation.Text = "";
            txtDescription.Text = "";
             
        }

        private void btnChildSave_Click(object sender, EventArgs e)
        {
                int value;
            if (int.TryParse(txtQuota.Text, out value))
            {
                SportFacilityDetail newSportDetail = new SportFacilityDetail();
                    newSportDetail.SportFacilityID = lblSP_ID.Text;
                    newSportDetail.SportFacilityNo = lblSportNo.Text;
                    newSportDetail.Description = txtDescription.Text;
                    newSportDetail.Location = txtLocation.Text;
                    newSportDetail.Quota = Convert.ToInt32(txtQuota.Text);
                    context.SportFacilityDetails.Add(newSportDetail);
                    context.SaveChanges();
                List<SportFacilityDetail> sportDetail = context.SportFacilityDetails.Where(x => x.SportFacilityNo == lblSportNo.Text).ToList();
                dataGridViewChild.DataSource = sportDetail;
                btnChildUpdate.Enabled = true;
                btnParentNew.Enabled = true;
                btnParentSave.Enabled = true;
                btnParentUpdate.Enabled = true;
                MessageBox.Show("New SportDetail has been added successfully!", "Success");

        }
                else
                {
                    MessageBox.Show("Quota must be integer");
                }
}
        private void btnChildUpdate_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtQuota.Text, out value))
            {
                int index = sportDetailList.FindIndex(x => x.SportFacilityID == lblSP_ID.Text);
                sportDetailList[index].Quota = Convert.ToInt16(txtQuota.Text);
                sportDetailList[index].Location = txtLocation.Text;
                sportDetailList[index].Description = txtDescription.Text;
                context.SaveChanges();
                MessageBox.Show("Updated Sucessfully");
                dataGridViewChild.Update();
                dataGridViewChild.Refresh();
                
            }
            else
            {
                MessageBox.Show("Quota must be integer");
            }
        }


    }
}


