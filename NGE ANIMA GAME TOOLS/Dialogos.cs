using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{

    public partial class Dialogos : Form
    {
        public const string palabra_buscar = "print";
        public string listastring;
        public string linea;
        public string directory;
        public string filetxtname;
        public string dialogoactual;
        public int cantidadindex;

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

        public Dialogos()
        {
            try
            {
                InitializeComponent();
                listBoxtxt.Items.Clear();
                string folder = mainfolder + @"\exec\";
                string[] txtfiles = Directory.GetFiles(folder, "*.txt");
                linecounter1.Text = "Linea: " + linecounter.ToString() + "/" + cantidadindex.ToString();


                foreach (var item in txtfiles)
                {
                    listBoxtxt.Items.Add(Path.GetFileName(item));
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error al ejecutar");
            }
        }

        int counter = 0;
        int linecounter = 0;
        int linecounter2 = 1;
        List<string> lista = new List<string>();
        string line;
        string lineanterior;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dcombcheck.Checked == true)
            {
                if (counter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                if (linecounter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line2 = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                textBox3.Text = line2;
                lineanterior = line2;
                var textob = textBox1.Text.Replace("print", "");
                var textob1 = textob.Replace("@c", "");
                var textob2 = textob1.Replace("\"", "");
                var textob3 = textob2.TrimStart().ToString();
                string textob4 = textob3;
                string textoc = lineanterior;
                var texto1c = textoc.Replace("print", "");
                var texto2c = texto1c.Replace("@c", "");
                var texto3c = texto2c.Replace("\"", "");
                var texto4c = texto3c.TrimStart().ToString();
                string texto5c = texto4c;
                string textocf = texto5c;

                textBox2.Text = textocf + textob4;

                string arrobab = "@n";
                if (textBox2.Text.Contains(arrobab))
                {
                    var sinarrobab = textob4.Replace("@n", Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", Environment.NewLine);
                    textBox2.Text = sinarrobac + sinarrobab;
                    return;
                }
                return;
            }
            if (dcombcheck.Checked == false)
            {
                dialogoactual = textBox1.Text;
                var texto = textBox1.Text.Replace("print", "");
                var texto1 = texto.Replace("@c", "");
                var texto2 = texto1.Replace("\"", "");
                var texto3 = texto2.TrimStart().ToString();
                string texto4 = texto3;
                textBox2.Text = texto4;
                string arroba = "@n";
                if (textBox2.Text.Contains(arroba))
                {
                    var sinarroba = texto4.Replace("@n", Environment.NewLine);
                    textBox2.Text = sinarroba;

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (dcombcheck.Checked == true)
            {
                if (counter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                if (linecounter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line2 = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                lineanterior = line2;
                var textob = textBox1.Text.Replace("print", "");
                var textob1 = textob.Replace("@c", "");
                var textob2 = textob1.Replace("\"", "");
                var textob3 = textob2.TrimStart().ToString();
                string textob4 = textob3;

                string textoc = textBox3.Text;
                var texto1c = textoc.Replace("print", "");
                var texto2c = texto1c.Replace("@c", "");
                var texto3c = texto2c.Replace("\"", "");
                var texto4c = texto3c.Trim().ToString();
                string texto5c = texto4c;
                string textocf = texto5c;

                textBox2.Text = textocf + textob4;

                string arrobab = "@n";
                if (textBox2.Text.Contains(arrobab))
                {
                    var sinarrobab = textob4.Replace("@n", Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", Environment.NewLine);
                    textBox2.Text = sinarrobac + sinarrobab;
                    return;

                }
            }
        }

        public void listBoxtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxtxt.SelectedIndex == -1)
            {
                return;
            }
            StreamReader file = new StreamReader(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default);
            filetxtname = listBoxtxt.SelectedItem.ToString();
            lista.Clear();
            linecounter = 0;
            linecounter2 = 1;
            counter = 0;
            listastring = string.Empty;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(palabra_buscar))
                {
                    lista.Add(counter.ToString());
                    listastring = string.Join(Environment.NewLine, lista);
                    string numberline = listastring.Split("\n".ToCharArray())[linecounter];

                    int linea1 = Convert.ToInt32(numberline);

                    string line = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();


                    textBox1.Text = line;
                    cantidadindex = lista.Count;
                    linecounter1.Text = "Linea: " + linecounter2.ToString() + "/" + cantidadindex.ToString();
                }
                counter++;


            }


            file.Close();
        }

        public static int buscarPalabra(String[] palabras, int index)
        {
            for (int i = index; i < palabras.Length; i++)
            {
                if (palabras[i].Contains("print"))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string line1 = listastring.Split(new[] { '\r', '\n' }).FirstOrDefault();
            MessageBox.Show(line1);
            */

            if (string.IsNullOrEmpty(listastring))
            {
                MessageBox.Show("No se ha seleccionado un txt valido", "error");
                return;
            }
            if (linecounter + 1 == cantidadindex)
            {
                MessageBox.Show("No hay nada mas delante", "error");
                return;
            }
            linecounter++;
            linecounter2++;
            linecounter1.Text = "Linea: " + linecounter2.ToString() + "/" + cantidadindex.ToString();
            string numberline = listastring.Split("\n".ToCharArray())[linecounter];
            int linea1 = Convert.ToInt32(numberline);
            string line = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();
            if (dcombcheck.Checked == true)
            {
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line4 = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                textBox3.Text = line4;
            }
            textBox1.Text = line;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(listastring))
            {
                MessageBox.Show("No se ha seleccionado un txt valido", "error");
                return;
            }
            string numberline = listastring.Split("\n".ToCharArray())[linecounter];
            int linea1 = Convert.ToInt32(numberline);
            string path = mainfolder + @"\exec\" + filetxtname;
            List<string> lines = File.ReadAllLines(path, Encoding.Default).ToList<string>();
            lines[linea1] = textBox1.Text;
            File.WriteAllLines(path, lines, Encoding.Default);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(listastring))
            {
                MessageBox.Show("No se ha seleccionado un txt valido", "error");
                return;
            }


            if (linecounter < 1)
            {
                MessageBox.Show("No hay nada mas detras", "error");
                return;
            }
            linecounter--;
            linecounter2--;
            linecounter1.Text = "Linea: " + linecounter2.ToString() + "/" + cantidadindex.ToString();
            string numberline = listastring.Split("\n".ToCharArray())[linecounter];
            int linea1 = Convert.ToInt32(numberline);
            string line = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();
            textBox1.Text = line;
            if (dcombcheck.Checked == true)
            {
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line4 = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                textBox3.Text = line4;
            } 

        }

        private void compilarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Deseas compilar el texto?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    empaquetar("gosflst-texto.txt", "exec");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tx3converter_Click(object sender, EventArgs e)
        {
            var p = new Process();

            p.StartInfo.WorkingDirectory = mainfolder + @"exec\";
            p.StartInfo.FileName = gostx31;
            p.StartInfo.Arguments = listBoxtxt.SelectedItem.ToString();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Convertir " + listBoxtxt.SelectedItem + " a TX3?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    p.Start();

                    var procId = p.Id;

                    while(true)
                    {
                        if (IsProcessOpen(procId) == false)
                        {
                            MessageBox.Show(listBoxtxt.SelectedItem.ToString() + " Convertido a Tx3 con exito");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dcombcheck.Checked == true)
            {
                if (counter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                if (linecounter == 0)
                {
                    MessageBox.Show("No hay anteriores dialogos");
                    dcombcheck.Checked = false;
                    return;
                }
                button1.Enabled = Enabled;
                textBox3.Enabled = Enabled;
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line2 = File.ReadLines(mainfolder + @"exec\" + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                textBox3.Text = line2;
                lineanterior = line2;
                var textob = textBox1.Text.Replace("print", "");
                var textob1 = textob.Replace("@c", "");
                var textob2 = textob1.Replace("\"", "");
                var textob3 = textob2.TrimStart().ToString();
                string textob4 = textob3;
                string textoc = lineanterior;
                var texto1c = textoc.Replace("print", "");
                var texto2c = texto1c.Replace("@c", "");
                var texto3c = texto2c.Replace("\"", "");
                var texto4c = texto3c.TrimStart().ToString();
                string texto5c = texto4c;
                string textocf = texto5c;

                textBox2.Text = textocf + textob4;

                string arrobab = "@n";
                if (textBox2.Text.Contains(arrobab))
                {
                    var sinarrobab = textob4.Replace("@n", Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", Environment.NewLine);
                    textBox2.Text = sinarrobac + sinarrobab;
                    return;
                }
                return;
            }
            if (dcombcheck.Checked == false)
            {
                button1.Enabled = false;
                textBox3.Enabled = false;
                dialogoactual = textBox1.Text;
                var texto = textBox1.Text.Replace("print", "");
                var texto1 = texto.Replace("@c", "");
                var texto2 = texto1.Replace("\"", "");
                var texto3 = texto2.TrimStart().ToString();
                string texto4 = texto3;
                textBox2.Text = texto4;
                string arroba = "@n";
                if (textBox2.Text.Contains(arroba))
                {
                    var sinarroba = texto4.Replace("@n", Environment.NewLine);
                    textBox2.Text = sinarroba;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listastring))
            {
                MessageBox.Show("No se ha seleccionado un txt valido", "error");
                return;
            }
            string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
            int linea2 = Convert.ToInt32(numberline2);
            string path = mainfolder + @"\exec\" + filetxtname;
            List<string> lines = File.ReadAllLines(path, Encoding.Default).ToList<string>();
            lines[linea2] = textBox3.Text;
            File.WriteAllLines(path, lines, Encoding.Default);
        }

        private void Dialogos_Load(object sender, EventArgs e)
        {

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


            p.StartInfo.WorkingDirectory = path;
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
