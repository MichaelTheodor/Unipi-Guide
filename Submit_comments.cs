using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unipi_Guide.Properties;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Unipi_Guide
{
    public partial class Submit_comments : Form
    {
        String connectionString = "Data source = database.db;version=3";
        SQLiteConnection conn;
        private int x1;
        private int x2;
        private int x3;
        private int x4;
        private int x5;
        private float f;

        public Submit_comments()
        {
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4= 0;
            x5 = 0;
            f = 0;

            InitializeComponent();
        }

        private void Submit_comments_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
             
        }

        private void pb_str5_1_Click(object sender, EventArgs e)
        {
            pb_str1_1.Image = Resources.yellow_star;
            pb_str2_1.Image = Resources.yellow_star;
            pb_str3_1.Image = Resources.yellow_star;
            pb_str4_1.Image = Resources.yellow_star;
            pb_str5_1.Image = Resources.yellow_star;
            x1 = 5;
        }

        private void pb_str4_1_Click(object sender, EventArgs e)
        {
            pb_str1_1.Image = Resources.yellow_star;
            pb_str2_1.Image = Resources.yellow_star;
            pb_str3_1.Image = Resources.yellow_star;
            pb_str4_1.Image = Resources.yellow_star;
            pb_str5_1.Image = Resources.white_star;
            x1 = 4;
        }

        private void pb_str3_1_Click(object sender, EventArgs e)
        {
            pb_str1_1.Image = Resources.yellow_star;
            pb_str2_1.Image = Resources.yellow_star;
            pb_str3_1.Image = Resources.yellow_star;
            pb_str4_1.Image = Resources.white_star;
            pb_str5_1.Image = Resources.white_star;
            x1 = 3;
        }

        private void pb_str2_1_Click(object sender, EventArgs e)
        {
            pb_str1_1.Image = Resources.yellow_star;
            pb_str2_1.Image = Resources.yellow_star;
            pb_str3_1.Image = Resources.white_star;
            pb_str4_1.Image = Resources.white_star;
            pb_str5_1.Image = Resources.white_star;
            x1 = 2;
        }

        private void pb_str1_1_Click(object sender, EventArgs e)
        {
            pb_str1_1.Image = Resources.yellow_star;
            pb_str2_1.Image = Resources.white_star;
            pb_str3_1.Image = Resources.white_star;
            pb_str4_1.Image = Resources.white_star;
            pb_str5_1.Image = Resources.white_star;
            x1 = 1;
        }
        private void pb_str1_2_Click(object sender, EventArgs e)
        {
            pb_str1_2.Image = Resources.yellow_star;
            pb_str2_2.Image = Resources.white_star;
            pb_str3_2.Image = Resources.white_star;
            pb_str4_2.Image = Resources.white_star;
            pb_str5_2.Image = Resources.white_star;
            x2 = 1;

        }

        private void pb_str2_2_Click(object sender, EventArgs e)
        {
            pb_str1_2.Image = Resources.yellow_star;
            pb_str2_2.Image = Resources.yellow_star;
            pb_str3_2.Image = Resources.white_star;
            pb_str4_2.Image = Resources.white_star;
            pb_str5_2.Image = Resources.white_star;
            x2 = 2;
        }

        private void pb_str3_2_Click(object sender, EventArgs e)
        {
            pb_str1_2.Image = Resources.yellow_star;
            pb_str2_2.Image = Resources.yellow_star;
            pb_str3_2.Image = Resources.yellow_star;
            pb_str4_2.Image = Resources.white_star;
            pb_str5_2.Image = Resources.white_star;
            x2 = 3;
        }

        private void pb_str4_2_Click(object sender, EventArgs e)
        {
            pb_str1_2.Image = Resources.yellow_star;
            pb_str2_2.Image = Resources.yellow_star;
            pb_str3_2.Image = Resources.yellow_star;
            pb_str4_2.Image = Resources.yellow_star;
            pb_str5_2.Image = Resources.white_star;
            x2 = 4;
        }

        private void pb_str5_2_Click(object sender, EventArgs e)
        {
            pb_str1_2.Image = Resources.yellow_star;
            pb_str2_2.Image = Resources.yellow_star;
            pb_str3_2.Image = Resources.yellow_star;
            pb_str4_2.Image = Resources.yellow_star;
            pb_str5_2.Image = Resources.yellow_star;
            x2 = 5;
        }
        private void pb_str1_3_Click(object sender, EventArgs e)
        {
            pb_str1_3.Image = Resources.yellow_star;
            pb_str2_3.Image = Resources.white_star;
            pb_str3_3.Image = Resources.white_star;
            pb_str4_3.Image = Resources.white_star;
            pb_str5_3.Image = Resources.white_star;
            x3 = 1;
        }

        private void pb_str2_3_Click(object sender, EventArgs e)
        {
            pb_str1_3.Image = Resources.yellow_star;
            pb_str2_3.Image = Resources.yellow_star;
            pb_str3_3.Image = Resources.white_star;
            pb_str4_3.Image = Resources.white_star;
            pb_str5_3.Image = Resources.white_star;
            x3 = 2;
        }

        private void pb_str3_3_Click(object sender, EventArgs e)
        {
            pb_str1_3.Image = Resources.yellow_star;
            pb_str2_3.Image = Resources.yellow_star;
            pb_str3_3.Image = Resources.yellow_star;
            pb_str4_3.Image = Resources.white_star;
            pb_str5_3.Image = Resources.white_star;
            x3 = 3;
        }
        private void pb_str4_3_Click(object sender, EventArgs e)
        {
            pb_str1_3.Image = Resources.yellow_star;
            pb_str2_3.Image = Resources.yellow_star;
            pb_str3_3.Image = Resources.yellow_star;
            pb_str4_3.Image = Resources.yellow_star;
            pb_str5_3.Image = Resources.white_star;
            x3 = 4;
        }

        private void pb_str5_3_Click(object sender, EventArgs e)
        {
            pb_str1_3.Image = Resources.yellow_star;
            pb_str2_3.Image = Resources.yellow_star;
            pb_str3_3.Image = Resources.yellow_star;
            pb_str4_3.Image = Resources.yellow_star;
            pb_str5_3.Image = Resources.yellow_star;
            x3 =5;
        }
        private void pb_str1_4_Click(object sender, EventArgs e)
        {
            pb_str1_4.Image = Resources.yellow_star;
            pb_str2_4.Image = Resources.white_star;
            pb_str3_4.Image = Resources.white_star;
            pb_str4_4.Image = Resources.white_star;
            pb_str5_4.Image = Resources.white_star;
            x4 = 1;
        }

        private void pb_str2_4_Click(object sender, EventArgs e)
        {
            pb_str1_4.Image = Resources.yellow_star;
            pb_str2_4.Image = Resources.yellow_star;
            pb_str3_4.Image = Resources.white_star;
            pb_str4_4.Image = Resources.white_star;
            pb_str5_4.Image = Resources.white_star;
            x4 = 2;
        }
        private void pb_str3_4_Click(object sender, EventArgs e)
        {
            pb_str1_4.Image = Resources.yellow_star;
            pb_str2_4.Image = Resources.yellow_star;
            pb_str3_4.Image = Resources.yellow_star;
            pb_str4_4.Image = Resources.white_star;
            pb_str5_4.Image = Resources.white_star;
            x4 = 3;
        }
        private void pb_str4_4_Click(object sender, EventArgs e)
        {
            pb_str1_4.Image = Resources.yellow_star;
            pb_str2_4.Image = Resources.yellow_star;
            pb_str3_4.Image = Resources.yellow_star;
            pb_str4_4.Image = Resources.yellow_star;
            pb_str5_4.Image = Resources.white_star;
            x4 = 4;
        }

        private void pb_str5_4_Click(object sender, EventArgs e)
        {
            pb_str1_4.Image = Resources.yellow_star;
            pb_str2_4.Image = Resources.yellow_star;
            pb_str3_4.Image = Resources.yellow_star;
            pb_str4_4.Image = Resources.yellow_star;
            pb_str5_4.Image = Resources.yellow_star;
            x4 = 5;
        }
        private void pb_str1_5_Click(object sender, EventArgs e)
        {
            pb_str1_5.Image = Resources.yellow_star;
            pb_str2_5.Image = Resources.white_star;
            pb_str3_5.Image = Resources.white_star;
            pb_str4_5.Image = Resources.white_star;
            pb_str5_5.Image = Resources.white_star;
            x5 = 1;
        }
        private void pb_str2_5_Click(object sender, EventArgs e)
        {
            pb_str1_5.Image = Resources.yellow_star;
            pb_str2_5.Image = Resources.yellow_star;
            pb_str3_5.Image = Resources.white_star;
            pb_str4_5.Image = Resources.white_star;
            pb_str5_5.Image = Resources.white_star;
            x5 = 2;
        }
        private void pb_str3_5_Click(object sender, EventArgs e)
        {
            pb_str1_5.Image = Resources.yellow_star;
            pb_str2_5.Image = Resources.yellow_star;
            pb_str3_5.Image = Resources.yellow_star;
            pb_str4_5.Image = Resources.white_star;
            pb_str5_5.Image = Resources.white_star;
            x5 = 3;
        }
        private void pb_str4_5_Click(object sender, EventArgs e)
        {
            pb_str1_5.Image = Resources.yellow_star;
            pb_str2_5.Image = Resources.yellow_star;
            pb_str3_5.Image = Resources.yellow_star;
            pb_str4_5.Image = Resources.yellow_star;
            pb_str5_5.Image = Resources.white_star;
            x5 = 4;
        }
        private void pb_str5_5_Click(object sender, EventArgs e)
        {
            pb_str1_5.Image = Resources.yellow_star;
            pb_str2_5.Image = Resources.yellow_star;
            pb_str3_5.Image = Resources.yellow_star;
            pb_str4_5.Image = Resources.yellow_star;
            pb_str5_5.Image = Resources.yellow_star;
            x5 = 5;
        }

        private void button3_Click(object sender, EventArgs e) //Έξοδος
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //Επιστροφή
        {
            Home_Students f4 = new Home_Students();
            f4.Show();
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e) // Αποθήκευση Σχολίου
        {
            conn.Open();
            f = (x1 + x2 + x3 + x4 + x5) / 5;
            textBox1.Text = f.ToString("f2");
            String comment = richTextBox1.Text;
            String rating = textBox1.Text; 
            String insertSQL= "INSERT INTO ΒΑΘΜΟΛΟΓΙΑ_ΣΧΟΛΙΑ (comment,rating) " + "VALUES (@comment,@rating)";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL,conn);
            cmd.Parameters.AddWithValue("@comment",comment);
            cmd.Parameters.AddWithValue("@rating", rating);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
                MessageBox.Show("H βαθμολόγηση και τα σχόλια σας αποθηκεύτηκαν. Ευχαριστούμε για τον χρόνο σας!");
            conn.Close();
        }
    }
}
