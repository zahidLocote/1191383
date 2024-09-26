using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sonidos;
        public Form1()
        {
            InitializeComponent();
            sonidos = new Dictionary<string, string> {
                { "boo", @"resources/boo.wav" },
                { "cat", @"resources/cat.wav" },
                { "drums", @"resources/drums.wav" },
                { "laugh", @"resources/laugh.wav" },
            };
        }
        public void reproducirSonido(string sonido)
        {
            if (sonidos.ContainsKey(sonido)){
                SoundPlayer player = new SoundPlayer(sonidos[sonido]);
                player.Play();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reproducirSonido("boo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reproducirSonido("cat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reproducirSonido("drums");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reproducirSonido("laugh");
        }
    }
}
