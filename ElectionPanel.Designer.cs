namespace eBoto
{
    partial class ElectionPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.election_title = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.view_details = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.start = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.status_label = new System.Windows.Forms.Label();
            this.delete_election = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // election_title
            // 
            this.election_title.AutoSize = true;
            this.election_title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.election_title.Location = new System.Drawing.Point(16, 20);
            this.election_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.election_title.Name = "election_title";
            this.election_title.Size = new System.Drawing.Size(207, 25);
            this.election_title.TabIndex = 43;
            this.election_title.Text = "CREATE ELECTION";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(18, 55);
            this.department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(74, 16);
            this.department.TabIndex = 66;
            this.department.Text = "Department";
            // 
            // view_details
            // 
            this.view_details.BorderRadius = 20;
            this.view_details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.view_details.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.view_details.ForeColor = System.Drawing.Color.White;
            this.view_details.Location = new System.Drawing.Point(722, 31);
            this.view_details.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.view_details.Name = "view_details";
            this.view_details.Size = new System.Drawing.Size(132, 40);
            this.view_details.TabIndex = 67;
            this.view_details.Text = "View Details";
            this.view_details.Click += new System.EventHandler(this.view_details_Click);
            // 
            // start
            // 
            this.start.BorderRadius = 20;
            this.start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start.FillColor = System.Drawing.Color.Green;
            this.start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(653, 31);
            this.start.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(52, 40);
            this.start.TabIndex = 68;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(18, 80);
            this.status_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(74, 16);
            this.status_label.TabIndex = 69;
            this.status_label.Text = "Department";
            // 
            // delete_election
            // 
            this.delete_election.BorderRadius = 20;
            this.delete_election.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_election.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_election.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_election.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_election.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.delete_election.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_election.ForeColor = System.Drawing.Color.White;
            this.delete_election.Location = new System.Drawing.Point(862, 31);
            this.delete_election.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.delete_election.Name = "delete_election";
            this.delete_election.Size = new System.Drawing.Size(148, 41);
            this.delete_election.TabIndex = 70;
            this.delete_election.Text = "Add Candidate";
            // 
            // ElectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.delete_election);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.start);
            this.Controls.Add(this.view_details);
            this.Controls.Add(this.department);
            this.Controls.Add(this.election_title);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ElectionPanel";
            this.Size = new System.Drawing.Size(1046, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_title;
        private System.Windows.Forms.Label department;
        private Siticone.Desktop.UI.WinForms.SiticoneButton view_details;
        private Siticone.Desktop.UI.WinForms.SiticoneButton start;
        private System.Windows.Forms.Label status_label;
        private Siticone.Desktop.UI.WinForms.SiticoneButton delete_election;
    }
}
