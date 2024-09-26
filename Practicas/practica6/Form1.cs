using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Font cambiarEstilo(FontStyle est)
        {
            return new Font(this.label1.Font.FontFamily, this.label1.Font.Size, this.label1.Font.Style ^ est);
        }

        private Font cambiarFamilia(string fam) {
            return new Font(fam,this.label1.Font.Size,this.label1.Font.Style);
        }
        private Font cambiarTam(int num)
        {
            return new Font(this.label1.Font.FontFamily, num, this.label1.Font.Style);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                label1.Font =  cambiarEstilo(FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                label1.Font = cambiarEstilo(FontStyle.Italic);   
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
                label1.Font = cambiarEstilo(FontStyle.Strikeout);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                label1.Font = cambiarEstilo(FontStyle.Underline);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarFamilia("Consolas");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarFamilia("Colonna MT");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarFamilia("Verdana");
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarFamilia("Broadway");
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarTam(8);   
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarTam(12);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarTam(16);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = cambiarTam(20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            FontFamily mss = new FontFamily("Microsoft Sans Serif"); this.label1.Font = new Font(mss, 12, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
