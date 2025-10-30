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
                    Panel panel = new Panel
                    {
                        Width = 1100,
                        Height = 100,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10)
                    };
                    Label electionNameLabel = new Label
                    {
                        Text = election.ElectionName,
                        Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold),
                        Location = new System.Drawing.Point(10, 10),
                        AutoSize = true
                    };
                    Label descriptionLabel = new Label
                    {
                        Text = election.Description,
                        Font = new System.Drawing.Font("Segoe UI", 10),
                        Location = new System.Drawing.Point(10, 40),
                        AutoSize = true
                    };
                    Label statusLabel = new Label
                    {
                        Text = election.Status ? "Ongoing" : "Not Started",
                        Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Italic),
                        Location = new System.Drawing.Point(10, 70),
                        AutoSize = true
                    };
                    Button viewCandidates = new Button
                    {
                        Text = "View Candidates",
                        Location = new System.Drawing.Point(900, 35),
                        AutoSize = true
                    };
                    Button startElection = new Button
                    {
                        Text = "Start Election",
                        Location = new System.Drawing.Point(780, 35),
                        AutoSize = true
                    };
                    panel.Controls.Add(electionNameLabel);
                    panel.Controls.Add(descriptionLabel);
                    panel.Controls.Add(statusLabel);
                    panel.Controls.Add(viewCandidates);
                    panel.Controls.Add(startElection);
                    flow.Controls.Add(panel);
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
