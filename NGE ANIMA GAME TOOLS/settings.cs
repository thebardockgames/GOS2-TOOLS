using System;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            
        }

         

        /// <summary>
        /// Al cargar el formulario se cargan las configuraciones en los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_Load(object sender, EventArgs e)
        {
             string main_folder = Properties.Settings.Default.main_folder;
             string run_game_exe = Properties.Settings.Default.run_game_exe;
             string goslb5un1 = Properties.Settings.Default.goslb5un1;
             string goslb5pk1 = Properties.Settings.Default.goslb5pk1;
             string gosbp3un1 = Properties.Settings.Default.gosbp3un1;
             string gosbp3pk1 = Properties.Settings.Default.gosbp3pk1;
             string gostx31 = Properties.Settings.Default.gostx31;
            string realesrgan = Properties.Settings.Default.realesrgan;


            txt_mainFolder.Text = main_folder; // folder principal
            txt_rungame.Text    = run_game_exe; // ruta del ejecutable del juego
            txt_goslb5un1.Text  = goslb5un1;
            txt_goslb5pk1.Text  = goslb5pk1;
            txt_gosbp3un1.Text  = gosbp3un1;
            txt_gosbp3pk1.Text  = gosbp3pk1;
            txt_gostx31.Text    = gostx31;
            txt_realesrgan.Text = realesrgan;

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
            if (MessageBox.Show("¿Desea restablecer la configuración por defecto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {

                    Properties.Settings.Default.main_folder = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\";
                    Properties.Settings.Default.run_game_exe = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\exe\00test03-latin.exe.lnk";
                    Properties.Settings.Default.goslb5un1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5un1.exe.lnk";
                    Properties.Settings.Default.goslb5pk1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk";
                    Properties.Settings.Default.gosbp3un1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3un1.exe.lnk";
                    Properties.Settings.Default.gosbp3pk1 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gosbp3pk1.exe.lnk";
                    Properties.Settings.Default.gostx31 = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe.lnk";
                    Properties.Settings.Default.realesrgan = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\Realesrgan\realesrgan-ncnn-vulkan.exe";
                    Properties.Settings.Default.Save();

                    if (MessageBox.Show("Configuración restablecida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Form h = new home();
                        h.Show();
                        this.Close();
                    }

                    }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error");
                }


            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar la configuración?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Properties.Settings.Default.main_folder = txt_mainFolder.Text;
                Properties.Settings.Default.run_game_exe = txt_rungame.Text;
                Properties.Settings.Default.goslb5un1 = txt_goslb5un1.Text;
                Properties.Settings.Default.goslb5pk1 = txt_goslb5pk1.Text;
                Properties.Settings.Default.gosbp3un1 = txt_gosbp3un1.Text;
                Properties.Settings.Default.gosbp3pk1 = txt_gosbp3pk1.Text;
                Properties.Settings.Default.gostx31 = txt_gostx31.Text;
                Properties.Settings.Default.realesrgan = txt_realesrgan.Text;
                Properties.Settings.Default.Save();

                    if (MessageBox.Show("Configuración guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                    Form h = new home();
                    h.Show();
                    this.Close();
                        }

                }
        }

        private void txt_realesrgan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
