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

namespace NGE_ANIMA_GAME_TOOLS
{
    public partial class Dialogos : Form
    {
        public Dialogos()
        {
            InitializeComponent();
            listBoxtxt.Items.Clear();
            string folder = @"C:\Program Files (x86)\GAINAX\IRONMAIDEN2";
            string[] txtfiles = Directory.GetFiles(folder, "*.txt");

            foreach (var item in txtfiles)
            {
                listBoxtxt.Items.Add(Path.GetFileName(item));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Replace("print", "");
            var texto1 = texto.Replace("@c", "");
            var texto2 = texto1.Replace("\"", "");
            textBox2.Text = texto2;
        }


        private void listBoxtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = string.Empty;
            var lines = File.ReadAllLines(@"C:\Program Files (x86)\GAINAX\IRONMAIDEN2\" + listBoxtxt.SelectedItem);
            foreach (var line in lines)
            {
                if (line.Contains("print"))
                {
                    
                    var text = line.ToString();
                    textBox1.Text = text;
                    var texto = textBox1.Text.Replace("print", "");
                    var texto1 = texto.Replace("@c", "");
                    var texto2 = texto1.Replace("\"", "");
                    textBox2.Text = texto2;
                }
            }
        }
    }
}
