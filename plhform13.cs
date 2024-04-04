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
    public partial class plhform13 : Form
    {
        public plhform13()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://gunet2.cs.unipi.gr/");
            webBrowser1.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://sis-portal.unipi.gr");
            webBrowser1.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://cslab.unipi.gr");
            webBrowser1.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.lib.unipi.gr/iguana/www.main.cls?surl=library");
            webBrowser1.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://eudoxus.gr/");
            webBrowser1.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://helpdesk.unipi.gr/");
            webBrowser1.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.kep.unipi.gr/");
            webBrowser1.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.unipi.gr/unipi/el/");
            webBrowser1.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://career.unipi.gr/");
            webBrowser1.Visible = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://helpdesk.unipi.gr/software/");
            webBrowser1.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://academy.oracle.com/en/oa-student.html");
            webBrowser1.Visible = true;
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
    }
}
