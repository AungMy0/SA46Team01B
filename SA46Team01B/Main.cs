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
    public partial class Main : Form
    {
        protected internal SA46Team01BEntities7 context;


        protected internal List<Member> memberList;
        protected internal List<MemberCategory> memberCategoryList;
        protected internal List<Country> countryList;
        protected internal List<Booking> bookingList;
        protected internal List<BookingDetail> bookingDetailList;
        protected internal List<Session> sessionList;
        protected internal List<SportFacility> sportFacilityList;
        protected internal List<SportFacilityDetail> sportFacilityDetailList;

        protected internal List<Form> InstantiatedForms;

        public Main()
        {

            
            InitializeComponent();
            this.Height = 570;
            this.Width = 800;
            InstantiatedForms = new List<Form>();

            Home();
        }

        //-----------------------------------------------Menu button click events --------------------------------------------------------
        private void Homebutton_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void Home()
        {
            Home newHomeForm = new Home();
            newHomeForm.MdiParent = this;
            newHomeForm.Dock = DockStyle.Fill;
            newHomeForm.Show();

            HideShowPanel("home");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newHomeForm);
        }

        private void Memberbutton_Click(object sender, EventArgs e)
        {
            MemberForm newMemberForm = new MemberForm(this);
            newMemberForm.MdiParent = this;
            newMemberForm.Dock = DockStyle.Fill;
            newMemberForm.Show();

            HideShowPanel("member");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newMemberForm);
        }

        private void Sessionbutton_Click(object sender, EventArgs e)
        {
            SessionForm newSessionForm = new SessionForm(this);
            newSessionForm.MdiParent = this;
            newSessionForm.Dock = DockStyle.Fill;
            newSessionForm.Show();

            HideShowPanel("session");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newSessionForm);
        }

        private void Countrybutton_Click(object sender, EventArgs e)
        {
            CountryCode newCountryForm = new CountryCode(this);
            newCountryForm.MdiParent = this;
            newCountryForm.Dock = DockStyle.Fill;
            newCountryForm.Show();

            HideShowPanel("country");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newCountryForm);
        }

        private void SportsFacilitybutton_Click(object sender, EventArgs e)
        {
            SportsFacilityGridForm newSportsFacility = new SportsFacilityGridForm(this);
            newSportsFacility.MdiParent = this;
            newSportsFacility.Dock = DockStyle.Fill;
            newSportsFacility.Show();

            HideShowPanel("sportsfacility");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newSportsFacility);
        }
        private void Bookingbutton_Click(object sender, EventArgs e)
        {
            BookingForm newBookingForm = new BookingForm(this);
            newBookingForm.MdiParent = this;
            newBookingForm.Dock = DockStyle.Fill;
            newBookingForm.Show();

            HideShowPanel("booking");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newBookingForm);
        }

        private void MemberCategorybutton_Click(object sender, EventArgs e)
        {
            MemberCatForm newMemberCatForm = new MemberCatForm(this);
            newMemberCatForm.MdiParent = this;
            newMemberCatForm.Dock = DockStyle.Fill;
            newMemberCatForm.Show();

            HideShowPanel("membercat");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newMemberCatForm);
        }
        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Reports newReports = new Reports(this);
            newReports.MdiParent = this;
            newReports.Dock = DockStyle.Fill;
            newReports.Show();

            HideShowPanel("report");
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            InstantiatedForms.Add(newReports);
        }


        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            if (InstantiatedForms.Count() > 0) CloseAllChild();
            this.Close();
        }

        //----------------------------------Store new context data in lists-----------------------------------------------------
        protected internal void CreateMemory()
        {
            context = new SA46Team01BEntities7();

            memberList = context.Members.ToList();
            memberCategoryList = context.MemberCategories.ToList();
            countryList = context.Countries.ToList();
            bookingList = context.Bookings.ToList();
            bookingDetailList = context.BookingDetails.ToList();
            sessionList = context.Sessions.ToList();
            sportFacilityList = context.SportFacilities.ToList();
            sportFacilityDetailList = context.SportFacilityDetails.ToList();
        }



        //---------------------------------------------ShowHide panel when menu buttons are clicked-------------------------------------
        private void HideShowPanel(string panel)
        {
            Homepanel.Hide();
            Bookingpanel.Hide();
            Memberpanel.Hide();
            SportsFacilitypanel.Hide();
            MemberCategorypanel.Hide();
            Sessionpanel.Hide();
            Countrypanel.Hide();
            Reportpanel.Hide();

            switch (panel)
            {
                case "home":
                    {
                        Homepanel.Show();
                        break;
                    }
                case "booking":
                    {
                        Bookingpanel.Show();
                        break;
                    }
                case "member":
                    {
                        Memberpanel.Show();
                        break;
                    }
                case "sportsfacility":
                    {
                        SportsFacilitypanel.Show();
                        break;
                    }
                case "membercat":
                    {
                        MemberCategorypanel.Show();
                        break;
                    }
                case "session":
                    {
                        Sessionpanel.Show();
                        break;
                    }
                case "country":
                    {
                        Countrypanel.Show();
                        break;
                    }
                case "report":
                    {
                        Reportpanel.Show();
                        break;
                    }
            }
        }

        //-----------------------------Close all instantiated child forms----------------------------------------------

        private void CloseAllChild()
        {
            for(int i = 0; i < InstantiatedForms.Count(); i++)
            {
                InstantiatedForms[i].Close();
            }
        }

        //-------------------------------------Shake Form for data validation violation------------------------------------
        protected internal void Shake()
        {
            System.Media.SystemSounds.Beep.Play();

            var original = this.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 7;
            
            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            this.Location = original;
        }

        //------------------------------------Login Validation-------------------------------------------------------------

        protected internal void Login(LoginForm myLogin)
        {
            this.Show();
            myLogin.Hide();
        }

    }
}
