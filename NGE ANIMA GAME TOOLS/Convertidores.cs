using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class convertidores : Form
    {
        private int mov;
        private int movX;
        private int movY;

        public convertidores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void DESEMPAQUETAR_MouseLeave(object sender, EventArgs e)
        {
            tx3_txt.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void DESEMPAQUETAR_MouseEnter(object sender, EventArgs e)
        {
            tx3_txt.ForeColor = Color.FromArgb(0, 0, 0);
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void tx3_txt_Click(object sender, EventArgs e)
        {
            if (tx3file.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe.lnk", tx3file.SafeFileName);
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + tx3file.SafeFileName))
                {
                    MessageBox.Show("Operacion Exitosa");
                    return;
                }
                MessageBox.Show("Operacion Fallida");
                return;
            }

            MessageBox.Show("Seleccione un archivo valido");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfile.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe.lnk", txtfile.SafeFileName);
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + txtfile.SafeFileName))
                {
                    MessageBox.Show("Operacion Exitosa");
                    return;
                }
                MessageBox.Show("Operacion Fallida");
                return;
            }

            MessageBox.Show("Seleccione un archivo valido");
            return;
        }

        private void bp3_bmp_Click(object sender, EventArgs e)
        {
            if (bp3file.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk", bp3file.SafeFileName);
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + bp3file.SafeFileName))
                {
                    MessageBox.Show("Operacion Exitosa");
                    return;
                }
                MessageBox.Show("Operacion Fallida");
                return;
            }

            MessageBox.Show("Seleccione un archivo valido");
            return;
        }

        private void bmp_bp3_Click(object sender, EventArgs e)
        {
            if (bmpfile.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk", bmpfile.SafeFileName);
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + bmpfile.SafeFileName))
                {
                    MessageBox.Show("Operacion Exitosa");
                    return;
                }
                MessageBox.Show("Operacion Fallida");
                return;
            }

            MessageBox.Show("Seleccione un archivo valido");
            return;
        }

        private void bp3_bmp_MouseEnter(object sender, EventArgs e)
        {
            bp3_bmp.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void bp3_bmp_MouseLeave(object sender, EventArgs e)
        {
            bp3_bmp.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void bmp_bp3_MouseEnter(object sender, EventArgs e)
        {
            bmp_bp3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void bmp_bp3_MouseLeave(object sender, EventArgs e)
        {
            bmp_bp3.ForeColor = Color.FromArgb(255, 255, 255);
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