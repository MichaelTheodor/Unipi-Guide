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
    public partial class About1V : Form
    {
        Random r;
        public About1V()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_Visitors f4 = new Home_Visitors();
            f4.Show();
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            r=new Random();
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            if (pictureBox3.Location.X < this.Width)
                pictureBox3.Location = new Point(pictureBox3.Location.X + 3, pictureBox3.Location.Y + 3);
            else
            {
                int randX = r.Next(this.Width - pictureBox3.Width);
                int randY = r.Next(this.Height - pictureBox3.Height);
                pictureBox3.Location = new Point(randX, randY);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.Navy)
                BackColor = Color.Maroon;
            else BackColor = Color.Navy;
        }
    }
}
