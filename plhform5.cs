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
    public partial class plhform5 : Form
    {
        public plhform5()
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

        private void plhform5_Load(object sender, EventArgs e)
        {
            String filename = "mitroa_pli_2021.pdf";
            axAcroPDF1.LoadFile(filename);
            richTextBox6.LoadFile("textfiles\\Καθηγητές και στοιχεία επικοινωνίας.txt",RichTextBoxStreamType.PlainText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox6.SaveFile("textfiles\\Επικοινωνία.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("Το αρχείο 'Καθηγητές και στοιχεία επικοινωνίας' αποθηκεύτηκε με όνομα αρχείου 'Επικοινωνία.txt'!");
        }
    }
}
