using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class Empaquetadores : Form
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

                try
                {
                    Process.Start(Properties.Settings.Default.goslb5pk1, "gosflst.txt exec"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk"
                    System.Threading.Thread.Sleep(1500);
                    DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Desea iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(Properties.Settings.Default.run_game_exe); // default @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk"
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ocurrio una excepción");

                        }
                    }
                    else if (dialogResult1 == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message , "Error de ficheros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void empimagenes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas compilar las imagenes?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Process.Start(Properties.Settings.Default.goslb5pk1, "gosflst1.txt event"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk"
                    System.Threading.Thread.Sleep(1500);
                    DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso\n ¿Desea iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        Process.Start(Properties.Settings.Default.run_game_exe);
                        return;
                    }
                    else if (dialogResult1 == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error de ficheros ", MessageBoxButtons.OK,MessageBoxIcon.Error); // ex almacena el error obtenido del sistema
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

        public void empaquetar(string gosflst, string filename)
        {
            var p = new Process();
            var g = new Process();

            string path = mainfolder + filename + @"\";

            string o_idx = mainfolder + filename + ".idx";
            string r_idx = path + filename + ".idx";

            string o_lb5 = mainfolder + filename + ".lb5";
            string r_lb5 = path + filename + ".lb5";

            g.StartInfo.WorkingDirectory = mainfolder + @"\exe\";
            g.StartInfo.UseShellExecute = true;
            g.StartInfo.Verb = "runas";
            g.StartInfo.FileName = rungame_exe;


            //p.StartInfo.WorkingDirectory = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
            p.StartInfo.FileName = goslbpk1;
            p.StartInfo.Arguments = gosflst + " " + filename;

            p.Start();
            var procid = p.Id;

            while (true)
            {
                if (IsProcessOpen(procid) == false)
                {
                    File.Delete(o_idx);
                    File.Delete(o_lb5);
                    File.Move(r_idx, o_idx);
                    File.Move(r_lb5, o_lb5);

                    DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Quieres iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        g.Start();
                        break;
                    }
                    else if (dialogResult1 == DialogResult.No)
                    {
                        break;
                    }
                    break;
                }
            }
        }
    }
}