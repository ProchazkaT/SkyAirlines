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
    public partial class Airline : UserControl
    {
        private Panel panel;

        public Airline(Panel panel)
        {
            InitializeComponent();

            this.panel = panel;
        }
    }
}
