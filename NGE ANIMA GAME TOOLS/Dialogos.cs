using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGE_ANIMA_GAME_TOOLS
{

    public partial class Dialogos : Form
    {
        public const string Pathgame = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\";
        public const string palabra_buscar = "print";
        public string listastring;
        public string linea;
        public string directory;
        public string filetxtname;
        public string dialogoactual;
        public int cantidadindex;

        public Dialogos()
        {
            InitializeComponent();
            listBoxtxt.Items.Clear();
            string folder = Pathgame;
            string[] txtfiles = Directory.GetFiles(folder, "*.txt");
            linecounter1.Text = "Linea: " + linecounter.ToString() + "/" + cantidadindex.ToString();


            foreach (var item in txtfiles)
            {
                listBoxtxt.Items.Add(Path.GetFileName(item));
            }
        }

        int counter = 0;
        int linecounter = 0;
        int linecounter2 = 1;
        List<string> lista = new List<string>();
        string line;
        string lineanterior;
        string predialogue;
        string postdialogue;

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
                string line2 = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
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
                    var sinarrobab = textob4.Replace("@n", System.Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", System.Environment.NewLine);
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
                    var sinarroba = texto4.Replace("@n", System.Environment.NewLine);
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
                string line2 = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
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
                    var sinarrobab = textob4.Replace("@n", System.Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", System.Environment.NewLine);
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
            System.IO.StreamReader file = new System.IO.StreamReader(Pathgame + listBoxtxt.SelectedItem, Encoding.Default);
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

                    string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();


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
            string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();
            if (dcombcheck.Checked == true)
            {
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line4 = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
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
            string path = Pathgame + filetxtname;
            List<string> lines = System.IO.File.ReadAllLines(path).ToList<string>();
            lines[linea1] = textBox1.Text;
            System.IO.File.WriteAllLines(path, lines, Encoding.Default);
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
            string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea1).Take(1).First();
            textBox1.Text = line;
            if (dcombcheck.Checked == true)
            {
                string numberline2 = listastring.Split("\n".ToCharArray())[linecounter - 1];
                int linea2 = Convert.ToInt32(numberline2);
                string line4 = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
                textBox3.Text = line4;
            }

        }

        private void compilarbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas compilar el texto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\goslb5pk1.exe.lnk", "gosflst.txt exec");
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
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void tx3converter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Convertir " + listBoxtxt.SelectedItem + " a TX3?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\gostx31.exe.lnk", listBoxtxt.SelectedItem.ToString());
                if (File.Exists(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + listBoxtxt.SelectedItem.ToString()))
                {
                    MessageBox.Show("Operacion Exitosa");
                    return;
                }
                MessageBox.Show("Operacion Fallida");
                return;
            }
            return;
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
                string line2 = File.ReadLines(Pathgame + listBoxtxt.SelectedItem, Encoding.Default).Skip(linea2).Take(1).First();
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
                    var sinarrobab = textob4.Replace("@n", System.Environment.NewLine);
                    var sinarrobac = textocf.Replace("@n", System.Environment.NewLine);
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
                    var sinarroba = texto4.Replace("@n", System.Environment.NewLine);
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
            string path = Pathgame + filetxtname;
            List<string> lines = System.IO.File.ReadAllLines(path).ToList<string>();
            lines[linea2] = textBox3.Text;
            System.IO.File.WriteAllLines(path, lines, Encoding.Default);
        }
    }
}
