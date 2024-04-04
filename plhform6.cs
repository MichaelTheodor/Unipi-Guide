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
    public partial class plhform6 : Form
    {
        public plhform6()
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

        private void button4_Click(object sender, EventArgs e)
        {
            String filename = "fek_epaggelmatiki_katoxirosi.pdf";
            axAcroPDF1.LoadFile(filename);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String filename = "fek_epaggelmatikon_dik_ptyxiouxon.pdf";
            axAcroPDF1.LoadFile(filename);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String filename = "fek_pedagogiki_eparkia111.pdf";
            axAcroPDF1.LoadFile(filename);
        }

        private void plhform6_Load(object sender, EventArgs e)
        {
            String filename = "fek_epaggelmatiki_katoxirosi.pdf";
            axAcroPDF1.LoadFile(filename);
        }
    }
}
