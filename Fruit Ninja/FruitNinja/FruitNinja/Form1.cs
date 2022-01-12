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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm =new Form2();
        Form3 frm2 = new Form3();
        Form4 frm3 = new Form4();
        Form6 frm6 = new Form6();
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
                 
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Game-start.wav";
            player.Play();

            this.Hide();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Game-start.wav";
            player.Play();

            this.Hide();
            frm3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Game-start.wav";
            player.Play();

            this.Hide();
            frm6.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
