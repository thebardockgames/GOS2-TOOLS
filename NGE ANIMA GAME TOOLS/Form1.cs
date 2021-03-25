using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class home : Form
    {
        private int mov;
        private int movX;
        private int movY;

        public home()
        {
            InitializeComponent();
            initalized = true;
            client = new DiscordRpcClient("822813361040785458");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"Menu",
                State = "By: THEBARDOCKGAMES",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"eva_-white",
                    LargeImageText = "GOS2 TOOLS",
                    SmallImageKey = ""
                }
            });
        }

        private void listBoxImages1(object sender, EventArgs e)
        {

        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            client.UpdateDetails("Visualizador BMP´S");
            abrirformhija(new bmpviewer());
            client.UpdateDetails("Visualizador BMP´S");
        }


        public DiscordRpcClient client;
        private bool initalized = false;

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void abrirformhija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
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
            DESEMPAQUETAR.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void DESEMPAQUETAR_MouseEnter(object sender, EventArgs e)
        {
            DESEMPAQUETAR.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.UpdateDetails("Compilando");
            abrirformhija(new Empaquetadores());
            client.UpdateDetails("Compilando");
        }

        private void DESEMPAQUETAR_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5un1.exe.lnk", openFileDialog1.SafeFileName);
                System.Threading.Thread.Sleep(2000);
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\t1101.tx3"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            client.UpdateDetails("Convirtiendo archivos");
            abrirformhija(new convertidores());
            client.UpdateDetails("Convirtiendo archivos");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            client.UpdateDetails("Editando dialogos");
            abrirformhija(new Dialogos());
            client.UpdateDetails("Editando dialogos");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/TheBardockGames");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.eva_black;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.eva__white;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            empaquetadores.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            empaquetadores.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void convertidores_MouseEnter(object sender, EventArgs e)
        {
            convertidores.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void convertidores_MouseLeave(object sender, EventArgs e)
        {
            convertidores.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.pngfind_com_fail_png_1761191;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.cruz_white;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            client.Deinitialize();
            Application.Exit();
        }



        public void home_Activated(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.minimize_icon_black;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.minimize_icon1;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(255, 255, 255);
        }


    }
}