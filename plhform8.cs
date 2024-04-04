using System;
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
    public partial class plhform8 : Form
    {
        public plhform8()
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

        private void button6_Click(object sender, EventArgs e)
        {
            String filename = "programma_spoudwn_2020_2021_working.pdf";
            axAcroPDF1.LoadFile(filename);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String filename1 = "pps2020_2021.pdf";
            axAcroPDF1.LoadFile(filename1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String filename2 = "b41_kanonismos_pps.pdf";
            axAcroPDF1.LoadFile(filename2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String filename3 = "kanonismos_ekponysis_ptyxiakis_ergasias.pdf";
            axAcroPDF1.LoadFile(filename3);
        }

        private void plhform8_Load(object sender, EventArgs e)
        {
            String filename1 = "pps2020_2021.pdf";
            axAcroPDF1.LoadFile(filename1);
        }
    }
}
