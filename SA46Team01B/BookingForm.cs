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
    public partial class BookingForm : Form
    {
        SA46Team01BEntities7 content = new SA46Team01BEntities7();
        List<Booking> Blist;
        List<Member> Mlist;
        List<SportFacility> Slist;
        List<SportFacilityDetail> SFDlist;
        List<SportFacilityDetail> SFDlist2;
        List<SportFacilityDetail> SFDlist3;
        List<BookingDetail> BDlist;
        List<BookingDetail> BDlist2;
        List<Session> Selist;
        bool cancellbtnWasClicked = false;
        List<string> Sesslist = new List<string>();
        bool session = false;
        bool session1 = false;
        bool rembtnclick = false;

        Main myParent; //inserted
        public BookingForm(Main Parent)
        {
            InitializeComponent();
            myParent = Parent; //inserted
        }
        // for loading
        private void Form2_Load(object sender, EventArgs e)
        {
            SFDlist2 = new List<SportFacilityDetail>();
            Mlist = content.Members.ToList();
            List<string> memberID = Mlist.Select(x => x.MemberID).ToList();
            List<string> membername = Mlist.Select(x => x.MemberName).ToList();
            memidbox.Text = memberID[0].ToString();
            membnbox.Text = membername[0].ToString();
            for (int i = 0; i < memberID.Count(); i++)
            {
                memidbox.Items.Add(memberID[i].ToString());
                membnbox.Items.Add(membername[i].ToString());
            }
            Slist = content.SportFacilities.ToList();
            List<string> facilityno = Slist.Select(x => x.SportFacilityNo).ToList();
            List<string> facilityname = Slist.Select(x => x.SportFacilityName).ToList();
            List<decimal> Priceh = Slist.Select(x => x.PricePerHour).ToList();
            facilityIDbox.Text = facilityno[0].ToString();
            facilitynamebox.Text = facilityname[0].ToString();
            amtlabel.Text = Priceh[0].ToString();
            for (int i = 0; i < facilityno.Count(); i++)
            {
                facilityIDbox.Items.Add(facilityno[i].ToString());
                facilitynamebox.Items.Add(facilityname[i].ToString());
            }

            Selist = content.Sessions.ToList();
            List<string> sesno = Selist.Select(x => x.SessionNo).ToList();
            sessionbox.Text = sesno[0].ToString();
            for (int i = 0; i < sesno.Count(); i++)
            {
                sessionbox.Items.Add(sesno[i].ToString());

            }
            SFDlist = content.SportFacilityDetails.ToList();
            List<string> facilityid = SFDlist.Select(x => x.SportFacilityID).ToList();
            List<int> quota = SFDlist.Select(x => x.Quota).ToList();
            List<string> facilityno1 = SFDlist.Select(x => x.SportFacilityNo).ToList();

            Blist = content.Bookings.ToList();
            int a = Blist.Count();
            string hexString = String.Format("{0:x5}", a);
            booknolabel.Text = hexString;
            dataGridView2.DataSource = Blist.Where(x => x.MemberID == memidbox.Text).Select(x => new
            {
                x.MemberID,
                x.BookingNo,
                x.TransactionDate,
                x.BookingAmount,
            }).ToList();
            dataGridView2.Show();
            dataGridView1.Hide();
            girdviewstatus.Text = "Previous Booking List";
            if (session == true)
            {
                dataGridView2.Columns.Remove("sessionno");
                session = false;
            }
        }
        // for MemberID and MemberName
        private void memidbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            membnbox.Text = Mlist.Where(x => x.MemberID == memidbox.Text).Select(x => x.MemberName).First().ToString();

            dataGridView2.DataSource = Blist.Where(x => x.MemberID == memidbox.Text).Select(x => new
            {
                x.MemberID,
                x.BookingNo,
                x.TransactionDate,
                x.BookingAmount,
            }).ToList();
            girdviewstatus.Text = "Previous Booking List";
            if (session == true)
            {
                dataGridView2.Columns.Remove("sessionno");
                session = false;
            }
        }
        private void membnbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            memidbox.Text = Mlist.Where(x => x.MemberName == membnbox.Text).Select(x => x.MemberID).First().ToString();
            dataGridView2.DataSource = Blist.Where(x => x.MemberID == memidbox.Text).Select(x => new
            {
                x.MemberID,
                x.BookingNo,
                x.TransactionDate,
                x.BookingAmount,
            }).ToList();
            girdviewstatus.Text = "Previous Booking List";
            if (session == true)
            {
                dataGridView2.Columns.Remove("sessionno");
                session = false;
            }
        }
        private void sessionbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // for facility No and Facility name
        private void facilityIDbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            facilitynamebox.Text = Slist.Where(x => x.SportFacilityNo == facilityIDbox.Text).Select(x => x.SportFacilityName).First().ToString();
            amtlabel.Text = Slist.Where(x => x.SportFacilityNo == facilityIDbox.Text).Select(x => x.PricePerHour).First().ToString();
        }
        private void facilitynamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            facilityIDbox.Text = Slist.Where(x => x.SportFacilityName == facilitynamebox.Text).Select(x => x.SportFacilityNo).First().ToString();
            amtlabel.Text = Slist.Where(x => x.SportFacilityName == facilitynamebox.Text).Select(x => x.PricePerHour).First().ToString();
        }
        // searching available booking
        private void Searchbtn_Click(object sender, EventArgs e)
        {

            cancellbtnWasClicked = false;
            dataGridView2.Show();
            BDlist2 = content.BookingDetails.ToList();
            SFDlist3 = content.SportFacilityDetails.ToList();
            List<string> SFID3 = new List<string>();
            List<SportFacilityDetail> Dlist = new List<SportFacilityDetail>();
            List<string> SFID2 = SFDlist3.Where(x => x.SportFacilityNo == facilityIDbox.Text).Select(x => x.SportFacilityID).ToList();
            List<string> SFID1 = BDlist2.Where(x => x.BookingDate.Date == dateTimePicker2.Value.Date && x.SessionNo == sessionbox.Text).Select(x => x.SportFacilityID).ToList();
            int a = 0;
            for (int i = 0; i < SFID2.Count; i++)
            {

                if (SFID1.Count == 0)
                {
                    SportFacilityDetail SportF = SFDlist3.Where(x => x.SportFacilityID == SFID2[i]).First();
                    Dlist.Add(SportF);
                }
                else
                {
                    for (int j = 0; j < SFID1.Count; j++)
                    {
                        if (SFID2[i] == SFID1[j])
                        {
                            string memID = SFID2[i];
                            int countid = BDlist2.Where(x => x.SportFacilityID == memID).Count();
                            int countquota = SFDlist3.Where(x => x.SportFacilityID == memID).Select(x => x.Quota).First();
                            a++;
                            if (countquota > countid)
                            {
                                SportFacilityDetail SportF = SFDlist3.Where(x => x.SportFacilityID == memID).First();
                                Dlist.Add(SportF);

                            }
                            else
                            {

                            }

                        }

                    }
                    if (a == 0)
                    {
                        SportFacilityDetail SportF = SFDlist3.Where(x => x.SportFacilityID == SFID2[i]).First();
                        Dlist.Add(SportF);

                    }
                    a = 0;
                }
            }
            dataGridView1.Hide();
            if (session == false)
            {
                dataGridView2.Columns.Add("sessionno", "SessionNo");
                session = true;
            }
            dataGridView2.DataSource =
                Dlist.Select(x => new
                {
                    x.SportFacilityID,
                    x.SportFacilityNo,
                    x.Location,
                    x.SportFacility.SportFacilityName,
                }).ToList();


            for (int i = 0; i < Dlist.Count(); i++)
            {
                dataGridView2.Rows[i].Cells["sessionno"].Value = sessionbox.Text;
            }
        }
        //adding the booking to the pending booking list
        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            dataGridView1.Show();
            dataGridView2.Hide();
            SportFacilityDetail SpFD = new SportFacilityDetail();
            int count = dataGridView2.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                SportFacilityDetail sf = new SportFacilityDetail();
                sf.SportFacilityID = row.Cells[1].Value.ToString();
                sf.SportFacilityNo = row.Cells[2].Value.ToString();
                sf.Location = row.Cells[3].Value.ToString();
                SFDlist2.Add(sf);
            }
            if (session1 == false)
            {
                dataGridView1.Columns.Add("sessionno1", "SessionNo");
                session = true;
            }
            dataGridView1.DataSource = SFDlist2.Select(x => new
            {
                x.SportFacilityID,
                x.SportFacilityNo,
                x.Location,
            }).ToList();
            girdviewstatus.Text = "Your Pending booking List";

            Sesslist.Add(sessionbox.Text);
            //  MessageBox.Show(Sesslist.Count.ToString());

            for (int i = 0; i < Sesslist.Count; i++)
            {
                dataGridView1.Rows[i].Cells["sessionno1"].Value = Sesslist[i];
            }
        }
        // removing from the pending booking list
        private void removebtn_Click(object sender, EventArgs e)
        {
            SportFacilityDetail SpFD1 = new SportFacilityDetail();
            int row = dataGridView1.SelectedRows[0].Index;
            SportFacilityDetail sf1 = SFDlist2[row];
            SFDlist2.Remove(sf1);
            Sesslist.Remove((dataGridView1.Rows[row].Cells["sessionno1"].Value).ToString());
            dataGridView1.DataSource = SFDlist2;

            dataGridView1.Refresh();
            girdviewstatus.Text = "Selected Booking has been deleted";
        }
        private void cancellbtn_Click(object sender, EventArgs e)
        {
            cancellbtnWasClicked = true;
            BDlist = new List<BookingDetail>();
            BDlist = content.BookingDetails.ToList();
            List<string> bookingNo = BDlist.Select(x => x.BookingNo).ToList();
            List<string> sessionno = BDlist.Select(x => x.SessionNo).ToList();
            List<string> facilityno2 = BDlist.Select(x => x.SportFacilityID).ToList();
            List<DateTime> bookingdate = BDlist.Select(x => x.BookingDate).ToList();

            dataGridView2.Show();
            dataGridView2.DataSource = BDlist.Where(x => x.BookingDate.Date == dateTimePicker1.Value.Date && x.Booking.MemberID == memidbox.Text).Select(
                x => new
                {
                    x.SportFacilityID,
                    x.BookingDate,
                    x.BookingNo,
                    x.SessionNo,
                    x.Booking.MemberID
                }).ToList();
            if (session == true)
            {
                dataGridView2.Columns.Remove("sessionno");
                session = false;
            }

            dataGridView1.Hide();
            girdviewstatus.Text = "Select to cancel and click submit";
        }
        // comfirm the booking and cancel the booking 
        private void submitbtn_Click(object sender, EventArgs e)
        {
            {
                if (cancellbtnWasClicked == true)
                {


                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        BookingDetail BDlist2 = new BookingDetail();
                        BDlist2.SportFacilityID = row.Cells["SportFacilityID"].Value.ToString();
                        MessageBox.Show("Your Booking has been cancelled");
                        BookingDetail delBD = content.BookingDetails.Where(x => x.SportFacilityID == BDlist2.SportFacilityID).First();
                        string Bno = content.BookingDetails.Where(x => x.SportFacilityID == BDlist2.SportFacilityID).Select(x => x.BookingNo).First().ToString();
                        Booking b1 = content.Bookings.Where(x => x.BookingNo == Bno).First();
                        b1.BookingAmount = b1.BookingAmount - 1;
                        //SportFacilityDetail sfd1 = content.SportFacilityDetails.Where(x => x.SportFacilityID == BDlist2.SportFacilityID).First();
                        //sfd1.Quota = sfd1.Quota + 1;
                        string BID1 = delBD.BookingNo;
                        string mID1 = content.Bookings.Where(x => x.BookingNo == BID1).Select(x => x.MemberID).First().ToString();
                        Member mber = content.Members.Where(x => x.MemberID == mID1).First();
                        string mcy = mber.Category;
                        decimal disc1 = content.MemberCategories.Where(x => x.Category == mcy).Select(x => x.Discount).First();
                        mber.AmountSpend = mber.AmountSpend - (delBD.Amount - (delBD.Amount * (disc1 / 100)));
                        content.BookingDetails.Remove(delBD);
                        content.SaveChanges();
                        cancellbtn_Click(sender, e);
                    }
                }
                else
                {
                    Member mb = new Member();
                    Booking bb = new Booking();
                    decimal total = 0;
                    SportFacilityDetail sd = new SportFacilityDetail();
                    string BID;
                    int a = Blist.Count();
                    string hexString = String.Format("{0:x5}", a);
                    booknolabel.Text = hexString;
                    bb.MemberID = memidbox.Text;
                    bb.BookingNo = hexString;
                    bb.TransactionDate = dateTimePicker1.Value;
                    bb.BookingAmount = dataGridView1.RowCount;
                    content.Bookings.Add(bb);
                    content.SaveChanges();
                    // MessageBox.Show(c);
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        BookingDetail bd = new BookingDetail();
                        bd.BookingNo = hexString;
                        BID = bd.BookingNo;
                        bd.BookingDate = dateTimePicker1.Value;
                        bd.SportFacilityID = dataGridView1.Rows[i].Cells["SportFacilityID"].Value.ToString();
                        bd.SessionNo = dataGridView1.Rows[i].Cells["sessionno1"].Value.ToString();
                        content.BookingDetails.Add(bd);
                        string c = dataGridView1.Rows[i].Cells["SportFacilityNo"].Value.ToString();
                        decimal value = Slist.Where(x => x.SportFacilityNo == c).Select(x => x.PricePerHour).First();
                        bd.Amount = value;
                        total = total + value;

                        content.SaveChanges();
                    }
                    BID = hexString; ;
                    string mID = content.Bookings.Where(x => x.BookingNo == BID).Select(x => x.MemberID).First().ToString();
                    Member m = content.Members.Where(x => x.MemberID == mID).First();
                    string mcy = m.Category;
                    decimal disc = content.MemberCategories.Where(x => x.Category == mcy).Select(x => x.Discount).First();
                    m.AmountSpend = m.AmountSpend + (total - (total * (disc / 100)));
                    decimal payment = total - (total * (disc / 100));
                    content.SaveChanges();
                    DialogResult result =
                        MessageBox.Show("Your Total Pyament is " + payment);
                    girdviewstatus.Text = "Already Booked";
                    Form2_Load(sender, e);
                    Sesslist.Clear();
                }
            }
        }

    }
}





        
    


            
        

    

