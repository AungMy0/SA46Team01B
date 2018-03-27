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
    public partial class LoginForm : Form
    {
        string username = "team01b";
        string password = "password1";
        public LoginForm()
        {
            InitializeComponent();
            
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string myUserName = UserNametextBox.Text;
            string myPassword = PasswordtextBox.Text;

            bool validation = Validation(myUserName, myPassword);

            if (validation == true)
            {
                Main myMain = new Main();
                myMain.Login(this);
            }
            else
            {
                Shake();
                MessageBox.Show("Username and password do not match!");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//-------------------------------------Support methods--------------------------------------------------------
        private bool Validation(string username, string password)
        {
            bool validation = username == this.username && password == this.password;
            return validation;
        }

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


    }
}
