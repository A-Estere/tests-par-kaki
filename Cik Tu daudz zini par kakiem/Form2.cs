using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cik_Tu_daudz_zini_par_kakiem
{
    public partial class Form2 : Form
    {
        int jautaKopa = 13;
        int pareizaAtbilde;
        int jautaNumurs = 1;
        int punktuSkaits;

        public Form2()
        {
            InitializeComponent();
            JautajumuKopums(jautaNumurs);
        }

        private void ParbauditAtbildesNotikumu(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == pareizaAtbilde)
            {
                punktuSkaits++;
            }

            if (jautaNumurs == jautaKopa)
            {
                MessageBox.Show(
                    "Tests Beidzās!" + Environment.NewLine +
                    "Jūsu Rezultāts: " + punktuSkaits + " / " +jautaKopa + Environment.NewLine +
                    "Spied labi, lai atkal spēlētu. "
                    );
                punktuSkaits = 0;
                jautaNumurs = 0;
                JautajumuKopums(jautaNumurs);
            }

            jautaNumurs++;
            JautajumuKopums(jautaNumurs);
        }

        private void JautajumuKopums(int jautajuma_numuri)
        {
            switch (jautajuma_numuri)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Pukes1;
                    label1.Text = "Neindīgs augs kaķiem?";
                    butt1.Text = "Lilijas";
                    butt2.Text = "Roses";
                    butt3.Text = "Tulpes";

                    pareizaAtbilde = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Krāsās;
                    label1.Text = "Kuru krāsu kaķis vislabāk redz?";
                    butt1.Text = "Zilu";
                    butt2.Text = "Baltu";
                    butt3.Text = "Dzeltanu";

                    pareizaAtbilde = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Clock_;
                    label1.Text = "Cik ilgi kaķi var atstāt vienu mājās?";
                    butt1.Text = "24 stundas";
                    butt2.Text = "12 stundas";
                    butt3.Text = "8 stundas";

                    pareizaAtbilde = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Puķes_;
                    label1.Text = "Indīgs augs kaķiem?";
                    butt1.Text = "Orhidejas";
                    butt2.Text = "Narcises";
                    butt3.Text = "Naudas koks";

                    pareizaAtbilde = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.dusm;
                    label1.Text = "Kad kaķis vicina asti ir?";
                    butt1.Text = "Nokaitināts";
                    butt2.Text = "Laimīgs";
                    butt3.Text = "Greizsirdīgs";

                    pareizaAtbilde = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Veārtrs_;
                    label1.Text = "Cik bieži jāved kaķis pie vetārsta?";
                    butt1.Text = "Ik pēc diviem gadiem";
                    butt2.Text = "Ik pēc trijiem gadiem";
                    butt3.Text = "Reizi gadā";

                    pareizaAtbilde = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Ķemme___1_;
                    label1.Text = "Cik bieži ir jāķemmē īsspalvains kaķis?";
                    butt1.Text = "Reizi nedēļā";
                    butt2.Text = "Katru dienu";
                    butt3.Text = "Divas reizes nedēļā";

                    pareizaAtbilde = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Bļodā_;
                    label1.Text = "Kāda ir veselīgākā barības bļoda kaķim?";
                    butt1.Text = "Plastama";
                    butt2.Text = "Tērauda";
                    butt3.Text = "Keramikas";

                    pareizaAtbilde = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Kaķis_;
                    label1.Text = "Cik ilgi dzīvo kaķis?";
                    butt1.Text = "10 līdz 15 gadus";
                    butt2.Text = "9 līdz 17 gadus";
                    butt3.Text = "8 līdz 16 gadus";

                    pareizaAtbilde = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.Ēd;
                    label1.Text = "Cik daudz kaķis jābaro dienā?";
                    butt1.Text = "3";
                    butt2.Text = "4";
                    butt3.Text = "2";

                    pareizaAtbilde = 3;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.Ausis_;
                    label1.Text = "Kaķa dzirdes diapazons ir?";
                    butt1.Text = "15Hz";
                    butt2.Text = "20Hz";
                    butt3.Text = "30Hz";

                    pareizaAtbilde = 2;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.Guļ__1_;
                    label1.Text = "Cik daudz stundas guļ pieaudzis kaķis?";
                    butt1.Text = "15 stundas";
                    butt2.Text = "9 stundas";
                    butt3.Text = "18 stundas";

                    pareizaAtbilde = 1;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.Box;
                    label1.Text = "Kāpēc kaķi ir apsēsti ar kartona kastēm?";
                    butt1.Text = "Jo smaržo pēc kartona";
                    butt2.Text = "Jo liek kaķiem justies droši";
                    butt3.Text = "Jo izskatās dīvainas";

                    pareizaAtbilde = 2;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
