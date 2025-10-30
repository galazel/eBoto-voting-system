using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBoto
{
    public partial class AddCandidates : Form
    {
        private string imagePath;
        private FlowLayoutPanel flow;
        public AddCandidates(FlowLayoutPanel flow)
        {
            InitializeComponent();
            positions_bombo.Items.Clear();
            this.flow = flow;

            using (var db = new eBotoDBEntities2())
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
            foreach (var list in Elec._list)
            {
                if (list.CandidateName == candidate_name_box.Text && list.Position == positions_bombo.SelectedItem.ToString())
                {
                    MessageBox.Show("Candidate already exists for this position.");
                    return;
                }
            }
            CandidateModel candidate = new CandidateModel
            {
               CandidateName = candidate_name_box.Text,
               Partylist = partylist_box.Text,
               Position=positions_bombo.SelectedItem.ToString(),
               Motto = motto_box.Text,
               Image = imagePath
            };
            Elec._list.Add(candidate);
            MessageBox.Show("Candidate added successfully.");
            if (Elec._list.Count() > 0)
            {
                flow.Controls.Clear();

                foreach (var list in Elec._list)
                {

                    Panel panel = new Panel();

                    Label name = new Label();
                    name.Text = "Name: " + list.CandidateName;
                    name.Location = new Point(10, 10);
                    name.AutoSize = true;
                    name.Font = new Font("Arial", 20, FontStyle.Bold);

                    Label position = new Label();
                    position.Text = "Position: " + list.Position;
                    position.Location = new Point(10, 40); 
                    position.AutoSize = true;
                    position.Font = new Font("Arial", 10, FontStyle.Regular);

                    panel.Controls.Add(name);
                    panel.Controls.Add(position);
                    panel.AutoSize = true;

                    flow.Controls.Add(panel);
                }
            }
            this.Hide();

        }

        private void photo_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
            }
        }
    }
}
