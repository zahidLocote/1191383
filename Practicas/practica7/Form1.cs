using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica7
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sonidos;
        private Dictionary<Keys, string> sonidos2;
        public Form1()
        {
            InitializeComponent();
            sonidos = new Dictionary<string, string>
            {
                {"DO",@"Sonidos/DO.wav"},
                {"RE",@"Sonidos/RE.wav"},
                {"MI",@"Sonidos/MI.wav"},
                {"FA",@"Sonidos/FA.wav"},
                {"SOL",@"Sonidos/SOL.wav"},
                {"LA",@"Sonidos/LA.wav"},
                {"SI",@"Sonidos/SI.wav"},
                {"DoUltimo",@"Sonidos/DoUltimo.wav"},
                {"DO#",@"Sonidos/DO#.wav"},
                {"RE#",@"Sonidos/RE#.wav"},
                {"FA#",@"Sonidos/FA#.wav"},
                {"SOL#",@"Sonidos/SOL#.wav"},
                {"LA#",@"Sonidos/LA#.wav"}
            };

            sonidos2 = new Dictionary<Keys, string> {
                {Keys.A,"DO"},
                {Keys.S,"RE"},
                {Keys.D,"MI"},
                {Keys.F,"FA"},
                {Keys.G,"SOL"},
                {Keys.H,"LA"},
                {Keys.J,"SI"},
                {Keys.K,"DoUltimo"},
                {Keys.W,"DO#"},
                {Keys.E,"RE#"},
                {Keys.T,"FA#"},
                {Keys.Y,"SOL#"},
                {Keys.U,"LA#"}
            };
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;
        }
        public void reproducirTecla(string tecla)
        {
            if (sonidos.ContainsKey(tecla))
            {
                SoundPlayer teclin = new SoundPlayer(sonidos[tecla]);
                teclin.Play();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reproducirTecla("DoUltimo");
            label1.Text = "DO Ultimo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reproducirTecla("DO");
            label1.Text = "DO";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reproducirTecla("RE");
            label1.Text = "RE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reproducirTecla("MI");
            label1.Text = "MI";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reproducirTecla("FA");
            label1.Text = "FA";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reproducirTecla("SOL");
            label1.Text = "SOL";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reproducirTecla("LA");
            label1.Text = "LA";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reproducirTecla("SI");
            label1.Text = "SI";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reproducirTecla("DO#");
            label1.Text = "DO#";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reproducirTecla("RE#");
            label1.Text = "RE#";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reproducirTecla("FA#");
            label1.Text = "FA#";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reproducirTecla("SOL#");
            label1.Text = "SOL#";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reproducirTecla("LA#");
            label1.Text = "LA#";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (sonidos2.ContainsKey(e.KeyCode))
            {
                string nota = sonidos2[e.KeyCode];
                label1.Text = nota;
                reproducirTecla(nota);
            }
            
        }
    }
}
