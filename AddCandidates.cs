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
    public partial class AddCandidates : Form
    {
        public AddCandidates()
        {
            InitializeComponent();
            positions_bombo.Items.Clear();
            using (var db = new eBotoDBEntities1())
            {
                positions_bombo.DataSource = db.Positions
                                                 .Select(d => d.PositionName)
                                                 .ToList();
            }
        }

        private void AddCandidates_Load(object sender, EventArgs e)
        {

        }

        private void confirm_candidate_Click(object sender, EventArgs e)
        {
            using (var db = new eBotoDBEntities1())
            {
                int positionId = db.Positions
                                   .Where(p => p.PositionName == positions_bombo.SelectedItem.ToString())
                                   .Select(p => p.PositionId)
                                   .FirstOrDefault();

                var candidate = new Candidate
                {
                    CandidateName = candidate_name_box.Text,
                    Partylist = partylist_box.Text,
                    PositionId = positionId,
                    Motto = motto_box.Text,
                    Image = ""
                };

                db.Candidates.Add(candidate);
                db.SaveChanges();
                MessageBox.Show("Candidate Added Successfully");
                this.Hide();
            }
        }
    }
}
