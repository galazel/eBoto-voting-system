namespace eBoto
{
    partial class AddElection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.electionName_box = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description_box = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.add_candidate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label20 = new System.Windows.Forms.Label();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBotoDBDataSet1 = new eBoto.eBotoDBDataSet1();
            this.candidates_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.create_election = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.departmentsTableAdapter = new eBoto.eBotoDBDataSet1TableAdapters.DepartmentsTableAdapter();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.departments_combo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBotoDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // electionName_box
            // 
            this.electionName_box.BackColor = System.Drawing.Color.Transparent;
            this.electionName_box.BorderColor = System.Drawing.Color.Gainsboro;
            this.electionName_box.BorderRadius = 10;
            this.electionName_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.electionName_box.DefaultText = "";
            this.electionName_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.electionName_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.electionName_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.electionName_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.electionName_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.electionName_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.electionName_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.electionName_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.electionName_box.Location = new System.Drawing.Point(21, 110);
            this.electionName_box.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.electionName_box.Name = "electionName_box";
            this.electionName_box.PasswordChar = '\0';
            this.electionName_box.PlaceholderText = "";
            this.electionName_box.SelectedText = "";
            this.electionName_box.Size = new System.Drawing.Size(475, 54);
            this.electionName_box.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Election Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label17.Location = new System.Drawing.Point(115, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(316, 39);
            this.label17.TabIndex = 42;
            this.label17.Text = "CREATE ELECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description";
            // 
            // description_box
            // 
            this.description_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.description_box.BackColor = System.Drawing.Color.Transparent;
            this.description_box.BorderColor = System.Drawing.Color.Gainsboro;
            this.description_box.BorderRadius = 10;
            this.description_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description_box.DefaultText = "";
            this.description_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.description_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.description_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.description_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.description_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description_box.Location = new System.Drawing.Point(21, 294);
            this.description_box.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.PasswordChar = '\0';
            this.description_box.PlaceholderText = "";
            this.description_box.SelectedText = "";
            this.description_box.Size = new System.Drawing.Size(475, 90);
            this.description_box.TabIndex = 44;
            // 
            // add_candidate
            // 
            this.add_candidate.BorderRadius = 20;
            this.add_candidate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_candidate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_candidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_candidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_candidate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.add_candidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_candidate.ForeColor = System.Drawing.Color.White;
            this.add_candidate.Location = new System.Drawing.Point(21, 399);
            this.add_candidate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.add_candidate.Name = "add_candidate";
            this.add_candidate.Size = new System.Drawing.Size(148, 41);
            this.add_candidate.TabIndex = 50;
            this.add_candidate.Text = "Add Candidate";
            this.add_candidate.Click += new System.EventHandler(this.add_candidate_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 187);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 65;
            this.label20.Text = "Department";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.eBotoDBDataSet1;
            // 
            // eBotoDBDataSet1
            // 
            this.eBotoDBDataSet1.DataSetName = "eBotoDBDataSet1";
            this.eBotoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidates_flow
            // 
            this.candidates_flow.AutoScroll = true;
            this.candidates_flow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.candidates_flow.Location = new System.Drawing.Point(23, 453);
            this.candidates_flow.Name = "candidates_flow";
            this.candidates_flow.Size = new System.Drawing.Size(473, 258);
            this.candidates_flow.TabIndex = 67;
            // 
            // create_election
            // 
            this.create_election.BorderRadius = 20;
            this.create_election.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.create_election.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.create_election.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.create_election.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.create_election.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.create_election.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.create_election.ForeColor = System.Drawing.Color.White;
            this.create_election.Location = new System.Drawing.Point(176, 724);
            this.create_election.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.create_election.Name = "create_election";
            this.create_election.Size = new System.Drawing.Size(148, 41);
            this.create_election.TabIndex = 68;
            this.create_election.Text = "CREATE";
            this.create_election.Click += new System.EventHandler(this.create_election_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Animated = true;
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.CustomIconSize = 50F;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Location = new System.Drawing.Point(461, 13);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedDepth = 50;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 12;
            this.siticoneControlBox1.UseTransparentBackground = true;
            // 
            // departments_combo
            // 
            this.departments_combo.AutoRoundedCorners = true;
            this.departments_combo.BackColor = System.Drawing.Color.Transparent;
            this.departments_combo.BorderRadius = 17;
            this.departments_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departments_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departments_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departments_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departments_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departments_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.departments_combo.ItemHeight = 30;
            this.departments_combo.Location = new System.Drawing.Point(23, 206);
            this.departments_combo.Name = "departments_combo";
            this.departments_combo.Size = new System.Drawing.Size(473, 36);
            this.departments_combo.TabIndex = 69;
            // 
            // AddElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 777);
            this.Controls.Add(this.departments_combo);
            this.Controls.Add(this.create_election);
            this.Controls.Add(this.candidates_flow);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.add_candidate);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.electionName_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddElection";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddElection";
            this.Load += new System.EventHandler(this.AddElection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBotoDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox electionName_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox description_box;
        private Siticone.Desktop.UI.WinForms.SiticoneButton add_candidate;
        private System.Windows.Forms.Label label20;
        private Siticone.Desktop.UI.WinForms.SiticoneButton create_election;
        private System.Windows.Forms.FlowLayoutPanel candidates_flow;
        private eBotoDBDataSet1 eBotoDBDataSet1;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private eBotoDBDataSet1TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox departments_combo;
    }
}