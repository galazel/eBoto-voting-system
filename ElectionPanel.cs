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
    public partial class ElectionPanel : UserControl
    {
        private string status;
        private IList<Candidate> candidates;
        public ElectionPanel(string electionName, string electionDepartment, IList<Candidate> candidates, string status)
        {
            InitializeComponent();
            this.election_title.Text = electionName;
            this.department.Text = electionDepartment;
            this.status = status;
            this.candidates = candidates;
        }

        private void view_details_Click(object sender, EventArgs e)
        {
            string candidatesView = "";

            using (var db = new eBotoDBEntities1())
            {
               foreach (var candidate in this.candidates)
                   candidatesView += "- " + candidate.CandidateName + " (" + db.Positions.FirstOrDefault(p => p.PositionId == candidate.PositionId).PositionName + ")\n";
            }


            MessageBox.Show("Election Name: "+election_title.Text +"\nDepartment: "+department.Text+"\nStatus: "+status+"\nCandidates: \n"+candidatesView);
        }

        private void start_Click(object sender, EventArgs e)
        {
            using(var db = new eBotoDBEntities1())
            {
                var elections = db.Elections.ToList();
                foreach(var election in elections)
                {
                   if(election.ElectionName == election_title.Text)
                   {
                       election.Status = true;
                       db.SaveChanges();
                       MessageBox.Show("Election Started!");
                    }
                }
            }
        }
    }
}
