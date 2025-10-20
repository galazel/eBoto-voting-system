namespace eBoto
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.label19 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.greetings_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ended = new System.Windows.Forms.TabPage();
            this.voters_dataview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBotoDBDataSet = new eBoto.eBotoDBDataSet();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.elections = new System.Windows.Forms.TabPage();
            this.create_button = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label11 = new System.Windows.Forms.Label();
            this.ongoing = new System.Windows.Forms.TabPage();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.candidates_dataview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.electionsTableAdapter = new eBoto.eBotoDBDataSetTableAdapters.ElectionsTableAdapter();
            this.siticoneTextBox4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.elections_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboard.SuspendLayout();
            this.ended.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voters_dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBotoDBDataSet)).BeginInit();
            this.siticoneTabControl1.SuspendLayout();
            this.elections.SuspendLayout();
            this.ongoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidates_dataview)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label19.Location = new System.Drawing.Point(17, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 33);
            this.label19.TabIndex = 3;
            this.label19.Text = "VOTERS";
            // 
            // dashboard
            // 
            this.dashboard.AutoScroll = true;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dashboard.Controls.Add(this.greetings_label);
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dashboard.ImageKey = "dashboard.png";
            this.dashboard.Location = new System.Drawing.Point(184, 4);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboard.Size = new System.Drawing.Size(1211, 828);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // greetings_label
            // 
            this.greetings_label.AutoSize = true;
            this.greetings_label.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetings_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.greetings_label.Location = new System.Drawing.Point(17, 20);
            this.greetings_label.Name = "greetings_label";
            this.greetings_label.Size = new System.Drawing.Size(233, 39);
            this.greetings_label.TabIndex = 6;
            this.greetings_label.Text = "Hello, Admin!";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Voter";
            // 
            // ended
            // 
            this.ended.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ended.Controls.Add(this.siticoneTextBox4);
            this.ended.Controls.Add(this.voters_dataview);
            this.ended.Controls.Add(this.iconButton1);
            this.ended.Controls.Add(this.label19);
            this.ended.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ended.ImageKey = "vote.png";
            this.ended.Location = new System.Drawing.Point(184, 4);
            this.ended.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ended.Name = "ended";
            this.ended.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ended.Size = new System.Drawing.Size(1211, 828);
            this.ended.TabIndex = 1;
            this.ended.Text = "Ended Elections";
            this.ended.UseVisualStyleBackColor = true;
            // 
            // voters_dataview
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.voters_dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.voters_dataview.AutoGenerateColumns = false;
            this.voters_dataview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.voters_dataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.voters_dataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.voters_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.voters_dataview.ColumnHeadersHeight = 50;
            this.voters_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.voters_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.voters_dataview.DataSource = this.electionsBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.voters_dataview.DefaultCellStyle = dataGridViewCellStyle9;
            this.voters_dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.voters_dataview.Location = new System.Drawing.Point(23, 91);
            this.voters_dataview.Name = "voters_dataview";
            this.voters_dataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.voters_dataview.RowHeadersVisible = false;
            this.voters_dataview.Size = new System.Drawing.Size(1166, 479);
            this.voters_dataview.TabIndex = 7;
            this.voters_dataview.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.voters_dataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.voters_dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.voters_dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.voters_dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.voters_dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.voters_dataview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.voters_dataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.voters_dataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.voters_dataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.voters_dataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_dataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.voters_dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.voters_dataview.ThemeStyle.HeaderStyle.Height = 50;
            this.voters_dataview.ThemeStyle.ReadOnly = false;
            this.voters_dataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.voters_dataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.voters_dataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_dataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.voters_dataview.ThemeStyle.RowsStyle.Height = 22;
            this.voters_dataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.voters_dataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ElectionID";
            this.dataGridViewTextBoxColumn17.HeaderText = "ElectionID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ElectionName";
            this.dataGridViewTextBoxColumn18.HeaderText = "ElectionName";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn19.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn20.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn21.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "PositionID";
            this.dataGridViewTextBoxColumn22.HeaderText = "PositionID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "CandidateID";
            this.dataGridViewTextBoxColumn23.HeaderText = "CandidateID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "PartylistID";
            this.dataGridViewTextBoxColumn24.HeaderText = "PartylistID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // electionsBindingSource
            // 
            this.electionsBindingSource.DataMember = "Elections";
            this.electionsBindingSource.DataSource = this.eBotoDBDataSet;
            // 
            // eBotoDBDataSet
            // 
            this.eBotoDBDataSet.DataSetName = "eBotoDBDataSet";
            this.eBotoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1135, 19);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(54, 47);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.dashboard);
            this.siticoneTabControl1.Controls.Add(this.elections);
            this.siticoneTabControl1.Controls.Add(this.ongoing);
            this.siticoneTabControl1.Controls.Add(this.ended);
            this.siticoneTabControl1.Controls.Add(this.settings);
            this.siticoneTabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ImageList = this.imageList1;
            this.siticoneTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 60);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1399, 836);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 60);
            this.siticoneTabControl1.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneTabControl1.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneTabControl1.TabIndex = 0;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // elections
            // 
            this.elections.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elections.Controls.Add(this.elections_flow);
            this.elections.Controls.Add(this.create_button);
            this.elections.Controls.Add(this.label11);
            this.elections.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.elections.ImageKey = "guidelines.png";
            this.elections.Location = new System.Drawing.Point(184, 4);
            this.elections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elections.Name = "elections";
            this.elections.Size = new System.Drawing.Size(1211, 828);
            this.elections.TabIndex = 2;
            this.elections.Text = "Elections";
            this.elections.UseVisualStyleBackColor = true;
            // 
            // create_button
            // 
            this.create_button.BorderRadius = 10;
            this.create_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.create_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.create_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.create_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.create_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.create_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.create_button.ForeColor = System.Drawing.Color.White;
            this.create_button.Location = new System.Drawing.Point(1051, 52);
            this.create_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(115, 36);
            this.create_button.TabIndex = 7;
            this.create_button.Text = "CREATE";
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label11.Location = new System.Drawing.Point(17, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 33);
            this.label11.TabIndex = 2;
            this.label11.Text = "ELECTIONS";
            // 
            // ongoing
            // 
            this.ongoing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ongoing.Controls.Add(this.siticoneButton2);
            this.ongoing.Controls.Add(this.candidates_dataview);
            this.ongoing.Controls.Add(this.iconButton2);
            this.ongoing.Controls.Add(this.siticoneTextBox2);
            this.ongoing.Controls.Add(this.label2);
            this.ongoing.ImageKey = "position.png";
            this.ongoing.Location = new System.Drawing.Point(184, 4);
            this.ongoing.Name = "ongoing";
            this.ongoing.Size = new System.Drawing.Size(1211, 828);
            this.ongoing.TabIndex = 4;
            this.ongoing.Text = "Ongoing Elections";
            this.ongoing.UseVisualStyleBackColor = true;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(1074, 577);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(115, 36);
            this.siticoneButton2.TabIndex = 15;
            this.siticoneButton2.Text = "Add Candidate";
            // 
            // candidates_dataview
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.candidates_dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.candidates_dataview.AutoGenerateColumns = false;
            this.candidates_dataview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.candidates_dataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.candidates_dataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.candidates_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.candidates_dataview.ColumnHeadersHeight = 50;
            this.candidates_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.candidates_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.candidates_dataview.DataSource = this.electionsBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.candidates_dataview.DefaultCellStyle = dataGridViewCellStyle12;
            this.candidates_dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.candidates_dataview.Location = new System.Drawing.Point(23, 91);
            this.candidates_dataview.Name = "candidates_dataview";
            this.candidates_dataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.candidates_dataview.RowHeadersVisible = false;
            this.candidates_dataview.Size = new System.Drawing.Size(1166, 479);
            this.candidates_dataview.TabIndex = 10;
            this.candidates_dataview.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.candidates_dataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.candidates_dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.candidates_dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.candidates_dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.candidates_dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.candidates_dataview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.candidates_dataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.candidates_dataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.candidates_dataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.candidates_dataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidates_dataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.candidates_dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.candidates_dataview.ThemeStyle.HeaderStyle.Height = 50;
            this.candidates_dataview.ThemeStyle.ReadOnly = false;
            this.candidates_dataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.candidates_dataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.candidates_dataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidates_dataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.candidates_dataview.ThemeStyle.RowsStyle.Height = 22;
            this.candidates_dataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.candidates_dataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ElectionID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ElectionID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ElectionName";
            this.dataGridViewTextBoxColumn10.HeaderText = "ElectionName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn13.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PositionID";
            this.dataGridViewTextBoxColumn14.HeaderText = "PositionID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CandidateID";
            this.dataGridViewTextBoxColumn15.HeaderText = "CandidateID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PartylistID";
            this.dataGridViewTextBoxColumn16.HeaderText = "PartylistID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(1140, 30);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 46);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "Search";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Location = new System.Drawing.Point(771, 30);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.Size = new System.Drawing.Size(358, 36);
            this.siticoneTextBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "CANDIDATES";
            // 
            // settings
            // 
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settings.ImageKey = "settings.png";
            this.settings.Location = new System.Drawing.Point(184, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1211, 828);
            this.settings.TabIndex = 6;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dashboard.png");
            this.imageList1.Images.SetKeyName(1, "guidelines.png");
            this.imageList1.Images.SetKeyName(2, "logout.png");
            this.imageList1.Images.SetKeyName(3, "settings.png");
            this.imageList1.Images.SetKeyName(4, "vote.png");
            this.imageList1.Images.SetKeyName(5, "position.png");
            this.imageList1.Images.SetKeyName(6, "groups.png");
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 20;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 1D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label18.Location = new System.Drawing.Point(3, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 58);
            this.label18.TabIndex = 7;
            this.label18.Text = "eBoto";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneTabControl1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 64);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1399, 836);
            this.siticonePanel2.TabIndex = 3;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.label18);
            this.siticonePanel1.Controls.Add(this.profile_button);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1399, 64);
            this.siticonePanel1.TabIndex = 2;
            // 
            // electionsTableAdapter
            // 
            this.electionsTableAdapter.ClearBeforeFill = true;
            // 
            // siticoneTextBox4
            // 
            this.siticoneTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox4.DefaultText = "Search";
            this.siticoneTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.Location = new System.Drawing.Point(782, 20);
            this.siticoneTextBox4.Name = "siticoneTextBox4";
            this.siticoneTextBox4.PasswordChar = '\0';
            this.siticoneTextBox4.PlaceholderText = "";
            this.siticoneTextBox4.SelectedText = "";
            this.siticoneTextBox4.Size = new System.Drawing.Size(358, 36);
            this.siticoneTextBox4.TabIndex = 9;
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.Color.Transparent;
            this.profile_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button.ForeColor = System.Drawing.Color.Transparent;
            this.profile_button.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profile_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.profile_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profile_button.Location = new System.Drawing.Point(1326, 13);
            this.profile_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(49, 43);
            this.profile_button.TabIndex = 2;
            this.toolTip1.SetToolTip(this.profile_button, "Voters Name");
            this.profile_button.UseVisualStyleBackColor = false;
            // 
            // elections_flow
            // 
            this.elections_flow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.elections_flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elections_flow.Location = new System.Drawing.Point(23, 97);
            this.elections_flow.Name = "elections_flow";
            this.elections_flow.Size = new System.Drawing.Size(1143, 542);
            this.elections_flow.TabIndex = 8;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 900);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.ended.ResumeLayout(false);
            this.ended.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voters_dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBotoDBDataSet)).EndInit();
            this.siticoneTabControl1.ResumeLayout(false);
            this.elections.ResumeLayout(false);
            this.elections.PerformLayout();
            this.ongoing.ResumeLayout(false);
            this.ongoing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidates_dataview)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage ended;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage elections;
        private System.Windows.Forms.TabPage ongoing;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.ImageList imageList1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton create_button;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label greetings_label;
        private eBotoDBDataSet eBotoDBDataSet;
        private System.Windows.Forms.BindingSource electionsBindingSource;
        private eBotoDBDataSetTableAdapters.ElectionsTableAdapter electionsTableAdapter;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView voters_dataview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView candidates_dataview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox4;
        private FontAwesome.Sharp.IconButton profile_button;
        private System.Windows.Forms.FlowLayoutPanel elections_flow;
    }
}