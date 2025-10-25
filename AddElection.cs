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
        }
        private void add_candidate_Click(object sender, EventArgs e)
        {
            new AddCandidates().ShowDialog();
        }

        private void create_election_Click(object sender, EventArgs e)
        {
       
            if (electionName_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.Text.Equals("") || candidates_flow.Controls.Count == 0 || start_date.Text.Equals("") || end_date.Text.Equals(""))
                MessageBox.Show("Please input the required fields");          
        }

        private void AddElection_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {
            try
            {
                DatabaseConfiguration connectionString = new DatabaseConfiguration();

                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments", conn);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    departments_combo.DataSource = tb;
                    departments_combo.DisplayMember = "DepartmentName";
                    departments_combo.ValueMember = "DepartmentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

    }
}
