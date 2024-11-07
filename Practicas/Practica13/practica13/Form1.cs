using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace practica13
{
    public partial class Form1 : Form
    {
        
        private ProductoService PS = new ProductoService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PS.verificar(textBox1.Text, textBox2.Text))
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false)
                textBox2.UseSystemPasswordChar = true;
        }
    }
}
