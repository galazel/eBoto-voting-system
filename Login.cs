
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBoto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();  

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username_box.Text.Equals("admin") && password_box.Text.Equals("admin123"))
            {
                this.Hide();
                new AdminDashboard().ShowDialog();  
            }else if (username_box.Text.Equals("") || password_box.Text.Equals(""))
                MessageBox.Show("Please input the required fields");
            else
            { 
                using (var db = new eBotoDBEntities3())
                {
                    var user = db.Voters.Where(u => u.Username.Equals(username_box.Text) && u.Password.Equals(password_box.Text)).ToList();
                    if (user.Count() > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        new VotersDashboard().ShowDialog();
                        return;
                    } else
                    { 
                        MessageBox.Show("Invalid username or password.");
                        username_box.Text = "";
                        password_box.Text = "";
                    }
                }
             }

        }

        private void register_here_Click(object sender, EventArgs e)
        {
            this.Hide();
            new return_bttn().ShowDialog();
        }

      
    }
}
