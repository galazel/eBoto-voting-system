namespace eBoto
{
    partial class ElectionDetails
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
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.election_name = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Animated = true;
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.CustomIconSize = 50F;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Location = new System.Drawing.Point(439, 16);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedDepth = 50;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 45;
            this.siticoneControlBox1.UseTransparentBackground = true;
            // 
            // election_name
            // 
            this.election_name.AutoSize = true;
            this.election_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name.Location = new System.Drawing.Point(31, 62);
            this.election_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.election_name.Name = "election_name";
            this.election_name.Size = new System.Drawing.Size(40, 16);
            this.election_name.TabIndex = 67;
            this.election_name.Text = "Name";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(31, 94);
            this.department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(40, 16);
            this.department.TabIndex = 68;
            this.department.Text = "Name";
            // 
            // ElectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.department);
            this.Controls.Add(this.election_name);
            this.Controls.Add(this.siticoneControlBox1);
            this.Name = "ElectionDetails";
            this.Size = new System.Drawing.Size(496, 479);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label election_name;
        private System.Windows.Forms.Label department;
    }
}
