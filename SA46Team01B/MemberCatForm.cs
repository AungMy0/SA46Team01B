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
    public partial class MemberCatForm : Form
    {
        SA46Team01BEntities7 ctx = new SA46Team01BEntities7();
        //MemberCategory mc = new MemberCategory();

        private bool newbtnWasClicked = false;
        Main myParent;
        public MemberCatForm(Main Parent)
        {
            InitializeComponent();
            myParent = Parent; //inserted
        }
        private void hidelabel()
        {
            // catlabel.Hide();
            amrlabel.Hide();
            dislabel.Hide();
        }
        private void showlabel()
        {
            catlabel.Show();
            amrlabel.Show();
            dislabel.Show();
        }
        private void showtextbox()
        {
            // categorytextbox.Show();
            amountratetaxbox.Show();
            discounttextbox.Show();
        }
        private void hidetextbox()
        {
            categorytextbox.Hide();
            amountratetaxbox.Hide();
            discounttextbox.Hide();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers != Keys.Shift)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MemberCategory> catlist = ctx.MemberCategories.ToList();
            dataGridView1.DataSource = catlist;

            catlabel.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            amrlabel.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            dislabel.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            status.Text = "Ready";
            // dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hidelabel();
            showtextbox();

            amountratetaxbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            discounttextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            status.Text = "Selected the row to Update";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hidetextbox();
            showlabel();
            catlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            amrlabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dislabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            status.Text = "Selecting";
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            hidelabel();
            showtextbox();
            categorytextbox.Show();

            categorytextbox.Text = "  ";
            amountratetaxbox.Text = "  ";
            discounttextbox.Text = "  ";
            newbtnWasClicked = true;

            status.Text = "New Member Category is creating";


        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (newbtnWasClicked == true)
            {
                string a = categorytextbox.Text;
                int b = int.Parse(amountratetaxbox.Text);
                decimal c = decimal.Parse(discounttextbox.Text);
                MemberCategory mcy = new MemberCategory();
                mcy.Category = a;
                mcy.Discount = c;
                mcy.TargetAmount = b;
                ctx.MemberCategories.Add(mcy);
                ctx.SaveChanges();
                newbtnWasClicked = false;
                hidetextbox();
                showlabel();
                catlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                amrlabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dislabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                List<MemberCategory> catlist = ctx.MemberCategories.ToList();
                dataGridView1.DataSource = catlist;

            }
            else
            {
                status.Text = "Updating the MemberCatrgory";
                dataGridView1.CurrentRow.Cells[1].Value = amountratetaxbox.Text;
                dataGridView1.CurrentRow.Cells[2].Value = discounttextbox.Text;
                ctx.SaveChanges();
                hidetextbox();
                showlabel();
                catlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                amrlabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dislabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                status.Text = "Updated the Membercategory";
            }
        }
        private void AddARow(DataTable table)
        {
            // Use the NewRow method to create a DataRow with 
            // the table's schema.
            DataRow newRow = table.NewRow();

            // Add the row to the rows collection.
            table.Rows.Add(newRow);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void amountratetaxbox_KeyDown(object sender, KeyEventArgs e)
        {

            e.SuppressKeyPress = !IsNumberKey(e.KeyData) && !IsActionKey(e.KeyData); 
        }

        private bool IsNumberKey(Keys inKey)
        {
            if (inKey < Keys.D0 || inKey > Keys.D9)
            {
                if (inKey < Keys.NumPad0 || inKey > Keys.NumPad9)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsActionKey(Keys inKey)
        {
            return inKey == Keys.Delete || inKey == Keys.Back || inKey == Keys.Tab || inKey == Keys.Return ;
        }

        private void discounttextbox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !IsNumberKey(e.KeyData) && !IsActionKey(e.KeyData);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void discounttextbox_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
