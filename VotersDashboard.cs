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
    public partial class VotersDashboard : Form
    {
        public VotersDashboard()
        {
            InitializeComponent();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Hide();
            new Login().Show();
        }

        private void view_candidates_button_Click(object sender, EventArgs e)
        {
            new ViewCandidates().ShowDialog();
        }

        private void confirm_ballot_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voted Successfully");
        }
    }
}
