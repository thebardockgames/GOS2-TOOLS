using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class Empaquetadores : Form
    {
        private int mov;
        private int movX;
        private int movY;

        public Empaquetadores()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            home f1 = new home();
            f1.Width = this.Width;
            f1.Height = this.Height;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void textcomp_MouseEnter(object sender, EventArgs e)
        {
            textcomp.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void textcomp_MouseLeave(object sender, EventArgs e)
        {
            textcomp.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void empimagenes_MouseEnter(object sender, EventArgs e)
        {
            empimagenes.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void empimagenes_MouseLeave(object sender, EventArgs e)
        {
            empimagenes.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void textcomp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas compilar el texto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk", "gosflst.txt exec");
                System.Threading.Thread.Sleep(1500);
                DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Desea iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk");
                    return;
                }
                else if (dialogResult1 == DialogResult.No)
                {
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void empimagenes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas compilar las imagenes?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk", "gosflst1.txt event");
                System.Threading.Thread.Sleep(1500);
                DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Desea iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk");
                    return;
                }
                else if (dialogResult1 == DialogResult.No)
                {
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/TheBardockGames");
        }
    }
}