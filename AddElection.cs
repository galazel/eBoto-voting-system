﻿using System;
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
    public partial class AddElection : Form
    {
        public AddElection()
        {
            InitializeComponent();
        }

        private void add_candidate_Click(object sender, EventArgs e)
        {
            new AddCandidates().ShowDialog();
        }
    }
}
