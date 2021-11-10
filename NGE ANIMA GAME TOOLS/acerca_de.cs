using System;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class acerca_de : Form
    {
        public acerca_de()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thebardockgames/GOS2-TOOLS");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/NGEAnima");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/TheBardockGames");
           
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form h = new home();
            h.Show();
            this.Close();
        }
    }
}
