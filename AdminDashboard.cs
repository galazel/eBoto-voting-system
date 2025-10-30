using Microsoft.VisualBasic;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace eBoto
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            siticoneTabControl1.SelectedIndexChanged += TabChanged;
            LoadData();
            Elec.LoadStatistics(this.no_of_registered,this.no_elections,this.no_candidates);
            Elec.LoadElections(this.elections_flow);
        }
        
        private void LoadData()
        {
            DataTable departmentTable = new DataTable();
            departmentTable.Columns.Add("DepartmentID", typeof(int));
            departmentTable.Columns.Add("DepartmentName", typeof(string));

            DataTable positionTable = new DataTable();
            positionTable.Columns.Add("PositionID", typeof(int));
            positionTable.Columns.Add("PositionName", typeof(string));

            using (var db = new eBotoDBEntities2())
            {
            
                foreach (var dept in db.Departments)
                    departmentTable.Rows.Add(dept.DepartmentId, dept.DepartmentName);
                departments_grid.DataSource = departmentTable;

                foreach (var pos in db.Positions)
                    positionTable.Rows.Add(pos.PositionId, pos.PositionName);
                positions_grid.DataSource = positionTable;

            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void TabChanged(object sender, EventArgs e)
        {
            //var selectedTab = siticoneTabControl1.SelectedTab;

            //if (selectedTab == null)
            //    return;
            //switch (selectedTab.Text)
            //{
            //    case "Elections":
                    
            //            break;

            //    case "Ongoing":
                 
            //        break;

            //    case "Ended":
                                        
            //        break;
            //}
            //Console.WriteLine($"Selected Tab: {selectedTab.Text}");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            new AddElection(this.elections_flow).ShowDialog();
        }

        private void elections_flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Hide();
            new Login().ShowDialog();
        }

        private void add_department_Click(object sender, EventArgs e)
        {
            string departmentName = Interaction.InputBox("Enter Department Name:", "Add Department", "");
            if(departmentName.Trim() != "")
            {
                using (var db = new eBotoDBEntities2())
                {
                    var departmentExists = db.Departments.Any(d => d.DepartmentName == departmentName.ToUpper());
                    if (departmentExists)
                    {
                        MessageBox.Show("Department already exists.");
                        return;
                    }
                    var newDepartment = new Department
                    {
                        DepartmentName = departmentName.ToUpper()
                    };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();

                }
                LoadData();
            }
            
        }

        private void delete_department_Click(object sender, EventArgs e)
        {
            int selectedIndex = departments_grid.CurrentCell.RowIndex;
            if (selectedIndex >= 0)
            {
                var departmentId = departments_grid.Rows[selectedIndex].Cells["DepartmentID"].Value;
                MessageBox.Show($"Deleting Department ID: {departmentId}");
                Delete((int)departmentId,"Departments");    
                LoadData();
            }

        }
        private void Delete(int index, string tableName)
        {
            using(var db = new eBotoDBEntities2())
            {
                if(tableName == "Departments")
                {
                    var departmentToDelete = db.Departments.Find(index);
                    if (departmentToDelete != null)
                    {
                        db.Departments.Remove(departmentToDelete);
                        db.SaveChanges();
                    }
                }
                else
                {
                    var positionToDelete = db.Positions.Find(index);
                    if (positionToDelete != null)
                    {
                        db.Positions.Remove(positionToDelete);
                        db.SaveChanges();
                    }
                }
                
            }
        }


        private void add_position_Click(object sender, EventArgs e)
        {
            string positionName = Interaction.InputBox("Enter Position Name:", "Add Position", "");
            if(positionName.Trim() != "")
            {
            using (var db = new eBotoDBEntities2())
            {
                var positionExists = db.Positions.Any(p => p.PositionName == positionName.ToUpper());
                if (positionExists)
                {
                   MessageBox.Show("Position already exists.");
                   return;
                }
                var newPosition = new Position
                {
                    PositionName = positionName.ToUpper()
                };
                db.Positions.Add(newPosition);
                db.SaveChanges();
                
            }
            LoadData();
            }

        }

        private void delete_position_Click(object sender, EventArgs e)
        {
            int selectedIndex = positions_grid.CurrentCell.RowIndex;
            if (selectedIndex >= 0)
            {
                var positionId = positions_grid.Rows[selectedIndex].Cells["PositionID"].Value;
                MessageBox.Show($"Deleting Position ID: {positionId}");
                Delete((int)positionId,"Positions");
                LoadData();
            }
        }

        private void departments_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new eBotoDBEntities2())
            {
                foreach (DataGridViewRow row in departments_grid.Rows)
                {
                    if (row.IsNewRow) continue;
                    int departmentId = Convert.ToInt32(row.Cells["DepartmentID"].Value);
                    string departmentName = row.Cells["DepartmentName"].Value.ToString();
                    var department = db.Departments.Find(departmentId);
                    if (department != null)
                    {
                        department.DepartmentName = departmentName;
                    }
                }
                db.SaveChanges();
            }
        }

        private void positions_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new eBotoDBEntities2())
            {
                foreach (DataGridViewRow row in positions_grid.Rows)
                {
                    if (row.IsNewRow) continue;
                    int positionId = Convert.ToInt32(row.Cells["PositionID"].Value);
                    string positionName = row.Cells["PositionName"].Value.ToString();
                    var position = db.Positions.Find(positionId);
                    if (position != null)
                    {
                        position.PositionName = positionName;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
