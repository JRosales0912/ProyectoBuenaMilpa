﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBuenaMilpa
{
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
        }

        private void pcbAtras_Click(object sender, EventArgs e)
        {
            (new Home()).Show();
            this.Hide();
        }
    }
}
