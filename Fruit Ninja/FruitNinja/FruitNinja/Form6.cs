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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Domates.Start();
            Bombaçıkış.Start();
            Bomba10.Start();
        }
        private void Domates_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += -3;
            if (pictureBox1.Bounds.IntersectsWith(button1.Bounds))
            {
                label1.Text = "Bitti";
                if (label1.Text=="Bitti")
                {
                    Domates.Stop();
                    pictureBox2.Visible = true;
                    Parmak.Start();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Parmak_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += +3;
            pictureBox2.Top += +3;
            if (pictureBox2.Bounds.IntersectsWith(button3.Bounds))
            {
                Parmak.Stop();
                Domatesdüşüş.Start();
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
            }
          
        }

        private void Domatesdüşüş_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += +3;
            if (pictureBox3.Bounds.IntersectsWith(button4.Bounds))
            {
                Domatesdüşüş.Stop();
            }
        }

        private void Bomba_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left += +3;
            pictureBox5.Top += +3;
            if (pictureBox5.Bounds.IntersectsWith(button5.Bounds))
            {
                label2.Visible = true;
                Bomba.Stop();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bombaçıkış.Start();
        }

        private void Bombaçıkış_Tick(object sender, EventArgs e)
        {
            pictureBox4.Top += -3;
            if (pictureBox4.Bounds.IntersectsWith(button7.Bounds))
            {
                pictureBox5.Visible = true;
                Bombaçıkış.Stop();
                Bomba.Start();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Bomba10_Tick(object sender, EventArgs e)
        {
            pictureBox7.Top += -3;
            if (pictureBox7.Bounds.IntersectsWith(button10.Bounds))
            {
                Bomba10.Stop();
                pictureBox6.Visible = true;
                Bomba10parmak.Start();
            }
        }
        private void Bomba10parmak_Tick(object sender, EventArgs e)
        {
            pictureBox6.Left += +3;
            pictureBox6.Top += +3;
            if (pictureBox6.Bounds.IntersectsWith(button9.Bounds))
            {
                Bomba10parmak.Stop();
                label3.Visible = true;
                label4.Visible = true;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Bomba10.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Next-screen-button.wav";
            player.Play();

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
