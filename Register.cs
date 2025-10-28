using Microsoft.VisualBasic;
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
    public partial class return_bttn : Form
    {
        public return_bttn()
        {
            InitializeComponent();
            using (var db = new eBotoDBEntities1())
            {
                var departments = db.Departments.Select(d => d.DepartmentName).ToList();
                departments_combo.Items.AddRange(departments.ToArray());
                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if(check_box.Checked == false)
            {
                MessageBox.Show("Please agree to the terms and conditions");
                return;
            }else
                using (var db = new eBotoDBEntities1())
                {
                    var user = new Voter
                    {
                        FirstName = firstname_box.Text,
                        LastName = lastname_box.Text,
                        MiddleName = middlename_box.Text,
                        BirthDate = birthday_date.Value,
                        ContactNumber = contact_box.Text,
                        Email = email_box.Text,
                        Province = province_box.Text,
                        Barangay = barangay_box.Text,
                        City = city_box.Text,
                        Year = year_box.Text,
                        Section = section_box.Text,
                        Department = db.Departments.FirstOrDefault(d => d.DepartmentName == departments_combo.Text),
                        Username = username_box.Text,
                        Password = password_box.Text,
                        Status = false
                    };
                    db.Voters.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Registration Successful!");
                    this.Hide();
                    new Login().ShowDialog();
                }
            
        }

        private void birthday_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
