using DiscordRPC;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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


        public bmpviewer()
        {
            try
            {
                InitializeComponent();
                listBoxImages.Items.Clear();
                string folder = Properties.Settings.Default.main_folder;
                string[] txtfiles = Directory.GetFiles(folder, "*.bp3");

                foreach (var item in txtfiles)
                {
                    listBoxImages.Items.Add(Path.GetFileName(item));
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error encontrado");
            }
        }

        public void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));
            string filepath = Properties.Settings.Default.main_folder + image;
            string imagefile = Properties.Settings.Default.main_folder + fileimage + ".bmp";
            string bp3temp = Properties.Settings.Default.main_folder + "temp.gos";
            string bmptemp = Properties.Settings.Default.main_folder + "temp.bmp";


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
                Process.Start(Properties.Settings.Default.gosbp3un1, "temp.gos"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un1.exe.lnk"
                System.Threading.Thread.Sleep(180);
                FileStream fs = new FileStream(Properties.Settings.Default.main_folder + "temp.bmp", FileMode.Open, FileAccess.Read); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.bmp"
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
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
            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));
            string imagenreemplazar = Properties.Settings.Default.main_folder + fileimage + ".bmp";
            string filepath = Properties.Settings.Default.main_folder + image;
            string selectedfilepath = Filedialogbmp.SafeFileName.ToString();
            string selectedfile = Filedialogbmp.FileName.ToString();
            if (Filedialogbmp.ShowDialog() == DialogResult.OK)
            {
                DialogResult reemplazar = MessageBox.Show("Desea reemplazar " + image + " por " + Filedialogbmp.SafeFileName + "?", "Confirmacion", MessageBoxButtons.YesNo);
                if (reemplazar == DialogResult.Yes)
                {
                    if (File.Exists(imagenreemplazar))
                    {
                        try
                        {
                            File.Delete(imagenreemplazar);
                            File.Copy(Filedialogbmp.FileName, imagenreemplazar);
                            Process.Start(Properties.Settings.Default.gosbp3pk1, fileimage + ".bmp"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk"
                            DialogResult compilar1 = MessageBox.Show("Desea compilar?", "Confirmacion", MessageBoxButtons.YesNo);
                            if (compilar1 == DialogResult.Yes)
                            {
                                Process.Start(Properties.Settings.Default.goslb5pk1, "gosflst1.txt event"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk"
                                System.Threading.Thread.Sleep(1500);
                                DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Desea iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                                if (dialogResult1 == DialogResult.Yes)
                                {
                                    Process.Start(Properties.Settings.Default.run_game_exe);
                                    return;
                                }
                                else if (dialogResult1 == DialogResult.No)
                                {
                                    return;
                                }
                                return;
                            }

                            return;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    try
                    {
                        File.Copy(Filedialogbmp.FileName, imagenreemplazar);
                        Process.Start(Properties.Settings.Default.gosbp3pk1, fileimage + ".bmp"); //@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk"
                        DialogResult compilar = MessageBox.Show("Desea compilar?", "Confirmacion", MessageBoxButtons.YesNo);
                        if (compilar == DialogResult.Yes)
                        {
                            Process.Start(Properties.Settings.Default.goslb5pk1, "gosflst1.txt event"); // @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk"
                            System.Threading.Thread.Sleep(1500);
                            DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Quieres iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                Process.Start(Properties.Settings.Default.run_game_exe);
                                return;
                            }
                            else if (dialogResult1 == DialogResult.No)
                            {
                                return;
                            }
                            return;
                        }

                        return;
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
                File.Copy(Properties.Settings.Default.main_folder + "temp.bmp", folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp");
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
                    Process.Start(Properties.Settings.Default.goslb5pk1, "gosflst1.txt event"); // @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk"
                    System.Threading.Thread.Sleep(1500);
                    DialogResult rungos = MessageBox.Show("Empaquetado exitoso,\n ¿Quieres iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (rungos == DialogResult.Yes)
                    {
                        Process.Start(Properties.Settings.Default.run_game_exe);
                        return;
                    }
                    else if (rungos == DialogResult.No)
                    {
                        return;
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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.eva_black;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.eva__white;
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
            string currentfile = listBoxImages.SelectedItem.ToString().Replace(".bp3", "");
            string folder_remaster = Properties.Settings.Default.realesrgan.ToString().Replace("realesrgan-ncnn-vulkan.exe", "Remastered\\");

            Process.Start(Properties.Settings.Default.realesrgan, " -i " + Properties.Settings.Default.main_folder + "temp.bmp" + " -o " + folder_remaster + currentfile + ".jpg");
            System.Threading.Thread.Sleep(4000);
            if (File.Exists(folder_remaster + currentfile + ".jpg"))
            {
                Process.Start(folder_remaster + currentfile + ".jpg");
            }
            else
            {

            }
            //filestatus = 1;


        }


    }
}