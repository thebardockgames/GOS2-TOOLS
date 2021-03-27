using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YamlDotNet.Core;

namespace NGE_ANIMA_GAME_TOOLS
{
    
    public partial class Dialogos : Form
    {
        public const string Pathgame = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\";
        public const string palabra_buscar = "print";
        public string listastring;
        public string linea;

        public Dialogos()
        {
            InitializeComponent();
            listBoxtxt.Items.Clear();
            string folder = Pathgame;
            string[] txtfiles = Directory.GetFiles(folder, "*.txt");

            foreach (var item in txtfiles)
            {
                listBoxtxt.Items.Add(Path.GetFileName(item));
            }
        }

        int counter = 0;
        int linecounter = 0;
        List<string> lista = new List<string>();
        string line;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Replace("print", "");
            var texto1 = texto.Replace("@c", "");
            var texto2 = texto1.Replace("\"", "");
            string texto3 = texto2.Trim();
            textBox2.Text = texto3;
            string arroba = "@n";
            if (textBox2.Text.Contains(arroba))
            {
                var sinarroba = texto3.Replace("@n", System.Environment.NewLine);
                textBox2.Text = sinarroba;

            }
        }


        public void listBoxtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(Pathgame + listBoxtxt.SelectedItem);
            
            while((line = file.ReadLine()) != null)
            {
                if (line.Contains(palabra_buscar))
                {
                    lista.Add(counter.ToString());
                    listastring = string.Join(Environment.NewLine, lista);
                    string numberline = listastring.Split("\n".ToCharArray())[linecounter];
                    int linea1 = Convert.ToInt32(numberline);
                    string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem).Skip(linea1).Take(1).First();
                    textBox1.Text = line;
                }
                counter++;

            }

            
            file.Close();

            /*
            string cadena = File.ReadAllText(Pathgame + listBoxtxt.SelectedItem);
            string[] palabras = cadena.Split();
            string op = "";
            int index = -1;
            do
            {
                index = buscarPalabra(palabras, index + 1);
                if (index != -1)
                {
                    MessageBox.Show("Se encontro print " + index);
                }
            } while (index != -1);
            */
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
            linecounter++;
            string numberline = listastring.Split("\n".ToCharArray())[linecounter];
            int linea1 = Convert.ToInt32(numberline);
            string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem).Skip(linea1).Take(1).First();
            textBox1.Text = line;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.Clear();
            linecounter = 0;
            counter = 0;
            listastring = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linecounter--;
            string numberline = listastring.Split("\n".ToCharArray())[linecounter];
            int linea1 = Convert.ToInt32(numberline);
            string line = File.ReadLines(Pathgame + listBoxtxt.SelectedItem).Skip(linea1).Take(1).First();
            textBox1.Text = line;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        
        }
        
    }
}
