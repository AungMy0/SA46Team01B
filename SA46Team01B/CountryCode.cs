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

    public partial class CountryCode : Form
    {
        SA46Team01BEntities7 context = new SA46Team01BEntities7();
        List<Country> countryList;
        int listcount;
        Main myParent; //inserted
        public CountryCode(Main Parent)
        {
            InitializeComponent();
            countryList = context.Countries.ToList();
            myParent = Parent; //inserted
            comboBox1.Height = 22; //inserted
            comboBox2.Height = 22;  //inserted
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryCodeDetail cd = new CountryCodeDetail(myParent);
            myParent.InstantiatedForms.Add(cd); //inserted
            cd.MdiParent = myParent; //inserted
            cd.Dock = DockStyle.Fill; //inserted

            cd.Show(); //editted
            comboBox1.Text = cd.cCode;
            
        }



        private void CountryCode_Load(object sender, EventArgs e)
        {
            countryList = context.Countries.ToList();
            listcount=countryList.Count() ;
            

            List<string> countryID = countryList.Select(x => x.CountryCode).ToList();
            List<string> countryName = countryList.Select(x => x.CountryName).ToList();

            comboBox1.Text = countryID[0].ToString();

            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.Text = countryName[0].ToString();
            for (int i = 0; i < countryID.Count(); i++)
            {
                comboBox1.Items.Add(countryID[i].ToString());
                comboBox2.Items.Add(countryName[i].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = countryList.Where(x => x.CountryCode == comboBox1.Text).Select(x => x.CountryName).First().ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = countryList.Where(x => x.CountryName == comboBox2.Text).Select(x => x.CountryCode).First().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index=comboBox1.SelectedIndex;
            if (index == -1)
            {
                index = 0;
            }
            countryList[index].CountryName = comboBox2.Text;
            context.SaveChanges();
            MessageBox.Show("Updated Sucessfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int parsedValue;

            bool flag = true;
            for (int i = 0; i < comboBox1.Text.ToString().Count(); i++)
            {
                if (Char.IsLetter(comboBox1.Text, i))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                if (comboBox1.Text.Length == 3)
                {
                    if (!int.TryParse(comboBox1.Text, out parsedValue))
                    {
                        Country newCountry = new Country();
                        newCountry.CountryCode = comboBox1.Text;
                        newCountry.CountryName = comboBox2.Text;
                        context.Countries.Add(newCountry);
                        context.SaveChanges();
                        MessageBox.Show("New Country has been added successfully!", "Success");

                    }
                    else
                    {
                        MessageBox.Show("Country Code must be only 3 characters");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Country Code must be only 3 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Country must be only characters");
            }
        } 

           

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void btnQSearch_Click(object sender, EventArgs e)
        {
            {
                comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
                string CountryName = comboBox2.Text;
                List<string> countrynameList = FindNameString(CountryName, "CountryName");

                for (int i = 0; i <= countrynameList.Count() - 1; i++)
                {
                   // MessageBox.Show(countrynameList[i].ToString());
                    comboBox2.Items.Add(countrynameList[i].ToString());
                }

                comboBox2.DroppedDown = true;
            }
        }
            private List<string> FindNameString(string Name, string sender)
            {
                int stringLength = Name.Count();

                List<string> NameList = new List<string>();

                if (sender == "CountryName")
                    NameList = countryList.Select(x => x.CountryName).ToList();



                List<string> RefinedList = new List<string>();

                for (int i = 0; i < NameList.Count() - 1; i++)
                {
                    for (int k = 0; k < NameList[i].Count() - stringLength; k++)
                    {
                        if (NameList[i].Substring(k, stringLength).ToLower() == Name.ToLower())
                        {
                        //MessageBox.Show(NameList[i].ToString());
                            RefinedList.Add(NameList[i]);
                            break;
                        }

                    }
                }

                return RefinedList;
            }
        }
    }

