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
    public partial class plhform14 : Form
    {
        public plhform14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ΕΞΟΔΟΣ
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)  //ΕΠΙΣΤΡΟΦΗ
        {
            Dplh pp1=new Dplh();
            pp1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //ΣΧΕΤΙΚΑ
        {
            About f6 = new About();
            f6.Show();
            this.Close();
        }

        private void plhform14_Load(object sender, EventArgs e)
        {
            String filename = "leitourgia_grammatias.pdf";
            axAcroPDF1.LoadFile(filename);
        }
    }
}
