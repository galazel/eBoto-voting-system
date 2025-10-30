using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eBoto
{
    public partial class AddElection : Form
    {
       private FlowLayoutPanel flow;
        public AddElection(FlowLayoutPanel flow)
        {
            InitializeComponent();
            this.flow = flow;

            departments_combo.Items.Clear();
            using (var db = new eBotoDBEntities2())
            {
                departments_combo.DataSource = db.Departments
                                                 .Select(d => d.DepartmentName)
                                                 .ToList();
            }
            
        }
        private void add_candidate_Click(object sender, EventArgs e)
        {
            new AddCandidates(this.candidates_flow).ShowDialog();
        }

        private void create_election_Click(object sender, EventArgs e)
        {
            if (electionName_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.Text.Equals("") || candidates_flow.Controls.Count == 0)
                MessageBox.Show("Please input the required fields");
            else
            {
                using (var db = new eBotoDBEntities2())
                {
                    var elections = db.Elections.ToList();
                    foreach (var elec in elections)
                    {
                        if (electionName_box.Text == elec.ElectionName)
                        {
                            MessageBox.Show("Election already exists. Please wait for it to end");
                            return;
                        }
                    }
                    var election = new Election
                    {
                        ElectionName = electionName_box.Text,
                        Description = description_box.Text,
                        Status = false,
                        Department = db.Departments.FirstOrDefault(d => d.DepartmentName == departments_combo.Text)
                    };
                    db.Elections.Add(election);
                    db.SaveChanges();
                    foreach (var candidate in Elec._list)
                    {
                        int positionId = db.Positions
                                           .Where(p => p.PositionName == candidate.Position)
                                           .Select(p => p.PositionId)
                                           .FirstOrDefault();

                        var newCandidate = new Candidate
                        {
                            CandidateName = candidate.CandidateName,
                            Partylist = candidate.Partylist,
                            PositionId = positionId,
                            Motto = candidate.Motto,
                            Image = candidate.Image,
                            DepartmentId = election.DepartmentId,
                            ElectionId = election.ElectionId
                        };
                        db.Candidates.Add(newCandidate);
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Election Created Successfully");
                this.Hide();
                Elec.LoadElections(flow);

            }
        }
        private void AddElection_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
