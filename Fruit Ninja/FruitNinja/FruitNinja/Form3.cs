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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int puan { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Form2.puan);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Game-over.wav";
            player.Play();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"Next-screen-button.wav";
            player.Play();

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
