using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team01B
{
    //assume that sessions are only in 1 hour block
    //let end time label be dependent on start time
    //updates all sessions if one session is updated such that if one session is push backward by 30mins, all sessions will also be push back by 30mins
    //inserting session is dependent on last index session end time such that the start time will be equal to the last session's end time
    public partial class SessionForm : Form
    {
        int index;
        Main myParent;
        SqlConnection cn;
        string con;

        public SessionForm(Main Parent)
        {
            InitializeComponent();

            StartdateTimePicker.Format = DateTimePickerFormat.Time;
            EnddateTimePicker.Format = DateTimePickerFormat.Time;
            StartdateTimePicker.ShowUpDown = true;
            EnddateTimePicker.ShowUpDown = true;

            myParent = Parent;
            index = 0;

            con = "data source = (local) ; database = SA46Team01B; integrated security=SSPI";
            cn = new SqlConnection(con);

            FillData();

            //MessageBox.Show(myParent.sessionList[index].StartTime.ToString());
        }
        //---------------------------------------------------Browsing through records------------------------------------------------
        private void FirstRecordbutton_Click(object sender, EventArgs e)
        {
            index = 0;
            FillData();
        }

        private void PreviousRecordbutton_Click(object sender, EventArgs e)
        {
            if (index != 0) index--;
            FillData();
        }

        private void NextRecordbutton_Click(object sender, EventArgs e)
        {
            if (index != myParent.sessionList.Count() - 1) index++;
            FillData();
        }

        private void LastRecordbutton_Click(object sender, EventArgs e)
        {
            index = myParent.sessionList.Count() - 1;
            FillData();
        }

        //------------------------------------ New / Update event------------------------------------------------------------
        private void Newbutton_Click(object sender, EventArgs e)
        {
            myParent.Shake();

            DialogResult result = Warning1();

            if (result == DialogResult.Yes)
            {
                int LastIndex = myParent.sessionList.Count() - 1;

                FillData();

                StartdateTimePicker.Text = myParent.sessionList[myParent.sessionList.Count() - 1].EndTime.ToString();

                string StartHour = GetHour(StartdateTimePicker.Text).PadLeft(2, '0');
                string StartMin = GetMin(EnddateTimePicker.Text).PadLeft(2, '0');
                string StartTime = StartHour + ":" + StartMin;

                string EndHour = Convert.ToString(Convert.ToInt32(StartHour) + 1).PadLeft(2, '0');
                string EndMin = StartMin.PadLeft(2, '0');
                string EndTime = EndHour + ":" + EndMin;

                SessionNolabel.Text = Convert.ToString(Convert.ToInt32(myParent.sessionList[LastIndex].SessionNo) + 1).PadLeft(2, '0');

                string query = "INSERT INTO Session VALUES(@SessionNo, @StartTimeValue, @EndTimeValue)";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.Add("@SessionNo", SqlDbType.NVarChar).Value = SessionNolabel.Text;
                cmd.Parameters.Add("@StartTimeValue", SqlDbType.Time).Value = StartTime;
                cmd.Parameters.Add("@EndTimeValue", SqlDbType.Time).Value = EndTime;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                FillData();
                index = myParent.sessionList.Count() - 1;
            }
            
            FillData();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            myParent.Shake();

            DialogResult result = Warning2();

            if (result == DialogResult.Yes)
            {
                int hourPushBack = Convert.ToInt32(GetHour(StartdateTimePicker.Text)) - Convert.ToInt32(myParent.sessionList[index].StartTime.ToString().Substring(0, 2));
                int minPushBack = Convert.ToInt32(GetMin(StartdateTimePicker.Text)) - Convert.ToInt32(myParent.sessionList[index].StartTime.ToString().Substring(3, 2));

                for (int i = 0; i <= myParent.sessionList.Count() - 1; i++)
                {
                    string query = "UPDATE Session SET StartTime = @StartTime, EndTime = @EndTime WHERE SessionNo = @SessionNo";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    string StarHour = myParent.sessionList[i].StartTime.ToString().Substring(0, 2).PadLeft(2, '0');
                    string StartMinute = myParent.sessionList[i].StartTime.ToString().Substring(3, 2).PadLeft(2, '0');
                    string EndHour = myParent.sessionList[i].EndTime.ToString().Substring(0, 2).PadLeft(2, '0');
                    string EndMinute = myParent.sessionList[i].EndTime.ToString().Substring(3, 2).PadLeft(2, '0');

                    string NewStartHour = Convert.ToString(ConvertNegative(Convert.ToString(Convert.ToInt32(StarHour) + hourPushBack))).PadLeft(2, '0');
                    string NewStartMin = Convert.ToString(Convert.ToInt32(StartMinute) + minPushBack).PadLeft(2, '0');

                    string NewEndHour = Convert.ToString(ConvertNegative(Convert.ToString(Convert.ToInt32(EndHour) + hourPushBack))).PadLeft(2, '0');
                    string NewEndMin = Convert.ToString(Convert.ToInt32(EndMinute) + minPushBack).PadLeft(2, '0');

                    //MessageBox.Show(NewStartHour + ":" + NewStartMin);
                    //MessageBox.Show(NewEndHour + ":" + NewEndMin);

                    cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = NewStartHour + ":" + NewStartMin;
                    cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = NewEndHour + ":" + NewEndMin;
                    cmd.Parameters.Add("@SessionNo", SqlDbType.NVarChar).Value = myParent.sessionList[i].SessionNo;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

            }
            
            FillData();
        }

        

        //--------------------------------------------------Filling and Refreshing data memory------------------------------------------
        private void FillData()
        {
            myParent.CreateMemory();

            SessionNolabel.Text = myParent.sessionList[index].SessionNo;
            StartdateTimePicker.Text = myParent.sessionList[index].StartTime.ToString();
            EnddateTimePicker.Text = myParent.sessionList[index].EndTime.ToString();

            label4.Hide();
            label5.Hide();
        }
        
        
        //-------------------------------------------------Get hour and minute-------------------------------------------------------------


        private string GetHour(string Time)
        {
            string hour = "";
            string firsttwodigits = "";

            if (Time.Substring(1, 1) == ":") firsttwodigits = "0" + Time.Substring(0, 1);
            else firsttwodigits = Time.Substring(0, 2);

            if (firsttwodigits == "12" && Time.Substring(Time.Length - 2, 2) == "PM") hour = "12";
            else if (firsttwodigits == "12" && Time.Substring(Time.Length - 2, 2) == "AM") hour = "00";
            else if (Time.Substring(Time.Length - 2, 2) == "PM") hour = Convert.ToString(Convert.ToInt32(firsttwodigits) + 12);
            else if (Time.Substring(Time.Length - 2, 2) == "AM") hour = firsttwodigits;

            return hour;
        }

        private string GetMin(string Time)
        {
            string min = "";

            if (Time.Substring(1, 1) == ":") min = Time.Substring(2, 2);
            else min = Time.Substring(3, 2);

            return min;
        }

        //--------------------------------------------------If Negative Time-----------------------------------------------------------

        private string ConvertNegative(string Hour)
        {
            if (Convert.ToInt32(Hour) < 0) Hour = Convert.ToString(24 - Convert.ToInt32(Hour));
            else if (Convert.ToInt32(Hour) > 24) Hour = Convert.ToString(Convert.ToInt32(Hour) - 24);
            return Hour;
        }

        //------------------------------------Label message to tell user that there will be no changes when End Date Timepicker is updated----------------------------------------
        private void EnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
        }

        //---------------------------------Warning Box------------------------------------------------------------------
        private DialogResult Warning1()
        {
            DialogResult result = MessageBox.Show("Continue? This will create a new session!", "Warning!", MessageBoxButtons.YesNo);
            return result;
        }
        private DialogResult Warning2()
        {
            DialogResult result = MessageBox.Show("Continue? This will update all records!", "Warning!", MessageBoxButtons.YesNo);
            return result;
        }

    }
}
