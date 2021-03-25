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
        private int mov;
        private int movX;
        private int movY;

        public DiscordRpcClient client;



        public bmpviewer()
        {
            InitializeComponent();
            listBoxImages.Items.Clear();
            string folder = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2";
            string[] txtfiles = Directory.GetFiles(folder, "*.bp3");

            foreach (var item in txtfiles)
            {
                listBoxImages.Items.Add(Path.GetFileName(item));
            }
        }

        public void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string image = listBoxImages.SelectedItem.ToString();
            string fileimage = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image));
            string filepath = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + image;
            string imagefile = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + fileimage + ".bmp";
            string bp3temp = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.gos";
            string bmptemp = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.bmp";


            if (File.Exists(bp3temp))
            {
                File.Delete(bp3temp);
                if (File.Exists(bmptemp))
                {
                    File.Delete(bmptemp);
                }
            }
            File.Copy(filepath, bp3temp);

            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un1.exe.lnk", "temp.gos");
            System.Threading.Thread.Sleep(150);
            FileStream fs = new FileStream(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.bmp", FileMode.Open, FileAccess.Read);
            pictureBox1.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
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
            string imagenreemplazar = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + fileimage + ".bmp";
            string filepath = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + image;
            string selectedfilepath = Filedialogbmp.SafeFileName.ToString();
            string selectedfile = Filedialogbmp.FileName.ToString();
            if (Filedialogbmp.ShowDialog() == DialogResult.OK)
            {
                DialogResult reemplazar = MessageBox.Show("Desea reemplazar " + image + " por " + Filedialogbmp.SafeFileName + "?", "Confirmacion", MessageBoxButtons.YesNo);
                if (reemplazar == DialogResult.Yes)
                {
                    if (File.Exists(imagenreemplazar))
                    {
                        File.Delete(imagenreemplazar);
                        File.Copy(Filedialogbmp.FileName, imagenreemplazar);
                        System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk", fileimage + ".bmp");
                        DialogResult compilar1 = MessageBox.Show("Desea compilar?", "Confirmacion", MessageBoxButtons.YesNo);
                        if (compilar1 == DialogResult.Yes)
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
                            return;
                        }

                        return;
                    }

                    File.Copy(Filedialogbmp.FileName, imagenreemplazar);
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk", fileimage + ".bmp");
                    DialogResult compilar = MessageBox.Show("Desea compilar?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (compilar == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk", "gosflst1.txt event");
                        System.Threading.Thread.Sleep(1500);
                        DialogResult dialogResult1 = MessageBox.Show("Empaquetado exitoso, Quieres iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk");
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
                File.Copy(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\temp.bmp", folderBrowserDialogbmp.SelectedPath + @"\" + fileimage + ".bmp");
            }
            else if (folderBrowserDialogbmp.ShowDialog() == DialogResult.No)
            {
                return;
            }
        }

        private void compilarbutton_Click(object sender, EventArgs e)
        {
            DialogResult compilar = MessageBox.Show("Quieres compilar las imagenes?", "Confirmacion", MessageBoxButtons.YesNo);
            if (compilar == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk", "gosflst1.txt event");
                System.Threading.Thread.Sleep(1500);
                DialogResult rungos = MessageBox.Show("Empaquetado exitoso, Quieres iniciar GOS2?", "Confirmacion", MessageBoxButtons.YesNo);
                if (rungos == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk");
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
    }
}