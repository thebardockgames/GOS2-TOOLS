using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using System.Linq;
using SharpCompress;
using System.Net;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives;
using SharpCompress.Common;

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
            string path_ftr;
            path_ftr = @"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Firs_time_run.ini";
            path_ftr = Environment.ExpandEnvironmentVariables(path_ftr);

            string path_appdata;
            path_appdata = @"%localappdata%\NGE_ANIMA";
            path_appdata = Environment.ExpandEnvironmentVariables(path_appdata);

            var p = new Process();

            if (File.Exists(path_ftr))
            {
                string path;
                path = @"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini";
                path = Environment.ExpandEnvironmentVariables(path);

                if (File.Exists(path))
                {
                    string mainfolder = File.ReadLines(path).Skip(0).Take(1).First();
                    string run_game_exe = File.ReadLines(path).Skip(1).Take(1).First();
                    string goslb5un1 = File.ReadLines(path).Skip(2).Take(1).First();
                    string goslb5pk1 = File.ReadLines(path).Skip(3).Take(1).First();
                    string gosbp3un1 = File.ReadLines(path).Skip(4).Take(1).First();
                    string gosbp3pk1 = File.ReadLines(path).Skip(5).Take(1).First();
                    string gostx31 = File.ReadLines(path).Skip(6).Take(1).First();
                    string realesrgan = File.ReadLines(path).Skip(7).Take(1).First();

                }
            }
            else
            {
                if (Directory.Exists(path_appdata))
                {

                }
                else
                {
                    Directory.CreateDirectory(path_appdata);
                    Directory.CreateDirectory(path_appdata + @"\GOS2-TOOLS");
                }

                Folder_browser.Description = "Seleccione la carpeta principal del juego (IRONMAIDEN2)";

                if (Folder_browser.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(Folder_browser.SelectedPath.ToString() + @"\" + @"exe\test03.exe"))
                    {
                        string path_game = Folder_browser.SelectedPath.ToString();
                        using(var client = new WebClient())
                        {
                            client.DownloadFile(new Uri("http://madman.i-delta.net.ru/bin/gosse.rar"), path_game + @"\gosse.rar");
                            client.DownloadFile(new Uri("https://dl.dropboxusercontent.com/s/ko69qdbx0vkapw6/exe.rar"), path_game + @"\exe\exe.rar");
                        }
                        using(var archive = RarArchive.Open(path_game + @"\gosse.rar"))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(path_game + @"\", new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }

                        using (var archive = RarArchive.Open(path_game + @"\exe\exe.rar"))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(path_game + @"\exe\", new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }

                        File.Delete(path_game + @"\" + "gostx2.exe");
                        File.Delete(path_game + @"\" + "gosmpiun.exe");
                        //File.Create(path_ftr);

                        Directory.CreateDirectory(path_game + @"\exec");
                        Directory.CreateDirectory(path_game + @"\event");
                        Directory.CreateDirectory(path_game + @"\face");
                        Directory.CreateDirectory(path_game + @"\imgfrm");

                        p.StartInfo.FileName = path_game + @"\goslb5un.exe";
                        p.StartInfo.Arguments = "exec.idx";
                        p.StartInfo.WorkingDirectory = path_game + @"\";
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] tx3files = Directory.GetFiles(path_game, "*.tx3");
                                foreach (var item in tx3files)
                                {
                                    File.Move(item, path_game + @"\exec\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"\gosflst.txt", path_game + @"\exec\gosflst-texto.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "event.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"\event\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"\gosflst.txt", path_game + @"\event\gosflst-event.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "imgfrm.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"\imgfrm\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"\gosflst.txt", path_game + @"\imgfrm\gosflst-img.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "FACE.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"\face\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"\gosflst.txt", path_game + @"\face\gosflst-face.txt");
                                break;
                            }
                        }

                        File.Delete(path_game + @"\gosse.rar");
                        File.Delete(path_game + @"\exe\exe.rar");
                        File.Delete(path_game + @"\readme.txt");

                        string path;
                        path = @"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini";
                        path = Environment.ExpandEnvironmentVariables(path);

                        string[] Configuraciones = new string[8];

                        Configuraciones[0] = path_game + @"\";
                        Configuraciones[1] = path_game + @"\exe\00test03-latin.exe";
                        Configuraciones[2] = path_game + @"\goslb5un.exe";
                        Configuraciones[3] = path_game + @"\goslb5pk.exe";
                        Configuraciones[4] = path_game + @"\gosbp3un.exe";
                        Configuraciones[5] = path_game + @"\gosbp3pk.exe";
                        Configuraciones[6] = path_game + @"\gostx3.exe";
                        Configuraciones[7] = "Nothing";

                        File.WriteAllLines(path, Configuraciones);
                        File.Create(path_ftr);

                    }

                    if (File.Exists(Folder_browser.SelectedPath.ToString() + @"\" + @"IRONMAIDEN2\exe\test03.exe"))
                    {
                        string path_game = Folder_browser.SelectedPath + @"\" + @"IRONMAIDEN2\";
                        using (var client = new WebClient())
                        {
                            client.DownloadFile(new Uri("http://madman.i-delta.net.ru/bin/gosse.rar"), path_game + @"gosse.rar");
                            client.DownloadFile(new Uri("https://dl.dropboxusercontent.com/s/ko69qdbx0vkapw6/exe.rar"), path_game + @"exe\exe.rar");
                        }
                        using (var archive = RarArchive.Open(path_game + @"gosse.rar"))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(path_game, new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }

                        using (var archive = RarArchive.Open(path_game + @"exe\exe.rar"))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(path_game + @"exe\", new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }

                        File.Delete(path_game + "gostx2.exe");
                        File.Delete(path_game + "gosmpiun.exe");

                        Directory.CreateDirectory(path_game + @"exec");
                        Directory.CreateDirectory(path_game + @"event");
                        Directory.CreateDirectory(path_game + @"face");
                        Directory.CreateDirectory(path_game + @"imgfrm");

                        p.StartInfo.FileName = path_game + @"goslb5un.exe";
                        p.StartInfo.Arguments = "exec.idx";
                        p.StartInfo.WorkingDirectory = path_game;
                        p.Start();

                        var procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] tx3files = Directory.GetFiles(path_game, "*.tx3");
                                foreach (var item in tx3files)
                                {
                                    File.Move(item, path_game + @"exec\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"gosflst.txt", path_game + @"exec\gosflst-texto.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "event.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"event\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"gosflst.txt", path_game + @"event\gosflst-event.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "imgfrm.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"imgfrm\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"gosflst.txt", path_game + @"imgfrm\gosflst-img.txt");
                                break;
                            }
                        }

                        p.StartInfo.Arguments = "FACE.idx";
                        p.Start();
                        procId = p.Id;

                        while (true)
                        {

                            if (IsProcessOpen(procId) == false)
                            {
                                string[] bp3files = Directory.GetFiles(path_game, "*.bp3");
                                foreach (var item in bp3files)
                                {
                                    File.Move(item, path_game + @"face\" + Path.GetFileName(item));
                                }
                                File.Move(path_game + @"gosflst.txt", path_game + @"face\gosflst-face.txt");
                                break;
                            }
                        }

                        File.Delete(path_game + @"gosse.rar");
                        File.Delete(path_game + @"exe\exe.rar");
                        File.Delete(path_game + @"readme.txt");

                        string path;
                        path = @"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini";
                        path = Environment.ExpandEnvironmentVariables(path);

                        

                        string[] Configuraciones = new string[8];

                        Configuraciones[0] = path_game;
                        Configuraciones[1] = path_game + @"exe\00test03-latin.exe";
                        Configuraciones[2] = path_game + @"goslb5un.exe";
                        Configuraciones[3] = path_game + @"goslb5pk.exe";
                        Configuraciones[4] = path_game + @"gosbp3un.exe";
                        Configuraciones[5] = path_game + @"gosbp3pk.exe";
                        Configuraciones[6] = path_game + @"gostx3.exe";
                        Configuraciones[7] = "Nothing";

                        File.WriteAllLines(path, Configuraciones);
                        File.Create(path_ftr);

                    }




                }
                else
                {
                    MessageBox.Show("Se debe seleccionar una carpeta valida");
                    return;
                }
            }

            

            
            

        }

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


        public bool IsAdmin
        {
            get 
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal principal = new WindowsPrincipal(identity);

                    return IsAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                    
                }
            }
            set
            {

            }
        }

        public void AdminRights()
        {

            
        }


        private void listBoxImages1(object sender, EventArgs e)
        {
            
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            if(IsAdmin)
            {
                client.UpdateDetails("Visualizador BMP´S");
                abrirformhija(new bmpviewer());
                client.UpdateDetails("Visualizador BMP´S");
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
            }
        }


        public DiscordRpcClient client;
       

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                client.UpdateDetails("Compilando");
                abrirformhija(new Empaquetadores());
                client.UpdateDetails("Compilando");
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                client.UpdateDetails("Convirtiendo archivos");
                abrirformhija(new convertidores());
                client.UpdateDetails("Convirtiendo archivos");
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
            }       
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                client.UpdateDetails("Editando dialogos");
                abrirformhija(new Dialogos());
                client.UpdateDetails("Editando dialogos");
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
            }          
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

            if (MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                client.Deinitialize();
                Application.Exit();
            }

            
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                Form ac = new acerca_de();
                ac.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                abrirformhija(new settings());
            }
            else
            {
                MessageBox.Show("Ejecute la Herramienta como Administrador");
                client.Deinitialize();
                Application.Exit();
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
    }

}