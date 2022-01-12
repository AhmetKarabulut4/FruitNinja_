using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FruitNinja
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int geri = 30;
        Form3 frm2 = new Form3();
        int basla = 4;
        Form7 frm8 = new Form7();

        private void Form4_Load(object sender, EventArgs e)
        {
            cilek.Visible = false;
            nar.Visible = false;
            domates.Visible = false;
            bomba.Visible = false;
            ZamanLabel.Visible = false;
            basLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            baslangıc.Enabled = true;

            baslangıc.Enabled = true;
            basLabel.Visible = true;
            cilek.Visible = false;
            nar.Visible = false;
            domates.Visible = false;
            bomba.Visible = false;

            ZamanLabel.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;


        }

        private void cilek1_Tick(object sender, EventArgs e)
        {
            cilek.Enabled = true;
            cilek.Image = Image.FromFile("cilek.png");

            cilek2.Enabled = true;
            cilek1.Enabled = true;
            Random rnd = new Random();
            int rastgele = rnd.Next(50, 750);
            cilek.Left = rastgele;
        }

        private void cilek2_Tick(object sender, EventArgs e)
        {
            cilek.Enabled = true;
            cilek.Image = Image.FromFile("cilek.png");

            cilek.Visible = true;
            cilek.Top = cilek.Top - 10;
            if (cilek.Top <= 200)
            {
                cilek.Image = Image.FromFile("cilek.png");

                cilek3.Enabled = true;
                cilek2.Enabled = false;
                cilek.Visible = false;
            }
        }

        private void cilek3_Tick(object sender, EventArgs e)
        {
            cilek.Visible = true;
            cilek1.Enabled = false;
            cilek2.Enabled = false;
            cilek.Top = cilek.Top + 10;
            if (cilek.Top == 446)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(50, 750);
                cilek.Left = rastgele;
                cilek1.Enabled = true;
                cilek2.Enabled = true;
                cilek3.Enabled = false;
            }
        }

        private void cilek_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"bamboo-swipe-1.wav";
            player.Play();
            cilek.Image = Image.FromFile("cilekv1.png");

            cilek.Visible = false;
            cilek3.Enabled = true;
            cilek1.Enabled = false;
            cilek2.Enabled = false;

            cilek.Enabled = false;
        }

        private void nar1_Tick(object sender, EventArgs e)
        {
            nar.Enabled = true;
            nar.Image = Image.FromFile("nar.png");

            nar2.Enabled = true;
            nar1.Enabled = true;
            Random rnd = new Random();
            int rastgele = rnd.Next(50, 750);
            nar.Left = rastgele;
        }

        private void nar2_Tick(object sender, EventArgs e)
        {
            nar.Enabled = true;
            nar.Image = Image.FromFile("nar.png");

            nar.Visible = true;
            nar.Top = nar.Top - 10;
            if (nar.Top <= 200)
            {
                nar.Image = Image.FromFile("nar.png");

                nar3.Enabled = true;
                nar2.Enabled = false;
                nar.Visible = false;

            }
        }

        private void nar3_Tick(object sender, EventArgs e)
        {
            nar.Visible = true;
            nar1.Enabled = false;
            nar2.Enabled = false;
            nar.Top = nar.Top + 10;
            if (nar.Top == 446)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(50, 750);
                nar.Left = rastgele;
                nar1.Enabled = true;
                nar2.Enabled = true;
                nar3.Enabled = false;
            }
        }

        private void nar_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"bamboo-swipe-1.wav";
            player.Play();

            nar.Image = Image.FromFile("narv1.png");

            nar.Visible = false;
            nar3.Enabled = true;
            nar1.Enabled = false;
            nar2.Enabled = false;

            nar.Enabled = false;
        }

        private void domates1_Tick(object sender, EventArgs e)
        {
            domates.Enabled = true;
            domates.Image = Image.FromFile("domates.png");

            domates2.Enabled = true;
            domates1.Enabled = true;
            Random rnd = new Random();
            int rastgele = rnd.Next(50, 750);
            domates.Left = rastgele;
        }

        private void domates2_Tick(object sender, EventArgs e)
        {
            domates.Enabled = true;
            domates.Image = Image.FromFile("domates.png");

            domates.Visible = true;
            domates.Top = domates.Top - 10;
            if (domates.Top <= 200)
            {
                domates3.Enabled = true;
                domates2.Enabled = false;
                domates.Visible = false;
            }
        }

        private void domates3_Tick(object sender, EventArgs e)
        {
            domates.Visible = true;
            domates1.Enabled = false;
            domates2.Enabled = false;
            domates.Top = domates.Top + 10;
            if (domates.Top == 446)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(50, 750);
                domates.Left = rastgele;
                domates1.Enabled = true;
                domates2.Enabled = true;
                domates3.Enabled = false;
            }
        }

        private void domates_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"bamboo-swipe-1.wav";
            player.Play();

            domates.Image = Image.FromFile("domatesv1.png");

            domates.Visible = false;
            domates3.Enabled = true;
            domates1.Enabled = false;
            domates2.Enabled = false;

            domates.Enabled = false;
        }

        private void bomba1_Tick(object sender, EventArgs e)
        {
            bomba2.Enabled = true;
            bomba1.Enabled = true;
            Random rnd = new Random();
            int rastgele = rnd.Next(50, 750);
            bomba.Left = rastgele;
        }

        private void bomba2_Tick(object sender, EventArgs e)
        {
            bomba.Visible = true;
            bomba.Top = bomba.Top - 10;
            if (bomba.Top <= 200)
            {
                bomba3.Enabled = true;
                bomba2.Enabled = false;
                bomba.Visible = false;
            }
        }

        private void bomba3_Tick(object sender, EventArgs e)
        {
            bomba.Visible = true;
            bomba1.Enabled = false;
            bomba2.Enabled = false;
            bomba.Top = bomba.Top + 10;
            if (bomba.Top == 446)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(50, 750);
                bomba.Left = rastgele;
                bomba1.Enabled = true;
                bomba2.Enabled = true;
                bomba3.Enabled = false;
            }
        }

        private void bomba_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"menu-bomb.wav";
            player.Play();


            bomba.Visible = false;
            if (bomba.Visible == false)
            {
                nar1.Enabled = false;
                nar2.Enabled = false;
                nar3.Enabled = false;

                cilek1.Enabled = false;
                cilek2.Enabled = false;
                cilek3.Enabled = false;

                domates1.Enabled = false;
                domates2.Enabled = false;
                domates3.Enabled = false;

                bomba1.Enabled = false;
                bomba2.Enabled = false;
                bomba3.Enabled = false;

                gerisayım.Enabled = false;

                /*        gerisayim.Enabled = false;
                        //   MessageBox.Show("BOMBA PATLADI OYUN BİTTİ PUANINIZ " + puan);
                        PuanLabel.Text = "0";
                        geri = 0;
                        ZamanLabel.Text = "0"; */

                this.Hide();
                frm8.Show();
            }
        }

        private void gerisayım_Tick(object sender, EventArgs e)
        {
            geri--;
            if (geri == 0)
            {
                nar1.Enabled = false;
                nar2.Enabled = false;
                nar3.Enabled = false;

                cilek1.Enabled = false;
                cilek2.Enabled = false;
                cilek3.Enabled = false;

                domates1.Enabled = false;
                domates2.Enabled = false;
                domates3.Enabled = false;

                bomba1.Enabled = false;
                bomba2.Enabled = false;
                bomba3.Enabled = false;

                gerisayım.Enabled = false;
                geri = 0;
                ZamanLabel.Text = "0";

                this.Hide();
                frm8.Show();
            }
            ZamanLabel.Text = Convert.ToString(geri);
        }

        private void baslangıc_Tick(object sender, EventArgs e)
        {
            basla--;
            if (basla == 0)
            {
                baslangıc.Enabled = true;
                gerisayım.Enabled = true;

                cilek.Visible = true;
                nar.Visible = true;
                domates.Visible = true;
                bomba.Visible = true;     

                ZamanLabel.Visible = true;

                cilek1.Enabled = true;
                cilek2.Enabled = true;
                Random rnd = new Random();
                int rastgele = rnd.Next(50, 750);
                cilek.Left = rastgele;

                nar1.Enabled = true;
                nar2.Enabled = true;
                Random rnd2 = new Random();
                int rastgele2 = rnd.Next(50, 750);
                nar.Left = rastgele2;

                domates1.Enabled = true;
                domates2.Enabled = true;
                Random rnd3 = new Random();
                int rastgele3 = rnd.Next(50, 750);
                domates.Left = rastgele3;

                bomba1.Enabled = true;
                bomba2.Enabled = true;
                Random rnd4 = new Random();
                int rastgele4 = rnd.Next(50, 750);
                bomba.Left = rastgele4;

                baslangıc.Enabled = false;
                basLabel.Visible = false;
            }
            basLabel.Text = Convert.ToString(basla);
        }
     
    }
}
