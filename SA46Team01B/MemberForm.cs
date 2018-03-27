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
    public partial class MemberForm : Form
    {
        string mode;
        int index;
        Main myParent;
        public MemberForm(Main Parent)
        {
            InitializeComponent();

            myParent = Parent;

            MemberNamecomboBox.Height = 22;
            
            mode = "view";
            Mode(mode);
            index = 0;

            FillData();
        }

        //------------------------------------------------------View Mode Button Events-----------------------------------------------------------

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
            if (index != myParent.memberList.Count() - 1) index++;
            FillData();
        }

        private void LastRecordbutton_Click(object sender, EventArgs e)
        {
            index = myParent.memberList.Count() - 1;
            FillData();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            MemberSearch myMemberSearch = new MemberSearch(myParent, this);
            myMemberSearch.MdiParent = myParent;
            myMemberSearch.Dock = DockStyle.Fill;
            myMemberSearch.Show();

            myParent.InstantiatedForms.Add(myMemberSearch);
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            mode = "edit";
            Mode(mode);
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            mode = "new";
            Mode(mode);
        }
        private void MemberNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= myParent.memberList.Count() - 1; i++)
            {
                if (myParent.memberList[i].MemberName == MemberNamecomboBox.Text)
                {
                    index = i;
                    break;
                }

            }
            FillData();
        }
        private void QuickSearch_Click(object sender, EventArgs e)
        {
            MemberNamecomboBox.Items.Clear();
            MemberNamecomboBox.DropDownStyle = ComboBoxStyle.DropDown;
            string memberName = MemberNamecomboBox.Text;
            List<string> memberNameList = FindNameString(memberName, "memberName");

            for (int i = 0; i <= memberNameList.Count() - 1; i++)
            {
                MemberNamecomboBox.Items.Add(memberNameList[i].ToString());
            }

            MemberNamecomboBox.DroppedDown = true;


        }

        //------------------------------------------Switching Modes-----------------------------------------------------------------------------
        private void Mode(string mode)
        {

            switch (mode)
            {
                case "view":
                    {
                        MemberIDlabel.Show();
                        Categorylabel.Show();

                        HideShowLabels("show");
                        HideShowButtons("show");
                        HideShowTBCB("hide");
                        HideShowMultiFunctionButton("hide");

                        ClearAllTextBox();

                        FillData();

                        break;
                    }

                case "new":

                    {
                        MemberIDlabel.Hide();
                        Categorylabel.Show();

                        Categorylabel.Text = "";

                        HideShowButtons("hide");
                        HideShowLabels("hide");
                        HideShowTBCB("show");
                        HideShowMultiFunctionButton("show");

                        MemberNamecomboBox.DropDownStyle = ComboBoxStyle.Simple;

                        ClearAllTextBox();

                        break;
                    }

                case "edit":
                    {
                        MemberIDlabel.Show();
                        Categorylabel.Show();

                        HideShowButtons("hide");
                        HideShowTBCB("show");

                        CountrycomboBox.Text = Countrylabel.Text;
                        SalutationtextBox.Text = Salutationlabel.Text;
                        AgetextBox.Text = Agelabel.Text;
                        AddresstextBox.Text = Addresslabel.Text;
                        PhoneNumbertextBox.Text = PhoneNumberlabel.Text;
                        PostalCodetextBox.Text = PostalCodelabel.Text;
                        EmailtextBox.Text = Emaillabel.Text;

                        MemberNamecomboBox.DropDownStyle = ComboBoxStyle.Simple;

                        HideShowLabels("hide");

                        HideShowMultiFunctionButton("show");

                        break;
                    }

            }

        }

        //------------------------------------------Multi Functional Buttons in edit and new mode-----------------------------------------------

        private void MultiFunctionbutton_Click(object sender, EventArgs e)
        {
            bool datavalidation = false;

            bool nameValidation = DataValidation("name", MemberNamecomboBox.Text);
            bool ageValidation = DataValidation("age", AgetextBox.Text);
            bool postalcodeValidation = DataValidation("postalcode", PostalCodetextBox.Text);
            bool countryValidation = DataValidation("country", CountrycomboBox.Text);
            bool salutaionValidation = DataValidation("salutation", SalutationtextBox.Text);
            bool phonenoValidation = DataValidation("phoneno", PhoneNumbertextBox.Text);
            bool emailValidation = DataValidation("email", EmailtextBox.Text);

            datavalidation = (nameValidation && ageValidation && postalcodeValidation && countryValidation && salutaionValidation && phonenoValidation && emailValidation);

            if (datavalidation == false) myParent.Shake();

            if (datavalidation == true)
            {
                Member myMember = new Member();

                myMember.MemberID = MemberIDlabel.Text;
                myMember.MemberName = UpperCaseFirstLetter(MemberNamecomboBox.Text);
                myMember.Category = Categorylabel.Text;
                myMember.Age = Convert.ToInt32(AgetextBox.Text);
                if (AmountSpentlabel.Text == "") AmountSpentlabel.Text = "0";
                myMember.AmountSpend = Convert.ToDecimal(AmountSpentlabel.Text);
                myMember.Address = UpperCaseFirstLetter(AddresstextBox.Text);
                myMember.PostalCode = PostalCodetextBox.Text;
                myMember.CountryCode = myParent.countryList.Where(x => x.CountryName == CountrycomboBox.Text).Select(x => x.CountryCode).First();
                myMember.ContactTitle = UpperCaseFirstLetter(SalutationtextBox.Text);
                myMember.PhoneNo = PhoneNumbertextBox.Text;
                myMember.Email = EmailtextBox.Text;


                switch (mode)
                {
                    case "new":
                        {
                            FillData();
                            int lastIndex = myParent.memberList.Count() - 1;

                            myMember.MemberID = Convert.ToString(Convert.ToInt32(myParent.memberList[lastIndex].MemberID) + 1).PadLeft(7,'0');
                            myMember.Category = myParent.memberCategoryList.OrderBy(x => x.Discount).Select(x => x.Category).First().ToString();
                            myMember.AmountSpend = 0;


                            myParent.context.Members.Add(myMember);
                            myParent.context.SaveChanges();

                            FillData();
                            index = myParent.memberList.Count() - 1;

                            mode = "view";
                            Mode(mode);

                            break;
                        }
                    case "edit":
                        {
                            if (datavalidation == true)
                            {
                                int findIndex = -1;

                                for (int i = 0; i < myParent.memberList.Count(); i++)
                                {
                                    if (myParent.memberList[i].MemberID.ToString() == MemberIDlabel.Text)
                                    {
                                        findIndex = i;
                                        break;
                                    }

                                }

                                myParent.memberList[findIndex].MemberName = myMember.MemberName;
                                myParent.memberList[findIndex].Age = myMember.Age;
                                myParent.memberList[findIndex].Address = myMember.Address;
                                myParent.memberList[findIndex].PostalCode = myMember.PostalCode;
                                myParent.memberList[findIndex].CountryCode = myMember.CountryCode;
                                myParent.memberList[findIndex].ContactTitle = myMember.ContactTitle;
                                myParent.memberList[findIndex].PhoneNo = myMember.PhoneNo;
                                myParent.memberList[findIndex].Email = myMember.Email;

                                myParent.context.SaveChanges();
                                FillData();
                                mode = "view";
                                Mode(mode);
                            }
                            break;
                        }
                }

            }
        }

        private void MultiFunctionbutton1_Click(object sender, EventArgs e)
        {
            mode = "view";
            Mode(mode);
            FillData();
        }



        // ----------------------------------------- Validation ----------------------------------------------------------------------

        private bool DataValidation(string source, string sourcevalue)
        {
            bool validation = false;

            switch (source)
            {
                case "name":
                    {
                        validation = OnlyLetters(sourcevalue);
                        if (validation == false || sourcevalue.Length == 0) NameVallabel.Show();
                        else NameVallabel.Hide();
                        goto case "filled";
                    }
                case "age":
                    {
                        int dummy;
                        validation = Int32.TryParse(sourcevalue, out dummy);
                        if (validation == false) AgeVallabel.Show();
                        else AgeVallabel.Hide();
                        goto case "filled";
                    }
                case "postalcode":
                    {
                        int length = 6;
                        int dummy;
                        bool validation1 = sourcevalue.Length == length;
                        bool validation2 = Int32.TryParse(sourcevalue, out dummy);
                        validation = validation1 && validation2;
                        if (validation == false) PCVallabel.Show();
                        else PCVallabel.Hide();
                        goto case "filled";
                    }
                case "country":
                    {
                        for (int i = 0; i < myParent.countryList.Count(); i++)
                        {
                            if (sourcevalue.ToLower() == myParent.countryList[i].CountryName.ToLower())
                            {
                                validation = true;
                                break;
                            }
                        }
                        if (validation == false) CountryVallabel.Show();
                        else CountryVallabel.Hide();
                        goto case "filled";
                    }
                case "salutation":
                    {
                        String[] salutations = { "Mr", "Ms", "Dr" };
                        for (int i = 0; i < salutations.Length; i++)
                        {
                            if (sourcevalue.ToLower() == salutations[i].ToLower())
                            {
                                validation = true;
                                break;
                            }
                        }
                        if (validation == false) SalutationVallabel.Show();
                        else SalutationVallabel.Hide();
                        goto case "filled";
                    }
                case "phoneno":
                    {
                        int length = 8;
                        int dummy;
                        bool validation1 = sourcevalue.Length == length;
                        bool validation2 = Int32.TryParse(sourcevalue, out dummy);
                        validation = validation1 && validation2;
                        if (validation == false) PhoneVallabel.Show();
                        else PhoneVallabel.Hide();
                        goto case "filled";
                    }
                case "email":
                    {
                        int count1 = 0;

                        for (int i = 0; i < sourcevalue.Count(); i++)
                        {
                            if (sourcevalue.Substring(i, 1) == "@") count1++;
                        }

                        if (count1 == 1) validation = true;
                        if (validation == false) EmailVallabel.Show();
                        else EmailVallabel.Hide();
                        goto case "filled";
                    }
                case "filled":
                    {
                        if (sourcevalue.Length == 0) validation = false;
                        break;
                    }
            }

            return validation;
        }

        private bool OnlyLetters(string source)
        {
            bool onlyletters = true;

            for (int i = 0; i < source.Count(); i++)
            {
                if (source[i] != ' ')
                {
                    if (Char.IsLetter(source[i]) != true)
                    {
                        onlyletters = false;
                        break;
                    }
                }

            }

            return onlyletters;
        }



        private void HideAllValidationLabels()
        {
            SalutationVallabel.Hide();
            AgeVallabel.Hide();
            NameVallabel.Hide();
            CountryVallabel.Hide();
            PhoneVallabel.Hide();
            PCVallabel.Hide();
            EmailVallabel.Hide();
        }
        //--------------------------------------------------Filling and Refreshing data memory------------------------------------------
        private void FillData()
        {
            myParent.CreateMemory();
            UpdateCountryCB();
            HideAllValidationLabels();

            MemberIDlabel.Text = Convert.ToString(myParent.memberList[index].MemberID);
            Categorylabel.Text = myParent.memberList[index].Category;
            AmountSpentlabel.Text = myParent.memberList[index].AmountSpend.ToString();
            Salutationlabel.Text = myParent.memberList[index].ContactTitle;
            SalutationtextBox.Text = myParent.memberList[index].ContactTitle;
            Agelabel.Text = myParent.memberList[index].Age.ToString();
            AgetextBox.Text = myParent.memberList[index].Age.ToString();
            MemberNamecomboBox.Text = myParent.memberList[index].MemberName;


            string Country = myParent.memberList[index].CountryCode;
            Countrylabel.Text = myParent.countryList.Where(x => x.CountryCode == Country).Select(x => x.CountryName).First().ToString();

            PhoneNumberlabel.Text = myParent.memberList[index].PhoneNo;
            PhoneNumbertextBox.Text = myParent.memberList[index].PhoneNo;
            Addresslabel.Text = myParent.memberList[index].Address;
            AddresstextBox.Text = myParent.memberList[index].Address;
            PostalCodelabel.Text = myParent.memberList[index].PostalCode;
            PostalCodetextBox.Text = myParent.memberList[index].PostalCode;
            Emaillabel.Text = myParent.memberList[index].Email;
            EmailtextBox.Text = myParent.memberList[index].Email;
        }
        //------------------------------Associating MemberSearch with MemberForm---------------------------------------------------------------

        protected internal void ReceiveMemberDetails(string MemberID)
        {
            MemberIDlabel.Text = MemberID;

            for (int i = 0; i <= myParent.memberList.Count() - 1; i++)
            {
                if (myParent.memberList[i].MemberID == MemberIDlabel.Text)
                {
                    index = i;
                    break;
                }

            }

            FillData();
        }

        //------------------------------SupportMethods (Updating components and hiding/showing components)--------------------------------------------------------

        private void ClearAllTextBox()
        {
            Categorylabel.Text = "";
            Categorylabel.Text = "";
            AmountSpentlabel.Text = "";

            SalutationtextBox.Text = "";
            AgetextBox.Text = "";
            MemberNamecomboBox.Text = "";

            CountrycomboBox.Text = "";
            PhoneNumbertextBox.Text = "";
            AddresstextBox.Text = "";
            PostalCodetextBox.Text = "";
            EmailtextBox.Text = "";
        }
        private void UpdateCountryCB()
        {
            CountrycomboBox.Items.Clear();
            for (int i = 0; i < myParent.countryList.Count(); i++)
            {
                CountrycomboBox.Items.Add(myParent.countryList[i].CountryName.ToString());
            }
        }

        private void HideShowTBCB(string HideShow)
        {
            if (HideShow == "hide")
            {
                SalutationtextBox.Hide();
                AgetextBox.Hide();
                CountrycomboBox.Hide();
                PhoneNumbertextBox.Hide();
                AddresstextBox.Hide();
                PostalCodetextBox.Hide();
                EmailtextBox.Hide();
            }
            else if (HideShow == "show")
            {
                SalutationtextBox.Show();
                AgetextBox.Show();
                CountrycomboBox.Show();
                PhoneNumbertextBox.Show();
                AddresstextBox.Show();
                PostalCodetextBox.Show();
                EmailtextBox.Show();
            }
        }

        private void HideShowLabels(string HideShow)
        {
            if (HideShow == "hide")
            {
                Salutationlabel.Hide();
                Agelabel.Hide();
                Countrylabel.Hide();
                PhoneNumberlabel.Hide();
                Addresslabel.Hide();
                PostalCodelabel.Hide();
                Emaillabel.Hide();
            }

            else if (HideShow == "show")
            {
                Salutationlabel.Show();
                Agelabel.Show();
                Countrylabel.Show();
                PhoneNumberlabel.Show();
                Addresslabel.Show();
                PostalCodelabel.Show();
                Emaillabel.Show();
            }

        }



        private void HideShowButtons(string HideShow)
        {
            if (HideShow == "hide")
            {
                Newbutton.Hide();
                Editbutton.Hide();
                Searchbutton.Hide();

                QuickSearch.Hide();

                NextRecordbutton.Hide();
                PreviousRecordbutton.Hide();
                LastRecordbutton.Hide();
                FirstRecordbutton.Hide();

            }

            else if (HideShow == "show")
            {
                Newbutton.Show();
                Editbutton.Show();
                Searchbutton.Show();

                QuickSearch.Show();

                NextRecordbutton.Show();
                PreviousRecordbutton.Show();
                LastRecordbutton.Show();
                FirstRecordbutton.Show();
            }

        }

        private void HideShowMultiFunctionButton(string HideShow)
        {
            if (HideShow == "hide")
            {
                MultiFunctionbutton.Hide();
                MultiFunctionbutton1.Hide();

            }

            else if (HideShow == "show")
            {
                MultiFunctionbutton.Show();
                MultiFunctionbutton1.Show();

                if (mode == "new")
                {
                    MultiFunctionbutton.Text = "Create";
                    MultiFunctionbutton1.Text = "Cancel";
                }

                else if (mode == "edit")
                {
                    MultiFunctionbutton.Text = "Update";
                    MultiFunctionbutton1.Text = "Cancel";
                }
            }

        }

        //--------------------------------------------Other support methods--------------------------------------------------------------

        private void FirstRecord()
        {
            index = 0;

        }

        private List<string> FindNameString(string Name, string sender)
        {
            int stringLength = Name.Count();

            List<string> NameList = new List<string>();

            if (sender == "memberName")
                NameList = myParent.memberList.Select(x => x.MemberName).ToList();

            List<string> RefinedList = new List<string>();

            for (int i = 0; i <= NameList.Count() - 1; i++)
            {
                for (int k = 0; k < NameList[i].Count() - stringLength + 1; k++)
                {
                    if (NameList[i].Substring(k, stringLength).ToLower() == Name.ToLower())
                    {
                        RefinedList.Add(NameList[i]);
                        break;
                    }

                }
            }

            return RefinedList;
        }

        private string UpperCaseFirstLetter(string stringVar)
        {
            string[] stringArray = stringVar.Split(' ');

            for(int i = 0; i < stringArray.Count(); i++)
            {
                for (int j = 0; j < stringArray[i].Length; j++)
                {
                    string Temp = stringArray[i].Substring(0, 1).ToUpper();
                    Temp = Temp + stringArray[i].Substring(1, stringArray[i].Length - 1).ToLower();
                    stringArray[i] = Temp;
                }
            }


            return stringVar = String.Join(" ", stringArray);
        }


    }
}
