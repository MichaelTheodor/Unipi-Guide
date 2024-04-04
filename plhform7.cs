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
    public partial class plhform7 : Form
    {
        public plhform7()
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

        private void plhform7_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cs.unipi.gr/index.php?option=com_k2&view=itemlist&layout=category&task=category&id=16&Itemid=673&lang=el");
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
