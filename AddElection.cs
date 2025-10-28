using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace eBoto
{
    public partial class AddElection : Form
    {
        public AddElection()
        {
            InitializeComponent();
            departments_combo.Items.Clear();
            using (var db = new eBotoDBEntities1())
            {
                departments_combo.DataSource = db.Departments
                                                 .Select(d => d.DepartmentName)
                                                 .ToList();
            }
        }
        private void add_candidate_Click(object sender, EventArgs e)
        {
            new AddCandidates().ShowDialog();
        }

        private void create_election_Click(object sender, EventArgs e)
        {
       
            if (electionName_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.Text.Equals("") || candidates_flow.Controls.Count == 0)
                MessageBox.Show("Please input the required fields");
            else
            {
                MessageBox.Show("Election Created Successfully");
                this.Hide();
            }
        }

        private void AddElection_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
