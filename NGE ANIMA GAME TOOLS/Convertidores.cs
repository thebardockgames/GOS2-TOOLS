using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class convertidores : Form
    {
        private int mov;
        private int movX;
        private int movY;

        public int id_process_bmp { get; set; }


        public string mainfolder
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(0).Take(1).First(); ;
            }
        }

        public string rungame_exe
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(1).Take(1).First(); ;
            }
        }

        public string goslb5un1
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(2).Take(1).First(); ;
            }
        }

        public string goslbpk1
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(3).Take(1).First(); ;
            }
        }

        public string gosbp3un1
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(4).Take(1).First(); ;
            }
        }

        public string gosbp3pk1
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(5).Take(1).First(); ;
            }
        }
        public string gostx31
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(6).Take(1).First(); ;
            }
        }

        public string realesrgan
        {
            get
            {
                return File.ReadLines(Environment.ExpandEnvironmentVariables(@"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini")).Skip(7).Take(1).First(); ;
            }
        }

        public bool IsProcessOpen(int ide)
        {

            foreach (Process clsProcess in Process.GetProcesses())
            {

                if (clsProcess.Id == ide)
                {

                    return true;
                }
            }
            return false;
        }

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
            tx3file.InitialDirectory = mainfolder + @"exec\";

            if (tx3file.ShowDialog() == DialogResult.OK)
            {
                string filename = tx3file.SafeFileName;

                var p = new Process();
                p.StartInfo.FileName = gostx31;
                p.StartInfo.WorkingDirectory = mainfolder + @"exec\";
                p.StartInfo.Arguments = tx3file.SafeFileName;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Convertir " + filename + " a TXT?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {
                            if (IsProcessOpen(procId) == false)
                            {
                                MessageBox.Show(filename + " Convertido a TXT con exito");
                                break;
                            }
                        }
                    }
                    return;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Seleccione un archivo valido");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtfile.InitialDirectory = mainfolder + @"exec\";

            if (txtfile.ShowDialog() == DialogResult.OK)
            {
                string filename = txtfile.SafeFileName;

                var p = new Process();
                p.StartInfo.FileName = gostx31;
                p.StartInfo.WorkingDirectory = mainfolder + @"exec\";
                p.StartInfo.Arguments = txtfile.SafeFileName;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Convertir " + filename + " a TX3?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {
                            if (IsProcessOpen(procId) == false)
                            {
                                MessageBox.Show(filename + " Convertido a TX3 con exito");
                                break;
                            }
                        }
                    }
                    return;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bp3_bmp_Click(object sender, EventArgs e)
        {
            bp3file.InitialDirectory = mainfolder;

            if (bp3file.ShowDialog() == DialogResult.OK)
            {
                string filename = bp3file.SafeFileName;

                var p = new Process();
                p.StartInfo.FileName = gosbp3un1;
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(bp3file.FileName);
                p.StartInfo.Arguments = bp3file.SafeFileName;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Convertir " + filename + " a BMP?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {
                            if (IsProcessOpen(procId) == false)
                            {
                                MessageBox.Show(filename + " Convertido a BMP con exito");
                                break;
                            }
                        }
                    }
                    return;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bmp_bp3_Click(object sender, EventArgs e)
        {
            bmpfile.InitialDirectory = mainfolder;

            if (bmpfile.ShowDialog() == DialogResult.OK)
            {
                string filename = bmpfile.SafeFileName;

                var p = new Process();
                p.StartInfo.FileName = gosbp3pk1;
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(bmpfile.FileName);
                p.StartInfo.Arguments = bmpfile.SafeFileName;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Convertir " + filename + " a BP3?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {
                            if (IsProcessOpen(procId) == false)
                            {
                                MessageBox.Show(filename + " Convertido a BP3 con exito");
                                break;
                            }
                        }
                    }
                    return;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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