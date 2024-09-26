using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text;

            textBox2.Text = cadena.Length.ToString();
            textBox3.Text = cadena[cadena.Length-1].ToString();
            textBox4.Text = cadena[0].ToString();
            textBox5.Text = cadena.Substring(2,6);
            textBox6.Text = cadena.IndexOf("a").ToString();
            textBox7.Text = cadena.ToUpper();   
            textBox8.Text = cadena.ToLower();
            textBox9.Text = cadena.Replace(" ","");
        }
    }
}
