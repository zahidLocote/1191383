using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Practica8
{
    public partial class Form1 : Form
    {
        string rutaArch = "C:/Users/Edgar/OneDrive/Desktop/TAREINIS/Topicos de programacion/Practicas/Practica8 y 11/historial.txt";
        public Form1()
        {
            if (!File.Exists(rutaArch))
            {
                crearArchivo(rutaArch,"");
            }
            InitializeComponent();
            historialLabel.Hide();
            richTextBox1.Hide();
            cerrarHistorialB.Hide();
        }
        public void crearArchivo(string rutaArch, string contenido)
        {
            using (StreamWriter archivo = File.CreateText(rutaArch))
                archivo.WriteLine(contenido);
        }

        public void agregarContenido(string rutaArch, string contenido)
        {
            using (StreamWriter archivo = File.AppendText(rutaArch))
                archivo.WriteLine(contenido);
        }
        public string leerArchivo(string rutaArch) {
            if (File.Exists(rutaArch))
            {
                using (StreamReader archivo = File.OpenText(rutaArch))
                {
                    string contenido = archivo.ReadToEnd();
                    return contenido;
                }

            }
            return string.Empty;
        }


        public void ingresarNum(string digito)
        {
            textBox1.Text = textBox1.Text + digito;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingresarNum("4");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ingresarNum("/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            num = Math.Sin(num);
            label2.Text = num.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            num = Math.Cos(num);
            label2.Text = num.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0) 
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresarNum("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingresarNum("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresarNum("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ingresarNum("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ingresarNum("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ingresarNum("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ingresarNum("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ingresarNum("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ingresarNum("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ingresarNum(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ingresarNum("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ingresarNum("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ingresarNum("*");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string ope = textBox1.Text;
            double res = 0;

            Regex regex = new Regex(@"(-?\d+(\.\d+)?)([+\-*/])(-?\d+(\.\d+)?)");
            Match match = regex.Match(ope);

            if (match.Success)
            {
                double num1 = double.Parse(match.Groups[1].Value);
                string operador = match.Groups[3].Value;
                double num2 = double.Parse(match.Groups[4].Value);

                switch (operador) 
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            res = (double)num1 / num2;
                        }
                        break;
                }
                label2.Text = res.ToString();
                agregarContenido("C:/Users/Edgar/OneDrive/Desktop/TAREINIS/Topicos de programacion/Practicas/Practica8 y 11/historial.txt",textBox1.Text + " = " + res.ToString());
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "00.0";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            num = Math.Tan(num);
            label2.Text = num.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void verHistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArch = "C:/Users/Edgar/OneDrive/Desktop/TAREINIS/Topicos de programacion/Practicas/Practica8 y 11/historial.txt";
            historialLabel.Show();
            richTextBox1.Show();
            cerrarHistorialB.Show();
            richTextBox1.Text = leerArchivo(rutaArch);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarHistorialB_Click(object sender, EventArgs e)
        {
            historialLabel.Hide();
            richTextBox1.Hide();
            cerrarHistorialB.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaArch))
            {
                File.Delete(rutaArch);
                MessageBox.Show("El archivo ha sido eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            historialLabel.Hide();
            richTextBox1.Hide();
            cerrarHistorialB.Hide();
        }
    }
}
