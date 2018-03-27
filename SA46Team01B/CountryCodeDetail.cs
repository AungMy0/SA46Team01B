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
    
    public partial class CountryCodeDetail : Form
    {
        List<Country> countrylist;
        public string cCode;
        public string cName;
        Main myParent;
        public CountryCodeDetail(Main Parent)
        {
            InitializeComponent();
            myParent = Parent; //inserted
        }

        private void CountryCodeDetail_Load(object sender, EventArgs e)
        {
            SA46Team01BEntities7 context = new SA46Team01BEntities7();
            countrylist = context.Countries.ToList();
            dataGridViewCountry.DataSource = countrylist;      
        }

        private void dataGridViewCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cCode = dataGridViewCountry.SelectedRows[0].Cells["CountryCode"].Value.ToString();
            cName = dataGridViewCountry.SelectedRows[0].Cells["CountryName"].Value.ToString();
            this.Close();
        }
    }
}
