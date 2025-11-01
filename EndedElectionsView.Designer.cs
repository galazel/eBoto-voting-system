namespace eBoto
{
    partial class EndedElectionsView
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
            this.view_winners = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // election_title
            // 
            this.election_title.AutoSize = true;
            this.election_title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.election_title.Location = new System.Drawing.Point(32, 39);
            this.election_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.election_title.Name = "election_title";
            this.election_title.Size = new System.Drawing.Size(207, 25);
            this.election_title.TabIndex = 44;
            this.election_title.Text = "CREATE ELECTION";
            // 
            // view_winners
            // 
            this.view_winners.BorderRadius = 20;
            this.view_winners.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_winners.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_winners.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_winners.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_winners.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.view_winners.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.view_winners.ForeColor = System.Drawing.Color.White;
            this.view_winners.Location = new System.Drawing.Point(878, 39);
            this.view_winners.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.view_winners.Name = "view_winners";
            this.view_winners.Size = new System.Drawing.Size(132, 40);
            this.view_winners.TabIndex = 68;
            this.view_winners.Text = "View Winners";
            // 
            // EndedElectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.view_winners);
            this.Controls.Add(this.election_title);
            this.Name = "EndedElectionsView";
            this.Size = new System.Drawing.Size(1046, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_title;
        private Siticone.Desktop.UI.WinForms.SiticoneButton view_winners;
    }
}
