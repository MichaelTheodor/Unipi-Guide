using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unipi_Guide
{
    public partial class StudWelfare : Form
    {
        private SoundPlayer _soundPlayer;
        public StudWelfare()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Another Brick In The Wall.wav");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chk_Play_Stop_Music_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Play_Stop_Music.Checked)
            {
                chk_Play_Stop_Music.Text = "Σταμάτα";
                _soundPlayer.Play();
            }
            else
            {
                chk_Play_Stop_Music.Text = "Παίξε";
                _soundPlayer.Stop();
            }
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pictureBox2.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About f7 = new About();
            f7.Show();
            this.Close();
        }
        private void ιστορίαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uhistory f7 = new Uhistory();
            f7.Show();
            this.Close();
        }

        private void περιήγησηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utour f7 = new Utour();
            f7.Show();
            this.Close();
        }

        private void εσωτερικόςΚανονισμόςΠανεπιστημίουΠειραιώςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urules f8 = new Urules();
            f8.Show();
            this.Close();
        }

        private void κώδικαςΔεοντολογίαςΚαιΚαλήςΠρακτικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uethics f9 = new Uethics();
            f9.Show();
            this.Close();
        }

        private void τοποθεσίεςΠρόσβασηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uaccess f10 = new Uaccess();
            f10.Show();
            this.Close();
        }

        private void προστασίαΔεδομένωνΠροσωπικούΧαρακτήραToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ugdpr f11 = new Ugdpr();
            f11.Show();
            this.Close();
        }

        private void πολιτικήΠοιότηταςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uquality f12 = new Uquality();
            f12.Show();
            this.Close();
        }

        private void στρατηγικήΠανεπιστημίουToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ustrategy f13 = new Ustrategy();
            f13.Show();
            this.Close();
        }

        private void httpseventsunipigrelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uevents f14 = new Uevents();
            f14.Show();
            this.Close();
        }
        private void γραφείοΠρυτάνεωςToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void unipigrunipielsugklhtosarmodiothtessugklhtouhtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Msenrespons f17 = new Msenrespons();
            f17.Show();
            this.Close();
        }

        private void αρμοδιότητεςΠρυτανικούΣυμβουλίουToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mrectcounsrespons f18 = new Mrectcounsrespons();
            f18.Show();
            this.Close();
        }

        private void αποφάσειςΠρυτανικούΣυμβουλίουToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mrectcounsdecis f19 = new Mrectcounsdecis();
            f19.Show();
            this.Close();
        }

        private void μΟΔΙΠToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mmodip f20 = new Mmodip();
            f20.Show();
            this.Close();
        }

        private void γραμματείεςΤμημάτωνΣχολώνΠανεπιστημίουToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mgtsp f21 = new Mgtsp();
            f21.Show();
            this.Close();
        }

        private void ανεξάρτηταΤμήματαΑυτοτελέςΓραφείοΚαιΛοιπέςΥπηρεσίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mindep f22 = new Mindep();
            f22.Show();
            this.Close();
        }

        private void διευθύνσειςΠανεπιστημίουToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Munivaddr f23 = new Munivaddr();
            f23.Show();
            this.Close();
        }

        private void τμήμαΟικονομικήςΕπιστήμηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doik f24 = new Doik();
            f24.Show();
            this.Close();
        }

        private void τμήμαΟργάνωσηςΔιοίκησηςΕπιχειρήσεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dode f25 = new Dode();
            f25.Show();
            this.Close();
        }

        private void τμήμαΔιεθνώνΕυρωπαϊκώνΣπουδώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ddes f26 = new Ddes();
            f26.Show();
            this.Close();
        }

        private void τμήμαΤουριστικώνΣπουδώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dtour f27 = new Dtour();
            f27.Show();
            this.Close();
        }

        private void τμήμαΝαυτιλιακώνΣπουδώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dnaut f28 = new Dnaut();
            f28.Show();
            this.Close();
        }

        private void tμήμαΒιομηχανικήςΔιοίκησηςTεχνολογίαςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dbio f29 = new Dbio();
            f29.Show();
            this.Close();
        }

        private void τμήμαΧρηματοοικονομικήςΚαιΤραπεζικήςΔιοικητικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dxrh f30 = new Dxrh();
            f30.Show();
            this.Close();
        }

        private void τμήμαΣτατιστικήςΑσφαλιστικήςΕπιστήμηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dsta f31 = new Dsta();
            f31.Show();
            this.Close();
        }

        private void τμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dplh f31 = new Dplh();
            f31.Show();
            this.Close();
        }

        private void τμήμαΨηφιακώνΣυστημάτωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dpsfs f32 = new Dpsfs();
            f32.Show();
            this.Close();
        }

        private void ερευνητικόΈργοΕΛΚΕToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relke f34 = new Relke();
            f34.Show();
            this.Close();
        }

        private void εργαστήριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rlabs f35 = new Rlabs();
            f35.Show();
            this.Close();
        }

        private void διδακτορικέςΣπουδέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rdoc f36 = new Rdoc();
            f36.Show();
            this.Close();
        }

        private void μεταδιδακτορικήΈρευναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rafterdoc f37 = new Rafterdoc();
            f37.Show();
            this.Close();
        }

        private void φοιτητικήΜέριμναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudWelfare f37 = new StudWelfare();
            f37.Show();
            this.Close();
        }

        private void βιβλιοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library f38 = new Library();
            f38.Show();
            this.Close();
        }

        private void ευρωπαϊκάΠρογράμματαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Europeanprog f39 = new Europeanprog();
            f39.Show();
            this.Close();
        }

        private void γραφείοΔιασύνδεσηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrerOffice f40 = new CarrerOffice();
            f40.Show();
            this.Close();
        }

        private void ιατρείοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispensary f41 = new Dispensary();
            f41.Show();
            this.Close();
        }

        private void συμβουλευτικόΚέντροToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounselingCenter f42 = new CounselingCenter();
            f42.Show();
            this.Close();
        }

        private void βραβείαΥποτροφίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scholarships f43 = new Scholarships();
            f43.Show();
            this.Close();
        }

        private void διδασκαλίαΞένωνΓλωσσώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Foreignlang f44 = new Foreignlang();
            f44.Show();
            this.Close();
        }

        private void γενικέςΠληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generalinfo f45 = new Generalinfo();
            f45.Show();
            this.Close();
        }

        private void uRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uregister f46 = new Uregister();
            f46.Show();
            this.Close();
        }

        private void myPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypassword f47 = new Mypassword();
            f47.Show();
            this.Close();
        }

        private void eΓραμματείαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Esecretar f47 = new Esecretar();
            f47.Show();
            this.Close();
        }

        private void ηλεκτρονικήΕξΑποστάσεωςΕκπαίδευσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            e_Learning f49 = new e_Learning();
            f49.Show();
            this.Close();
        }

        private void υπηρεσίαΥποστήριξηςΧρηστώνHelpdeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpdesk f50 = new Helpdesk();
            f50.Show();
            this.Close();
        }

        private void ηλεκτρονικόΤαχυδρομείοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email f51 = new Email();
            f51.Show();
            this.Close();
        }

        private void διάθεσηΛογισμικούΓιαΕκπαιδευτικήΧρήσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Software f511 = new Software();
            f511.Show();
            this.Close();
        }

        private void wiFiΚαιEduroamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wifieduroam f512 = new Wifieduroam();
            f512.Show();
            this.Close();
        }

        private void σύνδεσηΣτοΔίκτυοΤουΠανεπιστημίουVPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPN f513 = new VPN();
            f513.Show();
            this.Close();
        }

        private void υπηρεσίεςΤηλεδιάσκεψηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videoconferserv f52 = new Videoconferserv();
            f52.Show();
            this.Close();
        }

        private void εκδοσηΠιστοποιητικώνΤαυτότηταςΧρηστήΚαιΔιακομιστήServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuanceCertif f53 = new IssuanceCertif();
            f53.Show();
            this.Close();
        }

        private void υπηρεσίεςΕΔΥΤΕΥπουργείουΥπουργείοΨηφιακήςΔιακυβέρνησηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edyteserv f54 = new Edyteserv();
            f54.Show();
            this.Close();
        }

        private void πολιτιστικέςΟμάδεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Culturgroups f55 = new Culturgroups();
            f55.Show();
            this.Close();
        }

        private void φοιτητικοίΣύλλογοιToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studassociat f56 = new Studassociat();
            f56.Show();
            this.Close();
        }

        private void φοιτητικέςΠαρατάξειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studgroups f57 = new Studgroups();
            f57.Show();
            this.Close();
        }

        private void άλλεςΔραστηριότητεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otheractivit f58 = new Otheractivit();
            f58.Show();
            this.Close();
        }
        private void επιστημονικήΈνωσηΑποφοίτωνΤουΠανεπιστημίουΠειραιώςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlumniAssoc f59 = new AlumniAssoc();
            f59.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Contact f16 = new Contact();
            f16.Show();
            this.Close();
        }

        private void προπτυχιακέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undergrad f60 = new Undergrad();
            f60.Show();
            this.Close();
        }

        private void μεταπτυχιακέςΣπουδέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postgrad f61 = new Postgrad();
            f61.Show();
            this.Close();
        }

        private void κέντροΕπιμόρφωσηςΚαιΔιαΒιουΜάθησηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lifelonglearn f62 = new Lifelonglearn();
            f62.Show();
            this.Close();
        }

        private void ανακοινώσειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Announcements f63 = new Announcements();
            f63.Show();
            this.Close();
        }

        private void φοιτητικάΘέματαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudAffairs f64 = new StudAffairs();
            f64.Show();
            this.Close();
        }

        private void ημερολόγιοΕκδηλώσειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar f65 = new Calendar();
            f65.Show();
            this.Close();
        }
    }
}
