using DiscordRPC;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class bmpviewer : Form
    {
        public string bp3temp;
        public int filestatus;
        private int mov;
        private int movX;
        private int movY;

        public DiscordRpcClient client;

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
        public bmpviewer()
        {
            try
            {
                InitializeComponent();
                listBoxImages.Items.Clear();
                listbox_filesbase.Items.Clear();
                
                listbox_filesbase.Items.Add("event");
                listbox_filesbase.Items.Add("imgfrm");
                listbox_filesbase.Items.Add("face");

                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error encontrado");
            }
        }

        public void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            var p = new Process();
            

            p.StartInfo.WorkingDirectory = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
            p.StartInfo.FileName = gosbp3un1;
            p.StartInfo.UseShellExecute = true;


            string pathbp3 = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));
            string filepath = pathbp3 + image;
            string imagefile = pathbp3 + fileimage + ".bmp";
            string bp3temp = pathbp3 + "temp.gos";
            string bmptemp = pathbp3 + "temp.bmp";

            p.StartInfo.Arguments = "temp.gos";

            if (File.Exists(bp3temp))
            {
                File.Delete(bp3temp);
                if (File.Exists(bmptemp))
                {
                    File.Delete(bmptemp);
                }
            }
            File.Copy(filepath, bp3temp);

            try
            {
                p.Start();
                var procId = p.Id;
                id_process_bmp = procId;
                //MessageBox.Show(gosbp3un1  " temp.gos"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un1.exe.lnk"
                while(true)
                {
                    if(IsProcessOpen(procId) == false)
                    {
                        FileStream fs = new FileStream(pathbp3 + "temp.bmp", FileMode.Open, FileAccess.Read); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.bmp"
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                        break;
                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una imagen primero", "Error");
                return;
            }

            var p = new Process();


            p.StartInfo.WorkingDirectory = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
            p.StartInfo.FileName = gosbp3pk1;

            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));
            string imagenreemplazar = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\" + fileimage + ".bmp";
            string filepath = mainfolder + listbox_filesbase.SelectedItem.ToString() + image;
            string selectedfilepath = Filedialogbmp.SafeFileName.ToString();
            string selectedfile = Filedialogbmp.FileName.ToString();

            p.StartInfo.Arguments = '\u0022' + fileimage + ".bmp" + '\u0022';

            if (Filedialogbmp.ShowDialog() == DialogResult.OK)
            {
                DialogResult reemplazar = MessageBox.Show("Desea reemplazar " + image + " por " + Filedialogbmp.SafeFileName + "?", "Confirmacion", MessageBoxButtons.YesNo);
                if (reemplazar == DialogResult.Yes)
                {
                    try
                    {
                        File.Copy(Filedialogbmp.FileName, imagenreemplazar, overwrite:true);
                        p.Start();
                        var procId = p.Id;
                        id_process_bmp = procId;
                         while (true)
                            {
                                if (IsProcessOpen(id_process_bmp) == false)
                                {
                                    DialogResult compilar1 = MessageBox.Show("Desea compilar?", "Confirmacion", MessageBoxButtons.YesNo);
                                    if (compilar1 == DialogResult.Yes)
                                    {
                                        if (listbox_filesbase.SelectedItem.ToString() == "event")
                                        {
                                            empaquetar("gosflst-event.txt", "event");
                                            break;
                                        }
                                        if (listbox_filesbase.SelectedItem.ToString() == "face")
                                        {
                                            empaquetar("gosflst-face.txt", "FACE");
                                            break;
                                        }
                                        if (listbox_filesbase.SelectedItem.ToString() == "imgfrm")
                                        {
                                            empaquetar("gosflst-img.txt", "imgfrm");
                                            break;
                                        }
                                    }
                                break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                }
                else if (reemplazar == DialogResult.No)
                {
                    return;
                }
            }
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
            

            p.StartInfo.WorkingDirectory = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
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
        private void extraerbutton_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una imagen primero", "Error");
                return;
            }

            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));

            if (listBoxImages.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una imagen primero", "Error");
                return;
            }

            if (folderBrowserDialogbmp.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp"))
                {
                        File.Delete(folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp");
                        File.Copy(mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\temp.bmp", folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp");
                    
                }
                else
                {
                    File.Copy(mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\temp.bmp", folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp");
                }
                

            }
            else if (folderBrowserDialogbmp.ShowDialog() == DialogResult.No)
            {
                return;
            }
        }

        private void compilarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult compilar = MessageBox.Show("Quieres compilar las imagenes?", "Confirmación", MessageBoxButtons.YesNo);
                if (compilar == DialogResult.Yes)
                {
                    if (listbox_filesbase.SelectedItem.ToString() == "event")
                    {
                        empaquetar("gosflst-event.txt", "event");
                    }
                    if (listbox_filesbase.SelectedItem.ToString() == "face")
                    {
                        empaquetar("gosflst-face.txt", "FACE");
                    }
                    if (listbox_filesbase.SelectedItem.ToString() == "imgfrm")
                    {
                        empaquetar("gosflst-img.txt", "imgfrm");
                    }
                }
                else if (compilar == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filedialogbmp.ShowDialog();
            MessageBox.Show("Esto es el seleccionado" + Filedialogbmp.SafeFileName);
            MessageBox.Show("Esta es la direccion" + Filedialogbmp.FileName);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            home f1 = new home();
            f1.Width = 286;
            f1.Height = 279;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/TheBardockGames");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            home f1 = new home();
            MessageBox.Show(client.CurrentPresence.State.ToString());
        }

        private void remasterbutton_Click(object sender, EventArgs e)
        {      
            var p = new Process();
            p.StartInfo.FileName = realesrgan;

            string currentfile = listBoxImages.SelectedItem.ToString().Replace(".bp3", "");
            string folder_remaster = '\u0022' + realesrgan.ToString().Replace("realesrgan-ncnn-vulkan.exe", "Remastered\\");
            string startInfo = '\u0022' + realesrgan + '\u0022';
            string main_folder_path = '\u0022' + mainfolder;
            string filepath = folder_remaster + currentfile + ".jpg" + '\u0022';
            string arguments = " -i " + main_folder_path + listbox_filesbase.SelectedItem.ToString() + @"\" + "temp.bmp" + '\u0022' + " -o " + folder_remaster + currentfile + ".jpg" + '\u0022';
            p.StartInfo.Arguments = arguments;
            //Console.WriteLine(startInfo + " -i " +main_folder_path + "temp.bmp" + '\u0022' + " -o " + folder_remaster + currentfile + ".jpg" + '\u0022' );
            p.Start();
            var procId = p.Id;
            while(true)
            {
                if(IsProcessOpen(procId) == false)
                {
                    Process.Start(filepath);
                    break;
                }
            }
            
        }

        private void bmpviewer_Load(object sender, EventArgs e)
        {
            
        }

        private void listbox_filesbase_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxImages.Items.Clear();

            string folder = mainfolder + listbox_filesbase.SelectedItem.ToString() + @"\";
            string[] bp3files = Directory.GetFiles(folder, "*.bp3");

            foreach (var item in bp3files)
            {
                listBoxImages.Items.Add(Path.GetFileName(item));
            }


        }
    }
}