﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class MemberRow : UserControl
    {
        private string name;
        private string role;
        public MemberRow(string name, string role)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
        }

        private void MemberRow_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblRole.Text = role;
        }
    }
}
