﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unipi_Guide
{
    public partial class plhform10 : Form
    {
        public plhform10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About f6 = new About();
            f6.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dplh pp1 = new Dplh();
            pp1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void plhform10_Load(object sender, EventArgs e)
        {
            String filename1 = "kanonismos_didaktorikon_spoudon.pdf";
            axAcroPDF1.LoadFile(filename1);
        }
    }
}
