using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBoto
{
    internal class Elec
    {
        public static int ElectionId { get; set; }
        public static int DepartmentId { get; set; }

        public static IList<CandidateModel> _list = new List<CandidateModel>();
        public static Boolean isCreated = false;
        public static void LoadStatistics(Label label1, Label label2, Label label3)
        {
            using (var db = new eBotoDBEntities1())
            {
                int registeredVotersCount = db.Voters.Count();
                int electionsCount = db.Elections.Count();
                int candidatesCount = db.Candidates.Count();
                label1.Text = registeredVotersCount.ToString();
                label2.Text = electionsCount.ToString();
                label3.Text = candidatesCount.ToString();
            }
        }
        public static void LoadElections(FlowLayoutPanel flow)
        {
            using (var db = new eBotoDBEntities1())
            {
                var elections = db.Elections.ToList();
                foreach (var election in elections)
                {
                    string departmentName = db.Departments
                                            .Where(d => d.DepartmentId == election.DepartmentId)
                                            .Select(d => d.DepartmentName)
                                            .FirstOrDefault();
                    int electionId = election.ElectionId;
                    string status = election.Status ? "Ongoing" : "Not Started";
                    var candidates =  db.Candidates.Where(c => c.ElectionId == electionId).ToList();
                    flow.Controls.Add(new ElectionPanel(election.ElectionName, departmentName, candidates, status));
                }
            }
        }
        public void LoadOngoing()
        {

        }
        public void LoadEnded()
        {

        }
    }
    }
