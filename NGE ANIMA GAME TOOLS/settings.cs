using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class settings : Form
    {
        private home form1;
        public settings()
        {
            InitializeComponent();
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

                txt_mainFolder.Text = mainfolder;
                txt_rungame.Text = run_game_exe;
                txt_goslb5un1.Text = goslb5un1;
                txt_goslb5pk1.Text = goslb5pk1;
                txt_gosbp3un1.Text = gosbp3un1;
                txt_gosbp3pk1.Text = gosbp3pk1;
                txt_gostx31.Text = gostx31;
                txt_realesrgan.Text = realesrgan;

            }

            
        }



        /// <summary>
        /// Al cargar el formulario se cargan las configuraciones en los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_Load(object sender, EventArgs e)
        {
            // string main_folder = Properties.Settings.Default.main_folder;
            // string run_game_exe = Properties.Settings.Default.run_game_exe;
            // string goslb5un1 = Properties.Settings.Default.goslb5un1;
            // string goslb5pk1 = Properties.Settings.Default.goslb5pk1;
            // string gosbp3un1 = Properties.Settings.Default.gosbp3un1;
            // string gosbp3pk1 = Properties.Settings.Default.gosbp3pk1;
            // string gostx31 = Properties.Settings.Default.gostx31;
            //string realesrgan = Properties.Settings.Default.realesrgan;


            //txt_mainFolder.Text = main_folder; // folder principal
            //txt_rungame.Text    = run_game_exe; // ruta del ejecutable del juego
            //txt_goslb5un1.Text  = goslb5un1;
            //txt_goslb5pk1.Text  = goslb5pk1;
            //txt_gosbp3un1.Text  = gosbp3un1;
            //txt_gosbp3pk1.Text  = gosbp3pk1;
            //txt_gostx31.Text    = gostx31;
            //txt_realesrgan.Text = realesrgan;

            

    }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form h = new home();
            this.Close();
            h.Show();
        }

        /// <summary>
        /// habilita la edicion de las rutas de configuración
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_mainFolder.ReadOnly = false;
            txt_rungame.ReadOnly = false;
            txt_goslb5un1.ReadOnly = false;
            txt_goslb5pk1.ReadOnly = false;
            txt_gosbp3un1.ReadOnly = false;
            txt_gosbp3pk1.ReadOnly = false;
            txt_gostx31.ReadOnly = false;
            txt_realesrgan.ReadOnly = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Desea restablecer la configuración por defecto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    try
            //    {

            txt_mainFolder.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\";
            txt_rungame.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe";
            txt_goslb5un1.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5un.exe";
            txt_goslb5pk1.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk.exe";
            txt_gosbp3un1.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un.exe";
            txt_gosbp3pk1.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk.exe";
            txt_gostx31.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe";
            txt_realesrgan.Text = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\Realesrgan\realesrgan-ncnn-vulkan.exe";
            //        Properties.Settings.Default.main_folder = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\";
            //        Properties.Settings.Default.run_game_exe = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk";
            //        Properties.Settings.Default.goslb5un1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5un1.exe.lnk";
            //        Properties.Settings.Default.goslb5pk1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk";
            //        Properties.Settings.Default.gosbp3un1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un1.exe.lnk";
            //        Properties.Settings.Default.gosbp3pk1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk";
            //        Properties.Settings.Default.gostx31 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe.lnk";
            //        Properties.Settings.Default.realesrgan = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\Realesrgan\realesrgan-ncnn-vulkan.exe";
            //        Properties.Settings.Default.Save();

            //        if (MessageBox.Show("Configuración restablecida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            //        {
            //            Form h = new home();
            //            h.Show();
            //            this.Close();
            //        }

            //        }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message, "Error");
            //    }


            //}

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar la configuración?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //    Properties.Settings.Default.main_folder = txt_mainFolder.Text;
                //    Properties.Settings.Default.run_game_exe = txt_rungame.Text;
                //    Properties.Settings.Default.goslb5un1 = txt_goslb5un1.Text;
                //    Properties.Settings.Default.goslb5pk1 = txt_goslb5pk1.Text;
                //    Properties.Settings.Default.gosbp3un1 = txt_gosbp3un1.Text;
                //    Properties.Settings.Default.gosbp3pk1 = txt_gosbp3pk1.Text;
                //    Properties.Settings.Default.gostx31 = txt_gostx31.Text;
                //    Properties.Settings.Default.realesrgan = txt_realesrgan.Text;
                //    Properties.Settings.Default.Save();

                //        if (MessageBox.Show("Configuración guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                //            {
                //        Form h = new home();
                //        h.Show();
                //        this.Close();
                //            }

                string path;
                path = @"%localappdata%\NGE_ANIMA\GOS2-TOOLS\Config.ini";
                path = Environment.ExpandEnvironmentVariables(path);

                string[] Configuraciones = new string[8];

                Configuraciones[0] = txt_mainFolder.Text;
                Configuraciones[1] = txt_rungame.Text;
                Configuraciones[2] = txt_goslb5un1.Text;
                Configuraciones[3] = txt_goslb5pk1.Text;
                Configuraciones[4] = txt_gosbp3un1.Text;
                Configuraciones[5] = txt_gosbp3pk1.Text;
                Configuraciones[6] = txt_gostx31.Text;
                Configuraciones[7] = "Nothing";

                File.WriteAllLines(path, Configuraciones);
               
            }

        }

        private void txt_realesrgan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Jared Cortez\source\repos\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\WinFormsApp1.exe";
            Process.Start(path);
        }

        private void button_mainfolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_mainFolder.Text = folderBrowserDialog1.SelectedPath + @"\";
            }
        }

        private void run_game_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "00test03-latin.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_rungame.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "goslb5un.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_goslb5un1.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "goslb5pk.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_goslb5pk1.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "gosbp3un.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_gosbp3un1.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "gosbp3pk.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_gosbp3pk1.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "gostx3.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_gostx31.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "realesrgan-ncnn-vulkan.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_realesrgan.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }
    }
}
