using Siticone.Desktop.UI.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eBoto
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            siticoneTabControl1.SelectedIndexChanged += TabChanged;
        }

        private void LoadData(string query, SiticoneDataGridView view)
        {
            try
            {
                DatabaseConfiguration connectionString = new DatabaseConfiguration();

                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    view.AutoGenerateColumns = true; 
                    view.DataSource = null;
                    view.DataSource = tb;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Elections", elections_dataview);
        }

        private void TabChanged(object sender, EventArgs e)
        {
            var selectedTab = siticoneTabControl1.SelectedTab;

            if (selectedTab == null)
                return;
            switch (selectedTab.Text)
            {
                case "Elections":
                    LoadData("SELECT ElectionID, ElectionName, StartDate, EndDate FROM Elections", elections_dataview);
                    break;

                case "Positions":
                    LoadData("SELECT PositionID, PositionName FROM Positions ORDER BY PositionID", positions_dataview);
                    break;

                case "Candidates":
                    LoadData("SELECT Candidates.CandidateID, Candidates.FullName, Candidates.PartylistName, Departments.DepartmentName FROM Candidates INNER JOIN Departments ON Candidates.DepartmentID = Departments.DepartmentID", candidates_dataview);
                    break;

                case "Voters":
                    LoadData("SELECT VoterID, Username FROM Voters", voters_dataview);
                    break;
            }
            Console.WriteLine($"Selected Tab: {selectedTab.Text}");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
