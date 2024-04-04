using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;

namespace Unipi_Guide
{
    public partial class Login : Form
    {
        String connectionString = "Data source = database.db;version=3";
        SQLiteConnection conn;
        SpeechSynthesizer engine = new SpeechSynthesizer();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            engine.SelectVoice("Microsoft Stefanos");
            engine.SpeakAsync(richTextBox1.Text);
            engine.Volume = 7;
            engine.Rate = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // ΚΟΥΜΠΙ ΕΙΣΟΔΟΣ ΕΠΙΣΚΕΠΤΩΝ // 
        {
            Home_Visitors f3 = new Home_Visitors();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)  // ΚΟΥΜΠΙ ΕΙΣΟΔΟΣ ΦΟΙΤΗΤΩΝ //
        {
            conn.Open();
            String email = textBox1.Text;
            String password = textBox2.Text;
            //Parameterized query//
            String selectSQL = "Select * from ΦΟΙΤΗΤΕΣ where " + "email=@email and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show(" Έγινε Είσοδος!");
                Home_Students f4 = new Home_Students();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Λάθος ηλεκτρ. διεύθυνση και/ή κωδικός...");
            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e) // ΚΟΥΜΠΙ ΚΑΘΑΡΙΣΜΟΣ //
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e) // ΚΟΥΜΠΙ ΕΞΟΔΟΣ //
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var voice in engine.GetInstalledVoices())
                builder.Append(voice.VoiceInfo.Culture).Append(Environment.NewLine);
            MessageBox.Show(builder.ToString());
        }
    }
}
